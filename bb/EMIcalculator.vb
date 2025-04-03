' Rebuilt EMI Calculator Form - Budget Buddy
Imports System.Data.SqlClient

Public Class EMICalculator
    Dim conn As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")
    Dim loggedInUserID As Integer ' Store the logged-in user's ID

    Private Sub EMICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch the logged-in user ID
        loggedInUserID = FetchUserID()
        If loggedInUserID = -1 Then
            MessageBox.Show("User not found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        ' Populate bank names in the ComboBox
        cmbBank.Items.Add("State Bank of India")
        cmbBank.Items.Add("ICICI Bank")
        cmbBank.Items.Add("Kotak Mahindra Bank")
        cmbBank.Items.Add("HDFC Bank")
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

    Private Sub cmbBankName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBank.SelectedIndexChanged
        ' Set interest rate based on selected bank
        Select Case cmbBank.Text
            Case "State Bank of India"
                txtInterestRate.Text = "8.00"
            Case "ICICI Bank"
                txtInterestRate.Text = "6.00"
            Case "Kotak Mahindra Bank"
                txtInterestRate.Text = "5.00"
            Case "HDFC Bank"
                txtInterestRate.Text = "6.50"
            Case Else
                txtInterestRate.Text = ""
        End Select
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate inputs before calculating EMI
        If cmbBank.SelectedIndex = -1 OrElse txtPrincipal.Text = "" OrElse txtInterestRate.Text = "" OrElse txtMonths.Text = "" Then
            MessageBox.Show("Please fill all fields before calculating EMI.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim principal As Double = Convert.ToDouble(txtPrincipal.Text)
            Dim rate As Double = Convert.ToDouble(txtInterestRate.Text) / 100 / 12
            Dim months As Integer = Convert.ToInt32(txtMonths.Text)

            Dim emi As Double = (principal * rate * Math.Pow(1 + rate, months)) / (Math.Pow(1 + rate, months) - 1)
            txtEMI.Text = emi.ToString("F2")
        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' Validate inputs before saving
        If cmbBank.SelectedIndex = -1 OrElse txtPrincipal.Text = "" OrElse txtInterestRate.Text = "" OrElse txtMonths.Text = "" OrElse txtEMI.Text = "" Then
            MessageBox.Show("Please fill all fields before saving EMI.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ensure user ID is valid before inserting data
        If loggedInUserID = -1 Then
            MessageBox.Show("User ID is invalid. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Insert EMI calculation into database
            Dim query As String = "INSERT INTO EMItable (UserID, BankName, Principal, InterestRate, Months, EMIAmount) VALUES (@UserID, @BankName, @Principal, @InterestRate, @Months, @EMIAmount)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", loggedInUserID)
                cmd.Parameters.AddWithValue("@BankName", cmbBank.Text)
                cmd.Parameters.AddWithValue("@Principal", Convert.ToDouble(txtPrincipal.Text))
                cmd.Parameters.AddWithValue("@InterestRate", Convert.ToDouble(txtInterestRate.Text))
                cmd.Parameters.AddWithValue("@Months", Convert.ToInt32(txtMonths.Text))
                cmd.Parameters.AddWithValue("@EMIAmount", Convert.ToDouble(txtEMI.Text))
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("EMI saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while saving EMI: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        userdashboard.Show()
        Me.Hide()
    End Sub
End Class
