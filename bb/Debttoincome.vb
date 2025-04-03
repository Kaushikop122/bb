' Debt-to-Income Ratio Calculator - Budget Buddy
Imports System.Data.SqlClient
Imports System.IO

Public Class DebtToIncome
    Dim conn As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")
    Dim loggedInUserID As Integer ' Store the logged-in user's ID

    Private Sub DebtToIncomeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch the logged-in user ID
        loggedInUserID = FetchUserID()
        If loggedInUserID = -1 Then
            MessageBox.Show("User not found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
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

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate inputs before calculating
        If txtMonthlyIncome.Text = "" OrElse txtMonthlyDebt.Text = "" Then
            MessageBox.Show("Please enter both Monthly Income and Monthly Debt Payment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim monthlyIncome As Double = Convert.ToDouble(txtMonthlyIncome.Text)
            Dim monthlyDebt As Double = Convert.ToDouble(txtMonthlyDebt.Text)

            ' Prevent division by zero error
            If monthlyIncome = 0 Then
                MessageBox.Show("Monthly Income cannot be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim debtToIncomeRatio As Double = (monthlyDebt / monthlyIncome) * 100
            txtDTIRatio.Text = debtToIncomeRatio.ToString("F2") & "%"
        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter numeric values only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate inputs before saving
        If txtMonthlyIncome.Text = "" OrElse txtMonthlyDebt.Text = "" OrElse txtDTIRatio.Text = "" Then
            MessageBox.Show("Please calculate the Debt-to-Income Ratio before saving.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure user ID is valid before inserting data
        If loggedInUserID = -1 Then
            MessageBox.Show("User ID is invalid. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Insert Debt-to-Income Ratio calculation into database
            Dim query As String = "INSERT INTO DebtIncomeTable (UserID, MonthlyIncome, MonthlyDebt, DTI) VALUES (@UserID, @MonthlyIncome, @MonthlyDebt, @DTI)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", loggedInUserID)
                cmd.Parameters.AddWithValue("@MonthlyIncome", Convert.ToDouble(txtMonthlyIncome.Text))
                cmd.Parameters.AddWithValue("@MonthlyDebt", Convert.ToDouble(txtMonthlyDebt.Text))
                cmd.Parameters.AddWithValue("@DTI", Convert.ToDouble(txtDTIRatio.Text.TrimEnd("%"c)))
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Debt-to-Income ratio saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset all input fields
        txtMonthlyIncome.Clear()
        txtMonthlyDebt.Clear()
        txtDTIRatio.Clear()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Validate before exporting
        If txtMonthlyIncome.Text = "" OrElse txtMonthlyDebt.Text = "" OrElse txtDTIRatio.Text = "" Then
            MessageBox.Show("Please fill all fields before exporting.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Export calculation to a text file
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
        saveFileDialog.Title = "Save Debt-to-Income Ratio Calculation"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim filePath As String = saveFileDialog.FileName
                Using writer As New StreamWriter(filePath)
                    writer.WriteLine("Debt-to-Income Ratio Calculation")
                    writer.WriteLine("--------------------------------------")
                    writer.WriteLine("Monthly Income: " & txtMonthlyIncome.Text)
                    writer.WriteLine("Monthly Debt Payment: " & txtMonthlyDebt.Text)
                    writer.WriteLine("Debt-to-Income Ratio: " & txtDTIRatio.Text)
                    writer.WriteLine("--------------------------------------")
                End Using
                MessageBox.Show("Calculation exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error while exporting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        userdashboard.Show()
        Me.Hide()
    End Sub
End Class
