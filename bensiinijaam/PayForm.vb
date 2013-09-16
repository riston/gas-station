Public Class PayForm

    Dim _tankerControl As TankerControl

    Public Property tankerControl() As TankerControl
        Get
            tankerControl = _tankerControl
        End Get
        Set(ByVal value As TankerControl)
            _tankerControl = value
        End Set
    End Property

    Private Sub PayForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ResetInterface()

    End Sub

    Private Sub PayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AmmountLabel.Text = _tankerControl.ammount
        TotalCostLabel.Text = _tankerControl.currentCost & " EUR"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetInterface()
        Me.Close()

    End Sub

    Sub ResetInterface()

        _tankerControl.FuelButton.Enabled = True
        _tankerControl.ammount = 0.0
        _tankerControl.currentCost = 0

        _tankerControl.TotalCostLabel.Text = "0.00 EUR"
        _tankerControl.AmmountLabel.Text = "0.00"
        _tankerControl.FuelButton.Text = "Fuel"
    End Sub

End Class