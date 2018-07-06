<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_i.aspx.cs" Inherits="EscuelaCDIS.Facultades.facultad_i" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="block" style="margin-top: 20px;">
        <table class="centrado">
            <tr>
                <td>Nombre</td>
                <td>
                    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Código</td>
                <td>
                    <asp:TextBox ID="txt_codigo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fecha de creación</td>
                <td>
                    <asp:TextBox ID="txt_fecha" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClientClick="return teste();" OnClick="btnGuardar_Click" />
                </td>
            </tr>
        </table>
    </div>

    <script src="../Scripts/bootbox.js"></script>
    <script type="text/javascript">
        function teste() {
            bootbox.alert("Facultad agregada de manera <b>exitosa</b>");
        }
    </script>
</asp:Content>
