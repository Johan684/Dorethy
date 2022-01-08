<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.NpgsqlCommand1 = New Npgsql.NpgsqlCommand()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnShow = New System.Windows.Forms.Button()
        Me.LBTable = New System.Windows.Forms.ListBox()
        Me.BtnReturn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NpgsqlCommand1
        '
        Me.NpgsqlCommand1.AllResultTypesAreUnknown = False
        Me.NpgsqlCommand1.Transaction = Nothing
        Me.NpgsqlCommand1.UnknownResultTypeList = Nothing
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 140)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(776, 298)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnShow
        '
        Me.BtnShow.Location = New System.Drawing.Point(644, 27)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(144, 32)
        Me.BtnShow.TabIndex = 1
        Me.BtnShow.Text = "Show data"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'LBTable
        '
        Me.LBTable.FormattingEnabled = True
        Me.LBTable.ItemHeight = 15
        Me.LBTable.Items.AddRange(New Object() {"", "Customer", "Sales Today", "Products"})
        Me.LBTable.Location = New System.Drawing.Point(412, 12)
        Me.LBTable.Name = "LBTable"
        Me.LBTable.Size = New System.Drawing.Size(191, 49)
        Me.LBTable.TabIndex = 2
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnReturn.ForeColor = System.Drawing.Color.Aqua
        Me.BtnReturn.Location = New System.Drawing.Point(644, 86)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(144, 37)
        Me.BtnReturn.TabIndex = 27
        Me.BtnReturn.Text = "Return Main menu"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.LBTable)
        Me.Controls.Add(Me.BtnShow)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NpgsqlCommand1 As Npgsql.NpgsqlCommand
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnShow As Button
    Friend WithEvents LBTable As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BtnReturn As Button
End Class
