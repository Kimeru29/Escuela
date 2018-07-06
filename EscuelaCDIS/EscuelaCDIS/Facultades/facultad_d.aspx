<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_d.aspx.cs" Inherits="EscuelaCDIS.Facultades.facultad_d" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="block" style="margin-top: 20px;">
        <dl class="dl-horizontal centrado">
            <dt>Id</dt>
            <dd>
                <asp:Label ID="lbl_id" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Nombre</dt>
            <dd>
                <asp:Label ID="lbl_nombre" runat="server"></asp:Label>
            </dd>
            <dt>Código</dt>
            <dd>
                <asp:Label ID="lbl_codigo" runat="server"></asp:Label>
            </dd>
            <dt>Fecha de creación</dt>
            <dd>
                <asp:Label ID="lbl_fecha" runat="server"></asp:Label>
            </dd>
            <dt></dt>
            <dd>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClientClick="teste();" OnClick="btnEliminar_Click" />
            </dd>
        </dl>
    </div>

    <script src="../Scripts/bootbox.js"></script>
    <script type="text/javascript">
        function teste() {
            bootbox.alert("Facultad eliminada de manera <b>exitosa</b> </br> <i>El cascade delete debe estar activado</i>");
        }
    </script>

</asp:Content>
