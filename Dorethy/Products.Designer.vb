<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.DPR = New System.Windows.Forms.Label()
        Me.EAN2DB = New System.Windows.Forms.TextBox()
        Me.Name2DB = New System.Windows.Forms.TextBox()
        Me.NETPR2DB = New System.Windows.Forms.TextBox()
        Me.SALESPR2DB = New System.Windows.Forms.TextBox()
        Me.DEAN = New System.Windows.Forms.Label()
        Me.DNAME = New System.Windows.Forms.Label()
        Me.DNET = New System.Windows.Forms.Label()
        Me.Dsales = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.ID_FS = New System.Windows.Forms.Label()
        Me.IF_SWN = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DPR
        '
        Me.DPR.AutoSize = True
        Me.DPR.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DPR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DPR.Location = New System.Drawing.Point(12, 39)
        Me.DPR.Name = "DPR"
        Me.DPR.Size = New System.Drawing.Size(164, 23)
        Me.DPR.TabIndex = 0
        Me.DPR.Text = "Dorethy products"
        '
        'EAN2DB
        '
        Me.EAN2DB.Location = New System.Drawing.Point(12, 113)
        Me.EAN2DB.Name = "EAN2DB"
        Me.EAN2DB.Size = New System.Drawing.Size(121, 23)
        Me.EAN2DB.TabIndex = 1
        '
        'Name2DB
        '
        Me.Name2DB.Location = New System.Drawing.Point(160, 113)
        Me.Name2DB.Name = "Name2DB"
        Me.Name2DB.Size = New System.Drawing.Size(289, 23)
        Me.Name2DB.TabIndex = 2
        '
        'NETPR2DB
        '
        Me.NETPR2DB.Location = New System.Drawing.Point(479, 113)
        Me.NETPR2DB.Name = "NETPR2DB"
        Me.NETPR2DB.Size = New System.Drawing.Size(121, 23)
        Me.NETPR2DB.TabIndex = 3
        '
        'SALESPR2DB
        '
        Me.SALESPR2DB.Location = New System.Drawing.Point(634, 113)
        Me.SALESPR2DB.Name = "SALESPR2DB"
        Me.SALESPR2DB.Size = New System.Drawing.Size(121, 23)
        Me.SALESPR2DB.TabIndex = 4
        '
        'DEAN
        '
        Me.DEAN.AutoSize = True
        Me.DEAN.Location = New System.Drawing.Point(12, 85)
        Me.DEAN.Name = "DEAN"
        Me.DEAN.Size = New System.Drawing.Size(30, 15)
        Me.DEAN.TabIndex = 5
        Me.DEAN.Text = "EAN"
        '
        'DNAME
        '
        Me.DNAME.AutoSize = True
        Me.DNAME.Location = New System.Drawing.Point(160, 85)
        Me.DNAME.Name = "DNAME"
        Me.DNAME.Size = New System.Drawing.Size(98, 15)
        Me.DNAME.TabIndex = 6
        Me.DNAME.Text = "Name of product"
        '
        'DNET
        '
        Me.DNET.AutoSize = True
        Me.DNET.Location = New System.Drawing.Point(479, 85)
        Me.DNET.Name = "DNET"
        Me.DNET.Size = New System.Drawing.Size(55, 15)
        Me.DNET.TabIndex = 7
        Me.DNET.Text = "Net price"
        '
        'Dsales
        '
        Me.Dsales.AutoSize = True
        Me.Dsales.Location = New System.Drawing.Point(634, 85)
        Me.Dsales.Name = "Dsales"
        Me.Dsales.Size = New System.Drawing.Size(62, 15)
        Me.Dsales.TabIndex = 8
        Me.Dsales.Text = "Sales price"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 216)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(743, 165)
        Me.DataGridView1.TabIndex = 9
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnAdd.ForeColor = System.Drawing.Color.Cyan
        Me.BtnAdd.Location = New System.Drawing.Point(12, 153)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(121, 37)
        Me.BtnAdd.TabIndex = 10
        Me.BtnAdd.Text = "Add new product"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnReturn.ForeColor = System.Drawing.Color.Aqua
        Me.BtnReturn.Location = New System.Drawing.Point(611, 153)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(144, 37)
        Me.BtnReturn.TabIndex = 12
        Me.BtnReturn.Text = "Return Main menu"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnEdit.ForeColor = System.Drawing.Color.Cyan
        Me.BtnEdit.Location = New System.Drawing.Point(12, 401)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(121, 37)
        Me.BtnEdit.TabIndex = 13
        Me.BtnEdit.Text = "Edit product"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'ID_FS
        '
        Me.ID_FS.AutoSize = True
        Me.ID_FS.ForeColor = System.Drawing.Color.Red
        Me.ID_FS.Location = New System.Drawing.Point(493, 292)
        Me.ID_FS.Name = "ID_FS"
        Me.ID_FS.Size = New System.Drawing.Size(0, 15)
        Me.ID_FS.TabIndex = 14
        '
        'IF_SWN
        '
        Me.IF_SWN.AutoSize = True
        Me.IF_SWN.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.IF_SWN.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IF_SWN.Location = New System.Drawing.Point(329, 393)
        Me.IF_SWN.Name = "IF_SWN"
        Me.IF_SWN.Size = New System.Drawing.Size(426, 45)
        Me.IF_SWN.TabIndex = 15
        Me.IF_SWN.Text = resources.GetString("IF_SWN.Text")
        Me.IF_SWN.UseWaitCursor = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.IF_SWN)
        Me.Controls.Add(Me.ID_FS)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Dsales)
        Me.Controls.Add(Me.DNET)
        Me.Controls.Add(Me.DNAME)
        Me.Controls.Add(Me.DEAN)
        Me.Controls.Add(Me.SALESPR2DB)
        Me.Controls.Add(Me.NETPR2DB)
        Me.Controls.Add(Me.Name2DB)
        Me.Controls.Add(Me.EAN2DB)
        Me.Controls.Add(Me.DPR)
        Me.Name = "Products"
        Me.Text = "Products"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DPR As Label
    Friend WithEvents EAN2DB As TextBox
    Friend WithEvents Name2DB As TextBox
    Friend WithEvents NETPR2DB As TextBox
    Friend WithEvents SALESPR2DB As TextBox
    Friend WithEvents DEAN As Label
    Friend WithEvents DNAME As Label
    Friend WithEvents DNET As Label
    Friend WithEvents Dsales As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnReturn As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents ID_FS As Label
    Friend WithEvents IF_SWN As Label
End Class
