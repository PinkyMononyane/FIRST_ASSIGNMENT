Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class SIGNUP

    Dim Gender As String
    Private Sub SIGNUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OUR CONNECTION 
        'Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGSD\Desktop\ASSIGNMENT\ClubMembers\ClubMembers\ClubMembersDB.mdf;Integrated Security=True

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Connection

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

    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click


        Dim sConnectionString As String _
            = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DGSD\Desktop\ASSIGNMENT\ClubMembers\ClubMembers\ClubMembersDB.mdf;Integrated Security=True"
        Dim objConn As New SqlConnection(sConnectionString)
        Try
            objConn.Open()
        Catch ex As Exception
            MessageBox.Show("Failed!")
        End Try

        Dim sSQL As String = "INSERT INTO MEMBERS (NAME, LASTNAME, DATE_OF_BIRTH, GENDER, AGE, JOIN_DATE, ID_NUMBER) VALUES ( '" & MName.Text & "','" & MLname.Text & "','" & MDob.Text & "','" & Gender & "','" & Mage.Text & "','" & Date.Today & "','" & MId.Text & "')"
        Dim objCmd As New SqlCommand(sSQL, objConn)

        Try
            objCmd.ExecuteNonQuery()
            MessageBox.Show("SAVED")
        Catch ey As Exception

            If ey.ToString.Contains("duplicate") Then
                MessageBox.Show("Failed To Save Data Record Already Exist")
            ElseIf (ey.ToString.Contains("varchar")) Then
                MessageBox.Show("ID Number Cannot Contain any Character")
            Else

                MessageBox.Show("Failed To Save Data Due To AN UNKNOWN ERROR")
            End If

        End Try

        objConn.Close()


    End Sub

    Private Sub PREVIEW_Click(sender As Object, e As EventArgs) Handles PREVIEW.Click

        Pbox.Text = "WELCOME TO MEMBERS CLUB V1.0" & vbCrLf


        Pbox.Text &= "MEMBER NAME: " + MName.Text + vbCrLf + "SURNAME: " + MLname.Text + vbCrLf + "DATE OF BIRTH: " + MDob.Value.ToString + vbCrLf
        Pbox.Text += "AGE: " + Mage.Text + vbCrLf



    End Sub

    Private Sub MDob_ValueChanged(sender As Object, e As EventArgs) Handles MDob.ValueChanged


        Dim Year = MDob.Value.ToString("yyyy")
        Mage.Text = Date.Today.Year - Year

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

        Dim sSQL As String = "INSERT INTO MEMBERS (NAME, LASTNAME, DATE_OF_BIRTH, GENDER, AGE, JOIN_DATE, ID_NUMBER) VALUES ( '" & MName.Text & "','" & MLname.Text & "','" & MDob.Text & "','" & Gender & "','" & Mage.Text & "','" & Date.Today & "','" & MId.Text & "')"
        Dim objCmd As New SqlCommand(sSQL, objConn)

        Try
            objCmd.ExecuteNonQuery()
            MessageBox.Show("SAVED")
        Catch ey As Exception

            If ey.ToString.Contains("dublicate") Then
                MessageBox.Show("Failed To Save Data Record Already Exist")
            Else
                MessageBox.Show("Failed To Save Data Due To AN UNKNOWN ERROR   ")
            End If

        End Try

        objConn.Close()


    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Hide()
        CLUBMEMBERS.Show()




    End Sub

    Private Sub CLEAR_Click(sender As Object, e As EventArgs) Handles CLEAR.Click

        MId.Text = ""
        MName.Text = ""
        MLname.Text = ""

        MDob.ResetText()
        Mage.Text = ""
        Male.Checked = False
        Female.Checked = False
        MId.Focus()


        Pbox.Text = ""

    End Sub
End Class