<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_u.aspx.cs" Inherits="EscuelaCDIS.Facultades.facultad_u" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="block" style="margin-top: 20px;">
        <dl class="dl-horizontal centrado">
            <dt>Id</dt>
            <dd>
                <asp:Label ID="lbl_id" runat="server" Text="Label"></asp:Label>
            </dd>
            <dt>Nombre</dt>
            <dd>
                <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
            </dd>
            <dt>Código</dt>
            <dd>
                <asp:TextBox ID="txt_codigo" runat="server"></asp:TextBox>
            </dd>
            <dt>Fecha de creación</dt>
            <dd>
                <asp:TextBox ID="txt_fecha" runat="server"></asp:TextBox>
            </dd>
            <dt></dt>
            <dd>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClientClick="teste();" OnClick="btnGuardar_Click" />
            </dd>
        </dl>
    </div>

    <script src="../Scripts/bootbox.js"></script>
    <script type="text/javascript">
        function teste() {
            bootbox.alert("Facultad modificada de manera <b>exitosa</b>");
        }
    </script>

</asp:Content>
