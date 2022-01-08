<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DRT_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DRT_Login))
        Me.StrtRFIDr = New System.Windows.Forms.Button()
        Me.AddNewUser = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnGetRFID = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RFID_scanned = New System.Windows.Forms.Label()
        Me.Legal = New System.Windows.Forms.RichTextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.EIF = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StrtRFIDr
        '
        Me.StrtRFIDr.Location = New System.Drawing.Point(31, 171)
        Me.StrtRFIDr.Name = "StrtRFIDr"
        Me.StrtRFIDr.Size = New System.Drawing.Size(113, 37)
        Me.StrtRFIDr.TabIndex = 0
        Me.StrtRFIDr.Text = "StartRFIDreader"
        Me.StrtRFIDr.UseVisualStyleBackColor = True
        '
        'AddNewUser
        '
        Me.AddNewUser.BackColor = System.Drawing.Color.Lime
        Me.AddNewUser.FlatAppearance.BorderSize = 0
        Me.AddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewUser.Location = New System.Drawing.Point(749, 388)
        Me.AddNewUser.Name = "AddNewUser"
        Me.AddNewUser.Size = New System.Drawing.Size(13, 34)
        Me.AddNewUser.TabIndex = 2
        Me.AddNewUser.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(391, 67)
        Me.DataGridView1.TabIndex = 4
        '
        'BtnGetRFID
        '
        Me.BtnGetRFID.Location = New System.Drawing.Point(291, 172)
        Me.BtnGetRFID.Name = "BtnGetRFID"
        Me.BtnGetRFID.Size = New System.Drawing.Size(131, 35)
        Me.BtnGetRFID.TabIndex = 6
        Me.BtnGetRFID.Text = "Get scanned RFID"
        Me.BtnGetRFID.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Dorethy login"
        '
        'RFID_scanned
        '
        Me.RFID_scanned.AutoSize = True
        Me.RFID_scanned.Location = New System.Drawing.Point(196, 182)
        Me.RFID_scanned.Name = "RFID_scanned"
        Me.RFID_scanned.Size = New System.Drawing.Size(31, 15)
        Me.RFID_scanned.TabIndex = 8
        Me.RFID_scanned.Text = "RFID"
        Me.RFID_scanned.Visible = False
        '
        'Legal
        '
        Me.Legal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Legal.Location = New System.Drawing.Point(464, 76)
        Me.Legal.Name = "Legal"
        Me.Legal.ReadOnly = True
        Me.Legal.Size = New System.Drawing.Size(285, 294)
        Me.Legal.TabIndex = 9
        Me.Legal.Text = resources.GetString("Legal.Text")
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnExit.ForeColor = System.Drawing.Color.Aqua
        Me.BtnExit.Location = New System.Drawing.Point(464, 384)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(144, 37)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "Exit Dorethy"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'EIF
        '
        Me.EIF.BackColor = System.Drawing.Color.DarkRed
        Me.EIF.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EIF.Location = New System.Drawing.Point(164, 312)
        Me.EIF.Name = "EIF"
        Me.EIF.Size = New System.Drawing.Size(113, 37)
        Me.EIF.TabIndex = 11
        Me.EIF.Text = "Enter INI file"
        Me.EIF.UseVisualStyleBackColor = False
        '
        'DRT_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 434)
        Me.Controls.Add(Me.EIF)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Legal)
        Me.Controls.Add(Me.RFID_scanned)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnGetRFID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AddNewUser)
        Me.Controls.Add(Me.StrtRFIDr)
        Me.Name = "DRT_Login"
        Me.Text = "Dorethy login"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StrtRFIDr As Button
    Friend WithEvents AddNewUser As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnGetRFID As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RFID_scanned As Label
    Friend WithEvents Legal As RichTextBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents EIF As Button
End Class
