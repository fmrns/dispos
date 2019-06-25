<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPNumBoxSep
	Inherits System.Windows.Forms.UserControl

	'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.numYen = New DP.DPNumericTextBox()
		Me.numSen = New DP.DPNumericTextBox()
		Me.numMan = New DP.DPNumericTextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(8, 48)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(49, 12)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "万(補助)"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(63, 48)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(49, 12)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "千(補助)"
		'
		'lblTotal
		'
		Me.lblTotal.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTotal.Location = New System.Drawing.Point(130, 48)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(115, 12)
		Me.lblTotal.TabIndex = 7
		Me.lblTotal.Text = "1.234.567.890"
		Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'numYen
		'
		Me.numYen.BackColor = System.Drawing.SystemColors.Window
		Me.numYen.DefaultSelectionLength = 0
		Me.numYen.Font = New System.Drawing.Font("Consolas", 24.0!)
		Me.numYen.Location = New System.Drawing.Point(114, 0)
		Me.numYen.MaxNum = CType(9999999, Long)
		Me.numYen.MinNum = CType(0, Long)
		Me.numYen.Name = "numYen"
		Me.numYen.Size = New System.Drawing.Size(132, 45)
		Me.numYen.TabIndex = 2
		Me.numYen.Text = "1234567"
		Me.numYen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numYen.UnfocusedFormat = "#0"
		Me.numYen.Value = CType(1234567, Long)
		'
		'numSen
		'
		Me.numSen.BackColor = System.Drawing.SystemColors.Window
		Me.numSen.DefaultSelectionLength = 0
		Me.numSen.Font = New System.Drawing.Font("Consolas", 24.0!)
		Me.numSen.Location = New System.Drawing.Point(65, 0)
		Me.numSen.MaxNum = CType(99, Long)
		Me.numSen.MinNum = CType(0, Long)
		Me.numSen.Name = "numSen"
		Me.numSen.Size = New System.Drawing.Size(43, 45)
		Me.numSen.TabIndex = 1
		Me.numSen.Text = "12"
		Me.numSen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numSen.UnfocusedFormat = "#,0"
		Me.numSen.Value = CType(12, Long)
		'
		'numMan
		'
		Me.numMan.BackColor = System.Drawing.SystemColors.Window
		Me.numMan.DefaultSelectionLength = 0
		Me.numMan.Font = New System.Drawing.Font("Consolas", 24.0!)
		Me.numMan.Location = New System.Drawing.Point(0, 0)
		Me.numMan.MaxNum = CType(999, Long)
		Me.numMan.MinNum = CType(0, Long)
		Me.numMan.Name = "numMan"
		Me.numMan.Size = New System.Drawing.Size(59, 45)
		Me.numMan.TabIndex = 0
		Me.numMan.Text = "123"
		Me.numMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numMan.UnfocusedFormat = "#0"
		Me.numMan.Value = CType(123, Long)
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(57, 17)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(11, 12)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "+"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(106, 17)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(11, 12)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "+"
		'
		'DPNumBoxSep
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.numYen)
		Me.Controls.Add(Me.numSen)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.numMan)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Name = "DPNumBoxSep"
		Me.Size = New System.Drawing.Size(248, 65)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents numMan As DPNumericTextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents numSen As DPNumericTextBox
	Friend WithEvents numYen As DPNumericTextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents lblTotal As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
End Class
