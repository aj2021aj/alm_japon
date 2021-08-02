<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="alm_japon.login" %>

<!DOCTYPE html>
<link href="style_login.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
    <nav>
      <h1> INGRESO DE SISTEMAS</h1> 
         </nav>
<body>

    <form class="form_login" runat="server">
   
        <center>
     

    <div class ="datos_login">
        
         <table class ="tbl_datos">
            <tr>
                <th>CORREO ELECTRÓNICO</th>
                <th><asp:Label runat ="server" id ="lblcontra">CONTRASEÑA</asp:Label  ></th>
                <th><asp:Label runat ="server" Visible ="false" ID ="lblcontra_aux">CONTRASEÑA AUXILIAR</asp:Label  ></th>
            </tr>

            <tr>
                <td class="auto-style2">
                   <asp:TextBox ID="txtcorreo" runat="server" Width="250px"></asp:TextBox> 
                <td class="auto-style2"> 
                    <asp:TextBox ID="txtcontra" runat="server" Width="250px" ></asp:TextBox> 
               </td> 
                    <td class="auto-style2"> 
                    <asp:TextBox ID="txtcontra_aux" runat="server" Width="250px"  Visible ="false"></asp:TextBox> 
               </td> 
            </tr>
           

        </table>      
       <asp:Button ID="btn_ingresar" runat="server" Text="INGRESAR" />
        <asp:Button ID="btn_actualizar" runat="server" Text="ACTUALIZAR CONTRASEÑA" Visible="False" />
        <asp:Button ID="btn_recuperar" runat="server" Text="RECUPERA CONTRASEÑA" />
        <asp:Button ID="btn_enviar" runat="server" Text="OBTENER CONTRASEÑA" Visible ="False"/>

        <br />
        <br />

        <asp:Label ID="lblmensajecontra" runat="server" Text="--"></asp:Label>
        <asp:Label ID="lblmensajecontra2" runat="server" Text="--"></asp:Label>

    </div>

      
         
          </center>
    </form>
</body>
</html>
