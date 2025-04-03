Public Class userdashboard

    Public LoggedInUserID As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim emergencyForm As New EmergencyFund()
        emergencyForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emiForm As New EMIcalculator
        emiForm.Show()
        Me.Hide()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim savingsForm As New Savingplan
        savingsForm.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim usercalculationsForm As New usercalculationsform
        usercalculationsForm.Show()
        Me.Hide()
    End Sub

    Private Sub userdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "User ID: " & LoggedInUserID

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DebtToIncome.Show()
        Me.Hide()
    End Sub
End Class