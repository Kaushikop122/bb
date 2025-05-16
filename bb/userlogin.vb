Imports System.Data.SqlClient

Public Class userlogin
    Dim connectionString As String = "Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmail.Text = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Please enter Email and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("SELECT userid FROM Usertable WHERE Email = @Email AND Password = @Password", conn)

        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        conn.Open()

        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            ' Store the logged-in user ID
            LoggedInUserID = Convert.ToInt32(reader("userid"))

            ' ✅ Debugging Message: Check if the UserID is correctly set
            MessageBox.Show("Login Successful! User ID Set: " & LoggedInUserID)

            If reader.HasRows Then
                While reader.Read()
                    LoggedInUserID = reader("UserID") ' ✅ Store logged-in user ID globally
                End While
                reader.Close()

                ' ✅ Open Dashboard only once
                Dim dashboard As New userdashboard()
                dashboard.Show()
                'userdashboard.Show()

                Me.Hide()
                LoggedInUserEmail = txtEmail.Text
                LoggedInUserPassword = txtPassword.Text
            Else
                MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        conn.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Registerform.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Adminform1.Show()
        Me.Hide()
    End Sub
End Class