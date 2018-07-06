<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="facultad_s.aspx.cs" Inherits="EscuelaCDIS.Facultades.facultad_s" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="block">
        <div class="centrado" style="margin-top: 20px; width: 500px;">
            <asp:GridView ID="grd_facultades" runat="server" AutoGenerateColumns="false" CellPadding="7" ForeColor="#333333" GridLines="None" OnRowCommand="grd_facultades_RowCommand">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="id_facultad" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField HeaderText="Código" DataField="codigo" ItemStyle-HorizontalAlign="Center" />
                    <asp:BoundField HeaderText="Fecha Creación" DataField="fechaCreacion" ItemStyle-HorizontalAlign="Center" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Content/img/ico_editar.png" CommandName="Editar" CommandArgument='<%# Eval("id_facultad") %>' Height="20px" Width="20px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/Content/img/ico_eliminar.png" CommandName="Eliminar" CommandArgument='<%# Eval("id_facultad") %>' Height="20px" Width="20px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:Button ID="btnAgregar" runat="server" Text="Registrar facultad" OnClick="btnGuardar_Click"/>
        </div>
    </div>


</asp:Content>
