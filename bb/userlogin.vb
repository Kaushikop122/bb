Imports System.Data.SqlClient

Public Class userlogin
    Dim connectionString As String = "Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmail.Text = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Please enter Email and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                Dim query As String = "SELECT UserID FROM Usertable WHERE Email=@Email AND Password=@Password"
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim userID As String = reader("UserID").ToString()
                    reader.Close()

                    ' Store UserID in a session variable
                    LoggedInUserID = userID

                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open the next form (Dashboard or Main Application)
                    Dim dashboard As New UserDashboard()
                    dashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid Email or Password. Try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message)
        End Try
    End Sub

    ' Event to fetch UserID when email is entered
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Try
            Dim conn As New SqlConnection(connectionString)
            Dim command As New SqlCommand("SELECT UserID FROM Usertable WHERE Email = @Email", conn)
            command.Parameters.AddWithValue("@Email", txtEmail.Text)

            conn.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            cmbuserid.Items.Clear()

            While reader.Read()
                cmbuserid.Items.Add(reader("UserID").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error fetching UserID: " & ex.Message)
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

    End Sub
End Class
