<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVitrineSecoes.ascx.vb" Inherits="ucVitrineSecoes" %>
<asp:DataList ID="dlAreas" runat="server" RepeatColumns="1" RepeatDirection="Vertical">
    <HeaderTemplate>Departamentos</HeaderTemplate>
    <HeaderStyle CssClass="ItensMenuPrincipalSaude" />
    <ItemTemplate>
        <asp:Label ID="lblSecao" runat="server" Text='<% # fRetornaSecao(DataBinder.Eval(Container.DataItem, "cSecao"), DataBinder.Eval(Container.DataItem, "tSecao"), DataBinder.Eval(Container.DataItem, "cDepartamento") ) %>'></asp:Label>
    </ItemTemplate>
</asp:DataList>

