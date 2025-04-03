' Emergency Fund Calculator - Budget Buddy
Imports System.Data.SqlClient
Imports System.IO

Public Class EmergencyFund
    Dim conn As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")
    Dim loggedInUserID As Integer ' Store the logged-in user's ID

    Private Sub EmergencyFundCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch the logged-in user ID
        loggedInUserID = FetchUserID()
        If loggedInUserID = -1 Then
            MessageBox.Show("User not found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        ' Populate months to save in the ComboBox
        cmbMonthstosave.Items.Add("3")
        cmbMonthstosave.Items.Add("6")
        cmbMonthstosave.Items.Add("9")
        cmbMonthstosave.Items.Add("12")
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
        If txtMonthlyExpenses.Text = "" OrElse cmbMonthstosave.SelectedIndex = -1 Then
            MessageBox.Show("Please enter Monthly Expenses and select Months to Save.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim monthlyExpenses As Double = Convert.ToDouble(txtMonthlyExpenses.Text)
            Dim monthsToSave As Integer = Convert.ToInt32(cmbMonthstosave.Text)
            Dim totalEmergencyFund As Double = monthlyExpenses * monthsToSave
            txtTotalFund.Text = totalEmergencyFund.ToString("F2")
        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter a valid number for Monthly Expenses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate inputs before saving
        If txtMonthlyExpenses.Text = "" OrElse cmbMonthstosave.SelectedIndex = -1 OrElse txtTotalFund.Text = "" Then
            MessageBox.Show("Please fill all fields before saving.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure user ID is valid before inserting data
        If loggedInUserID = -1 Then
            MessageBox.Show("User ID is invalid. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Insert Emergency Fund calculation into database
            Dim query As String = "INSERT INTO EmergencyFundTable (UserID, Expenses, Months, EmergencyFund) VALUES (@UserID, @Expenses, @Months, @EmergencyFund)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", loggedInUserID)
                cmd.Parameters.AddWithValue("@Expenses", Convert.ToDouble(txtMonthlyExpenses.Text))
                cmd.Parameters.AddWithValue("@Months", Convert.ToInt32(cmbMonthstosave.Text))
                cmd.Parameters.AddWithValue("@EmergencyFund", Convert.ToDouble(txtTotalFund.Text))
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Emergency fund saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        userdashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Reset all input fields
        txtMonthlyExpenses.Clear()
        cmbMonthstosave.SelectedIndex = -1
        txtTotalFund.Clear()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Validate before exporting
        If txtMonthlyExpenses.Text = "" OrElse cmbMonthstosave.SelectedIndex = -1 OrElse txtTotalFund.Text = "" Then
            MessageBox.Show("Please fill all fields before exporting.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Export calculation to a text file
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
        saveFileDialog.Title = "Save Emergency Fund Calculation"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim filePath As String = saveFileDialog.FileName
                Using writer As New StreamWriter(filePath)
                    writer.WriteLine("Emergency Fund Calculation")
                    writer.WriteLine("--------------------------------------")
                    writer.WriteLine("Monthly Expenses: " & txtMonthlyExpenses.Text)
                    writer.WriteLine("Months to Save: " & cmbMonthstosave.Text)
                    writer.WriteLine("Total Fund Required: " & txtTotalFund.Text)
                    writer.WriteLine("--------------------------------------")
                End Using
                MessageBox.Show("Calculation exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error while exporting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
