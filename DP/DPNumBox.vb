'
' MIT License: https://opensource.org/licenses/MIT
'
' Copyright (c) 2019 Fumiyuki Shimizu
' Copyright (c) 2019 Abacus Technologies, Inc.
'
Public Class DPNumBox
	Public Shadows Event TextChanged As EventHandler
	Private Sub numBox_TextChanged(sender As Object, e As EventArgs) Handles numBox.TextChanged
		txtMan.Text = numBox.YenMan.ToString()
		txtMan.Visible = (0 <= numBox.Value And 1 <= numBox.YenMan)
		lblMan.Visible = txtMan.Visible

		txtSen.Text = numBox.YenSen.ToString()
		txtSen.Visible = (0 <= numBox.Value And 1 <= numBox.YenSen)
		lblSen.Visible = txtSen.Visible

		txtYen.Text = numBox.YenYen.ToString()
		txtYen.Visible = (0 <= numBox.Value And 1 <= numBox.YenYen)

		RaiseEvent TextChanged(Me, EventArgs.Empty)
	End Sub

	Public Property Value As Long
		Get
			Return numBox.Value
		End Get
		Set(value As Long)
			If numBox.MaxNum < value Then
				numBox.Value = Math.Min(numBox.MaxNum, numBox.Value)
			ElseIf numBox.MinNum > value Then
				numBox.Value = Math.Max(numBox.MinNum, numBox.Value)
			Else
				numBox.Value = value
			End If
		End Set
	End Property

	Public Overrides ReadOnly Property Focused As Boolean
		Get
			Return numBox.Focused
		End Get
	End Property

	Public Overloads Function Focus() As Boolean
		Focus = numBox.Focus()
	End Function

	Public Property ReadOnly_ As Boolean
		Get
			Return numBox.ReadOnly
		End Get
		Set(value As Boolean)
			numBox.ReadOnly = value
		End Set
	End Property

	Public Overloads Property Enabled As Boolean
		Get
			Return numBox.Enabled
		End Get
		Set(value As Boolean)
			numBox.Enabled = value
		End Set
	End Property

	Public Property SelectionStart As Integer
		Get
			Return numBox.SelectionStart
		End Get
		Set(value As Integer)
			numBox.SelectionStart = value
		End Set
	End Property

	Public Property SelectionLength As Integer
		Get
			Return numBox.SelectionLength
		End Get
		Set(value As Integer)
			numBox.SelectionLength = value
		End Set
	End Property

	Public Property DefaultSelectionLength As Integer
		Get
			Return numBox.DefaultSelectionLength
		End Get
		Set(value As Integer)
			numBox.DefaultSelectionLength = value
		End Set
	End Property

	Public Property MaxNum As Long
		Get
			Return numBox.MaxNum
		End Get
		Set(value As Long)
			numBox.MaxNum = value
		End Set
	End Property

	Public Overloads Property Font As Font
		Get
			Return numBox.Font
		End Get
		Set(value As Font)
			numBox.Font = value
		End Set
	End Property

	Public Overloads Property Width As Integer
		Get
			Return numBox.Width
		End Get
		Set(value As Integer)
			numBox.Width = value
		End Set
	End Property
End Class

' end of file
