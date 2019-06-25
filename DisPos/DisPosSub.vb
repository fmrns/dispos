'
' MIT License: https://opensource.org/licenses/MIT
'
' Copyright (c) 2019 Fumiyuki Shimizu
' Copyright (c) 2019 Abacus Technologies, Inc.
'
Imports System.ComponentModel

Public Class DisPosSub
	Dim _ord As Integer
	Public Property ord As Integer
		Get
			Return _ord
		End Get
		Set(value As Integer)
			_ord = value
			Me.Text = DisPos.Name & "[" & _ord & "]"
		End Set
	End Property

	Public Sub New(ordinal As Integer)
		InitializeComponent()
		ord = ordinal
	End Sub

	Private nextWindowState As Object = Nothing 'FormWindowState

	Private Sub maximize()
		nextWindowState = FormWindowState.Maximized
		Me.FormBorderStyle = FormBorderStyle.None
		Me.WindowState = FormWindowState.Maximized
		nextWindowState = Nothing
	End Sub

	Private Sub unmaximize()
		nextWindowState = FormWindowState.Normal
		Me.FormBorderStyle = FormBorderStyle.Sizable
		Me.WindowState = FormWindowState.Normal
		nextWindowState = Nothing
	End Sub

	Private Sub DisPosSub_Load(sender As Object, e As EventArgs) Handles Me.Load
		Dim reg As Microsoft.Win32.RegistryKey = DisPos.openKey(ord)
		Try
			Me.Location = New Point(CLng(reg.GetValue("x0", 30 * ord)), CLng(reg.GetValue("y0", 30 * ord)))
			Dim n As Long = CLng(reg.GetValue("w", 0))
			If Me.MinimumSize.Width <= n Then Me.Width = n
			n = CLng(reg.GetValue("h", 0))
			If Me.MinimumSize.Height <= n Then Me.Height = n
			Me.Location = DisPos.fixLocation(Screen.FromControl(Me), Me.Location)
			If 1 = CLng(reg.GetValue("max", 0)) Then
				maximize()
			Else
				unmaximize()
			End If
		Finally
			reg.Close()
		End Try
	End Sub

	Public Sub saveLocation()
		Dim reg As Microsoft.Win32.RegistryKey = DisPos.openKey(ord)
		reg.SetValue("x0", Me.Location.X, Microsoft.Win32.RegistryValueKind.DWord)
		reg.SetValue("y0", Me.Location.Y, Microsoft.Win32.RegistryValueKind.DWord)
		reg.SetValue("w", Me.Size.Width, Microsoft.Win32.RegistryValueKind.DWord)
		reg.SetValue("h", Me.Size.Height, Microsoft.Win32.RegistryValueKind.DWord)
		reg.SetValue("max", If(Me.WindowState = FormWindowState.Maximized, 1, 0), Microsoft.Win32.RegistryValueKind.DWord)
		reg.Close()
	End Sub

	Private Sub DisPosSub_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		DisPos.removeForm(ord)
	End Sub

	Private Sub DisPosSub_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout
		If nextWindowState Is Nothing Then
			If Me.WindowState <> FormWindowState.Maximized And Me.FormBorderStyle = FormBorderStyle.None Then
				Me.FormBorderStyle = FormBorderStyle.Sizable
			ElseIf Me.WindowState = FormWindowState.Maximized And Me.FormBorderStyle <> FormBorderStyle.None Then
				Me.FormBorderStyle = FormBorderStyle.None
				' resize happens
				Return
			End If
		ElseIf nextWindowState = FormWindowState.Maximized Then
			Me.FormBorderStyle = FormBorderStyle.None
		ElseIf nextWindowState = FormWindowState.Normal Then
			Me.FormBorderStyle = FormBorderStyle.Sizable
		End If
		' 0.5 space
		' 1 total
		' 1 keep
		' 1 change
		' 1.5 message
		Dim bottom = Me.ClientRectangle.Height * 3.5 / 5
		Dim topTotal As Integer = Me.ClientRectangle.Height * 0.5 / 5
		Dim topKeep As Integer = topTotal + (bottom - topTotal) / 3
		Dim topChange As Integer = topTotal + (bottom - topTotal) * 2 / 3
		Dim ratLR = Me.ClientRectangle.Width / 400
		Dim divLR = Me.ClientRectangle.Width * 140 / 400
		lblTotal.Top = topTotal + (topKeep - topTotal - lblTotal.Height) / 2
		numTotal.Top = topTotal + (topKeep - topTotal - numTotal.Height) / 2
		lblKeep.Top = topKeep + (topChange - topKeep - lblKeep.Height) / 2
		numKeep.Top = topKeep + (topChange - topKeep - numKeep.Height) / 2
		lblChange.Top = topChange + (bottom - topChange - lblChange.Height) / 2
		numChange.Top = topChange + (bottom - topChange - numChange.Height) / 2
		If Me.ClientRectangle.Width > 800 Then
			numTotal.Left = (Me.ClientRectangle.Width - numTotal.Width) / 2
			numKeep.Left = (Me.ClientRectangle.Width - numKeep.Width) / 2
			numChange.Left = (Me.ClientRectangle.Width - numChange.Width) / 2
			lblTotal.Left = numTotal.Left - 20 * ratLR - lblTotal.Width
			lblKeep.Left = numKeep.Left - 20 * ratLR - lblKeep.Width
			lblChange.Left = numChange.Left - 20 * ratLR - lblChange.Width
		Else
			lblTotal.Left = divLR - 10 * ratLR - lblTotal.Width
			numTotal.Left = divLR + 10 * ratLR
			lblKeep.Left = divLR - 10 * ratLR - lblKeep.Width
			numKeep.Left = divLR + 10 * ratLR
			lblChange.Left = divLR - 10 * ratLR - lblChange.Width
			numChange.Left = divLR + 10 * ratLR
		End If
	End Sub

	Private Sub DisPosSub_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
		If e.KeyChar = ChrW(Keys.Escape) Then
			unmaximize()
		End If
	End Sub

	Private Sub DisPosSub_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If e.KeyCode = Keys.F11 Then
			If Me.WindowState = FormWindowState.Normal Then
				maximize()
			Else
				unmaximize()
			End If
		End If
	End Sub

	Private Sub numTotal_Enter(sender As Object, e As EventArgs) Handles numTotal.Enter
		lblMessage.Focus()
	End Sub

	Private Sub numKeep_Enter(sender As Object, e As EventArgs) Handles numKeep.Enter
		lblMessage.Focus()
	End Sub
End Class

' end of file
