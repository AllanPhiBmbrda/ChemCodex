<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LChem
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
        Me.KimiaGrid01 = New System.Windows.Forms.DataGridView()
        CType(Me.KimiaGrid01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KimiaGrid01
        '
        Me.KimiaGrid01.AllowUserToAddRows = False
        Me.KimiaGrid01.AllowUserToDeleteRows = False
        Me.KimiaGrid01.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.KimiaGrid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KimiaGrid01.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KimiaGrid01.Location = New System.Drawing.Point(0, 1)
        Me.KimiaGrid01.Name = "KimiaGrid01"
        Me.KimiaGrid01.ReadOnly = True
        Me.KimiaGrid01.Size = New System.Drawing.Size(756, 514)
        Me.KimiaGrid01.TabIndex = 0
        '
        'LChem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 515)
        Me.Controls.Add(Me.KimiaGrid01)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LChem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chemical List "
        CType(Me.KimiaGrid01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KimiaGrid01 As System.Windows.Forms.DataGridView
End Class
