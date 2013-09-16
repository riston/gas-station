Public Class TankerControl

    Public ammount As Decimal = 0.0
    Public currentCost As Decimal

    Const FILL_BY As Decimal = 0.23

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TotalCostLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles FuelButton.Click
        If FuelButton.Text = "Fuel" Then
            FuelTimer.Enabled = True
            FuelButton.Text = "Stop"
        ElseIf FuelButton.Text = "Stop" Then
            FuelTimer.Enabled = False
            FuelButton.Text = "Pay"
        Else
            'Pay flow 
            'MainForm.Enabled = False
            FuelButton.Enabled = False

            Dim payForm As PayForm = New PayForm
            payForm.tankerControl = Me
            payForm.Show()

        End If

    End Sub

    Private Function GetPrice(fuelType As String) As Decimal
        Dim price As Decimal = 0.0

        If fuelType = "95" Then
            price = CSng(MainForm.MaskedTextBox95.Text)
        ElseIf fuelType = "98" Then
            price = CSng(MainForm.MaskedTextBox95.Text)
        ElseIf fuelType = "Diesel" Then
            price = CSng(MainForm.MaskedTextBoxDiesel.Text)
        Else
            Return price
        End If

        Return price
    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles FuelTimer.Tick
        ammount += FILL_BY
        currentCost = GetPrice(FuelTypeComboBox.Text) * Me.ammount

        AmmountLabel.Text = ammount
        TotalCostLabel.Text = Format(currentCost, "###.###") & " EUR"


    End Sub
End Class
