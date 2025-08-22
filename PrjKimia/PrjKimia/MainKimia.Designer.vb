<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainKimia
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfChemicalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfChemicalInSerialCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToUseChemicalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UtilitiesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(827, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfChemicalToolStripMenuItem, Me.ListOfChemicalInSerialCodeToolStripMenuItem, Me.ToUseChemicalToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ListOfChemicalToolStripMenuItem
        '
        Me.ListOfChemicalToolStripMenuItem.Name = "ListOfChemicalToolStripMenuItem"
        Me.ListOfChemicalToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ListOfChemicalToolStripMenuItem.Text = "List of Chemical"
        '
        'ListOfChemicalInSerialCodeToolStripMenuItem
        '
        Me.ListOfChemicalInSerialCodeToolStripMenuItem.Name = "ListOfChemicalInSerialCodeToolStripMenuItem"
        Me.ListOfChemicalInSerialCodeToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ListOfChemicalInSerialCodeToolStripMenuItem.Text = "List of Chemical in Serial Code"
        '
        'UtilitiesToolStripMenuItem
        '
        Me.UtilitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.UtilitiesToolStripMenuItem.Name = "UtilitiesToolStripMenuItem"
        Me.UtilitiesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.UtilitiesToolStripMenuItem.Text = "Utilities"
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.UploadToolStripMenuItem.Text = "Upload"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'ToUseChemicalToolStripMenuItem
        '
        Me.ToUseChemicalToolStripMenuItem.Name = "ToUseChemicalToolStripMenuItem"
        Me.ToUseChemicalToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ToUseChemicalToolStripMenuItem.Text = "To Use Chemical"
        '
        'MainKimia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 384)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainKimia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gudang Kimia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfChemicalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfChemicalInSerialCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToUseChemicalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
