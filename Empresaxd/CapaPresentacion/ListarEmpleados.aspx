<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarEmpleados.aspx.cs" Inherits="CapaPresentacion.ListarEmpleados" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Rut" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" >
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
                <asp:BoundField DataField="Dv" HeaderText="Dv" SortExpression="Dv" />
                <asp:BoundField DataField="Nombres" HeaderText="Nombres" 
                    SortExpression="Nombres" />
                <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" 
                    SortExpression="Apellidos" />
                <asp:BoundField DataField="Empresa" HeaderText="Empresa" 
                    SortExpression="Empresa" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Has Seleccionado: "></asp:Label>
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        <br />

    </div>
    </form>
</body>
</html>
