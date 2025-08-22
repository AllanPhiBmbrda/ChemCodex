<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LChemUse
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
        Me.UseKimCmb01 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UseKimTbx02 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UseKimTbx01 = New System.Windows.Forms.TextBox()
        Me.UseKimBtn02 = New System.Windows.Forms.Button()
        Me.UseKimBtn01 = New System.Windows.Forms.Button()
        Me.LCSDP01 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UseGrid01 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UseGrid01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UseKimCmb01)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.UseKimTbx02)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.UseKimTbx01)
        Me.GroupBox1.Controls.Add(Me.UseKimBtn02)
        Me.GroupBox1.Controls.Add(Me.UseKimBtn01)
        Me.GroupBox1.Controls.Add(Me.LCSDP01)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 128)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'UseKimCmb01
        '
        Me.UseKimCmb01.FormattingEnabled = True
        Me.UseKimCmb01.Location = New System.Drawing.Point(9, 38)
        Me.UseKimCmb01.Name = "UseKimCmb01"
        Me.UseKimCmb01.Size = New System.Drawing.Size(271, 23)
        Me.UseKimCmb01.TabIndex = 12
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
        'UseKimTbx02
        '
        Me.UseKimTbx02.Location = New System.Drawing.Point(172, 82)
        Me.UseKimTbx02.Name = "UseKimTbx02"
        Me.UseKimTbx02.Size = New System.Drawing.Size(91, 23)
        Me.UseKimTbx02.TabIndex = 10
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
        'UseKimTbx01
        '
        Me.UseKimTbx01.Location = New System.Drawing.Point(7, 82)
        Me.UseKimTbx01.Name = "UseKimTbx01"
        Me.UseKimTbx01.Size = New System.Drawing.Size(91, 23)
        Me.UseKimTbx01.TabIndex = 8
        '
        'UseKimBtn02
        '
        Me.UseKimBtn02.Location = New System.Drawing.Point(727, 37)
        Me.UseKimBtn02.Name = "UseKimBtn02"
        Me.UseKimBtn02.Size = New System.Drawing.Size(75, 23)
        Me.UseKimBtn02.TabIndex = 7
        Me.UseKimBtn02.Text = "Use NOW"
        Me.UseKimBtn02.UseVisualStyleBackColor = True
        '
        'UseKimBtn01
        '
        Me.UseKimBtn01.Location = New System.Drawing.Point(646, 37)
        Me.UseKimBtn01.Name = "UseKimBtn01"
        Me.UseKimBtn01.Size = New System.Drawing.Size(75, 23)
        Me.UseKimBtn01.TabIndex = 6
        Me.UseKimBtn01.Text = "Generate"
        Me.UseKimBtn01.UseVisualStyleBackColor = True
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
        'UseGrid01
        '
        Me.UseGrid01.AllowUserToAddRows = False
        Me.UseGrid01.AllowUserToDeleteRows = False
        Me.UseGrid01.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.UseGrid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UseGrid01.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UseGrid01.Location = New System.Drawing.Point(0, 133)
        Me.UseGrid01.Name = "UseGrid01"
        Me.UseGrid01.ReadOnly = True
        Me.UseGrid01.Size = New System.Drawing.Size(808, 374)
        Me.UseGrid01.TabIndex = 5
        '
        'LChemUse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 507)
        Me.Controls.Add(Me.UseGrid01)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Name = "LChemUse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chemical to Use Module"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UseGrid01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UseKimCmb01 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UseKimTbx02 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UseKimTbx01 As System.Windows.Forms.TextBox
    Friend WithEvents UseKimBtn02 As System.Windows.Forms.Button
    Friend WithEvents UseKimBtn01 As System.Windows.Forms.Button
    Friend WithEvents LCSDP01 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UseGrid01 As System.Windows.Forms.DataGridView
End Class
