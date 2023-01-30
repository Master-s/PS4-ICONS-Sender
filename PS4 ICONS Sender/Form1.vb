Imports System.IO
Imports System.Net
Imports System.Collections.Generic
Imports System.IO.Compression
Imports System.ComponentModel
Public Class Form1

    Private Sub ipbox_TextChanged(sender As Object, e As EventArgs) Handles ipbox.TextChanged

    End Sub
    Private Sub ipbox_Click(sender As Object, e As EventArgs) Handles ipbox.Click

    End Sub
    'portbox
    Private Sub portbox_TextChanged(sender As Object, e As EventArgs) Handles ipbox.TextChanged

    End Sub
    Private Sub portbox_Click(sender As Object, e As EventArgs) Handles ipbox.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.IP = "" Then
        Else
            ipbox.Text = My.Settings.IP
        End If
    End Sub

    Private Sub BuFolder_Click(sender As Object, e As EventArgs) Handles BuFolder.Click
        Process.Start("ICONS")
    End Sub

    Sub sendICONS()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/ICONS")

            Dim ftp As New FTP("", "")
            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & ipbox.Text & ":" & portbox.Text & "/data/ICONS/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & ipbox.Text & ":" & portbox.Text & "/data/ICONS/" & fi.Name)
                ElseIf File.Exists("ftp://" & ipbox.Text & ":" & portbox.Text & "/data/ICONS/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & ipbox.Text & ":" & portbox.Text & "/data/ICONS/" & fi.Name)
                End If

            Next

            MsgBox(" Default !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BuSend_Click(sender As Object, e As EventArgs) Handles BuSend.Click
        Dim overwrite = MessageBox.Show("Do you want to overwrite the existing custom?", "ICONS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        If overwrite = DialogResult.No Then

        ElseIf ow = DialogResult.Yes Then

        ElseIf ipbox.Text = "IP Here" Or ipbox.Text = "" Then
            MsgBox("Please enter a IP", MsgBoxStyle.Critical)
        Else
            My.Settings.IP = ipbox.Text
            Me.UseWaitCursor = True
            sendICONS()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ipbox.Text = "IP Here" Or ipbox.Text = "" Then
            MsgBox("Please enter a IP", MsgBoxStyle.Critical)
            My.Settings.IP = ipbox.Text
        Else
            Process.Start("explorer.exe", "ftp://" & ipbox.Text & ":" & portbox.Text & "/data/ICONS/")
        End If
    End Sub
End Class
