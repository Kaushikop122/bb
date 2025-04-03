Imports System.Data.SqlClient

Public Class userlogin
    Dim connection As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")

    ' Event to fetch UserID when email is entered
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Try
            Dim command As New SqlCommand("SELECT UserID FROM Usertable WHERE Email = @Email", connection)
            command.Parameters.AddWithValue("@Email", txtEmail.Text)

            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            cmbuserid.Items.Clear()

            While reader.Read()
                cmbuserid.Items.Add(reader("UserID").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error fetching UserID: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Event to verify login when user clicks Login button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim command As New SqlCommand("SELECT COUNT(*) FROM Usertable WHERE UserID = @UserID AND Password = @Password", connection)
            command.Parameters.AddWithValue("@UserID", cmbuserid.Text)
            command.Parameters.AddWithValue("@Password", txtPassword.Text)

            connection.Open()
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login Successful!")
                ' Redirect to dashboard
                Dim dashboard As New UserDashboard
                dashboard.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid UserID or Password.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Registerform.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Adminform1.Show()
        Me.Hide()
    End Sub

    Private Sub userlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        q
    End Sub
End Class
