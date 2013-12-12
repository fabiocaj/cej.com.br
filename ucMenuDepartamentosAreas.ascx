<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMenuDepartamentosAreas.ascx.vb" Inherits="ucMenuDepartamentosAreas" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>

<radP:RadPanelbar 
ID="rpbDepartamentosAreas" 
runat="server"
ItemCollapsedCssClass="panelbarItemSaude"
ItemSelectedCssClass="ItensMenuSaude"
ImagesBaseDir="~/App_Themes/Saude/RadPanelbar/Img/" 
CssFile="~/App_Themes/Saude/RadPanelbar/Styles/Saude.css" 
Width="161px" 
ItemTextCollapsedCssClass="ItensMenuSaude" 
ItemTextDisabledCssClass="ItensMenuSaude"
OnPanelItemDataBound="rpbPadrao_OnPanelItemDataBound" 
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
