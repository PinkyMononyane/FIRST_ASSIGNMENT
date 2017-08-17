Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class CLUBMEMBERS


    Dim Gender As String
    Private Sub CLUBMEMBERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim sConnectionString As String _
            = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGSD\Desktop\ASSIGNMENT\ClubMembers\ClubMembers\ClubMembersDB.mdf;Integrated Security=True"
        Dim objConn As New SqlConnection(sConnectionString)
        Try
            objConn.Open()
        Catch ex As Exception
            MessageBox.Show("Failed!")
        End Try

        Try
            Dim querystr As String = "SELECT ID_NUMBER FROM MEMBERS WHERE ID_NUMBER = '" & Id_Number.Text & "' "
            Dim mycmd As New SqlCommand(querystr, objConn)
            Dim Result As Object = mycmd.ExecuteScalar()

            MId.Text = Result.ToString

            querystr = "SELECT NAME FROM MEMBERS WHERE ID_NUMBER = '" & Id_Number.Text & "' "
            mycmd = New SqlCommand(querystr, objConn)
            Result = mycmd.ExecuteScalar()
            MName.Text = Result.ToString

            querystr = "SELECT LASTNAME FROM MEMBERS WHERE ID_NUMBER = '" & Id_Number.Text & "' "
            mycmd = New SqlCommand(querystr, objConn)
            Result = mycmd.ExecuteScalar()
            MLname.Text = Result.ToString

            querystr = "SELECT DATE_OF_BIRTH FROM MEMBERS WHERE ID_NUMBER = '" & Id_Number.Text & "' "
            mycmd = New SqlCommand(querystr, objConn)
            Result = mycmd.ExecuteScalar()

            MDob.Text = Result.ToString

            querystr = "SELECT AGE FROM MEMBERS WHERE ID_NUMBER = '" & Id_Number.Text & "' "
            mycmd = New SqlCommand(querystr, objConn)
            Result = mycmd.ExecuteScalar()

            Mage.Text = Result.ToString

            querystr = "SELECT GENDER FROM MEMBERS WHERE ID_NUMBER = '" & Id_Number.Text & "' "
            mycmd = New SqlCommand(querystr, objConn)
            Result = mycmd.ExecuteScalar()



            If Result.ToString.Contains("Female") Then

                Male.Checked = False
                Female.Checked = True
            Else
                Female.Checked = False
                Male.Checked = True
            End If

            querystr = "SELECT JOIN_DATE FROM MEMBERS WHERE ID_NUMBER = '" & Id_Number.Text & "' "
            mycmd = New SqlCommand(querystr, objConn)
            Result = mycmd.ExecuteScalar()

            RDATE.Text = Result.ToString

        Catch ex As Exception

            MessageBox.Show("MEMBER :" + Id_Number.Text + " Does Not Exist In Our Data Base")

        End Try


    End Sub

    Private Sub UPDATE_Click(sender As Object, e As EventArgs) Handles UPDATE.Click
        Dim sConnectionString As String _
            = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGSD\Desktop\ASSIGNMENT\ClubMembers\ClubMembers\ClubMembersDB.mdf;Integrated Security=True"
        Dim objConn As New SqlConnection(sConnectionString)
        Try
            objConn.Open()
        Catch ex As Exception
            MessageBox.Show("Failed!")
        End Try

        Dim sSQL As String = "UPDATE MEMBERS  SET NAME ='" & MName.Text & "' , LASTNAME = '" & MLname.Text & "', DATE_OF_BIRTH = '" & MDob.Text & "', GENDER  = '" & Gender & "', AGE = '" & Mage.Text & "' , ID_NUMBER = '" & MId.Text & "' WHERE ID_NUMBER = '" & Id_Number.Text & "' "
        Dim objCmd As New SqlCommand(sSQL, objConn)

        Try
            objCmd.ExecuteNonQuery()
            MessageBox.Show("SAVED")
        Catch ey As Exception
            MessageBox.Show("Failed To Save Data")
        End Try

        objConn.Close()

    End Sub

    Private Sub Male_CheckedChanged(sender As Object, e As EventArgs) Handles Male.CheckedChanged
        Female.Checked = False
        'Male.Checked = True
        Gender = "Male"
    End Sub

    Private Sub Female_CheckedChanged(sender As Object, e As EventArgs) Handles Female.CheckedChanged
        Male.Checked = False
        'Female.Checked = True
        Gender = "Female"
    End Sub

    Private Sub MDob_ValueChanged(sender As Object, e As EventArgs) Handles MDob.ValueChanged

        Dim Year = MDob.Value.ToString("yyyy")
        Mage.Text = Date.Today.Year - Year
    End Sub

    Private Sub DELETE_RECORD_Click(sender As Object, e As EventArgs) Handles DELETE_RECORD.Click
        Dim sConnectionString As String _
    = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGSD\Desktop\ASSIGNMENT\ClubMembers\ClubMembers\ClubMembersDB.mdf;Integrated Security=True"
        Dim objConn As New SqlConnection(sConnectionString)
        Try
            objConn.Open()
        Catch ex As Exception
            MessageBox.Show("Failed!")
        End Try

        Dim sSQL As String = "DELETE FROM MEMBERS WHERE ID_NUMBER ='" & Id_Number.Text & "'"
        Dim objCmd As New SqlCommand(sSQL, objConn)
        Try
            objCmd.ExecuteNonQuery()

            If (Id_Number.Text = "") Then
                MessageBox.Show("PLEASE KEY IN A VALID ID")
            Else
                MessageBox.Show("RECORD " + Id_Number.Text + "Has Been DELETED")
            End If




            MId.Text = ""
            MName.Text = ""
            MLname.Text = ""

            MDob.ResetText()
            Mage.Text = ""
            Male.Checked = False
            Female.Checked = False

            RDATE.Text = ""
            Id_Number.Text = ""
            Id_Number.Focus()



        Catch ey As Exception
            MessageBox.Show("Failed To DELETE RECORD")
        End Try

        objConn.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        MId.Text = ""
        MName.Text = ""
        MLname.Text = ""

        MDob.ResetText()
        Mage.Text = ""
        Male.Checked = False
        Female.Checked = False

        RDATE.Text = ""
        Id_Number.Text = ""
        Id_Number.Focus()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim sConnectionString As String _
           = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGSD\Desktop\ASSIGNMENT\ClubMembers\ClubMembers\ClubMembersDB.mdf;Integrated Security=True"
        Dim objConn As New SqlConnection(sConnectionString)
        Try
            objConn.Open()
        Catch ex As Exception
            MessageBox.Show("Failed!")
        End Try

        Dim sSQL As String = "UPDATE MEMBERS  SET NAME ='" & MName.Text & "' , LASTNAME = '" & MLname.Text & "', DATE_OF_BIRTH = '" & MDob.Text & "', GENDER  = '" & Gender & "', AGE = '" & Mage.Text & "' , ID_NUMBER = '" & MId.Text & "' WHERE ID_NUMBER = '" & Id_Number.Text & "' "
        Dim objCmd As New SqlCommand(sSQL, objConn)

        Try
            objCmd.ExecuteNonQuery()
            MessageBox.Show("SAVED")
        Catch ey As Exception
            MessageBox.Show("Failed To Save Data")
        End Try

        objConn.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Me.Close()

        SIGNUP.Show()

    End Sub
End Class