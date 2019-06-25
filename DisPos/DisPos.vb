'
' MIT License: https://opensource.org/licenses/MIT
'
' Copyright (c) 2019 Fumiyuki Shimizu
' Copyright (c) 2019 Abacus Technologies, Inc.
'
Imports System.ComponentModel

Public Class DisPos
	Private Const maxSubNum As Integer = 10
	Private Const keyBase As String = "Software\AbacusTech.jp\DisPos"

	Public Function openKey(ord As Integer) As Microsoft.Win32.RegistryKey
		Return Microsoft.Win32.Registry.CurrentUser.CreateSubKey(keyBase & If(0 > ord, "", "\" & ord))
	End Function

	Public Sub deleteKey(ord As Integer)
		Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(keyBase & "\" & ord)
	End Sub

	Private Function getScreen(desc As String) As Screen
		If "" <> desc Then
			Dim scr As Screen
			For Each scr In Screen.AllScreens
				If scr.ToString() = desc Then
					Return scr
				End If
			Next
		End If
		Return Screen.PrimaryScreen
	End Function

	Public Function fixLocation(scr As Screen, x0y0 As Point) As Point
		Dim rc As Point
		If x0y0.X + Me.Width <= scr.Bounds.Left + 10 Or scr.Bounds.Right - 10 <= x0y0.X Then
			rc.X = scr.Bounds.Left
		Else
			rc.X = x0y0.X
		End If
		If x0y0.Y < scr.Bounds.Top Or scr.Bounds.Bottom - 10 <= x0y0.Y Then
			rc.Y = scr.Bounds.Top
		Else
			rc.Y = x0y0.Y
		End If
		Return rc
	End Function

	Private Sub distributeValue(Optional isMessageOnly As Boolean = False)
		For Each frm In frms
			If Not isMessageOnly Then
				frm.numTotal.Value = numTotal.Value
				frm.numKeep.Value = numKeep.Value
				frm.numChange.Value = numChange.Value
			End If
			frm.lblMessage.Text = lblMessage.Text
		Next
	End Sub

	Private Sub updateChange()
		Dim change As Long
		If 0 < numTotal.Value And 0 < numKeep.Value Then
			change = numKeep.Value - numTotal.Value
		Else
			change = 0
		End If
		numChange.Value = change
		distributeValue()
	End Sub

	Private Sub clearAll()
		numTotal.Value = 0
		numKeep.Value = 0
		distributeValue()
	End Sub

	Private enterButtonClearAll As Boolean = False
	Private Sub setEnterTotal()
		enterButtonClearAll = False
		btnEnter.Text = "計"
	End Sub

	Private Sub setEnterClearAll()
		enterButtonClearAll = True
		btnEnter.Text = "クリア"
	End Sub

	Private frms As New List(Of DisPosSub)

	Private Sub DisPos_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim reg As Microsoft.Win32.RegistryKey = openKey(0)
		Me.Location = New Point(CLng(reg.GetValue("x0", 0)), CLng(reg.GetValue("y0", 0)))
		Me.Location = fixLocation(Screen.FromControl(Me), Me.Location)
		reg.Close()

		reg = openKey(-1)
		Dim num As Integer = Math.Min(maxSubNum, CInt(reg.GetValue("subs", 0)))
		reg.Close()

		lblMessage.Text = ""
		setAddDelSub()
		lblNumSub.Text = num
		For i As Integer = 1 To num
			Dim frm As New DisPosSub(i)
			frms.Add(frm)
		Next
		setEnterClearAll()
		clearAll()
		setAddDelSub()
		For Each frm As DisPosSub In frms
			frm.Show()
		Next
	End Sub

	Private Sub DisPos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		Dim reg As Microsoft.Win32.RegistryKey = openKey(-1)
		reg.SetValue("subs", frms.Count, Microsoft.Win32.RegistryValueKind.DWord)
		reg.Close()

		reg = openKey(0)
		reg.SetValue("x0", Me.Location.X, Microsoft.Win32.RegistryValueKind.DWord)
		reg.SetValue("y0", Me.Location.Y, Microsoft.Win32.RegistryValueKind.DWord)
		reg.Close()

		For Each frm As DisPosSub In frms
			If Not frm.IsDisposed Then
				frm.saveLocation()
			End If
		Next
	End Sub

	Public Sub removeForm(ord As Integer)
		Dim target As DisPosSub = Nothing
		For Each frm As DisPosSub In frms
			If ord = frm.ord Then
				target = frm
			ElseIf ord < frm.ord Then
				frm.ord = frm.ord - 1
			End If
		Next
		If Not target Is Nothing Then
			deleteKey(frms.Count)
			frms.Remove(target)
		End If
		setAddDelSub()
	End Sub

	Private Sub setAddDelSub()
		btnAddSub.Enabled = (frms.Count < maxSubNum)
		btnDelSub.Enabled = (1 <= frms.Count)
		lblNumSub.Text = frms.Count
	End Sub

	Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
		If 1 + frms.Count <= maxSubNum Then
			Dim frm As New DisPosSub(1 + frms.Count)
			frms.Add(frm)
			frm.Show()
		End If
		setAddDelSub()
		distributeValue()
	End Sub

	Private Sub btnDelSub_Click(sender As Object, e As EventArgs) Handles btnDelSub.Click
		If 1 <= frms.Count Then
			Dim frm As DisPosSub = frms.Last
			frm.Close()
		End If
		setAddDelSub()
	End Sub


	Private Sub DisPos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
		' rest is not -numChange.Value, which is not calc'd while numKeep.Value <= 0
		Dim rest As Long = numTotal.Value - numKeep.Value
		Dim isShifted As Boolean = Control.ModifierKeys = Keys.Shift
		If e.KeyChar = ChrW(Keys.Return) Or e.KeyChar = ChrW(Keys.Enter) Then
			If numTotal.Focused Then
				numKeep.YenFocus()
				e.Handled = True
			ElseIf isShifted And numKeep.Focused Then
				If 0 < numKeep.ManValue And 0 < numKeep.SenValue And 0 < numKeep.YenValue Then
					Dim v = numKeep.Value
					numKeep.ManValue = v \ 10000
					numKeep.ManSelectAll()
					numKeep.SenValue = (v - 10000 * numKeep.ManValue) \ 1000
					numKeep.SenSelectAll()
					numKeep.YenValue = v - 10000 * numKeep.ManValue - 1000 * numKeep.SenValue
					numKeep.YenSelectAll()
				Else
					' do NOT use numChange.Value, which is not caled while numKeep.Value = 0.
					If 0 = numKeep.ManValue Then
						numKeep.ManValue = (numTotal.Value - 1000 * numKeep.SenValue - numKeep.YenValue) \ 10000
						numKeep.ManSelectAll()
					End If
					If 0 = numKeep.SenValue Then
						numKeep.SenValue = (numTotal.Value - 10000 * numKeep.ManValue - numKeep.YenValue) \ 1000
						numKeep.SenSelectAll()
					End If
					If 0 = numKeep.YenValue Then
						numKeep.YenValue = (numTotal.Value - 10000 * numKeep.ManValue - 1000 * numKeep.SenValue)
						numKeep.YenSelectAll()
					End If
				End If
				numKeep.YenFocus()
				e.Handled = True
			ElseIf numKeep.YenFocused Then
				If 0 <= numChange.Value Then
					btnEnter.Focus()
					e.Handled = True
				End If
			ElseIf numKeep.SenFocused Then
				If 0 = numKeep.SenValue And 0 < rest Then
					numKeep.SenValue = rest \ 1000
					numKeep.SenSelectAll()
					e.Handled = True
				Else
					numKeep.YenFocus()
					e.Handled = True
				End If
			ElseIf numKeep.ManFocused Then
				If 0 = numKeep.ManValue And 0 < rest Then
					numKeep.ManValue = rest \ 10000
					numKeep.ManSelectAll()
					e.Handled = True
				Else
					numKeep.YenFocus()
					e.Handled = True
				End If
			End If
		ElseIf e.KeyChar = ChrW(Keys.Escape) Then
			If btnEnter.Focused Then
				numKeep.YenFocus()
				e.Handled = True
			ElseIf numTotal.Focused Then
				clearAll()
				e.Handled = True
			ElseIf numKeep.Focused Then
				numKeep.Value = 0
				numTotal.Focus()
				e.Handled = True
			End If
		ElseIf e.KeyChar = ChrW(Keys.Left) Then
			If btnEnter.Focused Then
				numTotal.Focus()
				e.Handled = True
			End If
		ElseIf e.KeyChar = ChrW(Keys.Up) Then
			If btnEnter.Focused Then
				numTotal.Focus()
				e.Handled = True
			End If
		End If

	End Sub

	Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
		If enterButtonClearAll Then
			clearAll()
			setEnterTotal()
			numTotal.Focus()
		Else
			setEnterClearAll()
		End If
	End Sub

	Private Sub btnEnter_Enter(sender As Object, e As EventArgs) Handles btnEnter.Enter
		lblMessage.Text = If(0 < numChange.Value, "お釣りをご確認ください",
							 If(0 < numTotal.Value And 0 = numChange.Value, "ちょうどお預かりいたしました", ""))
		distributeValue(True)
	End Sub

	Private Sub btnEnter_Leave(sender As Object, e As EventArgs) Handles btnEnter.Leave
		lblMessage.Text = ""
		distributeValue(True)
	End Sub

	Private Sub numTotal_TextChanged(sender As Object, e As EventArgs) Handles numTotal.TextChanged
		updateChange()
		setEnterTotal()
	End Sub

	Private Sub numTotal_Enter(sender As Object, e As EventArgs) Handles numTotal.Enter
		lblMessage.Text = "少々お待ちください"
		distributeValue(True)
		setEnterTotal()
	End Sub

	Private Sub numTotal_Leave(sender As Object, e As EventArgs) Handles numTotal.Leave
		lblMessage.Text = ""
		distributeValue(True)
	End Sub

	Private Sub numKeep_TextChanged(sender As Object, e As EventArgs) Handles numKeep.TextChanged
		updateChange()
		setEnterTotal()
	End Sub

	Private Sub numKeep_Enter(sender As Object, e As EventArgs) Handles numKeep.Enter
		lblMessage.Text = "お釣りを計算しています"
		distributeValue(True)
		setEnterTotal()
	End Sub

	Private Sub numKeep_Leave(sender As Object, e As EventArgs) Handles numKeep.Leave
		lblMessage.Text = ""
		distributeValue(True)
	End Sub

	Private Sub numChange_Enter(sender As Object, e As EventArgs) Handles numChange.Enter
		btnEnter.Focus()
	End Sub
End Class

' end of file
