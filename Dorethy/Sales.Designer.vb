<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.SalesSlip = New System.Windows.Forms.RichTextBox()
        Me.DSAL = New System.Windows.Forms.Label()
        Me.CAMPLOC = New System.Windows.Forms.Label()
        Me.S4LOC = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.S4CL = New System.Windows.Forms.TextBox()
        Me.PWDC = New System.Windows.Forms.Label()
        Me.PWDCY = New System.Windows.Forms.Button()
        Me.PWDCN = New System.Windows.Forms.Button()
        Me.CAC = New System.Windows.Forms.Label()
        Me.CA = New System.Windows.Forms.TextBox()
        Me.SCNPR = New System.Windows.Forms.Label()
        Me.ISCBpr = New System.Windows.Forms.TextBox()
        Me.AMT = New System.Windows.Forms.Label()
        Me.IMOU = New System.Windows.Forms.TextBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.PayNow = New System.Windows.Forms.Button()
        Me.TTLsls = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.Expl1 = New System.Windows.Forms.Label()
        Me.Expl2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesSlip
        '
        Me.SalesSlip.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SalesSlip.Location = New System.Drawing.Point(12, 216)
        Me.SalesSlip.Name = "SalesSlip"
        Me.SalesSlip.Size = New System.Drawing.Size(743, 186)
        Me.SalesSlip.TabIndex = 1
        Me.SalesSlip.Text = ""
        '
        'DSAL
        '
        Me.DSAL.AutoSize = True
        Me.DSAL.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DSAL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DSAL.Location = New System.Drawing.Point(12, 23)
        Me.DSAL.Name = "DSAL"
        Me.DSAL.Size = New System.Drawing.Size(134, 23)
        Me.DSAL.TabIndex = 2
        Me.DSAL.Text = "Dorethy Sales"
        '
        'CAMPLOC
        '
        Me.CAMPLOC.AutoSize = True
        Me.CAMPLOC.Location = New System.Drawing.Point(12, 64)
        Me.CAMPLOC.Name = "CAMPLOC"
        Me.CAMPLOC.Size = New System.Drawing.Size(102, 15)
        Me.CAMPLOC.TabIndex = 3
        Me.CAMPLOC.Text = "Camping location"
        '
        'S4LOC
        '
        Me.S4LOC.BackColor = System.Drawing.Color.DarkGreen
        Me.S4LOC.ForeColor = System.Drawing.Color.Cyan
        Me.S4LOC.Location = New System.Drawing.Point(207, 57)
        Me.S4LOC.Name = "S4LOC"
        Me.S4LOC.Size = New System.Drawing.Size(78, 34)
        Me.S4LOC.TabIndex = 5
        Me.S4LOC.Text = "Search"
        Me.S4LOC.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 418)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(602, 64)
        Me.DataGridView1.TabIndex = 6
        '
        'S4CL
        '
        Me.S4CL.Location = New System.Drawing.Point(131, 64)
        Me.S4CL.Name = "S4CL"
        Me.S4CL.Size = New System.Drawing.Size(60, 23)
        Me.S4CL.TabIndex = 7
        '
        'PWDC
        '
        Me.PWDC.AutoSize = True
        Me.PWDC.Location = New System.Drawing.Point(310, 31)
        Me.PWDC.Name = "PWDC"
        Me.PWDC.Size = New System.Drawing.Size(130, 15)
        Me.PWDC.TabIndex = 8
        Me.PWDC.Text = "Pay with Dorethy Card?"
        '
        'PWDCY
        '
        Me.PWDCY.BackColor = System.Drawing.Color.DarkGreen
        Me.PWDCY.ForeColor = System.Drawing.Color.Cyan
        Me.PWDCY.Location = New System.Drawing.Point(310, 64)
        Me.PWDCY.Name = "PWDCY"
        Me.PWDCY.Size = New System.Drawing.Size(49, 27)
        Me.PWDCY.TabIndex = 9
        Me.PWDCY.Text = "Yes"
        Me.PWDCY.UseVisualStyleBackColor = False
        '
        'PWDCN
        '
        Me.PWDCN.BackColor = System.Drawing.Color.Firebrick
        Me.PWDCN.ForeColor = System.Drawing.Color.Cyan
        Me.PWDCN.Location = New System.Drawing.Point(391, 64)
        Me.PWDCN.Name = "PWDCN"
        Me.PWDCN.Size = New System.Drawing.Size(49, 27)
        Me.PWDCN.TabIndex = 10
        Me.PWDCN.Text = "No"
        Me.PWDCN.UseVisualStyleBackColor = False
        '
        'CAC
        '
        Me.CAC.AutoSize = True
        Me.CAC.Location = New System.Drawing.Point(483, 31)
        Me.CAC.Name = "CAC"
        Me.CAC.Size = New System.Drawing.Size(139, 15)
        Me.CAC.TabIndex = 11
        Me.CAC.Text = "Current Amount on Card"
        '
        'CA
        '
        Me.CA.Location = New System.Drawing.Point(558, 67)
        Me.CA.Name = "CA"
        Me.CA.Size = New System.Drawing.Size(64, 23)
        Me.CA.TabIndex = 12
        '
        'SCNPR
        '
        Me.SCNPR.AutoSize = True
        Me.SCNPR.BackColor = System.Drawing.Color.DarkBlue
        Me.SCNPR.ForeColor = System.Drawing.Color.Cyan
        Me.SCNPR.Location = New System.Drawing.Point(12, 110)
        Me.SCNPR.Name = "SCNPR"
        Me.SCNPR.Size = New System.Drawing.Size(77, 15)
        Me.SCNPR.TabIndex = 13
        Me.SCNPR.Text = "Scan product"
        '
        'ISCBpr
        '
        Me.ISCBpr.Location = New System.Drawing.Point(97, 107)
        Me.ISCBpr.Name = "ISCBpr"
        Me.ISCBpr.Size = New System.Drawing.Size(94, 23)
        Me.ISCBpr.TabIndex = 14
        '
        'AMT
        '
        Me.AMT.AutoSize = True
        Me.AMT.BackColor = System.Drawing.Color.DarkBlue
        Me.AMT.ForeColor = System.Drawing.Color.Cyan
        Me.AMT.Location = New System.Drawing.Point(207, 110)
        Me.AMT.Name = "AMT"
        Me.AMT.Size = New System.Drawing.Size(51, 15)
        Me.AMT.TabIndex = 15
        Me.AMT.Text = "Amount"
        '
        'IMOU
        '
        Me.IMOU.Location = New System.Drawing.Point(265, 107)
        Me.IMOU.Name = "IMOU"
        Me.IMOU.Size = New System.Drawing.Size(94, 23)
        Me.IMOU.TabIndex = 16
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnNext.ForeColor = System.Drawing.Color.Cyan
        Me.BtnNext.Location = New System.Drawing.Point(391, 104)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(49, 27)
        Me.BtnNext.TabIndex = 17
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'PayNow
        '
        Me.PayNow.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.PayNow.ForeColor = System.Drawing.Color.Cyan
        Me.PayNow.Location = New System.Drawing.Point(558, 107)
        Me.PayNow.Name = "PayNow"
        Me.PayNow.Size = New System.Drawing.Size(63, 27)
        Me.PayNow.TabIndex = 18
        Me.PayNow.Text = "Pay"
        Me.PayNow.UseVisualStyleBackColor = False
        '
        'TTLsls
        '
        Me.TTLsls.AutoSize = True
        Me.TTLsls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TTLsls.Location = New System.Drawing.Point(659, 418)
        Me.TTLsls.Name = "TTLsls"
        Me.TTLsls.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TTLsls.Size = New System.Drawing.Size(89, 21)
        Me.TTLsls.TabIndex = 20
        Me.TTLsls.Text = "Total sales"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnReturn.ForeColor = System.Drawing.Color.Aqua
        Me.BtnReturn.Location = New System.Drawing.Point(634, 445)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(114, 37)
        Me.BtnReturn.TabIndex = 21
        Me.BtnReturn.Text = "Return Main menu"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'Expl1
        '
        Me.Expl1.AutoSize = True
        Me.Expl1.BackColor = System.Drawing.Color.DarkBlue
        Me.Expl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Expl1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Expl1.Location = New System.Drawing.Point(12, 155)
        Me.Expl1.Name = "Expl1"
        Me.Expl1.Size = New System.Drawing.Size(596, 39)
        Me.Expl1.TabIndex = 36
        Me.Expl1.Text = resources.GetString("Expl1.Text")
        '
        'Expl2
        '
        Me.Expl2.AutoSize = True
        Me.Expl2.BackColor = System.Drawing.Color.DarkBlue
        Me.Expl2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Expl2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Expl2.Location = New System.Drawing.Point(628, 95)
        Me.Expl2.Name = "Expl2"
        Me.Expl2.Size = New System.Drawing.Size(125, 91)
        Me.Expl2.TabIndex = 37
        Me.Expl2.Text = "Reminder: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If not Payed with the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dorethy card. Proceed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with scanning barcode" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "D010. The bill will be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "stored marked with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pay Other!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 500)
        Me.Controls.Add(Me.Expl2)
        Me.Controls.Add(Me.Expl1)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.TTLsls)
        Me.Controls.Add(Me.PayNow)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.IMOU)
        Me.Controls.Add(Me.AMT)
        Me.Controls.Add(Me.ISCBpr)
        Me.Controls.Add(Me.SCNPR)
        Me.Controls.Add(Me.CA)
        Me.Controls.Add(Me.CAC)
        Me.Controls.Add(Me.PWDCN)
        Me.Controls.Add(Me.PWDCY)
        Me.Controls.Add(Me.PWDC)
        Me.Controls.Add(Me.S4CL)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.S4LOC)
        Me.Controls.Add(Me.CAMPLOC)
        Me.Controls.Add(Me.DSAL)
        Me.Controls.Add(Me.SalesSlip)
        Me.Name = "Sales"
        Me.Text = "Sales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalesSlip As RichTextBox
    Friend WithEvents DSAL As Label
    Friend WithEvents CAMPLOC As Label
    Friend WithEvents S4LOC As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents S4CL As TextBox
    Friend WithEvents PWDC As Label
    Friend WithEvents PWDCY As Button
    Friend WithEvents PWDCN As Button
    Friend WithEvents CAC As Label
    Friend WithEvents CA As TextBox
    Friend WithEvents SCNPR As Label
    Friend WithEvents ISCBpr As TextBox
    Friend WithEvents AMT As Label
    Friend WithEvents IMOU As TextBox
    Friend WithEvents BtnNext As Button
    Friend WithEvents PayNow As Button
    Friend WithEvents TTLsls As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BtnReturn As Button
    Friend WithEvents Expl1 As Label
    Friend WithEvents Expl2 As Label
End Class
