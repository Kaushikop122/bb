Imports System.Data.SqlClient

Public Class Adminform1
    Dim con As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            con.Open()
            Dim query As String = "SELECT COUNT(*) FROM AdminTable WHERE Username=@Username AND Password=@Password"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@Username", txtAdminUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtAdminPassword.Text)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                AdminDashboard.Show() ' Open Admin Panel if login is successful
            Else
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Adminform1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userlogin.Show()
        Me.Hide()
    End Sub
End Class