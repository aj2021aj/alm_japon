Imports System.Math
Imports System.Random
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Net
Imports System.Net.Mail
Imports System.Text






Public Class login
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub initializeSmptClient(correo_rec As String, contra_aux As String)
        Dim auxiliar As String = contra_aux
        Dim correo As String = correo_rec
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
            mailMessage.Body = "<h1>Buen día empleado tu contraseña auxiliar:  </h1>" & auxiliar
            mailMessage.Priority = MailPriority.Normal
            mailMessage.To.Add(correo)
            mailMessage.IsBodyHtml = True
            smtpClient.Send(mailMessage)

        Catch ex As Exception
        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()
        End Try

    End Sub


    Protected Sub btn_recuperar_Click(sender As Object, e As EventArgs) Handles btn_recuperar.Click


            txtcontra.Visible = False
            lblcontra.Visible = False
            btn_enviar.Visible = True
            btn_ingresar.Visible = False
        btn_recuperar.Visible = False


    End Sub
    'Contraseña Auxiliar para cambio de contraseña
    Dim rnd As New Random
    Dim contra_aux As Int32 = rnd.Next()
    Protected Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click

        ''Contraseña Auxiliar para cambio de contraseña
        'Dim rnd As New Random
        'Dim contra_aux As Int32 = rnd.Next()
        ''txtcorreo.Text = dbl1


        txtcontra.Visible = True
            txtcontra_aux.Visible = True


            Dim conecta As String = System.Configuration.ConfigurationManager.ConnectionStrings("japon").ConnectionString
            Dim conexion As New SqlConnection(conecta)
            conexion.Open()
        Dim actualizar_Dato As New SqlCommand("update usuarios set  contra_aux  = ('" & contra_aux & "')  where correo_usuario = ('" & txtcorreo.Text & "')", conexion)
        Dim cantidad As Integer = actualizar_Dato.ExecuteNonQuery()



        If cantidad = 1 Then
            'ENVIO CONTRASEÑA AUXILIAR
            initializeSmptClient(txtcorreo.Text, contra_aux)
            lblmensajecontra.Text = "Al correo: " & txtcorreo.Text & " se ha enviado la nueva contraseña para que puedas actualizarla."

        Else
            lblmensajecontra.Text = "Error al actualizar..."
        End If

        lblcontra.Visible = True
            lblcontra_aux.Visible = False
            btn_ingresar.Visible = False
            btn_recuperar.Visible = True
            btn_enviar.Visible = False
            btn_actualizar.Visible = True
        lblcontra_aux.Visible = True

    End Sub
    Public Sub actualizar_contra()
        Dim conecta As String = System.Configuration.ConfigurationManager.ConnectionStrings("japon").ConnectionString
        Dim conexion As New SqlConnection(conecta)
        conexion.Open()
        Dim actualizar_Dato As New SqlCommand("update usuarios set  contra_usuario  = ('" & txtcontra.Text & "')  where correo_usuario = ('" & txtcorreo.Text & "')", conexion)
        Dim cantidad As Integer = actualizar_Dato.ExecuteNonQuery()
        If cantidad = 1 Then
            lblmensajecontra2.Text = "Contraseña actualizada, ingresar Credencial Nuevamente..."

            btn_ingresar.Visible = True
            btn_recuperar.Visible = True
            btn_actualizar.Visible = False
            lblcontra_aux.Visible = False

            txtcontra_aux.Visible = False

            lblmensajecontra.Text = ""
            txtcorreo.Text = ""
            txtcontra.Text = ""
            txtcontra_aux.Text = ""


        Else
            lblmensajecontra2.Text = "Error..."

        End If
    End Sub

    Protected Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        'OBTENER CONTRASEÑA AUX DE BASE DE DATOS
        Dim val_contra_aux As Integer
        Dim conecta As String = System.Configuration.ConfigurationManager.ConnectionStrings("japon").ConnectionString
        Dim conexion As New SqlConnection(conecta)
        conexion.Open()

        Dim buscar_dato As New SqlCommand("select contra_aux from usuarios where correo_usuario = ('" & txtcorreo.Text & "')", conexion)

        Dim datos As SqlDataReader = buscar_dato.ExecuteReader()
        If datos.Read() Then
            val_contra_aux = datos("contra_aux")
        Else
            lblmensajecontra.Text = "ERROR"
        End If


        'VALICACION DE CONTRASEÑA AUXILIAR
        If Convert.ToInt32(txtcontra_aux.Text) = val_contra_aux Then
            actualizar_contra()
            lblmensajecontra.Text = "Contraseña auxiliar coincide, cambio realizado..."
        Else
            lblmensajecontra.Text = "Contraseña auxiliar no coincide, verificar..."
        End If


    End Sub

    Protected Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        ' Response.Redirect("~/mantenimiento/menu.aspx")
        'INICIO DE SESION DE BASE DE DATOS
        Dim contrabd As String = ""
        Dim correobd As String = ""

        Dim conecta As String = System.Configuration.ConfigurationManager.ConnectionStrings("japon").ConnectionString
        Dim conexion As New SqlConnection(conecta)
        conexion.Open()

        Dim buscar_dato As New SqlCommand("select correo_usuario,contra_usuario from usuarios where correo_usuario = ('" & txtcorreo.Text & "')", conexion)

        Dim datos As SqlDataReader = buscar_dato.ExecuteReader()
        If datos.Read() Then
            correobd = datos("correo_usuario")
            contrabd = datos("contra_usuario")
        Else
            lblmensajecontra.Text = "ERROR"
        End If

        'Dim correobd2 As String = Convert.ToString(correobd)
        'Dim contrabd2 As String = Convert.ToString(contrabd)

        'Dim correotxt As String = Convert.ToString(txtcorreo.Text.Trim)
        'Dim contratxt As String = Convert.ToString(txtcontra.Text.Trim)

        ' VALICACION DE USUARIO 
        If (txtcorreo.Text.Equals(correobd.Trim())) And (txtcontra.Text.Equals(contrabd.Trim())) Then
            lblmensajecontra.Text = "CREDENCIALES CORRECTAS"
            Response.Redirect("~/mantenimiento/menu.aspx")
        Else
            lblmensajecontra.Text = "CORREO/CONTRASEÑA INCORRECTA"
        End If


    End Sub
End Class