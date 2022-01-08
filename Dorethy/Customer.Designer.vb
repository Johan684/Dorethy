<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.ID_FS = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Dcity = New System.Windows.Forms.Label()
        Me.DPC = New System.Windows.Forms.Label()
        Me.DADD = New System.Windows.Forms.Label()
        Me.DNM = New System.Windows.Forms.Label()
        Me.City2DB = New System.Windows.Forms.TextBox()
        Me.PostalC2DB = New System.Windows.Forms.TextBox()
        Me.Address2DB = New System.Windows.Forms.TextBox()
        Me.Name2DB = New System.Windows.Forms.TextBox()
        Me.DCUS = New System.Windows.Forms.Label()
        Me.PHONE2DB = New System.Windows.Forms.TextBox()
        Me.NFC2DB = New System.Windows.Forms.TextBox()
        Me.DPHN = New System.Windows.Forms.Label()
        Me.DNFC = New System.Windows.Forms.Label()
        Me.DCLoc = New System.Windows.Forms.Label()
        Me.DLeft = New System.Windows.Forms.Label()
        Me.BtnScanCrd = New System.Windows.Forms.Button()
        Me.BtnGetCardData = New System.Windows.Forms.Button()
        Me.CLOC2DB = New System.Windows.Forms.ListBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.InfoScan = New System.Windows.Forms.TextBox()
        Me.LBleft = New System.Windows.Forms.CheckedListBox()
        Me.InfoHTC = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_FS
        '
        Me.ID_FS.AutoSize = True
        Me.ID_FS.ForeColor = System.Drawing.Color.Red
        Me.ID_FS.Location = New System.Drawing.Point(493, 382)
        Me.ID_FS.Name = "ID_FS"
        Me.ID_FS.Size = New System.Drawing.Size(0, 15)
        Me.ID_FS.TabIndex = 28
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnEdit.ForeColor = System.Drawing.Color.Cyan
        Me.BtnEdit.Location = New System.Drawing.Point(12, 401)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(121, 37)
        Me.BtnEdit.TabIndex = 27
        Me.BtnEdit.Text = "Edit Customer"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnReturn.ForeColor = System.Drawing.Color.Aqua
        Me.BtnReturn.Location = New System.Drawing.Point(611, 243)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(144, 37)
        Me.BtnReturn.TabIndex = 26
        Me.BtnReturn.Text = "Return Main menu"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnAdd.ForeColor = System.Drawing.Color.Cyan
        Me.BtnAdd.Location = New System.Drawing.Point(12, 243)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(121, 37)
        Me.BtnAdd.TabIndex = 25
        Me.BtnAdd.Text = "Add new customer"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 315)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(743, 64)
        Me.DataGridView1.TabIndex = 24
        '
        'Dcity
        '
        Me.Dcity.AutoSize = True
        Me.Dcity.Location = New System.Drawing.Point(575, 77)
        Me.Dcity.Name = "Dcity"
        Me.Dcity.Size = New System.Drawing.Size(28, 15)
        Me.Dcity.TabIndex = 23
        Me.Dcity.Text = "City"
        '
        'DPC
        '
        Me.DPC.AutoSize = True
        Me.DPC.Location = New System.Drawing.Point(479, 77)
        Me.DPC.Name = "DPC"
        Me.DPC.Size = New System.Drawing.Size(68, 15)
        Me.DPC.TabIndex = 22
        Me.DPC.Text = "Postal code"
        '
        'DADD
        '
        Me.DADD.AutoSize = True
        Me.DADD.Location = New System.Drawing.Point(223, 77)
        Me.DADD.Name = "DADD"
        Me.DADD.Size = New System.Drawing.Size(49, 15)
        Me.DADD.TabIndex = 21
        Me.DADD.Text = "Address"
        '
        'DNM
        '
        Me.DNM.AutoSize = True
        Me.DNM.Location = New System.Drawing.Point(12, 77)
        Me.DNM.Name = "DNM"
        Me.DNM.Size = New System.Drawing.Size(39, 15)
        Me.DNM.TabIndex = 20
        Me.DNM.Text = "Name"
        '
        'City2DB
        '
        Me.City2DB.Location = New System.Drawing.Point(575, 105)
        Me.City2DB.Name = "City2DB"
        Me.City2DB.Size = New System.Drawing.Size(169, 23)
        Me.City2DB.TabIndex = 19
        '
        'PostalC2DB
        '
        Me.PostalC2DB.Location = New System.Drawing.Point(479, 105)
        Me.PostalC2DB.Name = "PostalC2DB"
        Me.PostalC2DB.Size = New System.Drawing.Size(68, 23)
        Me.PostalC2DB.TabIndex = 18
        '
        'Address2DB
        '
        Me.Address2DB.Location = New System.Drawing.Point(223, 105)
        Me.Address2DB.Name = "Address2DB"
        Me.Address2DB.Size = New System.Drawing.Size(226, 23)
        Me.Address2DB.TabIndex = 17
        '
        'Name2DB
        '
        Me.Name2DB.Location = New System.Drawing.Point(12, 105)
        Me.Name2DB.Name = "Name2DB"
        Me.Name2DB.Size = New System.Drawing.Size(180, 23)
        Me.Name2DB.TabIndex = 16
        '
        'DCUS
        '
        Me.DCUS.AutoSize = True
        Me.DCUS.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DCUS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DCUS.Location = New System.Drawing.Point(12, 31)
        Me.DCUS.Name = "DCUS"
        Me.DCUS.Size = New System.Drawing.Size(168, 23)
        Me.DCUS.TabIndex = 15
        Me.DCUS.Text = "Dorethy customer"
        '
        'PHONE2DB
        '
        Me.PHONE2DB.Location = New System.Drawing.Point(12, 194)
        Me.PHONE2DB.Name = "PHONE2DB"
        Me.PHONE2DB.Size = New System.Drawing.Size(180, 23)
        Me.PHONE2DB.TabIndex = 29
        '
        'NFC2DB
        '
        Me.NFC2DB.Location = New System.Drawing.Point(223, 194)
        Me.NFC2DB.Name = "NFC2DB"
        Me.NFC2DB.Size = New System.Drawing.Size(169, 23)
        Me.NFC2DB.TabIndex = 30
        '
        'DPHN
        '
        Me.DPHN.AutoSize = True
        Me.DPHN.Location = New System.Drawing.Point(12, 165)
        Me.DPHN.Name = "DPHN"
        Me.DPHN.Size = New System.Drawing.Size(86, 15)
        Me.DPHN.TabIndex = 33
        Me.DPHN.Text = "Phone number"
        '
        'DNFC
        '
        Me.DNFC.AutoSize = True
        Me.DNFC.Location = New System.Drawing.Point(223, 165)
        Me.DNFC.Name = "DNFC"
        Me.DNFC.Size = New System.Drawing.Size(30, 15)
        Me.DNFC.TabIndex = 34
        Me.DNFC.Text = "NFC"
        '
        'DCLoc
        '
        Me.DCLoc.AutoSize = True
        Me.DCLoc.Location = New System.Drawing.Point(407, 165)
        Me.DCLoc.Name = "DCLoc"
        Me.DCLoc.Size = New System.Drawing.Size(146, 15)
        Me.DCLoc.TabIndex = 35
        Me.DCLoc.Text = "Location on camping field"
        '
        'DLeft
        '
        Me.DLeft.AutoSize = True
        Me.DLeft.Location = New System.Drawing.Point(582, 165)
        Me.DLeft.Name = "DLeft"
        Me.DLeft.Size = New System.Drawing.Size(52, 15)
        Me.DLeft.TabIndex = 36
        Me.DLeft.Text = "Has left?"
        '
        'BtnScanCrd
        '
        Me.BtnScanCrd.BackColor = System.Drawing.Color.Maroon
        Me.BtnScanCrd.ForeColor = System.Drawing.Color.Cyan
        Me.BtnScanCrd.Location = New System.Drawing.Point(223, 243)
        Me.BtnScanCrd.Name = "BtnScanCrd"
        Me.BtnScanCrd.Size = New System.Drawing.Size(96, 37)
        Me.BtnScanCrd.TabIndex = 37
        Me.BtnScanCrd.Text = "Scan new card"
        Me.BtnScanCrd.UseVisualStyleBackColor = False
        '
        'BtnGetCardData
        '
        Me.BtnGetCardData.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnGetCardData.ForeColor = System.Drawing.Color.Cyan
        Me.BtnGetCardData.Location = New System.Drawing.Point(325, 243)
        Me.BtnGetCardData.Name = "BtnGetCardData"
        Me.BtnGetCardData.Size = New System.Drawing.Size(96, 37)
        Me.BtnGetCardData.TabIndex = 38
        Me.BtnGetCardData.Text = "Get card data"
        Me.BtnGetCardData.UseVisualStyleBackColor = False
        '
        'CLOC2DB
        '
        Me.CLOC2DB.FormattingEnabled = True
        Me.CLOC2DB.ItemHeight = 15
        Me.CLOC2DB.Items.AddRange(New Object() {"", "10", "11", "12", "13", "14", "15", "20", "21", "22", "23", "24", "25", "30", "31", "32", "33", "34", "35", "40", "41", "42", "42", "44", "45"})
        Me.CLOC2DB.Location = New System.Drawing.Point(410, 193)
        Me.CLOC2DB.Name = "CLOC2DB"
        Me.CLOC2DB.Size = New System.Drawing.Size(49, 34)
        Me.CLOC2DB.TabIndex = 42
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(465, 193)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 43
        Me.RichTextBox1.Text = "10+ Small tents" & Global.Microsoft.VisualBasic.ChrW(10) & "20+ Large tents" & Global.Microsoft.VisualBasic.ChrW(10) & "30+ Caravans" & Global.Microsoft.VisualBasic.ChrW(10) & "40+ Campers"
        '
        'InfoScan
        '
        Me.InfoScan.BackColor = System.Drawing.Color.Yellow
        Me.InfoScan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InfoScan.Location = New System.Drawing.Point(223, 286)
        Me.InfoScan.Name = "InfoScan"
        Me.InfoScan.Size = New System.Drawing.Size(198, 23)
        Me.InfoScan.TabIndex = 44
        Me.InfoScan.Text = "SCAN YOUR CARD FIRST!"
        Me.InfoScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBleft
        '
        Me.LBleft.FormattingEnabled = True
        Me.LBleft.Items.AddRange(New Object() {"Has arrived", "Has left"})
        Me.LBleft.Location = New System.Drawing.Point(582, 187)
        Me.LBleft.Name = "LBleft"
        Me.LBleft.Size = New System.Drawing.Size(86, 40)
        Me.LBleft.TabIndex = 45
        '
        'InfoHTC
        '
        Me.InfoHTC.AutoSize = True
        Me.InfoHTC.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.InfoHTC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InfoHTC.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.InfoHTC.Location = New System.Drawing.Point(151, 412)
        Me.InfoHTC.Name = "InfoHTC"
        Me.InfoHTC.Size = New System.Drawing.Size(517, 15)
        Me.InfoHTC.TabIndex = 46
        Me.InfoHTC.Text = "If you need to change data. Changes must bedone in the Grid. Save with Add new Cu" &
    "stomer."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(669, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(669, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 15)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "0"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InfoHTC)
        Me.Controls.Add(Me.LBleft)
        Me.Controls.Add(Me.InfoScan)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CLOC2DB)
        Me.Controls.Add(Me.BtnGetCardData)
        Me.Controls.Add(Me.BtnScanCrd)
        Me.Controls.Add(Me.DLeft)
        Me.Controls.Add(Me.DCLoc)
        Me.Controls.Add(Me.DNFC)
        Me.Controls.Add(Me.DPHN)
        Me.Controls.Add(Me.NFC2DB)
        Me.Controls.Add(Me.PHONE2DB)
        Me.Controls.Add(Me.ID_FS)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Dcity)
        Me.Controls.Add(Me.DPC)
        Me.Controls.Add(Me.DADD)
        Me.Controls.Add(Me.DNM)
        Me.Controls.Add(Me.City2DB)
        Me.Controls.Add(Me.PostalC2DB)
        Me.Controls.Add(Me.Address2DB)
        Me.Controls.Add(Me.Name2DB)
        Me.Controls.Add(Me.DCUS)
        Me.Name = "Customer"
        Me.Text = "Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ID_FS As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnReturn As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Dcity As Label
    Friend WithEvents DPC As Label
    Friend WithEvents DADD As Label
    Friend WithEvents DNM As Label
    Friend WithEvents City2DB As TextBox
    Friend WithEvents PostalC2DB As TextBox
    Friend WithEvents Address2DB As TextBox
    Friend WithEvents Name2DB As TextBox
    Friend WithEvents DCUS As Label
    Friend WithEvents PHONE2DB As TextBox
    Friend WithEvents NFC2DB As TextBox
    Friend WithEvents DPHN As Label
    Friend WithEvents DNFC As Label
    Friend WithEvents DCLoc As Label
    Friend WithEvents DLeft As Label
    Friend WithEvents BtnScanCrd As Button
    Friend WithEvents BtnGetCardData As Button
    Friend WithEvents CLOC2DB As ListBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents InfoScan As TextBox
    Friend WithEvents LBleft As CheckedListBox
    Friend WithEvents InfoHTC As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
