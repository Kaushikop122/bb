Imports System.Data.SqlClient

Public Class Registerform
    Dim connection As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validate that Email and Password are not empty
        If Emailtxt.Text = "" Or Passwordtxt.Text = "" Then
            MessageBox.Show("Email and Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim command As New SqlCommand("INSERT INTO Usertable (Name, Contact, Email, Password, Username) VALUES (@Name, @Contact, @Email, @Password, @Username)", connection)
            command.Parameters.AddWithValue("@Name", Nametxt.Text)
            command.Parameters.AddWithValue("@Contact", Contacttxt.Text)
            command.Parameters.AddWithValue("@Email", Emailtxt.Text)
            command.Parameters.AddWithValue("@Password", Passwordtxt.Text)
            command.Parameters.AddWithValue("@Username", Usernametxt.Text)

            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally clear fields after registration
            Nametxt.Clear()
            Contacttxt.Clear()
            Emailtxt.Clear()
            Passwordtxt.Clear()
            Usernametxt.Clear()

        Catch ex As Exception
            MessageBox.Show("Error during registration: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



