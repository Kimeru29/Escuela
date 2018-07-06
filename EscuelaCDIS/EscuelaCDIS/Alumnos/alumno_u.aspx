<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="alumno_u.aspx.cs" Inherits="EscuelaCDIS.Alumnos.alumno_u" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="block" style="margin-top: 20px;">
        <dl class="dl-horizontal centrado">
                <dt>Matrícula</dt>
                <dd>
                    <asp:Label ID="lbl_matricula" runat="server" Text="Label"></asp:Label>
                </dd>
                <dt>Nombre</dt>
                <dd>
                    <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
                </dd>
                <dt>Fecha de nacimiento</dt>
                <dd>
                    <asp:TextBox ID="txt_fecha" runat="server"></asp:TextBox>
                </dd>
                <dt>Semestre</dt>
                <dd>
                    <asp:TextBox ID="txt_semestre" runat="server"></asp:TextBox>
                </dd>
                <dt>Facultad</dt>
                <dd>
                    <asp:TextBox ID="txt_facultad" runat="server"></asp:TextBox>
                </dd>
                <dt></dt>
                <dd>
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClientClick="return teste();" OnClick="btnGuardar_Click"/>
                </dd>
        </dl>
    </div>

    <script src="../Scripts/bootbox.js"></script>
    <script type="text/javascript">
    function teste() {
        bootbox.alert("Alumno modificado de manera <b>exitosa</b>");
    }
</script>
</asp:Content>


