Imports System.Data.SqlClient

Public Class UserCalculationsForm
    Private connectionString As String = "Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True"
    Public Sub LoadUnionTableData()
        ' Code to refresh DataGridView
        ' Example:
        LoadUserCalculations() ' Replace this with the actual method that loads the union table data
    End Sub
    Private Sub UserCalculationsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserCalculations()
    End Sub

    Private Sub LoadUserCalculations()
        Dim userID As Integer = GetCurrentUserID() ' Fetch session-based user ID

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "
                SELECT 'EMI Calculation' AS CalculationType, Principle_Amount AS Detail1, Interest_Rate AS Detail2, No_Of_Month AS Detail3, EMI_Amount AS Result FROM EMItable WHERE UserID = @UserID
                UNION ALL
                SELECT 'Savings Plan', Income, Expense, Months, SavingsPerMonths FROM Savingtable WHERE UserID = @UserID
                UNION ALL
                SELECT 'Emergency Fund', Expenses, Months, NULL, EmergencyFund FROM EmergencyFundtable WHERE UserID = @UserID
                UNION ALL
                SELECT 'DTI Calculation', MonthlyIncome, MonthlyDebt, NULL, DTI FROM DebtIncometable WHERE UserID = @UserID"

            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@UserID", userID)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Function GetCurrentUserID() As Integer
        Return SessionData.LoggedInUserID
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dashboard As New UserDashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        LoadUserCalculations()
    End Sub

End Class