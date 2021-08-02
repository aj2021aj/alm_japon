<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="mantenimiento.aspx.vb" Inherits="alm_japon.mantenimiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Style/style_mantenimiento.css" rel="stylesheet" />
<head runat="server">
    <title>MANTENIMIENTOS</title>
</head>
    <nav> <h1> MANTENIMIENTO DE SISTEMAS </h1></nav>
<body>

    <form id="form_mantenimiento" runat="server">
       <center>
          <div>

    <table style="1">
          <thead class="thead-light">
            <tr>
                <th>DPI</th>
                <th>NOMBRE</th>
            </tr>

            <tr>
                <td class="auto-style2">
                   <asp:TextBox ID="txtdpi" runat="server" Width="250px" TextMode="Number"></asp:TextBox> 
                <td class="auto-style2"> 
                    <asp:TextBox ID="txtnombre" runat="server" Width="250px" Enabled="False" ></asp:TextBox> 
               </td> 
            </tr>
                </thead>
        </table>       
        
        <table style="1">
            <tr>
                <th>HIJOS</th>
                <th>SALARIO BASE</th>
            </tr>

            <tr>
                <td class="auto-style2">
                   <asp:TextBox ID="txthijos" runat="server" Width="250px" TextMode="Number" Enabled="False"></asp:TextBox> 
                <td class="auto-style2"> 
                    <asp:TextBox ID="txtsalario" runat="server" Width="250px" Enabled="False" ></asp:TextBox> 
                
               </td> 
                    <br />

            </tr>
        
                                
        </table>  
         <br />
        <br /> 
        <table>
            <tr>
                <th><asp:Button ID="btn_buscar" runat="server" Text="BUSCAR" />  </th>
                  <th><asp:Button ID="btn_modificar" runat="server" Text="MODIFICAR" />  </th>
                <th><asp:Button ID="btn_actualizar" runat="server" Text="ACTUALIZAR" Visible="False" />  </th> 
                 <th><asp:Button ID="btn_cancelar" runat="server" Text="CANCELAR" Visible="False" />  </th>           
                 <th><asp:Button ID="btn_eliminar" runat="server" Text="ELIMINAR" />  </th>
            </tr>
          
            
        </table> 
         
           <br />
        <br />
         <asp:Label ID="lblbuscar" runat="server" Text="--"></asp:Label>
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
        <asp:Button ID="bnt_regresar" runat="server" Text="REGRESAR" />
        <br />

      
    </div>
              

        </center>
    </form>
</body>
</html>
