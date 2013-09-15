<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TankerControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TankerControl))
        Me.AmmountLabel = New System.Windows.Forms.Label()
        Me.FuelTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.FuelButton = New System.Windows.Forms.Button()
        Me.TotalCostLabel = New System.Windows.Forms.Label()
        Me.FuelTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmmountLabel
        '
        Me.AmmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AmmountLabel.AutoSize = True
        Me.AmmountLabel.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmmountLabel.Location = New System.Drawing.Point(8, 26)
        Me.AmmountLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.AmmountLabel.Name = "AmmountLabel"
        Me.AmmountLabel.Size = New System.Drawing.Size(58, 25)
        Me.AmmountLabel.TabIndex = 12
        Me.AmmountLabel.Text = "0.00"
        '
        'FuelTypeComboBox
        '
        Me.FuelTypeComboBox.FormattingEnabled = True
        Me.FuelTypeComboBox.Items.AddRange(New Object() {"95", "98", "Diesel"})
        Me.FuelTypeComboBox.Location = New System.Drawing.Point(13, 148)
        Me.FuelTypeComboBox.Name = "FuelTypeComboBox"
        Me.FuelTypeComboBox.Size = New System.Drawing.Size(100, 21)
        Me.FuelTypeComboBox.TabIndex = 11
        Me.FuelTypeComboBox.Text = "95"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = CType(resources.GetObject("PictureBox4.InitialImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 139)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'FuelButton
        '
        Me.FuelButton.Location = New System.Drawing.Point(13, 175)
        Me.FuelButton.Name = "FuelButton"
        Me.FuelButton.Size = New System.Drawing.Size(100, 23)
        Me.FuelButton.TabIndex = 13
        Me.FuelButton.Text = "Fuel"
        Me.FuelButton.UseVisualStyleBackColor = True
        '
        'TotalCostLabel
        '
        Me.TotalCostLabel.AutoSize = True
        Me.TotalCostLabel.Location = New System.Drawing.Point(13, 205)
        Me.TotalCostLabel.Name = "TotalCostLabel"
        Me.TotalCostLabel.Size = New System.Drawing.Size(55, 13)
        Me.TotalCostLabel.TabIndex = 14
        Me.TotalCostLabel.Text = "Total Cost"
        '
        'FuelTimer
        '
        Me.FuelTimer.Interval = 250
        '
        'TankerControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TotalCostLabel)
        Me.Controls.Add(Me.FuelButton)
        Me.Controls.Add(Me.AmmountLabel)
        Me.Controls.Add(Me.FuelTypeComboBox)
        Me.Controls.Add(Me.PictureBox4)
        Me.Name = "TankerControl"
        Me.Size = New System.Drawing.Size(126, 226)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AmmountLabel As System.Windows.Forms.Label
    Friend WithEvents FuelTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents FuelButton As System.Windows.Forms.Button
    Friend WithEvents TotalCostLabel As System.Windows.Forms.Label
    Friend WithEvents FuelTimer As System.Windows.Forms.Timer

End Class
