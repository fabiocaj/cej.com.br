<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMenuSaude.ascx.vb" Inherits="ucMenuSaude" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="width: 100px">
<img src="app_themes/Saude/RadPanelbar/Img/fundoescsaude.jpg" /></td>
</tr>
<tr>
<td style="width: 100px">



<radP:RadPanelbar 
ID="rpbSaude" 
runat="server"
ItemCollapsedCssClass="panelbarItemSaude"
ItemSelectedCssClass="ItensMenuSaude"
ImagesBaseDir="~/App_Themes/Saude/RadPanelbar/Img/" 
CssFile="~/App_Themes/Saude/RadPanelbar/Styles/Saude.css" 
Width="161px" 
ItemTextCollapsedCssClass="ItensMenuSaude" 
ItemTextDisabledCssClass="ItensMenuSaude"
OnPanelItemDataBound="rpbSaude_OnPanelItemDataBound" 
ItemTextExpandedCssClass="ItensMenuSaude" 
FullExpandedPanels="True"
HeaderCollapsedCssClass="ItensMenuPrincipalSaude" 
HeaderDisabledCssClass="ItensMenuPrincipalSaude"
HeaderExpandedCssClass="ItensMenuPrincipalSaude" 
HeaderHoverCollapsedCssClass="ItensMenuPrincipalSaude" 
HeaderHoverExpandedCssClass="ItensMenuPrincipalSaude" 
HeaderSelectedCssClass="ItensMenuPrincipalSaude" 
HeaderTextCollapsedCssClass="ItensMenuPrincipalSaude" 
HeaderTextDisabledCssClass="ItensMenuPrincipalSaude" 
HeaderTextExpandedCssClass="ItensMenuPrincipalSaude" 
HeaderTextHoverCollapsedCssClass="ItensMenuPrincipalSaude">
</radP:RadPanelbar>
</td>
</tr>
</table>
