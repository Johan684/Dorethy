<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewUser
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
        Me.DANU = New System.Windows.Forms.Label()
        Me.ScanNewRFID = New System.Windows.Forms.Button()
        Me.GetscannedRFID = New System.Windows.Forms.Button()
        Me.UsrNM = New System.Windows.Forms.Label()
        Me.Authorisation = New System.Windows.Forms.Label()
        Me.KeyID = New System.Windows.Forms.Label()
        Me.ID_FS = New System.Windows.Forms.Label()
        Me.Name2DB = New System.Windows.Forms.TextBox()
        Me.Auth2DB = New System.Windows.Forms.TextBox()
        Me.Save2DB = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SRM = New System.Windows.Forms.Button()
        Me.SNI = New System.Windows.Forms.Button()
        Me.EDT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Expl1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DANU
        '
        Me.DANU.AutoSize = True
        Me.DANU.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DANU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DANU.Location = New System.Drawing.Point(26, 44)
        Me.DANU.Name = "DANU"
        Me.DANU.Size = New System.Drawing.Size(213, 23)
        Me.DANU.TabIndex = 0
        Me.DANU.Text = "Dorethy Add New User"
        '
        'ScanNewRFID
        '
        Me.ScanNewRFID.Location = New System.Drawing.Point(26, 97)
        Me.ScanNewRFID.Name = "ScanNewRFID"
        Me.ScanNewRFID.Size = New System.Drawing.Size(146, 27)
        Me.ScanNewRFID.TabIndex = 1
        Me.ScanNewRFID.Text = "Scan new RFID key"
        Me.ScanNewRFID.UseVisualStyleBackColor = True
        '
        'GetscannedRFID
        '
        Me.GetscannedRFID.Location = New System.Drawing.Point(26, 149)
        Me.GetscannedRFID.Name = "GetscannedRFID"
        Me.GetscannedRFID.Size = New System.Drawing.Size(146, 27)
        Me.GetscannedRFID.TabIndex = 2
        Me.GetscannedRFID.Text = "Get scanned RFID"
        Me.GetscannedRFID.UseVisualStyleBackColor = True
        '
        'UsrNM
        '
        Me.UsrNM.AutoSize = True
        Me.UsrNM.Location = New System.Drawing.Point(376, 97)
        Me.UsrNM.Name = "UsrNM"
        Me.UsrNM.Size = New System.Drawing.Size(66, 15)
        Me.UsrNM.TabIndex = 3
        Me.UsrNM.Text = "User name:"
        '
        'Authorisation
        '
        Me.Authorisation.AutoSize = True
        Me.Authorisation.Location = New System.Drawing.Point(376, 161)
        Me.Authorisation.Name = "Authorisation"
        Me.Authorisation.Size = New System.Drawing.Size(82, 15)
        Me.Authorisation.TabIndex = 4
        Me.Authorisation.Text = "Authorisation:"
        '
        'KeyID
        '
        Me.KeyID.AutoSize = True
        Me.KeyID.Location = New System.Drawing.Point(376, 130)
        Me.KeyID.Name = "KeyID"
        Me.KeyID.Size = New System.Drawing.Size(29, 15)
        Me.KeyID.TabIndex = 5
        Me.KeyID.Text = "Key:"
        '
        'ID_FS
        '
        Me.ID_FS.AutoSize = True
        Me.ID_FS.Location = New System.Drawing.Point(505, 130)
        Me.ID_FS.Name = "ID_FS"
        Me.ID_FS.Size = New System.Drawing.Size(41, 15)
        Me.ID_FS.TabIndex = 6
        Me.ID_FS.Text = "Label1"
        '
        'Name2DB
        '
        Me.Name2DB.Location = New System.Drawing.Point(503, 94)
        Me.Name2DB.Name = "Name2DB"
        Me.Name2DB.Size = New System.Drawing.Size(176, 23)
        Me.Name2DB.TabIndex = 7
        '
        'Auth2DB
        '
        Me.Auth2DB.AutoCompleteCustomSource.AddRange(New String() {"0", "1", "2"})
        Me.Auth2DB.Location = New System.Drawing.Point(503, 158)
        Me.Auth2DB.MaxLength = 1
        Me.Auth2DB.Name = "Auth2DB"
        Me.Auth2DB.Size = New System.Drawing.Size(23, 23)
        Me.Auth2DB.TabIndex = 8
        Me.Auth2DB.Text = "1"
        '
        'Save2DB
        '
        Me.Save2DB.Location = New System.Drawing.Point(581, 204)
        Me.Save2DB.Name = "Save2DB"
        Me.Save2DB.Size = New System.Drawing.Size(97, 28)
        Me.Save2DB.TabIndex = 9
        Me.Save2DB.Text = "Save to DBase"
        Me.Save2DB.UseVisualStyleBackColor = True
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnReturn.ForeColor = System.Drawing.Color.Aqua
        Me.BtnReturn.Location = New System.Drawing.Point(535, 252)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(144, 37)
        Me.BtnReturn.TabIndex = 11
        Me.BtnReturn.Text = "Return Main menu"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(652, 71)
        Me.DataGridView1.TabIndex = 12
        '
        'SRM
        '
        Me.SRM.BackColor = System.Drawing.Color.Crimson
        Me.SRM.ForeColor = System.Drawing.Color.Aqua
        Me.SRM.Location = New System.Drawing.Point(26, 390)
        Me.SRM.Name = "SRM"
        Me.SRM.Size = New System.Drawing.Size(144, 37)
        Me.SRM.TabIndex = 13
        Me.SRM.Text = "Skip return Main menu"
        Me.SRM.UseVisualStyleBackColor = False
        '
        'SNI
        '
        Me.SNI.BackColor = System.Drawing.Color.RoyalBlue
        Me.SNI.ForeColor = System.Drawing.Color.Aqua
        Me.SNI.Location = New System.Drawing.Point(534, 390)
        Me.SNI.Name = "SNI"
        Me.SNI.Size = New System.Drawing.Size(144, 37)
        Me.SNI.TabIndex = 14
        Me.SNI.Text = "Scan new Key"
        Me.SNI.UseVisualStyleBackColor = False
        '
        'EDT
        '
        Me.EDT.BackColor = System.Drawing.Color.DarkGreen
        Me.EDT.ForeColor = System.Drawing.Color.Aqua
        Me.EDT.Location = New System.Drawing.Point(279, 390)
        Me.EDT.Name = "EDT"
        Me.EDT.Size = New System.Drawing.Size(144, 37)
        Me.EDT.TabIndex = 15
        Me.EDT.Text = "Edit above data"
        Me.EDT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(535, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "1= Limited <>1 Full access"
        '
        'Expl1
        '
        Me.Expl1.AutoSize = True
        Me.Expl1.BackColor = System.Drawing.Color.DarkBlue
        Me.Expl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Expl1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Expl1.Location = New System.Drawing.Point(26, 188)
        Me.Expl1.Name = "Expl1"
        Me.Expl1.Size = New System.Drawing.Size(106, 91)
        Me.Expl1.TabIndex = 38
        Me.Expl1.Text = "Reminder: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Editing user data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "needs to be done" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in the Grid below!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Otherwise ch" &
    "anges" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are not stored in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the database." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AddNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Expl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EDT)
        Me.Controls.Add(Me.SNI)
        Me.Controls.Add(Me.SRM)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.Save2DB)
        Me.Controls.Add(Me.Auth2DB)
        Me.Controls.Add(Me.Name2DB)
        Me.Controls.Add(Me.ID_FS)
        Me.Controls.Add(Me.KeyID)
        Me.Controls.Add(Me.Authorisation)
        Me.Controls.Add(Me.UsrNM)
        Me.Controls.Add(Me.GetscannedRFID)
        Me.Controls.Add(Me.ScanNewRFID)
        Me.Controls.Add(Me.DANU)
        Me.Name = "AddNewUser"
        Me.Text = "AddNewUser"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DANU As Label
    Friend WithEvents ScanNewRFID As Button
    Friend WithEvents GetscannedRFID As Button
    Friend WithEvents UsrNM As Label
    Friend WithEvents Authorisation As Label
    Friend WithEvents KeyID As Label
    Friend WithEvents ID_FS As Label
    Friend WithEvents Name2DB As TextBox
    Friend WithEvents Auth2DB As TextBox
    Friend WithEvents Save2DB As Button
    Friend WithEvents BtnReturn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SRM As Button
    Friend WithEvents SNI As Button
    Friend WithEvents EDT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Expl1 As Label
End Class
