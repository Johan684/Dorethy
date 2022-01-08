<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.DorethyMenu = New System.Windows.Forms.Label()
        Me.Usrnm = New System.Windows.Forms.Label()
        Me.DB_user = New System.Windows.Forms.Label()
        Me.AuthC = New System.Windows.Forms.Label()
        Me.Auth_C = New System.Windows.Forms.Label()
        Me.BtnCust = New System.Windows.Forms.Button()
        Me.BtnChkO = New System.Windows.Forms.Button()
        Me.BtnProducts = New System.Windows.Forms.Button()
        Me.BtnSales = New System.Windows.Forms.Button()
        Me.BtbPO = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DorethyMenu
        '
        Me.DorethyMenu.AutoSize = True
        Me.DorethyMenu.Font = New System.Drawing.Font("Ink Free", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DorethyMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DorethyMenu.Location = New System.Drawing.Point(24, 35)
        Me.DorethyMenu.Name = "DorethyMenu"
        Me.DorethyMenu.Size = New System.Drawing.Size(133, 23)
        Me.DorethyMenu.TabIndex = 0
        Me.DorethyMenu.Text = "Dorethy menu"
        '
        'Usrnm
        '
        Me.Usrnm.AutoSize = True
        Me.Usrnm.Location = New System.Drawing.Point(24, 95)
        Me.Usrnm.Name = "Usrnm"
        Me.Usrnm.Size = New System.Drawing.Size(72, 15)
        Me.Usrnm.TabIndex = 1
        Me.Usrnm.Text = "User name:  "
        '
        'DB_user
        '
        Me.DB_user.AutoSize = True
        Me.DB_user.Location = New System.Drawing.Point(116, 95)
        Me.DB_user.Name = "DB_user"
        Me.DB_user.Size = New System.Drawing.Size(0, 15)
        Me.DB_user.TabIndex = 2
        '
        'AuthC
        '
        Me.AuthC.AutoSize = True
        Me.AuthC.Location = New System.Drawing.Point(24, 125)
        Me.AuthC.Name = "AuthC"
        Me.AuthC.Size = New System.Drawing.Size(65, 15)
        Me.AuthC.TabIndex = 3
        Me.AuthC.Text = "Auth code:"
        '
        'Auth_C
        '
        Me.Auth_C.AutoSize = True
        Me.Auth_C.Location = New System.Drawing.Point(116, 125)
        Me.Auth_C.Name = "Auth_C"
        Me.Auth_C.Size = New System.Drawing.Size(0, 15)
        Me.Auth_C.TabIndex = 4
        '
        'BtnCust
        '
        Me.BtnCust.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnCust.ForeColor = System.Drawing.Color.Cyan
        Me.BtnCust.Location = New System.Drawing.Point(28, 179)
        Me.BtnCust.Name = "BtnCust"
        Me.BtnCust.Size = New System.Drawing.Size(129, 65)
        Me.BtnCust.TabIndex = 5
        Me.BtnCust.Text = "Customer"
        Me.BtnCust.UseVisualStyleBackColor = False
        '
        'BtnChkO
        '
        Me.BtnChkO.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnChkO.ForeColor = System.Drawing.Color.Cyan
        Me.BtnChkO.Location = New System.Drawing.Point(333, 179)
        Me.BtnChkO.Name = "BtnChkO"
        Me.BtnChkO.Size = New System.Drawing.Size(129, 65)
        Me.BtnChkO.TabIndex = 6
        Me.BtnChkO.Text = "Check out"
        Me.BtnChkO.UseVisualStyleBackColor = False
        '
        'BtnProducts
        '
        Me.BtnProducts.BackColor = System.Drawing.Color.Navy
        Me.BtnProducts.ForeColor = System.Drawing.Color.Cyan
        Me.BtnProducts.Location = New System.Drawing.Point(634, 179)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Size = New System.Drawing.Size(129, 65)
        Me.BtnProducts.TabIndex = 7
        Me.BtnProducts.Text = "Products"
        Me.BtnProducts.UseVisualStyleBackColor = False
        '
        'BtnSales
        '
        Me.BtnSales.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSales.ForeColor = System.Drawing.Color.Cyan
        Me.BtnSales.Location = New System.Drawing.Point(28, 290)
        Me.BtnSales.Name = "BtnSales"
        Me.BtnSales.Size = New System.Drawing.Size(129, 65)
        Me.BtnSales.TabIndex = 8
        Me.BtnSales.Text = "Sales"
        Me.BtnSales.UseVisualStyleBackColor = False
        '
        'BtbPO
        '
        Me.BtbPO.BackColor = System.Drawing.Color.DarkBlue
        Me.BtbPO.ForeColor = System.Drawing.Color.Cyan
        Me.BtbPO.Location = New System.Drawing.Point(333, 290)
        Me.BtbPO.Name = "BtbPO"
        Me.BtbPO.Size = New System.Drawing.Size(129, 65)
        Me.BtbPO.TabIndex = 9
        Me.BtbPO.Text = "Print only"
        Me.BtbPO.UseVisualStyleBackColor = False
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnReturn.ForeColor = System.Drawing.Color.Cyan
        Me.BtnReturn.Location = New System.Drawing.Point(634, 290)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(129, 65)
        Me.BtnReturn.TabIndex = 10
        Me.BtnReturn.Text = "Return to login"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtbPO)
        Me.Controls.Add(Me.BtnSales)
        Me.Controls.Add(Me.BtnProducts)
        Me.Controls.Add(Me.BtnChkO)
        Me.Controls.Add(Me.BtnCust)
        Me.Controls.Add(Me.Auth_C)
        Me.Controls.Add(Me.AuthC)
        Me.Controls.Add(Me.DB_user)
        Me.Controls.Add(Me.Usrnm)
        Me.Controls.Add(Me.DorethyMenu)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DorethyMenu As Label
    Friend WithEvents Usrnm As Label
    Friend WithEvents DB_user As Label
    Friend WithEvents AuthC As Label
    Friend WithEvents Auth_C As Label
    Friend WithEvents BtnCust As Button
    Friend WithEvents BtnChkO As Button
    Friend WithEvents BtnProducts As Button
    Friend WithEvents BtnSales As Button
    Friend WithEvents BtbPO As Button
    Friend WithEvents BtnReturn As Button
End Class
