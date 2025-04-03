Imports System.Data.SqlClient
Imports System.IO

Public Class EMIcalculator
    Dim connectionString As String = "Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True"


    Private Sub EMIcalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBank.Items.Add("State Bank of India")
        cmbBank.Items.Add("HDFC")
        cmbBank.Items.Add("ICICI")
        cmbBank.Items.Add("Kotak Mahindra")

        ' Set default selection to avoid NullReferenceException
        If cmbBank.Items.Count > 0 Then
            cmbBank.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBank.SelectedIndexChanged
        If cmbBank.SelectedItem IsNot Nothing Then
            Select Case cmbBank.SelectedItem.ToString()
                Case "State Bank of India"
                    txtInterestRate.Text = "8"
                Case "HDFC"
                    txtInterestRate.Text = "6"
                Case "ICICI"
                    txtInterestRate.Text = "7"
                Case "Kotak Mahindra"
                    txtInterestRate.Text = "6.5"
            End Select
        End If
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        If txtPrincipal.Text = "" Or txtMonths.Text = "" Or cmbBank.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim principal As Double = Convert.ToDouble(txtPrincipal.Text)
        Dim rate As Double = Convert.ToDouble(txtInterestRate.Text) / 12 / 100 ' Monthly interest rate
        Dim months As Integer = Convert.ToInt32(txtMonths.Text)

        ' EMI Calculation
        Dim emi As Double
        If rate = 0 Then
            emi = principal / months ' If interest is 0
        Else
            Dim rPow As Double = Math.Pow(1 + rate, months)
            emi = (principal * rate * rPow) / (rPow - 1)
        End If

        txtEMI.Text = Math.Round(emi, 2).ToString()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtEMI.Text = "" Then
            MessageBox.Show("Please calculate EMI first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If



        Try
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "INSERT INTO EMItable(UserID, Principle_Amount, Interest_Rate, No_Of_Month, Bank_Name, EMI_Amount) 
                                       VALUES (@UserID, @Principal, @InterestRate, @Months, @Bank, @EMI)"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@UserID", SessionData.LoggedInUserID) ' Get user ID from session
                    cmd.Parameters.AddWithValue("@Principal", Convert.ToDouble(txtPrincipal.Text))
                    cmd.Parameters.AddWithValue("@InterestRate", Convert.ToDouble(txtInterestRate.Text))
                    cmd.Parameters.AddWithValue("@Months", Convert.ToInt32(txtMonths.Text))
                    cmd.Parameters.AddWithValue("@Bank", cmbBank.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@EMI", Convert.ToDouble(txtEMI.Text))

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If txtEMI.Text = "" Then
            MessageBox.Show("Please calculate EMI first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
        saveFileDialog.Title = "Export EMI Details"
        saveFileDialog.FileName = "EMI_Calculation.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    writer.WriteLine("EMI Calculation Details")
                    writer.WriteLine("----------------------")
                    writer.WriteLine("User ID: " & SessionData.LoggedInUserID)
                    writer.WriteLine("Bank Name: " & cmbBank.SelectedItem.ToString())
                    writer.WriteLine("Principal Amount: " & txtPrincipal.Text)
                    writer.WriteLine("Interest Rate: " & txtInterestRate.Text & "%")
                    writer.WriteLine("Loan Tenure (Months): " & txtMonths.Text)
                    writer.WriteLine("Monthly EMI: " & txtEMI.Text)
                    writer.WriteLine("----------------------")
                    writer.WriteLine("Exported on: " & DateTime.Now.ToString())
                End Using
                MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New UserDashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPrincipal.Clear()
        txtInterestRate.Clear()
        txtMonths.Clear()
        txtEMI.Clear()


        cmbBank.SelectedIndex = -1

        MessageBox.Show("All inputs have been cleared!", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class


