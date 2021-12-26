Imports System
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Threading
Imports System.Net
Imports System.Text
Public Class Form1
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.Dispose()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Coded By MonsterMc :)", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information + vbSystemModal, ":)")

        Try
            Me.Dispose()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Me.Text = "No-ip Updater V" & My.Application.Info.Version.ToString
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Task.Run(New Action(Sub()
                                Updeter()
                            End Sub))
    End Sub
    Private Sub Updeter()
        Try
            Dim x As HttpWebRequest = HttpWebRequest.CreateHttp(New Uri("http://dynupdate.no-ip.com/nic/update?hostname=" & Me.Host.Text & "&myip=" & Me.IP.Text))
            x.UseDefaultCredentials = True
            x.Credentials = New NetworkCredential(Me.Useremail.Text, Me.Senha.Text)
            x.GetResponse()
            x.Abort()
            MsgBox("Sucess!", MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Information + vbSystemModal, "Sucess")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Critical + vbSystemModal, "Erro")
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked Then
            Me.Senha.PasswordChar = "*"
        Else
            Me.Senha.PasswordChar = Nothing
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked Then
            Me.Host.PasswordChar = "*"
        Else
            Me.Host.PasswordChar = Nothing
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) 
        If Me.CheckBox1.Checked Then
            Me.Senha.PasswordChar = "*"
        Else
            Me.Senha.PasswordChar = Nothing
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
        If Me.CheckBox2.Checked Then
            Me.Host.PasswordChar = "*"
        Else
            Me.Host.PasswordChar = Nothing
        End If
    End Sub
End Class
