Imports System.Data.SqlClient
Imports System.IO

Public Class EmergencyFundForm
    Private connectionString As String = "Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True"
    Private LoggedInUserID As Integer

    ' Constructor to receive User ID
    Public Sub New(userID As Integer)
        InitializeComponent()
        LoggedInUserID = userID
    End Sub

    ' Form Load Event
    Private Sub EmergencyFundForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMonths.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        cmbMonths.SelectedIndex = 2 ' Default: 3 months
    End Sub

    ' Calculate Emergency Fund
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If txtExpenses.Text = "" Or cmbMonths.SelectedIndex = -1 Then
            MessageBox.Show("Enter expenses and select months!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim expenses As Decimal = Convert.ToDecimal(txtExpenses.Text)
        Dim months As Integer = Convert.ToInt32(cmbMonths.SelectedItem)
        Dim emergencyFund As Decimal = expenses * months

        txtEmergencyFund.Text = emergencyFund.ToString("0.00")
    End Sub

    ' Save Data to Database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtEmergencyFund.Text = "" Then
            MessageBox.Show("Calculate the emergency fund first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO EmergencyFundtable (UserID, Expenses, Months, EmergencyFund) VALUES (@UserID, @Expenses, @Months, @EmergencyFund)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@UserID", LoggedInUserID)
            cmd.Parameters.AddWithValue("@Expenses", Convert.ToDecimal(txtExpenses.Text))
            cmd.Parameters.AddWithValue("@Months", Convert.ToInt32(cmbMonths.SelectedItem))
            cmd.Parameters.AddWithValue("@EmergencyFund", Convert.ToDecimal(txtEmergencyFund.Text))

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As SqlException
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Export Data to Text File
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim saveFile As New SaveFileDialog()
        saveFile.Filter = "Text Files (*.txt)|*.txt"
        If saveFile.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(saveFile.FileName, $"User ID: {LoggedInUserID}{vbCrLf}Expenses: {txtExpenses.Text}{vbCrLf}Months: {cmbMonths.SelectedItem}{vbCrLf}Emergency Fund: {txtEmergencyFund.Text}")
            MessageBox.Show("Data Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Reset Fields
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtExpenses.Clear()
        cmbMonths.SelectedIndex = -1
        txtEmergencyFund.Clear()
    End Sub

    ' Close Form (Optional: Adjust Navigation as needed)
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New UserDashboard
        dashboard.Show()
        Me.Hide()
    End Sub
End Class
