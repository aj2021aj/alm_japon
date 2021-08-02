Imports System.Data.SqlClient
Imports System.Linq
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System




Public Class registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Dim dpi As Integer
    Dim nombre As String
    Dim hijos As Integer
    Dim salario_base As Decimal
    Dim bono_decreto = 250
    Dim creacion = Date.Today
    Dim creacion2 As String = "11/02/2021"
    Dim iggs As Decimal
    Dim irtra As Decimal
    Dim bono_paternidad As Integer
    Dim salario_total As Decimal
    Dim salario_liquido As Decimal




    Protected Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

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
        Dim insertar As New SqlCommand("insert into Empleados (dpi_emp,nombre_emp,hijos_emp,salariobase_emp,bono_emp,creacion_emp,iggs_emp,irtra_emp,bonopater_emp,salario_total_emp,salario_liquido_emp) values ('" & dpi & "','" & nombre & "','" & hijos & "','" & salario_base & "','" & bono_decreto & "','" & creacion & "','" & iggs & "','" & irtra & "','" & bono_paternidad & "','" & salario_total & "','" & salario_liquido & "')", conexion)
        insertar.ExecuteNonQuery()
        lblguardar.Text = "Empleado Registrado"
        conexion.Close()


        btn_limpiar.Visible = True


        btn_guardar.Visible = False
    End Sub

    Protected Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        lblbonomonto.Text = ""
        lbliggsmonto.Text = ""
        lblirtramonto.Text = ""
        lblpaternidadbono.Text = ""
        lblsalariototalmonto.Text = ""
        lblsalarioliquidomonto.Text = ""
        lblguardar.Text = ""

        txtdpi.Text = ""
        txtnombre.Text = ""
        txthijos.Text = ""
        txtsalario.Text = ""
        btn_guardar.Visible = True
        btn_limpiar.Visible = False
    End Sub

    Protected Sub btn_Regresarmenu_Click(sender As Object, e As EventArgs) Handles btn_Regresarmenu.Click
        Response.Redirect("menu.aspx")
    End Sub
End Class