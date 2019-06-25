'
' MIT License: https://opensource.org/licenses/MIT
'
' Copyright (c) 2019 Fumiyuki Shimizu
' Copyright (c) 2019 Abacus Technologies, Inc.
'
Public Class DPNumBoxSep
	Private Sub updateTotal()
		Me._value = 10000 * numMan.Value + 1000 * numSen.Value + numYen.Value
		If 1 > Me._value Then
			lblTotal.Text = ""
		Else
			lblTotal.Text = "計 " & Strings.Format(Me._value, "#,0")
			If 0 > numSen.Value Or 0 > numMan.Value _
			  Or (0 < numSen.Value And 1000 <= numYen.Value) _
			  Or (0 < numMan.Value And 10000 <= numYen.Value) _
			  Or (0 <> numSen.Value And 0 < numYen.Value And numYen.Value < 100) _
			  Or (0 <> numMan.Value And 0 = numSen.Value) _
			  Then
				lblTotal.ForeColor = Color.DarkViolet
			Else
				lblTotal.ForeColor = SystemColors.ControlText
			End If
		End If
	End Sub

	Private _value As Long
	Public Property Value As Long
		Get
			Return _value
		End Get
		Set(value As Long)
			Dim v As Long = value
			Dim n As Long = v \ 10000
			numMan.Value = n
			v = v - n * 10000
			n = v \ 1000
			numSen.Value = n
			numYen.Value = v - n * 1000
			updateTotal()
		End Set
	End Property
	Public Property ManValue As Long
		Get
			Return numMan.Value
		End Get
		Set(value As Long)
			If numMan.MaxNum < value Then
				numMan.Value = Math.Min(numMan.MaxNum, numMan.Value)
			ElseIf numMan.MinNum > value Then
				numMan.Value = Math.Max(numMan.MinNum, numMan.Value)
			Else
				numMan.Value = value
			End If
		End Set
	End Property
	Public Property SenValue As Long
		Get
			Return numSen.Value
		End Get
		Set(value As Long)
			If numSen.MaxNum < value Then
				numSen.Value = Math.Min(numSen.MaxNum, numSen.Value)
			ElseIf numSen.MinNum > value Then
				numSen.Value = Math.Max(numSen.MinNum, numSen.Value)
			Else
				numSen.Value = value
			End If
		End Set
	End Property
	Public Property YenValue As Long
		Get
			Return numYen.Value
		End Get
		Set(value As Long)
			If numYen.MaxNum < value Then
				numYen.Value = Math.Min(numYen.MaxNum, numYen.Value)
			ElseIf numYen.MinNum > value Then
				numYen.Value = Math.Max(numYen.MinNum, numYen.Value)
			Else
				numYen.Value = value
			End If
		End Set
	End Property

	Public Shadows Event TextChanged As EventHandler
	Private Sub numMan_TextChanged(sender As Object, e As EventArgs) Handles numMan.TextChanged
		updateTotal()
		RaiseEvent TextChanged(Me, EventArgs.Empty)
	End Sub
	Private Sub numSen_TextChanged(sender As Object, e As EventArgs) Handles numSen.TextChanged
		updateTotal()
		RaiseEvent TextChanged(Me, EventArgs.Empty)
	End Sub
	Private Sub numYen_TextChanged(sender As Object, e As EventArgs) Handles numYen.TextChanged
		updateTotal()
		RaiseEvent TextChanged(Me, EventArgs.Empty)
	End Sub

	Public Shadows Event Enter As EventHandler
	Private Sub numMan_Enter(sender As Object, e As EventArgs) Handles numMan.Enter
		RaiseEvent Enter(Me, EventArgs.Empty)
	End Sub
	Private Sub numSen_Enter(sender As Object, e As EventArgs) Handles numSen.Enter
		RaiseEvent Enter(Me, EventArgs.Empty)
	End Sub
	Private Sub numYen_Enter(sender As Object, e As EventArgs) Handles numYen.Enter
		RaiseEvent Enter(Me, EventArgs.Empty)
	End Sub

	Public Shadows Event Leave As EventHandler
	Private Sub numMan_Leave(sender As Object, e As EventArgs) Handles numMan.Leave
		RaiseEvent Leave(Me, EventArgs.Empty)
	End Sub
	Private Sub numSen_Leave(sender As Object, e As EventArgs) Handles numSen.Leave
		RaiseEvent Leave(Me, EventArgs.Empty)
	End Sub
	Private Sub numYen_Leave(sender As Object, e As EventArgs) Handles numYen.Leave
		RaiseEvent Leave(Me, EventArgs.Empty)
	End Sub

	Public ReadOnly Property YenFocused As Boolean
		Get
			Return numYen.Focused
		End Get
	End Property
	Public ReadOnly Property SenFocused As Boolean
		Get
			Return numSen.Focused
		End Get
	End Property
	Public ReadOnly Property ManFocused As Boolean
		Get
			Return numMan.Focused
		End Get
	End Property
	Public Overrides ReadOnly Property Focused As Boolean
		Get
			Return YenFocused Or SenFocused Or ManFocused
		End Get
	End Property

	Public Overloads Function YenFocus() As Boolean
		YenFocus = numYen.Focus()
	End Function
	Public Overloads Function SenFocus() As Boolean
		SenFocus = numSen.Focus()
	End Function
	Public Overloads Function ManFocus() As Boolean
		ManFocus = numMan.Focus()
	End Function
	Public Overloads Function Focus() As Boolean
		If 0 < numYen.Value Then
			Focus = YenFocus()
		ElseIf 0 < numMan.Value Then
			Focus = ManFocus()
		ElseIf 0 < numSen.Value Then
			Focus = SenFocus()
		Else
			Focus = YenFocus()
		End If
	End Function

	Private Function isSelectedAll(ctrl As TextBox) As Boolean
		If "" = ctrl.Text Then Return True
		If 0 <> ctrl.SelectionStart Then Return False
		Return Strings.Len(ctrl.Text) <= ctrl.SelectionLength
	End Function
	Public ReadOnly Property YenSelectedAll As Boolean
		Get
			Return isSelectedAll(numYen)
		End Get
	End Property
	Public ReadOnly Property SenSelectedAll As Boolean
		Get
			Return isSelectedAll(numSen)
		End Get
	End Property
	Public ReadOnly Property ManSelectedAll As Boolean
		Get
			Return isSelectedAll(numMan)
		End Get
	End Property

	Public Sub YenSelectAll()
		numYen.SelectAll()
	End Sub
	Public Sub SenSelectAll()
		numSen.SelectAll()
	End Sub
	Public Sub ManSelectAll()
		numMan.SelectAll()
	End Sub
End Class

' end of file
