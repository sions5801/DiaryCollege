<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.TxtDay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMonth = New System.Windows.Forms.TextBox()
        Me.TxtYear = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEntry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMood = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTargets = New System.Windows.Forms.TextBox()
        Me.BtnEnter = New System.Windows.Forms.Button()
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
        Me.LblClose.TabIndex = 3
        Me.LblClose.Text = "X"
        '
        'LblSubtitle
        '
        Me.LblSubtitle.AutoSize = True
        Me.LblSubtitle.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSubtitle.Location = New System.Drawing.Point(290, 85)
        Me.LblSubtitle.Name = "LblSubtitle"
        Me.LblSubtitle.Size = New System.Drawing.Size(227, 38)
        Me.LblSubtitle.TabIndex = 8
        Me.LblSubtitle.Text = "Select an option."
        '
        'LblMenu
        '
        Me.LblMenu.AutoSize = True
        Me.LblMenu.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblMenu.Location = New System.Drawing.Point(336, 29)
        Me.LblMenu.Name = "LblMenu"
        Me.LblMenu.Size = New System.Drawing.Size(124, 56)
        Me.LblMenu.TabIndex = 7
        Me.LblMenu.Text = "Menu"
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(272, 123)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(245, 31)
        Me.TxtTitle.TabIndex = 9
        '
        'TxtDay
        '
        Me.TxtDay.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDay.Location = New System.Drawing.Point(272, 156)
        Me.TxtDay.Name = "TxtDay"
        Me.TxtDay.Size = New System.Drawing.Size(34, 31)
        Me.TxtDay.TabIndex = 10
        Me.TxtDay.Text = "DD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Title"
        '
        'TxtMonth
        '
        Me.TxtMonth.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMonth.Location = New System.Drawing.Point(335, 156)
        Me.TxtMonth.Name = "TxtMonth"
        Me.TxtMonth.Size = New System.Drawing.Size(40, 31)
        Me.TxtMonth.TabIndex = 12
        Me.TxtMonth.Text = "MM"
        '
        'TxtYear
        '
        Me.TxtYear.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtYear.Location = New System.Drawing.Point(407, 154)
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.Size = New System.Drawing.Size(66, 31)
        Me.TxtYear.TabIndex = 13
        Me.TxtYear.Text = "YYYY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(303, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 38)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "/"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(370, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 38)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "/"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(199, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(199, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 23)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Entry"
        '
        'TxtEntry
        '
        Me.TxtEntry.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEntry.Location = New System.Drawing.Point(272, 195)
        Me.TxtEntry.Multiline = True
        Me.TxtEntry.Name = "TxtEntry"
        Me.TxtEntry.Size = New System.Drawing.Size(245, 146)
        Me.TxtEntry.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(199, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Mood"
        '
        'TxtMood
        '
        Me.TxtMood.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMood.Location = New System.Drawing.Point(272, 347)
        Me.TxtMood.Name = "TxtMood"
        Me.TxtMood.Size = New System.Drawing.Size(245, 31)
        Me.TxtMood.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(199, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 23)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Targets"
        '
        'TxtTargets
        '
        Me.TxtTargets.Font = New System.Drawing.Font("Comic Sans MS", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTargets.Location = New System.Drawing.Point(272, 384)
        Me.TxtTargets.Name = "TxtTargets"
        Me.TxtTargets.Size = New System.Drawing.Size(245, 31)
        Me.TxtTargets.TabIndex = 21
        '
        'BtnEnter
        '
        Me.BtnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BtnEnter.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.BtnEnter.ForeColor = System.Drawing.Color.White
        Me.BtnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnter.Location = New System.Drawing.Point(358, 421)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnter.TabIndex = 23
        Me.BtnEnter.Text = "Submit"
        Me.BtnEnter.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnEnter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTargets)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtMood)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtEntry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtYear)
        Me.Controls.Add(Me.TxtMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDay)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.LblSubtitle)
        Me.Controls.Add(Me.LblMenu)
        Me.Controls.Add(Me.LblClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblClose As Label
    Friend WithEvents LblSubtitle As Label
    Friend WithEvents LblMenu As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents TxtDay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMonth As TextBox
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtEntry As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMood As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTargets As TextBox
    Friend WithEvents BtnEnter As Button
End Class
