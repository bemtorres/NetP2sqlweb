<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioEmpleado.aspx.cs" Inherits="CapaPresentacion.FormularioEmpleado" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>
                    Rut:
                </td>
                <td>
                    <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Digito Verificador:
                </td>
                <td>
                    <asp:TextBox ID="txtDv" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Nombres</td>
                <td>
                    <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Apellidos</td>
                <td class="style1">
                    <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Empresa</td>
                <td>
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                        SelectMethod="GenerarListado" TypeName="CapaNegocio.EmpresaColeccion">
                    </asp:ObjectDataSource>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                        DataSourceID="ObjectDataSource1" DataTextField="RazonSocial" 
                        DataValueField="Rut">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </div>
    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" 
        onclick="btnAgregar_Click" />
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
        onclick="btnBuscar_Click" />
    <asp:Button ID="btnModificar" runat="server" Text="Modificar" 
        onclick="btnModificar_Click" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" 
        onclick="btnEliminar_Click" />
    <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
