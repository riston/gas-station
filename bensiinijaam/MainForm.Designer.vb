<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBox95 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxDiesel = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox98 = New System.Windows.Forms.MaskedTextBox()
        Me.FuelTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FuelTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FuelTimer3 = New System.Windows.Forms.Timer(Me.components)
        Me.FuelTimer4 = New System.Windows.Forms.Timer(Me.components)
        Me.TankerControl1 = New bensiinijaam.TankerControl()
        Me.TankerControl2 = New bensiinijaam.TankerControl()
        Me.TankerControl3 = New bensiinijaam.TankerControl()
        Me.TankerControl4 = New bensiinijaam.TankerControl()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prices"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "95"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "98"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Diesel:"
        '
        'MaskedTextBox95
        '
        Me.MaskedTextBox95.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox95.Location = New System.Drawing.Point(86, 45)
        Me.MaskedTextBox95.Mask = "1.000"
        Me.MaskedTextBox95.Name = "MaskedTextBox95"
        Me.MaskedTextBox95.Size = New System.Drawing.Size(69, 26)
        Me.MaskedTextBox95.TabIndex = 3
        Me.MaskedTextBox95.Text = "390"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(86, 74)
        Me.MaskedTextBox2.Mask = "1.000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(69, 26)
        Me.MaskedTextBox2.TabIndex = 3
        '
        'MaskedTextBoxDiesel
        '
        Me.MaskedTextBoxDiesel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxDiesel.Location = New System.Drawing.Point(86, 102)
        Me.MaskedTextBoxDiesel.Mask = "1.000"
        Me.MaskedTextBoxDiesel.Name = "MaskedTextBoxDiesel"
        Me.MaskedTextBoxDiesel.Size = New System.Drawing.Size(69, 26)
        Me.MaskedTextBoxDiesel.TabIndex = 3
        Me.MaskedTextBoxDiesel.Text = "405"
        '
        'MaskedTextBox98
        '
        Me.MaskedTextBox98.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox98.Location = New System.Drawing.Point(86, 74)
        Me.MaskedTextBox98.Mask = "1.000"
        Me.MaskedTextBox98.Name = "MaskedTextBox98"
        Me.MaskedTextBox98.Size = New System.Drawing.Size(69, 26)
        Me.MaskedTextBox98.TabIndex = 3
        Me.MaskedTextBox98.Text = "430"
        '
        'FuelTimer1
        '
        Me.FuelTimer1.Interval = 250
        '
        'FuelTimer2
        '
        Me.FuelTimer2.Interval = 250
        '
        'FuelTimer3
        '
        Me.FuelTimer3.Interval = 250
        '
        'FuelTimer4
        '
        Me.FuelTimer4.Interval = 250
        '
        'TankerControl1
        '
        Me.TankerControl1.Location = New System.Drawing.Point(12, 143)
        Me.TankerControl1.Name = "TankerControl1"
        Me.TankerControl1.Size = New System.Drawing.Size(126, 226)
        Me.TankerControl1.TabIndex = 4
        '
        'TankerControl2
        '
        Me.TankerControl2.Location = New System.Drawing.Point(144, 143)
        Me.TankerControl2.Name = "TankerControl2"
        Me.TankerControl2.Size = New System.Drawing.Size(126, 226)
        Me.TankerControl2.TabIndex = 4
        '
        'TankerControl3
        '
        Me.TankerControl3.Location = New System.Drawing.Point(276, 143)
        Me.TankerControl3.Name = "TankerControl3"
        Me.TankerControl3.Size = New System.Drawing.Size(126, 226)
        Me.TankerControl3.TabIndex = 4
        '
        'TankerControl4
        '
        Me.TankerControl4.Location = New System.Drawing.Point(408, 143)
        Me.TankerControl4.Name = "TankerControl4"
        Me.TankerControl4.Size = New System.Drawing.Size(126, 226)
        Me.TankerControl4.TabIndex = 4
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 388)
        Me.Controls.Add(Me.TankerControl4)
        Me.Controls.Add(Me.TankerControl3)
        Me.Controls.Add(Me.TankerControl2)
        Me.Controls.Add(Me.TankerControl1)
        Me.Controls.Add(Me.MaskedTextBoxDiesel)
        Me.Controls.Add(Me.MaskedTextBox98)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox95)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Gas station"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox95 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBoxDiesel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox98 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FuelTimer1 As System.Windows.Forms.Timer
    Friend WithEvents FuelTimer2 As System.Windows.Forms.Timer
    Friend WithEvents FuelTimer3 As System.Windows.Forms.Timer
    Friend WithEvents FuelTimer4 As System.Windows.Forms.Timer
    Friend WithEvents TankerControl1 As bensiinijaam.TankerControl
    Friend WithEvents TankerControl2 As bensiinijaam.TankerControl
    Friend WithEvents TankerControl3 As bensiinijaam.TankerControl
    Friend WithEvents TankerControl4 As bensiinijaam.TankerControl

End Class
