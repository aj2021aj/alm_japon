Imports System.Net
Imports System.Net.Mail
Imports System.Text

Public Class correo1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        initializeSmptClient()
    End Sub

    Public Sub initializeSmptClient()
        Dim auxiliar As String = "prueba de contraseña"

        Dim smtpClient As SmtpClient
        'Dim senderMail As String
        'Dim password As String
        'Dim host As String
        'Dim port As Integer

        smtpClient = New SmtpClient
        smtpClient.Credentials = New NetworkCredential("recuperarcontraj@gmail.com", "Julio+2021")
        smtpClient.Host = "smtp.gmail.com"
        smtpClient.Port = 587
        smtpClient.EnableSsl = True

        Dim mailMessage As MailMessage = New MailMessage

        Try
            mailMessage.From = New MailAddress("recuperarcontraj@gmail.com")
            mailMessage.Subject = "Recuperación de Contraseña"
            mailMessage.Body = "<h1>Buen día empleado tu contraseña auxiliar es:  </h1>" & auxiliar
            mailMessage.Priority = MailPriority.Normal
            mailMessage.To.Add("anagbc96@gmail.com")
            mailMessage.IsBodyHtml = True
            smtpClient.Send(mailMessage)

        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()
        End Try

    End Sub





End Class

