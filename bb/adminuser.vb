Imports System.Data.SqlClient

Public Class adminuser
    Dim con As New SqlConnection("Data Source=NITRO5\MSSQLSERVER01;Initial Catalog=BudgetBud;Integrated Security=True;TrustServerCertificate=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        Try
            con.Open()
            da = New SqlDataAdapter("SELECT UserID, Name, Contact, Email, Username FROM Usertable", con)
            dt = New DataTable()
            da.Fill(dt)
            dgvUsers.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim userID As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("UserID").Value)

            ' Ensure the connection is closed before opening it
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            ' First, delete related records in EMItable
            Dim deleteEMIQuery As String = "DELETE FROM EMItable WHERE UserID=@UserID"
            Dim cmdDeleteEMI As New SqlCommand(deleteEMIQuery, con)
            cmdDeleteEMI.Parameters.AddWithValue("@UserID", userID)
            cmdDeleteEMI.ExecuteNonQuery()

            ' Then, delete the user from Usertable
            Dim deleteUserQuery As String = "DELETE FROM Usertable WHERE UserID=@UserID"
            Dim cmdDeleteUser As New SqlCommand(deleteUserQuery, con)
            cmdDeleteUser.Parameters.AddWithValue("@UserID", userID)
            cmdDeleteUser.ExecuteNonQuery()

            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUserData() ' Refresh DataGridView

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure connection is properly closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        Try
            If dgvUsers.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvUsers.SelectedRows(0)
                Dim userID As Integer = selectedRow.Cells("UserID").Value ' Get UserID from DataGridView

                con.Open()
                cmd = New SqlCommand("DELETE FROM Usertable WHERE UserID=@UserID", con)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.ExecuteNonQuery()

                MessageBox.Show("User deleted successfully")
                LoadUserData()
            Else
                MessageBox.Show("Please select a user from the table to delete.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            If dgvUsers.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvUsers.SelectedRows(0)
                Dim userID As Integer = selectedRow.Cells("UserID").Value
                Dim newName As String = selectedRow.Cells("Name").Value.ToString()
                Dim newContact As String = selectedRow.Cells("Contact").Value.ToString()
                Dim newEmail As String = selectedRow.Cells("Email").Value.ToString()
                Dim newUsername As String = selectedRow.Cells("Username").Value.ToString()

                ' Open database connection
                con.Open()

                ' Check if data has changed before updating
                Dim checkQuery As String = "SELECT Name, Contact, Email, Username FROM Usertable WHERE UserID=@UserID"
                Dim checkCmd As New SqlCommand(checkQuery, con)
                checkCmd.Parameters.AddWithValue("@UserID", userID)

                Dim reader As SqlDataReader = checkCmd.ExecuteReader()
                Dim oldName, oldContact, oldEmail, oldUsername As String

                If reader.Read() Then
                    oldName = reader("Name").ToString()
                    oldContact = reader("Contact").ToString()
                    oldEmail = reader("Email").ToString()
                    oldUsername = reader("Username").ToString()
                Else
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    con.Close()
                    Exit Sub
                End If
                reader.Close()

                ' Check if any value has changed
                If oldName = newName AndAlso oldContact = newContact AndAlso oldEmail = newEmail AndAlso oldUsername = newUsername Then
                    MessageBox.Show("No changes detected.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con.Close()
                    Exit Sub
                End If

                ' Update the user details
                Dim updateQuery As String = "UPDATE Usertable SET Name=@Name, Contact=@Contact, Email=@Email, Username=@Username WHERE UserID=@UserID"
                Dim cmd As New SqlCommand(updateQuery, con)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.Parameters.AddWithValue("@Name", newName)
                cmd.Parameters.AddWithValue("@Contact", newContact)
                cmd.Parameters.AddWithValue("@Email", newEmail)
                cmd.Parameters.AddWithValue("@Username", newUsername)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadUserData()
                Else
                    MessageBox.Show("Update failed. No changes were made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please select a user from the table to update.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminDashboard.Show()
        Me.Hide()
    End Sub
End Class