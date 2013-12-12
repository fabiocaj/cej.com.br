<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucRedeDescontos.ascx.vb" Inherits="ucRedeDescontos" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
&nbsp;<table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td style="width: 100px">
            <img src="app_themes/Saude/RadPanelbar/Img/fundoescdescontos.jpg" /></td>
    </tr>
    <tr>
        <td style="width: 100px">
<radP:RadPanelbar ID="rpbDescontos" runat="server"
ItemCollapsedCssClass="panelbarItemSaude"
ItemSelectedCssClass="ItensMenuSaude"
ImagesBaseDir="~/App_Themes/Saude/RadPanelbar/Img/" 
CatalogIconImageUrl="" DataPath="" Description="" Title="" TitleIconImageUrl="" TitleUrl="" 
CssFile="~/App_Themes/Saude/RadPanelbar/Styles/Saude.css" Width="161px" ItemTextCollapsedCssClass="ItensMenuSaude" ItemTextDisabledCssClass="ItensMenuSaude" ItemTextExpandedCssClass="ItensMenuSaude" ItemTextHoverCollapsedCssClass="ItensMenuSaude" ItemTextHoverExpandedCssClass="ItensMenuSaude" ItemTextSelectedCssClass="ItensMenuSaude">
<PanelItems>
    <radP:PanelItem ID="PanelItem1" runat="server" Expanded="True" Text="Carro" ImagePosition="Left" ItemTextExpandedCssClass="ItensMenuPrincipalSaude">
        <radP:PanelItem ID="PanelItem2" runat="server" Text="New Item">
        </radP:PanelItem>
        <radP:PanelItem ID="PanelItem3" runat="server" Text="New Item">
        </radP:PanelItem>
    </radP:PanelItem>
    <radP:PanelItem runat="server" Text="Avi&#227;o">
        <radP:PanelItem runat="server" Text="New Item">
        </radP:PanelItem>
        <radP:PanelItem runat="server" Text="New Item">
        </radP:PanelItem>
    </radP:PanelItem>
</PanelItems>
</radP:RadPanelbar>
        </td>
    </tr>
</table>
