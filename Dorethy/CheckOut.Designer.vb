<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Me.DorethyCO = New System.Windows.Forms.Label()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.TTLsls = New System.Windows.Forms.Label()
        Me.CA = New System.Windows.Forms.TextBox()
        Me.CAC = New System.Windows.Forms.Label()
        Me.S4CL = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.S4LOC = New System.Windows.Forms.Button()
        Me.CAMPLOC = New System.Windows.Forms.Label()
        Me.SalesSlip = New System.Windows.Forms.RichTextBox()
        Me.IN_pay = New System.Windows.Forms.TextBox()
        Me.CPO = New System.Windows.Forms.Button()
        Me.Expl1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DorethyCO
        '
        Me.DorethyCO.AutoSize = True
        Me.DorethyCO.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DorethyCO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DorethyCO.Location = New System.Drawing.Point(12, 25)
        Me.DorethyCO.Name = "DorethyCO"
        Me.DorethyCO.Size = New System.Drawing.Size(174, 23)
        Me.DorethyCO.TabIndex = 1
        Me.DorethyCO.Text = "Dorethy Check out"
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnReturn.ForeColor = System.Drawing.Color.Aqua
        Me.BtnReturn.Location = New System.Drawing.Point(654, 502)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(114, 37)
        Me.BtnReturn.TabIndex = 32
        Me.BtnReturn.Text = "Return Main menu"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'TTLsls
        '
        Me.TTLsls.AutoSize = True
        Me.TTLsls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TTLsls.Location = New System.Drawing.Point(679, 475)
        Me.TTLsls.Name = "TTLsls"
        Me.TTLsls.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TTLsls.Size = New System.Drawing.Size(89, 21)
        Me.TTLsls.TabIndex = 31
        Me.TTLsls.Text = "Total sales"
        '
        'CA
        '
        Me.CA.Location = New System.Drawing.Point(704, 94)
        Me.CA.Name = "CA"
        Me.CA.Size = New System.Drawing.Size(64, 23)
        Me.CA.TabIndex = 28
        '
        'CAC
        '
        Me.CAC.AutoSize = True
        Me.CAC.Location = New System.Drawing.Point(629, 58)
        Me.CAC.Name = "CAC"
        Me.CAC.Size = New System.Drawing.Size(139, 15)
        Me.CAC.TabIndex = 27
        Me.CAC.Text = "Current Amount on Card"
        '
        'S4CL
        '
        Me.S4CL.Location = New System.Drawing.Point(155, 97)
        Me.S4CL.Name = "S4CL"
        Me.S4CL.Size = New System.Drawing.Size(60, 23)
        Me.S4CL.TabIndex = 26
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 475)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(602, 64)
        Me.DataGridView1.TabIndex = 25
        '
        'S4LOC
        '
        Me.S4LOC.BackColor = System.Drawing.Color.DarkGreen
        Me.S4LOC.ForeColor = System.Drawing.Color.Cyan
        Me.S4LOC.Location = New System.Drawing.Point(231, 90)
        Me.S4LOC.Name = "S4LOC"
        Me.S4LOC.Size = New System.Drawing.Size(78, 34)
        Me.S4LOC.TabIndex = 24
        Me.S4LOC.Text = "Search"
        Me.S4LOC.UseVisualStyleBackColor = False
        '
        'CAMPLOC
        '
        Me.CAMPLOC.AutoSize = True
        Me.CAMPLOC.Location = New System.Drawing.Point(36, 97)
        Me.CAMPLOC.Name = "CAMPLOC"
        Me.CAMPLOC.Size = New System.Drawing.Size(102, 15)
        Me.CAMPLOC.TabIndex = 23
        Me.CAMPLOC.Text = "Camping location"
        '
        'SalesSlip
        '
        Me.SalesSlip.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SalesSlip.Location = New System.Drawing.Point(32, 263)
        Me.SalesSlip.Name = "SalesSlip"
        Me.SalesSlip.Size = New System.Drawing.Size(736, 184)
        Me.SalesSlip.TabIndex = 22
        Me.SalesSlip.Text = ""
        '
        'IN_pay
        '
        Me.IN_pay.BackColor = System.Drawing.SystemColors.MenuBar
        Me.IN_pay.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IN_pay.ForeColor = System.Drawing.Color.Red
        Me.IN_pay.Location = New System.Drawing.Point(440, 137)
        Me.IN_pay.Name = "IN_pay"
        Me.IN_pay.Size = New System.Drawing.Size(328, 23)
        Me.IN_pay.TabIndex = 33
        '
        'CPO
        '
        Me.CPO.BackColor = System.Drawing.Color.DarkBlue
        Me.CPO.ForeColor = System.Drawing.Color.Aqua
        Me.CPO.Location = New System.Drawing.Point(232, 137)
        Me.CPO.Name = "CPO"
        Me.CPO.Size = New System.Drawing.Size(96, 26)
        Me.CPO.TabIndex = 34
        Me.CPO.Text = "Check out"
        Me.CPO.UseVisualStyleBackColor = False
        '
        'Expl1
        '
        Me.Expl1.AutoSize = True
        Me.Expl1.BackColor = System.Drawing.Color.DarkBlue
        Me.Expl1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Expl1.Location = New System.Drawing.Point(32, 175)
        Me.Expl1.Name = "Expl1"
        Me.Expl1.Size = New System.Drawing.Size(270, 75)
        Me.Expl1.TabIndex = 35
        Me.Expl1.Text = "Reminder: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Every top up of the Dorethy card is stored as a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "negative value. Duri" &
    "ng check-out you need to pay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the customer the negative amount stored on the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do" &
    "rethy card." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 557)
        Me.Controls.Add(Me.Expl1)
        Me.Controls.Add(Me.CPO)
        Me.Controls.Add(Me.IN_pay)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.TTLsls)
        Me.Controls.Add(Me.CA)
        Me.Controls.Add(Me.CAC)
        Me.Controls.Add(Me.S4CL)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.S4LOC)
        Me.Controls.Add(Me.CAMPLOC)
        Me.Controls.Add(Me.SalesSlip)
        Me.Controls.Add(Me.DorethyCO)
        Me.Name = "CheckOut"
        Me.Text = "CheckOut"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DorethyCO As Label
    Friend WithEvents BtnReturn As Button
    Friend WithEvents TTLsls As Label
    Friend WithEvents CA As TextBox
    Friend WithEvents CAC As Label
    Friend WithEvents S4CL As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents S4LOC As Button
    Friend WithEvents CAMPLOC As Label
    Friend WithEvents SalesSlip As RichTextBox
    Friend WithEvents IN_pay As TextBox
    Friend WithEvents CPO As Button
    Friend WithEvents Expl1 As Label
End Class
