<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="registro.aspx.vb" Inherits="alm_japon.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Style/style_registro.css" rel="stylesheet" />
<head runat="server">
    <title>REGISTRO</title>
   <nav><h1> REGISTRO DE EMPLEADOS    </h1></nav>
    <style type="text/css">
        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
    
<body>
   
    <form id="form_registro" runat="server">
    <div>
        <center>

  
        <table style="1">
            <tr>
                <th>DPI</th>
                <th>NOMBRE</th>
            </tr>

            <tr>
                <td class="auto-style2">
                   <asp:TextBox ID="txtdpi" runat="server" Width="250px"></asp:TextBox> 
                <td class="auto-style2"> 
                    <asp:TextBox ID="txtnombre" runat="server" Width="250px" ></asp:TextBox> 
               </td> 
            </tr>
        </table>       
        
        <table style="1">
            <tr>
                <th>HIJOS</th>
                <th>SALARIO BASE</th>
            </tr>

            <tr>
                <td class="auto-style2">
                   <asp:TextBox ID="txthijos" runat="server" Width="250px" TextMode="Number"></asp:TextBox> 
                <td class="auto-style2"> 
                    <asp:TextBox ID="txtsalario" runat="server" Width="250px" ></asp:TextBox> 
                
               </td> 
            </tr>
        
                                
        </table>   
        <br />
        <br />
             <br />
         <asp:Label ID="lblguardar" runat="server" Text="--"></asp:Label>
        <br />
        <br />
        <br />


        <asp:Label ID="lblbono" runat="server" Text="Bono Decreto:"></asp:Label>
         <asp:Label ID="lblbonomonto" runat="server" Text="--"></asp:Label>
        <br />
        <br />
            <asp:Label ID="lbligss" runat="server" Text="IGGS: "></asp:Label>
         <asp:Label ID="lbliggsmonto" runat="server" Text="--"></asp:Label>
        <br />
        <br />
            <asp:Label ID="lblirtra" runat="server" Text="IRTRA:"></asp:Label>
         <asp:Label ID="lblirtramonto" runat="server" Text="--"></asp:Label>
        <br />
        <br />
         <asp:Label ID="lblpaternidad" runat="server" Text="Bono de Paternidad:"></asp:Label>
         <asp:Label ID="lblpaternidadbono" runat="server" Text="--"></asp:Label>
        <br />
        <br />
            <asp:Label ID="lblsalariototal" runat="server" Text="Salario Total:"></asp:Label>
         <asp:Label ID="lblsalariototalmonto" runat="server" Text="--"></asp:Label>
        <br />
        <br />
           <asp:Label ID="lblsalarioliquido" runat="server" Text="Salario Líquido:"></asp:Label>
         <asp:Label ID="lblsalarioliquidomonto" runat="server" Text="--"></asp:Label>
        <br />
        <br />

       <asp:Button ID="btn_guardar" runat="server" Text="GUARDAR" />
        <asp:Button ID="btn_limpiar" runat="server" Text="NUEVO" Visible = "False" />
          <asp:Button ID="btn_Regresarmenu" runat="server" Text="REGRESAR" />
              <br />
        <br />

      
              </center>

    </div>

    </form>
</body>
</html>
