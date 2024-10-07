<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LblSubtitle = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
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
        Me.LblClose.TabIndex = 1
        Me.LblClose.Text = "X"
        '
        'LblSubtitle
        '
        Me.LblSubtitle.AutoSize = True
        Me.LblSubtitle.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSubtitle.Location = New System.Drawing.Point(290, 85)
        Me.LblSubtitle.Name = "LblSubtitle"
        Me.LblSubtitle.Size = New System.Drawing.Size(213, 38)
        Me.LblSubtitle.TabIndex = 4
        Me.LblSubtitle.Text = "Stay Organised"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTitle.Location = New System.Drawing.Point(262, 29)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(276, 56)
        Me.LblTitle.TabIndex = 3
        Me.LblTitle.Text = "Diary System"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BtnLogin.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(327, 360)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(176, 37)
        Me.BtnLogin.TabIndex = 11
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(180, 262)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(103, 29)
        Me.LblPassword.TabIndex = 10
        Me.LblPassword.Text = "Password"
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(180, 217)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(108, 29)
        Me.LblUser.TabIndex = 9
        Me.LblUser.Text = "Username"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(297, 259)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(231, 37)
        Me.TxtPassword.TabIndex = 8
        '
        'TxtUser
        '
        Me.TxtUser.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(297, 216)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(231, 37)
        Me.TxtUser.TabIndex = 7
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(351, 412)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(0, 20)
        Me.LblError.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.LblSubtitle)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblClose As Label
    Friend WithEvents LblSubtitle As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUser As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents LblError As Label
End Class
