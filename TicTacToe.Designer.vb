<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacToe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.xLb = New System.Windows.Forms.Label()
        Me.oLb = New System.Windows.Forms.Label()
        Me.noLb = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.oCtr = New System.Windows.Forms.RadioButton()
        Me.xCtr = New System.Windows.Forms.RadioButton()
        Me.noStr = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'xLb
        '
        Me.xLb.AutoSize = True
        Me.xLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xLb.Location = New System.Drawing.Point(35, 33)
        Me.xLb.Name = "xLb"
        Me.xLb.Size = New System.Drawing.Size(52, 18)
        Me.xLb.TabIndex = 0
        Me.xLb.Text = "X wins"
        '
        'oLb
        '
        Me.oLb.AutoSize = True
        Me.oLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oLb.Location = New System.Drawing.Point(35, 74)
        Me.oLb.Name = "oLb"
        Me.oLb.Size = New System.Drawing.Size(54, 18)
        Me.oLb.TabIndex = 1
        Me.oLb.Text = "O wins"
        '
        'noLb
        '
        Me.noLb.AutoSize = True
        Me.noLb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noLb.Location = New System.Drawing.Point(35, 118)
        Me.noLb.Name = "noLb"
        Me.noLb.Size = New System.Drawing.Size(62, 18)
        Me.noLb.TabIndex = 2
        Me.noLb.Text = "No wins"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.xLb)
        Me.GroupBox1.Controls.Add(Me.noLb)
        Me.GroupBox1.Controls.Add(Me.oLb)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(267, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 160)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.oCtr)
        Me.GroupBox2.Controls.Add(Me.xCtr)
        Me.GroupBox2.Controls.Add(Me.noStr)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 169)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Strategy"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(23, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 86)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoEllipsis = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 75)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "xxxx"
        '
        'oCtr
        '
        Me.oCtr.AutoSize = True
        Me.oCtr.Location = New System.Drawing.Point(290, 32)
        Me.oCtr.Name = "oCtr"
        Me.oCtr.Size = New System.Drawing.Size(74, 17)
        Me.oCtr.TabIndex = 2
        Me.oCtr.TabStop = True
        Me.oCtr.Text = "Strategy C"
        Me.oCtr.UseVisualStyleBackColor = True
        '
        'xCtr
        '
        Me.xCtr.AutoSize = True
        Me.xCtr.Location = New System.Drawing.Point(152, 32)
        Me.xCtr.Name = "xCtr"
        Me.xCtr.Size = New System.Drawing.Size(74, 17)
        Me.xCtr.TabIndex = 1
        Me.xCtr.TabStop = True
        Me.xCtr.Text = "Strategy B"
        Me.xCtr.UseVisualStyleBackColor = True
        '
        'noStr
        '
        Me.noStr.AutoSize = True
        Me.noStr.Location = New System.Drawing.Point(23, 32)
        Me.noStr.Name = "noStr"
        Me.noStr.Size = New System.Drawing.Size(74, 17)
        Me.noStr.TabIndex = 0
        Me.noStr.TabStop = True
        Me.noStr.Text = "Strategy A"
        Me.noStr.UseVisualStyleBackColor = True
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(443, 462)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TicTacToe"
        Me.Text = "Tic-Tac-Toe"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents xLb As System.Windows.Forms.Label
    Friend WithEvents oLb As System.Windows.Forms.Label
    Friend WithEvents noLb As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents oCtr As System.Windows.Forms.RadioButton
    Friend WithEvents xCtr As System.Windows.Forms.RadioButton
    Friend WithEvents noStr As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
