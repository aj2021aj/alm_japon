Imports System.Data.SqlClient
Imports System.Linq
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System


Public Class mantenimiento
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Dim buscar As Integer
    Dim dpi As Integer
    Dim nombre As String
    Dim hijos As Integer
    Dim salario_base As Decimal
    Dim bono_decreto = 250
    Dim creacion = Date.Now
    Dim creacion2 As String = "11/02/2021"
    Dim iggs As Decimal
    Dim irtra As Decimal
    Dim bono_paternidad As Integer
    Dim salario_total As Decimal
    Dim salario_liquido As Decimal

    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        'Dim buscar As Integer
        buscar = Convert.ToInt32(txtdpi.Text)


        Dim conecta As String = System.Configuration.ConfigurationManager.ConnectionStrings("japon").ConnectionString
        Dim conexion As New SqlConnection(conecta)
        conexion.Open()

        Dim buscar_dato As New SqlCommand("select dpi_emp,nombre_emp,hijos_emp,salariobase_emp,bono_emp,iggs_emp,irtra_emp,bonopater_emp,salario_total_emp,salario_liquido_emp from Empleados where dpi_emp = ('" & buscar & "')", conexion)

        Dim datos As SqlDataReader = buscar_dato.ExecuteReader()
        If datos.Read() Then
            txtnombre.Text = datos("nombre_emp")
            txthijos.Text = datos("hijos_emp")
            txtsalario.Text = datos("salariobase_emp")
            lblbonomonto.Text = datos("bono_emp")
            lbliggsmonto.Text = datos("iggs_emp")
            lblirtramonto.Text = datos("irtra_emp")
            lblpaternidadbono.Text = datos("bonopater_emp")
            lblsalariototalmonto.Text = datos("salario_total_emp")
            lblsalarioliquidomonto.Text = datos("salario_liquido_emp")

        Else
            lblbuscar.Text = "Empleado no encontrado... verificar DPI"

            lblbonomonto.Text = ""
            lbliggsmonto.Text = ""
            lblirtramonto.Text = ""
            lblpaternidadbono.Text = ""
            lblsalariototalmonto.Text = ""
            lblsalarioliquidomonto.Text = ""

            txtnombre.Text = ""
            txthijos.Text = ""
            txtsalario.Text = ""
        End If



    End Sub

    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        buscar = Convert.ToInt32(txtdpi.Text)

        Dim conecta As String = System.Configuration.ConfigurationManager.ConnectionStrings("japon").ConnectionString
        Dim conexion As New SqlConnection(conecta)
        conexion.Open()

        Dim eliminar_Dato As New SqlCommand("delete from Empleados where dpi_emp = ('" & buscar & "')", conexion)

        'Dim datos As SqlDataReader = eliminar_Dato.ExecuteReader()
        Dim cantidad As Integer = eliminar_Dato.ExecuteNonQuery()
        If cantidad = 1 Then
            lblbuscar.Text = "El No.de DPI seleccionado ha sido eliminado..."
        Else
            lblbuscar.Text = "Error al eliminar registro..."
        End If



        txtnombre.Enabled = False
        txthijos.Enabled = False
        txtsalario.Enabled = False


        lblbonomonto.Text = ""
        lbliggsmonto.Text = ""
        lblirtramonto.Text = ""
        lblpaternidadbono.Text = ""
        lblsalariototalmonto.Text = ""
        lblsalarioliquidomonto.Text = ""

        txtnombre.Text = ""
        txthijos.Text = ""
        txtsalario.Text = ""

    End Sub

    Protected Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click



        btn_actualizar.Visible = True

        txtnombre.Enabled = True
        txthijos.Enabled = True
        txtsalario.Enabled = True

        btn_modificar.Visible = False
        btn_buscar.Visible = False
        btn_eliminar.Visible = False
        btn_cancelar.Visible = True
    End Sub

    Protected Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click


        dpi = Convert.ToInt32(txtdpi.Text)
        nombre = txtnombre.Text
        hijos = txthijos.Text
        salario_base = txtsalario.Text


        'CALCULO DE IGGS
        iggs = salario_base * 0.0483

        'CALCULO DE IRTRA
        irtra = salario_base * 0.01

        'CALCULO DE BONO DE PATERNIDAD
        bono_paternidad = 133 * hijos

        'CALCULO DE SALARIO TOTAL
        salario_total = salario_base + bono_paternidad + bono_decreto

        'CALCULO DE SALARIO LIQUIDO
        salario_liquido = salario_total - iggs - irtra


        'RESULTADOS 
        lblbonomonto.Text = bono_decreto
        lbliggsmonto.Text = iggs
        lblirtramonto.Text = irtra
        lblpaternidadbono.Text = bono_paternidad
        lblsalariototalmonto.Text = salario_total
        lblsalarioliquidomonto.Text = salario_liquido

        Dim conecta As String = System.Configuration.ConfigurationManager.ConnectionStrings("japon").ConnectionString
        Dim conexion As New SqlConnection(conecta)
        conexion.Open()
        Dim actualizar_Dato As New SqlCommand("update Empleados set  dpi_emp  = ('" & dpi & "') ,nombre_emp = ('" & nombre & "'), hijos_emp = ('" & hijos & "'),salariobase_emp  = ('" & salario_base & "'),bono_emp = ('" & bono_decreto & "'), iggs_emp = ('" & iggs & "'),irtra_emp = ('" & irtra & "'),bonopater_emp = ('" & bono_paternidad & "'),salario_total_emp = ('" & salario_total & "'),salario_liquido_emp = ('" & salario_liquido & "') where dpi_emp = ('" & dpi & "')", conexion)
        Dim cantidad As Integer = actualizar_Dato.ExecuteNonQuery()

        If cantidad = 1 Then
            lblbuscar.Text = "Registro actualizado..."
        Else
            lblbuscar.Text = "Error al actualizar..."
        End If


        btn_actualizar.Visible = False
        txtnombre.Enabled = False
        txthijos.Enabled = False
        txtsalario.Enabled = False

        btn_modificar.Visible = True
        btn_buscar.Visible = True
        btn_eliminar.Visible = True
        btn_cancelar.Visible = False


        txtnombre.Enabled = False
        txthijos.Enabled = False
        txtsalario.Enabled = False


        lblbonomonto.Text = ""
        lbliggsmonto.Text = ""
        lblirtramonto.Text = ""
        lblpaternidadbono.Text = ""
        lblsalariototalmonto.Text = ""
        lblsalarioliquidomonto.Text = ""


        txtnombre.Text = ""
        txthijos.Text = ""
        txtsalario.Text = ""
    End Sub

    Protected Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        btn_modificar.Visible = True
        btn_buscar.Visible = True
        btn_eliminar.Visible = True

        btn_actualizar.Visible = False
        btn_cancelar.Visible = False

        txtnombre.Enabled = False
        txthijos.Enabled = False
        txtsalario.Enabled = False
    End Sub

    Protected Sub bnt_regresar_Click(sender As Object, e As EventArgs) Handles bnt_regresar.Click
        Response.Redirect("menu.aspx")
    End Sub
End Class