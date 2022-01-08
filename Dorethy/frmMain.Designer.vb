<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.cbxReaderList = New System.Windows.Forms.ComboBox()
        Me.btnRefreshReader = New System.Windows.Forms.Button()
        Me.btnStartMonitor = New System.Windows.Forms.Button()
        Me.btnStopMonitor = New System.Windows.Forms.Button()
        Me.txtReadingMode = New System.Windows.Forms.TextBox()
        Me.TxtInputspace = New System.Windows.Forms.TextBox()
        Me.Dorethy_brand = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxReaderList
        '
        Me.cbxReaderList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbxReaderList.FormattingEnabled = True
        Me.cbxReaderList.Location = New System.Drawing.Point(341, 197)
        Me.cbxReaderList.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbxReaderList.Name = "cbxReaderList"
        Me.cbxReaderList.Size = New System.Drawing.Size(76, 26)
        Me.cbxReaderList.TabIndex = 0
        '
        'btnRefreshReader
        '
        Me.btnRefreshReader.Enabled = False
        Me.btnRefreshReader.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefreshReader.Location = New System.Drawing.Point(341, 77)
        Me.btnRefreshReader.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRefreshReader.Name = "btnRefreshReader"
        Me.btnRefreshReader.Size = New System.Drawing.Size(102, 31)
        Me.btnRefreshReader.TabIndex = 2
        Me.btnRefreshReader.Text = "Refresh"
        Me.btnRefreshReader.UseVisualStyleBackColor = True
        Me.btnRefreshReader.Visible = False
        '
        'btnStartMonitor
        '
        Me.btnStartMonitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStartMonitor.Location = New System.Drawing.Point(29, 139)
        Me.btnStartMonitor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStartMonitor.Name = "btnStartMonitor"
        Me.btnStartMonitor.Size = New System.Drawing.Size(139, 84)
        Me.btnStartMonitor.TabIndex = 3
        Me.btnStartMonitor.Text = "Start Reading RFID"
        Me.btnStartMonitor.UseVisualStyleBackColor = True
        '
        'btnStopMonitor
        '
        Me.btnStopMonitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStopMonitor.Location = New System.Drawing.Point(341, 128)
        Me.btnStopMonitor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStopMonitor.Name = "btnStopMonitor"
        Me.btnStopMonitor.Size = New System.Drawing.Size(102, 52)
        Me.btnStopMonitor.TabIndex = 5
        Me.btnStopMonitor.Text = "Save and return"
        Me.btnStopMonitor.UseVisualStyleBackColor = True
        '
        'txtReadingMode
        '
        Me.txtReadingMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtReadingMode.Location = New System.Drawing.Point(419, 197)
        Me.txtReadingMode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtReadingMode.Name = "txtReadingMode"
        Me.txtReadingMode.Size = New System.Drawing.Size(24, 24)
        Me.txtReadingMode.TabIndex = 8
        Me.txtReadingMode.Text = "1"
        '
        'TxtInputspace
        '
        Me.TxtInputspace.Location = New System.Drawing.Point(29, 83)
        Me.TxtInputspace.MaxLength = 8
        Me.TxtInputspace.Name = "TxtInputspace"
        Me.TxtInputspace.Size = New System.Drawing.Size(139, 23)
        Me.TxtInputspace.TabIndex = 9
        '
        'Dorethy_brand
        '
        Me.Dorethy_brand.AutoSize = True
        Me.Dorethy_brand.Font = New System.Drawing.Font("Ink Free", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Dorethy_brand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Dorethy_brand.Location = New System.Drawing.Point(29, 23)
        Me.Dorethy_brand.Name = "Dorethy_brand"
        Me.Dorethy_brand.Size = New System.Drawing.Size(404, 43)
        Me.Dorethy_brand.TabIndex = 10
        Me.Dorethy_brand.Text = "Dorethy RFID interface"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 248)
        Me.Controls.Add(Me.Dorethy_brand)
        Me.Controls.Add(Me.TxtInputspace)
        Me.Controls.Add(Me.txtReadingMode)
        Me.Controls.Add(Me.btnStopMonitor)
        Me.Controls.Add(Me.btnStartMonitor)
        Me.Controls.Add(Me.btnRefreshReader)
        Me.Controls.Add(Me.cbxReaderList)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmMain"
        Me.Text = "Dorethy Payment console"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxReaderList As ComboBox
    Friend WithEvents btnRefreshReader As Button
    Friend WithEvents btnStopMonitor As Button
    Friend WithEvents txtReadingMode As TextBox
    Friend WithEvents btnStartMonitor As Button
    Friend WithEvents TxtInputspace As TextBox
    Friend WithEvents Dorethy_brand As Label
End Class
