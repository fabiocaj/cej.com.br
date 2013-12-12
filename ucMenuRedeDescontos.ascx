<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMenuRedeDescontos.ascx.vb" Inherits="ucMenuRedeDescontos" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="width: 100px">
<img src="app_themes/RedeDescontos/RadPanelbar/Img/fundoescdescontos.jpg" /></td>
</tr>
<tr>
<td style="width: 100px">
<radP:RadPanelbar 
ID="rpbRedeDescontos" 
runat="server"
ItemCollapsedCssClass="panelbarItemRedeDescontos"
ItemSelectedCssClass="ItensMenuRedeDescontos"
ImagesBaseDir="~/App_Themes/RedeDescontos/RadPanelbar/Img/" 
CssFile="~/App_Themes/RedeDescontos/RadPanelbar/Styles/RedeDescontos.css" 
Width="161px" 
ItemTextCollapsedCssClass="ItensMenuRedeDescontos" 
ItemTextDisabledCssClass="ItensMenuRedeDescontos"
OnPanelItemDataBound="rpbRedeDescontos_OnPanelItemDataBound"
ItemTextExpandedCssClass="ItensMenuRedeDescontos" 
FullExpandedPanels="True"    
HeaderCollapsedCssClass="ItensMenuPrincipalRedeDescontos" 
HeaderDisabledCssClass="ItensMenuPrincipalRedeDescontos"
HeaderExpandedCssClass="ItensMenuPrincipalRedeDescontos" 
HeaderHoverCollapsedCssClass="ItensMenuPrincipalRedeDescontos" 
HeaderHoverExpandedCssClass="ItensMenuPrincipalRedeDescontos" 
HeaderSelectedCssClass="ItensMenuPrincipalRedeDescontos" 
HeaderTextCollapsedCssClass="ItensMenuPrincipalRedeDescontos" 
HeaderTextDisabledCssClass="ItensMenuPrincipalRedeDescontos" 
HeaderTextExpandedCssClass="ItensMenuPrincipalRedeDescontos" 
HeaderTextHoverCollapsedCssClass="ItensMenuPrincipalRedeDescontos"
>

<%--<PanelItems>
<radP:PanelItem  runat="server" Expanded="True" Text="Rede" ImagePosition="Left" ItemTextExpandedCssClass="ItensMenuPrincipalRedeDescontos">
<radP:PanelItem  runat="server" Text="New Item">
</radP:PanelItem>
<radP:PanelItem runat="server" Text="New Item">
</radP:PanelItem>
</radP:PanelItem>
</PanelItems>--%>
</radP:RadPanelbar>
</td>
</tr>
</table>
