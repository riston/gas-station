﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AmmountLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalCostLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanked:"
        '
        'AmmountLabel
        '
        Me.AmmountLabel.AutoSize = True
        Me.AmmountLabel.Location = New System.Drawing.Point(61, 18)
        Me.AmmountLabel.Name = "AmmountLabel"
        Me.AmmountLabel.Size = New System.Drawing.Size(77, 13)
        Me.AmmountLabel.TabIndex = 1
        Me.AmmountLabel.Text = "AmmountLabel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total:"
        '
        'TotalCostLabel
        '
        Me.TotalCostLabel.AutoSize = True
        Me.TotalCostLabel.Location = New System.Drawing.Point(174, 18)
        Me.TotalCostLabel.Name = "TotalCostLabel"
        Me.TotalCostLabel.Size = New System.Drawing.Size(78, 13)
        Me.TotalCostLabel.TabIndex = 2
        Me.TotalCostLabel.Text = "TotalCostLabel"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pay"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 50)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalCostLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AmmountLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PayForm"
        Me.Text = "PayForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AmmountLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalCostLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
