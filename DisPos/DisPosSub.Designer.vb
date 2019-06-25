<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DisPosSub
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.lblChange = New System.Windows.Forms.Label()
		Me.lblKeep = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.numKeep = New DP.DPNumBox()
		Me.numChange = New DP.DPNumBox()
		Me.numTotal = New DP.DPNumBox()
		Me.SuspendLayout()
		'
		'lblMessage
		'
		Me.lblMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblMessage.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.lblMessage.Location = New System.Drawing.Point(23, 281)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(372, 45)
		Me.lblMessage.TabIndex = 29
		Me.lblMessage.Text = "メッセージ"
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblChange
		'
		Me.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lblChange.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.lblChange.Location = New System.Drawing.Point(12, 186)
		Me.lblChange.Name = "lblChange"
		Me.lblChange.Size = New System.Drawing.Size(129, 45)
		Me.lblChange.TabIndex = 28
		Me.lblChange.Text = "お釣り"
		Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblKeep
		'
		Me.lblKeep.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lblKeep.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.lblKeep.Location = New System.Drawing.Point(12, 117)
		Me.lblKeep.Name = "lblKeep"
		Me.lblKeep.Size = New System.Drawing.Size(129, 45)
		Me.lblKeep.TabIndex = 27
		Me.lblKeep.Text = "お預かり"
		Me.lblKeep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblTotal
		'
		Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.lblTotal.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.lblTotal.Location = New System.Drawing.Point(12, 48)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(129, 45)
		Me.lblTotal.TabIndex = 26
		Me.lblTotal.Text = "合計"
		Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'numKeep
		'
		Me.numKeep.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.numKeep.AutoSize = True
		Me.numKeep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.numKeep.DefaultSelectionLength = 0
		Me.numKeep.Location = New System.Drawing.Point(147, 117)
		Me.numKeep.MaxNum = CType(999999999, Long)
		Me.numKeep.MinimumSize = New System.Drawing.Size(248, 65)
		Me.numKeep.Name = "numKeep"
		Me.numKeep.ReadOnly_ = True
		Me.numKeep.SelectionLength = 0
		Me.numKeep.SelectionStart = 0
		Me.numKeep.Size = New System.Drawing.Size(248, 65)
		Me.numKeep.TabIndex = 30
		Me.numKeep.Value = CType(123456789, Long)
		'
		'numChange
		'
		Me.numChange.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.numChange.AutoSize = True
		Me.numChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.numChange.DefaultSelectionLength = 0
		Me.numChange.Location = New System.Drawing.Point(147, 186)
		Me.numChange.MaxNum = CType(999999999, Long)
		Me.numChange.MinimumSize = New System.Drawing.Size(248, 65)
		Me.numChange.Name = "numChange"
		Me.numChange.ReadOnly_ = True
		Me.numChange.SelectionLength = 0
		Me.numChange.SelectionStart = 0
		Me.numChange.Size = New System.Drawing.Size(248, 65)
		Me.numChange.TabIndex = 25
		Me.numChange.TabStop = False
		Me.numChange.Value = CType(123456789, Long)
		'
		'numTotal
		'
		Me.numTotal.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.numTotal.AutoSize = True
		Me.numTotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.numTotal.DefaultSelectionLength = 0
		Me.numTotal.Location = New System.Drawing.Point(147, 48)
		Me.numTotal.MaxNum = CType(999999999, Long)
		Me.numTotal.MinimumSize = New System.Drawing.Size(248, 65)
		Me.numTotal.Name = "numTotal"
		Me.numTotal.ReadOnly_ = True
		Me.numTotal.SelectionLength = 11
		Me.numTotal.SelectionStart = 0
		Me.numTotal.Size = New System.Drawing.Size(248, 65)
		Me.numTotal.TabIndex = 22
		Me.numTotal.Value = CType(123456789, Long)
		'
		'DisPosSub
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(414, 361)
		Me.Controls.Add(Me.numKeep)
		Me.Controls.Add(Me.numChange)
		Me.Controls.Add(Me.numTotal)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.lblChange)
		Me.Controls.Add(Me.lblKeep)
		Me.Controls.Add(Me.lblTotal)
		Me.KeyPreview = True
		Me.MinimumSize = New System.Drawing.Size(430, 400)
		Me.Name = "DisPosSub"
		Me.Text = "DisPosSub"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents numChange As DP.DPNumBox
	Friend WithEvents numTotal As DP.DPNumBox
	Friend WithEvents lblMessage As Label
	Friend WithEvents lblChange As Label
	Friend WithEvents lblKeep As Label
	Friend WithEvents lblTotal As Label
	Friend WithEvents numKeep As DP.DPNumBox
End Class
