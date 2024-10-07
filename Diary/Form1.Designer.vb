<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblClose = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblSubtitle = New System.Windows.Forms.Label()
        Me.BtnEnter = New System.Windows.Forms.Button()
        Me.LblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblClose
        '
        Me.LblClose.AutoSize = True
        Me.LblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.LblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblClose.Location = New System.Drawing.Point(762, 9)
        Me.LblClose.Name = "LblClose"
        Me.LblClose.Size = New System.Drawing.Size(26, 25)
        Me.LblClose.TabIndex = 0
        Me.LblClose.Text = "X"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTitle.Location = New System.Drawing.Point(270, 158)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(276, 56)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "Diary System"
        '
        'LblSubtitle
        '
        Me.LblSubtitle.AutoSize = True
        Me.LblSubtitle.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSubtitle.Location = New System.Drawing.Point(298, 214)
        Me.LblSubtitle.Name = "LblSubtitle"
        Me.LblSubtitle.Size = New System.Drawing.Size(213, 38)
        Me.LblSubtitle.TabIndex = 2
        Me.LblSubtitle.Text = "Stay Organised"
        '
        'BtnEnter
        '
        Me.BtnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BtnEnter.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEnter.Location = New System.Drawing.Point(305, 298)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(206, 67)
        Me.BtnEnter.TabIndex = 3
        Me.BtnEnter.Text = "Enter"
        Me.BtnEnter.UseVisualStyleBackColor = False
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(341, 391)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(0, 20)
        Me.LblError.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.LblSubtitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblClose As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblSubtitle As Label
    Friend WithEvents BtnEnter As Button
    Friend WithEvents LblError As Label
End Class
