<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LChemAdd
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UpKimTbx03 = New System.Windows.Forms.TextBox()
        Me.UpKimCmb01 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UpKimTbx02 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpKimTbx01 = New System.Windows.Forms.TextBox()
        Me.UpKimBtn02 = New System.Windows.Forms.Button()
        Me.UpKimBtn01 = New System.Windows.Forms.Button()
        Me.LCSDP01 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LCSGrid01 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LCSGrid01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.UpKimTbx03)
        Me.GroupBox1.Controls.Add(Me.UpKimCmb01)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.UpKimTbx02)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.UpKimTbx01)
        Me.GroupBox1.Controls.Add(Me.UpKimBtn02)
        Me.GroupBox1.Controls.Add(Me.UpKimBtn01)
        Me.GroupBox1.Controls.Add(Me.LCSDP01)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 128)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(469, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Weight to Upload :"
        '
        'UpKimTbx03
        '
        Me.UpKimTbx03.Location = New System.Drawing.Point(472, 82)
        Me.UpKimTbx03.Name = "UpKimTbx03"
        Me.UpKimTbx03.Size = New System.Drawing.Size(142, 23)
        Me.UpKimTbx03.TabIndex = 13
        '
        'UpKimCmb01
        '
        Me.UpKimCmb01.FormattingEnabled = True
        Me.UpKimCmb01.Location = New System.Drawing.Point(9, 38)
        Me.UpKimCmb01.Name = "UpKimCmb01"
        Me.UpKimCmb01.Size = New System.Drawing.Size(271, 23)
        Me.UpKimCmb01.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "End :"
        '
        'UpKimTbx02
        '
        Me.UpKimTbx02.Location = New System.Drawing.Point(172, 82)
        Me.UpKimTbx02.Name = "UpKimTbx02"
        Me.UpKimTbx02.Size = New System.Drawing.Size(91, 23)
        Me.UpKimTbx02.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Start :"
        '
        'UpKimTbx01
        '
        Me.UpKimTbx01.Location = New System.Drawing.Point(7, 82)
        Me.UpKimTbx01.Name = "UpKimTbx01"
        Me.UpKimTbx01.Size = New System.Drawing.Size(91, 23)
        Me.UpKimTbx01.TabIndex = 8
        '
        'UpKimBtn02
        '
        Me.UpKimBtn02.Location = New System.Drawing.Point(732, 38)
        Me.UpKimBtn02.Name = "UpKimBtn02"
        Me.UpKimBtn02.Size = New System.Drawing.Size(75, 23)
        Me.UpKimBtn02.TabIndex = 7
        Me.UpKimBtn02.Text = "Upload"
        Me.UpKimBtn02.UseVisualStyleBackColor = True
        '
        'UpKimBtn01
        '
        Me.UpKimBtn01.Location = New System.Drawing.Point(651, 38)
        Me.UpKimBtn01.Name = "UpKimBtn01"
        Me.UpKimBtn01.Size = New System.Drawing.Size(75, 23)
        Me.UpKimBtn01.TabIndex = 6
        Me.UpKimBtn01.Text = "Generate"
        Me.UpKimBtn01.UseVisualStyleBackColor = True
        '
        'LCSDP01
        '
        Me.LCSDP01.CustomFormat = "dd MMM yyyy"
        Me.LCSDP01.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LCSDP01.Location = New System.Drawing.Point(301, 38)
        Me.LCSDP01.Name = "LCSDP01"
        Me.LCSDP01.Size = New System.Drawing.Size(156, 23)
        Me.LCSDP01.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Chemical Date IN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chemical Name"
        '
        'LCSGrid01
        '
        Me.LCSGrid01.AllowUserToAddRows = False
        Me.LCSGrid01.AllowUserToDeleteRows = False
        Me.LCSGrid01.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.LCSGrid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LCSGrid01.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LCSGrid01.Location = New System.Drawing.Point(0, 134)
        Me.LCSGrid01.Name = "LCSGrid01"
        Me.LCSGrid01.ReadOnly = True
        Me.LCSGrid01.Size = New System.Drawing.Size(813, 374)
        Me.LCSGrid01.TabIndex = 4
        '
        'LChemAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 508)
        Me.Controls.Add(Me.LCSGrid01)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Name = "LChemAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Batch of Chemical"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LCSGrid01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UpKimBtn01 As System.Windows.Forms.Button
    Friend WithEvents LCSDP01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UpKimBtn02 As System.Windows.Forms.Button
    Friend WithEvents UpKimTbx01 As System.Windows.Forms.TextBox
    Friend WithEvents LCSGrid01 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UpKimTbx02 As System.Windows.Forms.TextBox
    Friend WithEvents UpKimCmb01 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UpKimTbx03 As System.Windows.Forms.TextBox
End Class
