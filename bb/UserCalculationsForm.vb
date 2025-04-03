Imports System.Data.SqlClient

Public Class usercalculationsform
    Dim conn As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")
    Dim loggedInUserID As Integer ' Store the logged-in user's ID

    Private Sub CalculationHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch the logged-in user ID
        loggedInUserID = FetchUserID()
        If loggedInUserID = -1 Then
            MessageBox.Show("User not found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        ' Load calculations into DataGridView
        LoadUserCalculations()
    End Sub

    Private Function FetchUserID() As Integer
        ' Fetch user ID from session or database
        Dim userID As Integer = -1
        Dim query As String = "SELECT UserID FROM Usertable WHERE Email = @Email AND Password = @Password"
        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", LoggedInUserEmail)
            cmd.Parameters.AddWithValue("@Password", LoggedInUserPassword)
            conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then userID = Convert.ToInt32(result)
            conn.Close()
        End Using
        Return userID
    End Function

    Private Sub LoadUserCalculations()
        Try
            Dim query As String = "SELECT 'EMI Calculation' AS CalculationType, Principle_Amount AS Detail1, Interest_Rate AS Detail2, No_Of_Month AS Detail3, EMI_Amount AS Detail4 FROM EMItable WHERE UserID = @UserID " &
                                  "UNION ALL " &
                                  "SELECT 'Emergency Fund' AS CalculationType, Expenses, Months, NULL, EmergencyFund FROM EmergencyFundtable WHERE UserID = @UserID " &
                                  "UNION ALL " &
                                  "SELECT 'Debt-to-Income Ratio' AS CalculationType, MonthlyIncome, MonthlyDebt, NULL, DTI FROM DebtIncometable WHERE UserID = @UserID " &
                                  "UNION ALL " &
                                  "SELECT 'Savings Plan' AS CalculationType, Income, Expense, TargetSavings, Months FROM Savingtable WHERE UserID = @UserID"

            Dim adapter As New SqlDataAdapter(query, conn)
            adapter.SelectCommand.Parameters.AddWithValue("@UserID", loggedInUserID)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvCalculations.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading calculations: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userdashboard.Show()
        Me.Hide()
    End Sub
End Class