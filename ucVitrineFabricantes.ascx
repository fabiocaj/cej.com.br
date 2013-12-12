<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVitrineFabricantes.ascx.vb" Inherits="ucVitrineFabricantes" %>


    <tr>
        <td>
<asp:DataList ID="dlAreas" runat="server" RepeatColumns="1" RepeatDirection="Vertical" 
           Width="161px">
     <HeaderTemplate>Fabricantes</HeaderTemplate>
    <HeaderStyle CssClass="ItensMenuPrincipalSaude" />
    <ItemTemplate>
            <asp:Label ID="lblFabricante" CssClass="ItensMenuSaudeD" runat="server" Text='<% # fRetornaFabricante(DataBinder.Eval(Container.DataItem, "cFabricante"), DataBinder.Eval(Container.DataItem, "tFabricante"), DataBinder.Eval(Container.DataItem, "cDepartamento"), DataBinder.Eval(Container.DataItem, "cSecao") ) %>'></asp:Label>
    </ItemTemplate>
</asp:DataList>


        </td>
    </tr>




