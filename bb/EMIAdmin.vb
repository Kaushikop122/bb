Imports System.Data.SqlClient

Public Class EMIAdmin
    ' Declare connection string at the class level
    Private connectionString As String = "Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True"

    ' Load data from the database into DataGridView when the form loads
    Private Sub EMIAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEMIData()
    End Sub

    ' Function to Load Data into DataGridView
    Private Sub LoadEMIData()
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT EMI_Calculation_id, userid, Principle_Amount, Interest_Rate, No_Of_Month, Bank_Name FROM EMItable"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvEMIRates.DataSource = table ' Bind data to DataGridView
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Loading Data: " & ex.Message)
        End Try
    End Sub

    ' Update Interest Rate when the button is clicked
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if a row is selected
        If dgvEMIRates.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a bank from the table before updating.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve selected bank name
        Dim selectedBank As String = dgvEMIRates.SelectedRows(0).Cells("Bank_Name").Value.ToString()

        ' Ensure the interest rate textbox is not empty
        If String.IsNullOrWhiteSpace(txtInterestRate.Text) Then
            MessageBox.Show("Please enter a valid interest rate.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Try to update the interest rate in the database
        Try
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "UPDATE EMItable SET Interest_Rate = @InterestRate WHERE Bank_Name = @BankName"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@InterestRate", Convert.ToDecimal(txtInterestRate.Text))
                    cmd.Parameters.AddWithValue("@BankName", selectedBank)

                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    conn.Close()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Interest Rate Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadEMIData() ' Refresh DataGridView after update
                    Else
                        MessageBox.Show("Update failed. Please check the bank name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminDashboard.Show()
        Me.Hide()
    End Sub
End Class
