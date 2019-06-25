'
' MIT License: https://opensource.org/licenses/MIT
'
' Copyright (c) 2019 Fumiyuki Shimizu
' Copyright (c) 2019 Abacus Technologies, Inc.
'
Imports System.Text.RegularExpressions

Public Class DPNumericTextBox
	Inherits TextBox

	Private _value As Long = 0
	Private _foreColor As Color
	Private _focused As Boolean = False

	Public Property UnfocusedFormat As String = "#,0"
	Public Property DefaultSelectionLength As Integer = 0
	Public Property MinNum As Long = -999999999
	Public Property MaxNum As Long = 999999999

	Private Sub DPNumericTextBox_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
		Me._foreColor = Me.ForeColor
	End Sub

	Public Property Value As Long
		Get
			Return Me._value
		End Get
		Set(value As Long)
			Me._value = value
			valueToText()
			Dim c As Color = If(Me._value < 0, Color.IndianRed, Me._foreColor)
			If Me.ForeColor <> c Then
				Me.BackColor = Me.BackColor
				Me.ForeColor = c
			End If
		End Set
	End Property

	Public ReadOnly Property YenMan As Long
		Get
			Return _value \ 10000
		End Get
	End Property

	Public ReadOnly Property YenSen As Long
		Get
			Return (_value Mod 10000) \ 1000
		End Get
	End Property

	Public ReadOnly Property YenYen As Long
		Get
			Return _value Mod 1000
		End Get
	End Property

	Private Function isHumanEdittable() As Boolean
		Return Me._focused And Me.Enabled And Not Me.ReadOnly
	End Function

	Private Sub valueToText()
		Dim s As String
		If 0 = Me._value Then
			s = ""
		ElseIf Not isHumanEdittable() Then
			s = Strings.Format(Me._value, UnfocusedFormat)
		Else
			s = Me._value.ToString()
		End If
		If Me.Text <> s Then
			Me.Text = s
		End If
	End Sub

	Private reNonNum As Regex = New Regex("[^0-9]")

	Private Sub textToValue()
		If isHumanEdittable() Then
			' handle only human input
			If "" = Me.Text Or "-" = Me.Text Then
				Me._value = 0
			Else
				Dim hasMinus As Boolean = ("-" = Strings.Left(Me.Text, 1))
				Dim s = If(hasMinus, Strings.Mid(Me.Text, 2), Me.Text)
				s = If(hasMinus, "-", "") & reNonNum.Replace(s, "")
				Dim n As Long
				Try
					n = Val(s)
					If Me.MinNum < n And n <= Me.MaxNum Then
						Me.Value = n
						Return
					End If
				Catch ex As Exception
				End Try
				valueToText()
			End If
		End If
	End Sub

	Private Sub Me_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged
		textToValue()
	End Sub

	Private Sub Me_Enter(sender As Object, e As EventArgs) Handles Me.Enter
		Me._focused = True
		valueToText()

		Dim totlen As Integer = Strings.Len(Me.Text)
		If 0 = Me.DefaultSelectionLength Or totlen <= Me.DefaultSelectionLength Then
			Me.SelectAll()
		Else
			Me.SelectionStart = totlen - Me.DefaultSelectionLength
			Me.SelectionLength = Me.DefaultSelectionLength
		End If
		Me.DefaultSelectionLength = 0
	End Sub

	Private Sub Me_Leave(sender As Object, e As EventArgs) Handles Me.Leave
		Me._focused = False
		valueToText()
	End Sub
End Class

' end of file
