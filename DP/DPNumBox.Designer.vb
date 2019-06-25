<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPNumBox
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
		Me.txtYen = New System.Windows.Forms.Label()
		Me.lblSen = New System.Windows.Forms.Label()
		Me.txtSen = New System.Windows.Forms.Label()
		Me.txtMan = New System.Windows.Forms.Label()
		Me.lblMan = New System.Windows.Forms.Label()
		Me.numBox = New DP.DPNumericTextBox()
		Me.SuspendLayout()
		'
		'txtYen
		'
		Me.txtYen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtYen.Location = New System.Drawing.Point(205, 51)
		Me.txtYen.Name = "txtYen"
		Me.txtYen.Size = New System.Drawing.Size(40, 16)
		Me.txtYen.TabIndex = 1
		Me.txtYen.Text = "Yen"
		Me.txtYen.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.txtYen.Visible = False
		'
		'lblSen
		'
		Me.lblSen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.lblSen.Location = New System.Drawing.Point(165, 51)
		Me.lblSen.Name = "lblSen"
		Me.lblSen.Size = New System.Drawing.Size(21, 16)
		Me.lblSen.TabIndex = 2
		Me.lblSen.Text = "千"
		Me.lblSen.Visible = False
		'
		'txtSen
		'
		Me.txtSen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtSen.Location = New System.Drawing.Point(143, 51)
		Me.txtSen.Name = "txtSen"
		Me.txtSen.Size = New System.Drawing.Size(19, 16)
		Me.txtSen.TabIndex = 3
		Me.txtSen.Text = "Sen"
		Me.txtSen.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.txtSen.Visible = False
		'
		'txtMan
		'
		Me.txtMan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtMan.Location = New System.Drawing.Point(3, 51)
		Me.txtMan.Name = "txtMan"
		Me.txtMan.Size = New System.Drawing.Size(101, 16)
		Me.txtMan.TabIndex = 5
		Me.txtMan.Text = "Man"
		Me.txtMan.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.txtMan.Visible = False
		'
		'lblMan
		'
		Me.lblMan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.lblMan.Location = New System.Drawing.Point(107, 51)
		Me.lblMan.Name = "lblMan"
		Me.lblMan.Size = New System.Drawing.Size(21, 16)
		Me.lblMan.TabIndex = 4
		Me.lblMan.Text = "万"
		Me.lblMan.Visible = False
		'
		'numBox
		'
		Me.numBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.numBox.BackColor = System.Drawing.SystemColors.Window
		Me.numBox.DefaultSelectionLength = 0
		Me.numBox.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numBox.Location = New System.Drawing.Point(0, 0)
		Me.numBox.MaxNum = CType(999999999, Long)
		Me.numBox.MinNum = CType(-999999999, Long)
		Me.numBox.Name = "numBox"
		Me.numBox.Size = New System.Drawing.Size(245, 45)
		Me.numBox.TabIndex = 0
		Me.numBox.Text = "123,456,789"
		Me.numBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.numBox.UnfocusedFormat = "#,0"
		Me.numBox.Value = CType(123456789, Long)
		'
		'DPNumBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Controls.Add(Me.txtMan)
		Me.Controls.Add(Me.lblMan)
		Me.Controls.Add(Me.txtSen)
		Me.Controls.Add(Me.lblSen)
		Me.Controls.Add(Me.txtYen)
		Me.Controls.Add(Me.numBox)
		Me.MinimumSize = New System.Drawing.Size(248, 65)
		Me.Name = "DPNumBox"
		Me.Size = New System.Drawing.Size(248, 65)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents numBox As DPNumericTextBox
	Friend WithEvents txtYen As Label
	Friend WithEvents lblSen As Label
	Friend WithEvents txtSen As Label
	Friend WithEvents txtMan As Label
	Friend WithEvents lblMan As Label
End Class
