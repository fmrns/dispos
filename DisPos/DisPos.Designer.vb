<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisPos
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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
		Me.lblMessage = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnEnter = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblNumSub = New System.Windows.Forms.Label()
		Me.btnAddSub = New System.Windows.Forms.Button()
		Me.btnDelSub = New System.Windows.Forms.Button()
		Me.numChange = New DP.DPNumBox()
		Me.numTotal = New DP.DPNumBox()
		Me.numKeep = New DP.DPNumBoxSep()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'lblMessage
		'
		Me.lblMessage.Font = New System.Drawing.Font("MS UI Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.lblMessage.Location = New System.Drawing.Point(20, 248)
		Me.lblMessage.Name = "lblMessage"
		Me.lblMessage.Size = New System.Drawing.Size(458, 45)
		Me.lblMessage.TabIndex = 15
		Me.lblMessage.Text = "メッセージ"
		Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label3.Location = New System.Drawing.Point(38, 150)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 45)
		Me.Label3.TabIndex = 14
		Me.Label3.Text = "お釣り"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label2.Location = New System.Drawing.Point(12, 78)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(126, 45)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "お預かり"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.Label1.Location = New System.Drawing.Point(54, 6)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(84, 45)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "合計"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnEnter
		'
		Me.btnEnter.Location = New System.Drawing.Point(409, 155)
		Me.btnEnter.Name = "btnEnter"
		Me.btnEnter.Size = New System.Drawing.Size(53, 40)
		Me.btnEnter.TabIndex = 2
		Me.btnEnter.Text = "計"
		Me.btnEnter.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(398, 95)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(84, 12)
		Me.Label4.TabIndex = 16
		Me.Label4.Text = "[TAB] ⇧+[TAB]"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(403, 80)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(74, 12)
		Me.Label5.TabIndex = 17
		Me.Label5.Text = "[Enter] [ESC]"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(66, 220)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(72, 12)
		Me.Label6.TabIndex = 18
		Me.Label6.Text = "表示ウィンドウ"
		'
		'lblNumSub
		'
		Me.lblNumSub.Location = New System.Drawing.Point(144, 220)
		Me.lblNumSub.Name = "lblNumSub"
		Me.lblNumSub.Size = New System.Drawing.Size(53, 12)
		Me.lblNumSub.TabIndex = 19
		Me.lblNumSub.Text = "99"
		Me.lblNumSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnAddSub
		'
		Me.btnAddSub.Location = New System.Drawing.Point(203, 215)
		Me.btnAddSub.Name = "btnAddSub"
		Me.btnAddSub.Size = New System.Drawing.Size(38, 23)
		Me.btnAddSub.TabIndex = 20
		Me.btnAddSub.Text = "追加"
		Me.btnAddSub.UseVisualStyleBackColor = True
		'
		'btnDelSub
		'
		Me.btnDelSub.Location = New System.Drawing.Point(247, 215)
		Me.btnDelSub.Name = "btnDelSub"
		Me.btnDelSub.Size = New System.Drawing.Size(38, 23)
		Me.btnDelSub.TabIndex = 21
		Me.btnDelSub.Text = "削除"
		Me.btnDelSub.UseVisualStyleBackColor = True
		'
		'numChange
		'
		Me.numChange.AutoSize = True
		Me.numChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.numChange.DefaultSelectionLength = 0
		Me.numChange.Location = New System.Drawing.Point(144, 150)
		Me.numChange.MaxNum = CType(999999999, Long)
		Me.numChange.MinimumSize = New System.Drawing.Size(248, 65)
		Me.numChange.Name = "numChange"
		Me.numChange.ReadOnly_ = False
		Me.numChange.SelectionLength = 0
		Me.numChange.SelectionStart = 0
		Me.numChange.Size = New System.Drawing.Size(248, 65)
		Me.numChange.TabIndex = 2
		Me.numChange.TabStop = False
		Me.numChange.Value = CType(123456789, Long)
		'
		'numTotal
		'
		Me.numTotal.AutoSize = True
		Me.numTotal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.numTotal.DefaultSelectionLength = 0
		Me.numTotal.Location = New System.Drawing.Point(144, 6)
		Me.numTotal.MaxNum = CType(999999999, Long)
		Me.numTotal.MinimumSize = New System.Drawing.Size(248, 65)
		Me.numTotal.Name = "numTotal"
		Me.numTotal.ReadOnly_ = False
		Me.numTotal.SelectionLength = 0
		Me.numTotal.SelectionStart = 0
		Me.numTotal.Size = New System.Drawing.Size(248, 65)
		Me.numTotal.TabIndex = 0
		Me.numTotal.Value = CType(123456789, Long)
		'
		'numKeep
		'
		Me.numKeep.Location = New System.Drawing.Point(144, 80)
		Me.numKeep.ManValue = CType(371, Long)
		Me.numKeep.Name = "numKeep"
		Me.numKeep.SenValue = CType(0, Long)
		Me.numKeep.Size = New System.Drawing.Size(248, 65)
		Me.numKeep.TabIndex = 1
		Me.numKeep.Value = CType(4944567, Long)
		Me.numKeep.YenValue = CType(1234567, Long)
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(409, 110)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(63, 12)
		Me.Label7.TabIndex = 22
		Me.Label7.Text = "⇧+[ENTER]"
		'
		'DisPos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(494, 311)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.btnDelSub)
		Me.Controls.Add(Me.btnAddSub)
		Me.Controls.Add(Me.lblNumSub)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.btnEnter)
		Me.Controls.Add(Me.numChange)
		Me.Controls.Add(Me.numTotal)
		Me.Controls.Add(Me.numKeep)
		Me.Controls.Add(Me.lblMessage)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MaximumSize = New System.Drawing.Size(510, 350)
		Me.MinimumSize = New System.Drawing.Size(510, 350)
		Me.Name = "DisPos"
		Me.Text = "DisPos"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblMessage As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents numKeep As DP.DPNumBoxSep
	Friend WithEvents numTotal As DP.DPNumBox
	Friend WithEvents numChange As DP.DPNumBox
	Friend WithEvents btnEnter As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblNumSub As Label
	Friend WithEvents btnAddSub As Button
	Friend WithEvents btnDelSub As Button
	Friend WithEvents Label7 As Label
End Class
