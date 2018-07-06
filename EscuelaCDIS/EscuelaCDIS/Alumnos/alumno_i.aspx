<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="alumno_i.aspx.cs" Inherits="EscuelaCDIS.Alumnos.alumno_i" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="block" style="margin-top: 20px;">
        <table class="centrado">
            <tr>
                <td>Matrícula</td>
                <td>
                    <asp:TextBox ID="txt_matricula" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Nombre</td>
                <td>
                    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fecha de nacimiento</td>
                <td>
                    <asp:TextBox ID="txt_fecha" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Semestre</td>
                <td>
                    <asp:TextBox ID="txt_semestre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Facultad</td>
                <td>
                    <asp:TextBox ID="txt_facultad" runat="server"></asp:TextBox>
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
            bootbox.alert("Alumno agregado de manera <b>exitosa</b>");
        }
    </script>
</asp:Content>
