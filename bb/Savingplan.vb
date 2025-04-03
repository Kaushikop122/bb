Imports System.Data.SqlClient
Imports System.IO
Public Class Savingplan
    Private connectionString As String = "Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True"

    ' Function to Get Logged-in User ID
    Private Function GetCurrentUserID() As Integer
        ' Fetch the logged-in user ID from session (Implement session tracking in your app)
        Return 1 ' Placeholder (Replace this with actual session-based user retrieval)
    End Function

    Private Sub Savingsplan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbmonths.Items.Clear()
        For i As Integer = 1 To 12
            cmbmonths.Items.Add("Month " & i)
        Next
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim income As Double
        Dim expenses As Double
        Dim targetSavings As Double
        Dim months As Integer
        Dim savingsPerMonth As Double

        ' Validate input
        If Double.TryParse(txtIncome.Text, income) AndAlso
           Double.TryParse(txtExpenses.Text, expenses) AndAlso
           Double.TryParse(txtTargetSavings.Text, targetSavings) AndAlso
           cmbmonths.SelectedItem IsNot Nothing Then

            ' Extract month number
            months = Integer.Parse(cmbmonths.SelectedItem.ToString().Split(" "c)(1))

            If months <= 0 Then
                MessageBox.Show("Please select a valid number of months.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Calculate savings per month
            Dim monthlyRemaining As Double = income - expenses
            savingsPerMonth = targetSavings / months

            ' Validate feasibility
            If savingsPerMonth > monthlyRemaining Then
                MessageBox.Show("Your target savings per month exceeds your available income after expenses!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSavingsPerMonth.Text = "Not Feasible"
            Else
                txtSavingsPerMonth.Text = savingsPerMonth.ToString("C") ' Format as currency
            End If

        Else
            MessageBox.Show("Please enter valid numeric values for income, expenses, and target savings, and select a month.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Save to Database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim income As Decimal
        Dim expenses As Decimal
        Dim targetSavings As Decimal
        Dim months As Integer
        Dim savingsPerMonth As Decimal
        Dim userID As Integer = GetCurrentUserID()

        ' Validate input
        If Decimal.TryParse(txtIncome.Text, income) AndAlso
           Decimal.TryParse(txtExpenses.Text, expenses) AndAlso
           Decimal.TryParse(txtTargetSavings.Text, targetSavings) AndAlso
           cmbmonths.SelectedItem IsNot Nothing Then

            months = Integer.Parse(cmbmonths.SelectedItem.ToString().Split(" "c)(1))
            savingsPerMonth = (targetSavings - expenses) / months

            ' Check affordability
            If savingsPerMonth > (income - expenses) Then
                MessageBox.Show("Your savings goal exceeds your available balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Save to database
            Using con As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Savingtable (UserID, Income, Expense, TargetSavings, Months, SavingsPerMonths) 
                                       VALUES (@userid, @Income, @Expense, @TargetSavings, @Months, @SavingsPerMonths)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@userid", userID)
                    cmd.Parameters.AddWithValue("@Income", income)
                    cmd.Parameters.AddWithValue("@Expense", expenses)
                    cmd.Parameters.AddWithValue("@TargetSavings", targetSavings)
                    cmd.Parameters.AddWithValue("@Months", months)
                    cmd.Parameters.AddWithValue("@SavingsPerMonths", savingsPerMonth)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Savings Plan Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using

        Else
            MessageBox.Show("Please enter valid details and select a month.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Export Data to Text File
    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        Dim filePath As String = "C:\Users\Public\SavingsPlanExport.txt"
        Try
            Using writer As New StreamWriter(filePath, False)
                writer.WriteLine("User Savings Plan Summary")
                writer.WriteLine("--------------------------------------")
                writer.WriteLine("User ID: " & GetCurrentUserID())
                writer.WriteLine("Income: " & txtIncome.Text)
                writer.WriteLine("Expenses: " & txtExpenses.Text)
                writer.WriteLine("Target Savings: " & txtTargetSavings.Text)
                writer.WriteLine("Months: " & cmbmonths.SelectedItem)
                writer.WriteLine("Recommended Savings Per Month: " & txtSavingsPerMonth.Text)
            End Using
            MessageBox.Show("Exported Successfully to " & filePath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error exporting file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Reset Button: Clears fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncome.Clear()
        txtExpenses.Clear()
        txtTargetSavings.Clear()
        txtSavingsPerMonth.Clear()
        cmbmonths.SelectedIndex = -1
    End Sub

    ' Back Button: Return to Dashboard
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New UserDashboard
        dashboard.Show()
        Me.Hide()
    End Sub
End Class
