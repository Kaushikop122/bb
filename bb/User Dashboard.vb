Public Class UserDashboard
    Private userID As Integer

    ' Constructor to receive userID
    Public Sub New(Optional userID As Integer = 0)
        InitializeComponent()
        Me.userID = userID
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim emergencyForm As New EmergencyFundForm(Me.userID)
        emergencyForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emiForm As New EMIcalculator
        emiForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim debtForm As New Debttoincome(Me.userID) ' ✅ Use the existing userID
        debtForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim savingsForm As New Savingplan
        savingsForm.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim calculationsForm As New UserCalculationsForm
        calculationsForm.Show()
        Me.Hide()
    End Sub

End Class
