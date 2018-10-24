<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowPackageForm
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
        Me.RANGE = New System.Windows.Forms.Label()
        Me.range1 = New System.Windows.Forms.ComboBox()
        Me.CITY = New System.Windows.Forms.Label()
        Me.city1 = New System.Windows.Forms.ComboBox()
        Me.DAYS = New System.Windows.Forms.Label()
        Me.Days1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RANGE
        '
        Me.RANGE.AutoSize = True
        Me.RANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RANGE.Location = New System.Drawing.Point(21, 46)
        Me.RANGE.Name = "RANGE"
        Me.RANGE.Size = New System.Drawing.Size(72, 20)
        Me.RANGE.TabIndex = 1
        Me.RANGE.Text = "RANGE"
        '
        'range1
        '
        Me.range1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.range1.FormattingEnabled = True
        Me.range1.Items.AddRange(New Object() {"5000-10000 /5 nights,6days", "10000-20000 /10 nights,11 days", "20000-30000 /20 nights,21days"})
        Me.range1.Location = New System.Drawing.Point(113, 46)
        Me.range1.Name = "range1"
        Me.range1.Size = New System.Drawing.Size(150, 28)
        Me.range1.TabIndex = 2
        '
        'CITY
        '
        Me.CITY.AutoSize = True
        Me.CITY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CITY.Location = New System.Drawing.Point(31, 96)
        Me.CITY.Name = "CITY"
        Me.CITY.Size = New System.Drawing.Size(49, 20)
        Me.CITY.TabIndex = 3
        Me.CITY.Text = "CITY"
        '
        'city1
        '
        Me.city1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city1.FormattingEnabled = True
        Me.city1.Items.AddRange(New Object() {"Bangalore", "Mangalore", "Chennai", "Mumbai", "Delhi", "Kolkata", ""})
        Me.city1.Location = New System.Drawing.Point(113, 95)
        Me.city1.Name = "city1"
        Me.city1.Size = New System.Drawing.Size(150, 28)
        Me.city1.TabIndex = 4
        '
        'DAYS
        '
        Me.DAYS.AutoSize = True
        Me.DAYS.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAYS.Location = New System.Drawing.Point(31, 152)
        Me.DAYS.Name = "DAYS"
        Me.DAYS.Size = New System.Drawing.Size(49, 20)
        Me.DAYS.TabIndex = 5
        Me.DAYS.Text = "DAYS"
        '
        'Days1
        '
        Me.Days1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Days1.FormattingEnabled = True
        Me.Days1.Items.AddRange(New Object() {"3-5", "5-10", "10-15"})
        Me.Days1.Location = New System.Drawing.Point(113, 153)
        Me.Days1.Name = "Days1"
        Me.Days1.Size = New System.Drawing.Size(150, 28)
        Me.Days1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(95, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShowPackageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Days1)
        Me.Controls.Add(Me.DAYS)
        Me.Controls.Add(Me.city1)
        Me.Controls.Add(Me.CITY)
        Me.Controls.Add(Me.range1)
        Me.Controls.Add(Me.RANGE)
        Me.Name = "ShowPackageForm"
        Me.Text = "ShowPackage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RANGE As System.Windows.Forms.Label
    Friend WithEvents range1 As System.Windows.Forms.ComboBox
    Friend WithEvents CITY As System.Windows.Forms.Label
    Friend WithEvents city1 As System.Windows.Forms.ComboBox
    Friend WithEvents DAYS As System.Windows.Forms.Label
    Friend WithEvents Days1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
