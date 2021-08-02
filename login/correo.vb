Imports System.Net
Imports System.Net.Mail
Imports System.Text


Public Class correo

    'Public MustInherit Class MasterEmailServer
    '    '//Atributos'
    '    Private smtpClient As SmtpClient
    '    Protected senderMail As String
    '    Protected password As String
    '    Protected host As String
    '    Protected port As Integer

    Protected ssl As Boolean
    Public Sub initializeSmptClient()

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
            mailMessage.Body = "<h1>Buen día, empleado tu contraseña auxiliar:  <h1/>"
            mailMessage.Priority = MailPriority.Normal
            mailMessage.To.Add("ricardobautistagil95@gmail.com")
            smtpClient.Send(mailMessage)

        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()
        End Try

    End Sub

    'End Class
End Class
