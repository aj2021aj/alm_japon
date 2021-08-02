<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="menu.aspx.vb" Inherits="alm_japon.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Style/style_menu.css" rel="stylesheet" />
<head runat="server">
    <title>MENÚ DE SISTEMA</title>
    <header><h1> MENÚ DE SISTEMAS</h1> </header>
</head>
<body>
    <form id="form_menu" runat="server">
   
        <center>

   
         <div class="d_menu">
       
        <asp:Button ID="btn_registro" runat="server" Text="Nuevo Registro" />
      
        <br />
        <br />
            
        <asp:Button ID="btn_mantenimiento" runat="server" Text="Mantenimientos" />

           <br />
        <br />
            
        <asp:Button ID="bnt_regresar" runat="server" Text="Regresar" />
    </div>
        </center>
    </form>
</body>
</html>
