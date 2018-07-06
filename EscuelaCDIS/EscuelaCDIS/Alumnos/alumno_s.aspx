<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="alumno_s.aspx.cs" Inherits="EscuelaCDIS.Alumnos.alumno_s" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="block" style="margin-top:20px;">
        <div class="centrado">
            <asp:GridView ID="grd_alumnos" runat="server" AutoGenerateColumns="false" CellPadding="7" ForeColor="#333333" GridLines="None" OnRowCommand="grd_alumnos_RowCommand">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" HorizontalAlign="Center" />
                <Columns>
                    <asp:BoundField HeaderText="Matrícula" DataField="matricula" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField HeaderText="Nombre" DataField="nombre" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="fechaNacimiento" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField HeaderText="Semestre" DataField="semestre" ItemStyle-HorizontalAlign="Center"/>
                    <asp:BoundField HeaderText="Facultad" DataField="facultad" ItemStyle-HorizontalAlign="Center"/>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Content/img/ico_editar.png" CommandName="Editar" CommandArgument='<%# Eval("matricula") %>' Height="20px" Width="20px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/Content/img/ico_eliminar.png" CommandName="Eliminar" CommandArgument='<%# Eval("matricula") %>' Height="20px" Width="20px" />
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
            <asp:Button ID="btnAgregar" runat="server" Text="Registrar alumno" OnClick="btnAgregar_Click"/>
        </div>
    </div>


</asp:Content>
