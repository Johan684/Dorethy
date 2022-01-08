<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IniStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniStart))
        Me.GLDBstr = New System.Windows.Forms.TextBox()
        Me.IPHN = New System.Windows.Forms.TextBox()
        Me.IPUN = New System.Windows.Forms.TextBox()
        Me.IPPW = New System.Windows.Forms.TextBox()
        Me.IPDB = New System.Windows.Forms.TextBox()
        Me.IPPWAU = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FN1 = New System.Windows.Forms.TextBox()
        Me.FN2 = New System.Windows.Forms.TextBox()
        Me.FN3 = New System.Windows.Forms.TextBox()
        Me.FN4 = New System.Windows.Forms.TextBox()
        Me.FN5 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnCHK = New System.Windows.Forms.Button()
        Me.BtnWRT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GLDBstr
        '
        Me.GLDBstr.Location = New System.Drawing.Point(199, 81)
        Me.GLDBstr.Name = "GLDBstr"
        Me.GLDBstr.Size = New System.Drawing.Size(492, 23)
        Me.GLDBstr.TabIndex = 0
        Me.GLDBstr.Text = """Host=localhost;Username=postgres;Password=""""4Dor=Access!"""";Database=postgres"""
        '
        'IPHN
        '
        Me.IPHN.Location = New System.Drawing.Point(553, 155)
        Me.IPHN.Name = "IPHN"
        Me.IPHN.Size = New System.Drawing.Size(138, 23)
        Me.IPHN.TabIndex = 1
        Me.IPHN.Text = "localhost"
        '
        'IPUN
        '
        Me.IPUN.Location = New System.Drawing.Point(553, 209)
        Me.IPUN.Name = "IPUN"
        Me.IPUN.Size = New System.Drawing.Size(138, 23)
        Me.IPUN.TabIndex = 2
        Me.IPUN.Text = "postgres"
        '
        'IPPW
        '
        Me.IPPW.Location = New System.Drawing.Point(553, 262)
        Me.IPPW.Name = "IPPW"
        Me.IPPW.Size = New System.Drawing.Size(138, 23)
        Me.IPPW.TabIndex = 3
        Me.IPPW.Text = "4Dor=Access!"
        '
        'IPDB
        '
        Me.IPDB.Location = New System.Drawing.Point(553, 316)
        Me.IPDB.Name = "IPDB"
        Me.IPDB.Size = New System.Drawing.Size(138, 23)
        Me.IPDB.TabIndex = 4
        Me.IPDB.Text = "postgres"
        '
        'IPPWAU
        '
        Me.IPPWAU.Location = New System.Drawing.Point(553, 367)
        Me.IPPWAU.Name = "IPPWAU"
        Me.IPPWAU.Size = New System.Drawing.Size(138, 23)
        Me.IPPWAU.TabIndex = 5
        Me.IPPWAU.Text = "20Dorethy21"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dorethy onetime setup"
        '
        'FN1
        '
        Me.FN1.BackColor = System.Drawing.Color.DarkGreen
        Me.FN1.ForeColor = System.Drawing.SystemColors.Window
        Me.FN1.Location = New System.Drawing.Point(363, 155)
        Me.FN1.Name = "FN1"
        Me.FN1.Size = New System.Drawing.Size(138, 23)
        Me.FN1.TabIndex = 9
        Me.FN1.Text = "Hostname"
        '
        'FN2
        '
        Me.FN2.BackColor = System.Drawing.Color.DarkGreen
        Me.FN2.ForeColor = System.Drawing.SystemColors.Window
        Me.FN2.Location = New System.Drawing.Point(363, 209)
        Me.FN2.Name = "FN2"
        Me.FN2.Size = New System.Drawing.Size(138, 23)
        Me.FN2.TabIndex = 10
        Me.FN2.Text = "Username"
        '
        'FN3
        '
        Me.FN3.BackColor = System.Drawing.Color.DarkGreen
        Me.FN3.ForeColor = System.Drawing.SystemColors.Window
        Me.FN3.Location = New System.Drawing.Point(363, 262)
        Me.FN3.Name = "FN3"
        Me.FN3.Size = New System.Drawing.Size(138, 23)
        Me.FN3.TabIndex = 11
        Me.FN3.Text = "Password"
        '
        'FN4
        '
        Me.FN4.BackColor = System.Drawing.Color.DarkGreen
        Me.FN4.ForeColor = System.Drawing.SystemColors.Window
        Me.FN4.Location = New System.Drawing.Point(363, 316)
        Me.FN4.Name = "FN4"
        Me.FN4.Size = New System.Drawing.Size(138, 23)
        Me.FN4.TabIndex = 12
        Me.FN4.Text = "Database"
        '
        'FN5
        '
        Me.FN5.BackColor = System.Drawing.Color.DarkGreen
        Me.FN5.ForeColor = System.Drawing.SystemColors.Window
        Me.FN5.Location = New System.Drawing.Point(363, 367)
        Me.FN5.Name = "FN5"
        Me.FN5.Size = New System.Drawing.Size(138, 23)
        Me.FN5.TabIndex = 13
        Me.FN5.Text = "Password add users"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.DarkGreen
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 155)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(319, 235)
        Me.RichTextBox1.TabIndex = 14
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DarkGreen
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(12, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 23)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "Your database connection string"
        '
        'BtnCHK
        '
        Me.BtnCHK.BackColor = System.Drawing.Color.Yellow
        Me.BtnCHK.ForeColor = System.Drawing.SystemColors.MenuText
        Me.BtnCHK.Location = New System.Drawing.Point(362, 410)
        Me.BtnCHK.Name = "BtnCHK"
        Me.BtnCHK.Size = New System.Drawing.Size(138, 30)
        Me.BtnCHK.TabIndex = 16
        Me.BtnCHK.Text = "Check your settings"
        Me.BtnCHK.UseVisualStyleBackColor = False
        '
        'BtnWRT
        '
        Me.BtnWRT.BackColor = System.Drawing.Color.DarkRed
        Me.BtnWRT.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnWRT.Location = New System.Drawing.Point(553, 410)
        Me.BtnWRT.Name = "BtnWRT"
        Me.BtnWRT.Size = New System.Drawing.Size(138, 30)
        Me.BtnWRT.TabIndex = 17
        Me.BtnWRT.Text = "Save your settings"
        Me.BtnWRT.UseVisualStyleBackColor = False
        '
        'IniStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnWRT)
        Me.Controls.Add(Me.BtnCHK)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.FN5)
        Me.Controls.Add(Me.FN4)
        Me.Controls.Add(Me.FN3)
        Me.Controls.Add(Me.FN2)
        Me.Controls.Add(Me.FN1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IPPWAU)
        Me.Controls.Add(Me.IPDB)
        Me.Controls.Add(Me.IPPW)
        Me.Controls.Add(Me.IPUN)
        Me.Controls.Add(Me.IPHN)
        Me.Controls.Add(Me.GLDBstr)
        Me.Name = "IniStart"
        Me.Text = "IniStart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GLDBstr As TextBox
    Friend WithEvents IPHN As TextBox
    Friend WithEvents IPUN As TextBox
    Friend WithEvents IPPW As TextBox
    Friend WithEvents IPDB As TextBox
    Friend WithEvents IPPWAU As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FN1 As TextBox
    Friend WithEvents FN2 As TextBox
    Friend WithEvents FN3 As TextBox
    Friend WithEvents FN4 As TextBox
    Friend WithEvents FN5 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnCHK As Button
    Friend WithEvents BtnWRT As Button
End Class
