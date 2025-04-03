Imports System.Data.SqlClient
Imports System.IO

Public Class Debttoincome
    Dim conn As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")
    Dim currentUserID As Integer  ' Store UserID from login form

    ' Constructor to receive UserID from Login Form
    Public Sub New(userID As Integer)
        InitializeComponent()
        currentUserID = userID  ' Assign UserID
    End Sub

    ' Calculate DTI Ratio
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim income As Decimal
        Dim debt As Decimal

        If Decimal.TryParse(txtIncome.Text, income) AndAlso Decimal.TryParse(txtDebt.Text, debt) Then
            If income > 0 Then
                Dim dti As Decimal = (debt / income) * 100
                lblResult.Text = "DTI Ratio: " & dti.ToString("F2") & "%"
            Else
                MessageBox.Show("Income must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Save Data to SQL Database (UserID is Auto-Recorded)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim income As Decimal = Convert.ToDecimal(txtIncome.Text)
            Dim debt As Decimal = Convert.ToDecimal(txtDebt.Text)
            Dim dti As Decimal = (debt / income) * 100

            Dim query As String = "INSERT INTO DebtIncomeTable (UserID, MonthlyIncome, MonthlyDebt, DTI) VALUES (@UserID, @Income, @Debt, @DTI)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@UserID", currentUserID)  ' Use Logged-In User's ID
            cmd.Parameters.AddWithValue("@Income", income)
            cmd.Parameters.AddWithValue("@Debt", debt)
            cmd.Parameters.AddWithValue("@DTI", dti)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Export Data to Text File
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            Dim saveFileDialog As New SaveFileDialog With {
                .Filter = "Text Files|*.txt",
                .Title = "Export DTI Calculation"
            }

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    writer.WriteLine("Debt-to-Income Ratio Calculation")
                    writer.WriteLine("---------------------------------")
                    writer.WriteLine("Monthly Income: " & txtIncome.Text)
                    writer.WriteLine("Monthly Debt: " & txtDebt.Text)
                    writer.WriteLine(lblResult.Text)

                    writer.WriteLine("UserID: " & currentUserID)
                End Using
                MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New UserDashboard
        dashboard.Show()
        Me.Hide()
    End Sub
End Class