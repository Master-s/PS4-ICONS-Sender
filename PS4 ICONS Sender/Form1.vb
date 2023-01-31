Imports System.IO
Imports System.Net
Imports System.Collections.Generic
Imports System.IO.Compression
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Public Class Form1
    Inherits Form
    Private dragging As Boolean = False
    Private stratPoint As Point = New Point(0, 0)

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr     ' x-coordinate of upper-left corner
        ' y-coordinate of upper-left corner
        ' x-coordinate of lower-right corner
        ' y-coordinate of lower-right corner
        ' height of ellipse
        ' width of ellipse
    End Function
    Public Sub New()
        InitializeComponent()
        FormBorderStyle = FormBorderStyle.None
        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20))
    End Sub

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
    Private Sub panel3_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel3.MouseDown
        dragging = True
        stratPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub panel3_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel3.MouseUp
        dragging = False
    End Sub

    Private Sub panel3_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Panel3.MouseMove
        If dragging Then

            Dim p = PointToScreen(e.Location)
            Location = New Point(p.X - stratPoint.X, p.Y - stratPoint.Y)
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
