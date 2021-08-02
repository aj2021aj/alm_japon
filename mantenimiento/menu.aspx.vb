Public Class menu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_mantenimiento_Click(sender As Object, e As EventArgs) Handles btn_mantenimiento.Click
        Response.Redirect("mantenimiento.aspx")
    End Sub

    Protected Sub btn_registro_Click(sender As Object, e As EventArgs) Handles btn_registro.Click
        Response.Redirect("registro.aspx")
    End Sub

    Protected Sub bnt_regresar_Click(sender As Object, e As EventArgs) Handles bnt_regresar.Click

        Response.Redirect("~/login/login.aspx")
    End Sub
End Class