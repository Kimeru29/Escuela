<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="alumno_d.aspx.cs" Inherits="EscuelaCDIS.Alumnos.alumno_d" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="block" style="margin-top: 20px;">
        <dl class="dl-horizontal centrado">
            <dt>Matrícula</dt>
            <dd>
                <asp:Label ID="lbl_matricula" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Nombre</dt>
            <dd>
                <asp:Label ID="lbl_nombre" runat="server"></asp:Label>
            </dd>
            <dt>Fecha de nacimiento</dt>
            <dd>
                <asp:Label ID="lbl_fecha" runat="server"></asp:Label>
            </dd>
            <dt>Semestre</dt>
            <dd>
                <asp:Label ID="lbl_semestre" runat="server"></asp:Label>
            </dd>
            <dt>Facultad</dt>
            <dd>
                <asp:Label ID="lbl_facultad" runat="server"></asp:Label>
            </dd>
            <dt></dt>
            <dd>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClientClick=" return teste();" OnClick="btnEliminar_Click" />
            </dd>
        </dl>
    </div>

    <script src="../Scripts/bootbox.js"></script>
    <script type="text/javascript">
        function teste() {
            bootbox.alert("Alumno eliminado de manera <b>exitosa</b>");
        }
    </script>

</asp:Content >
