<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMenuArea.ascx.vb" Inherits="ucMenuArea" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="width:200px">
<radP:RadPanelbar 
ID="rpbPadrao" 
runat="server"
ItemCollapsedCssClass="ItemArea"
ItemSelectedCssClass="ItemArea"
ImagesBaseDir="~/App_Themes/Padrao/RadPanelbar/Img/" 
CssFile="~/App_Themes/Padrao/RadPanelbar/Styles/PadraoArea.css" 
Width="200px" 
ItemTextCollapsedCssClass="ItemArea" 
ItemTextDisabledCssClass="ItemArea"
OnPanelItemDataBound="rpbPadrao_OnPanelItemDataBound" 
ItemTextExpandedCssClass="ItemArea" 
FullExpandedPanels="True"
HeaderCollapsedCssClass="HeaderArea" 
HeaderDisabledCssClass="HeaderArea"
HeaderExpandedCssClass="HeaderArea" 
HeaderHoverCollapsedCssClass="HeaderArea" 
HeaderSelectedCssClass="HeaderArea" 
HeaderTextCollapsedCssClass="HeaderArea" 
HeaderTextDisabledCssClass="HeaderArea" 
HeaderHoverExpandedCssClass="HeaderArea" 
HeaderTextExpandedCssClass="HeaderArea"
HeaderTextHoverCollapsedCssClass="HeaderArea"
HeaderTextHoverExpandedCssClass="HeaderArea" 
HeaderTextSelectedCssClass="HeaderArea" ItemDisabledCssClass="ItemArea" 
ItemExpandedCssClass="ItemArea" ItemHoverCollapsedCssClass="ItemArea" 
ItemHoverExpandedCssClass="ItemArea" ItemTextHoverCollapsedCssClass="ItemArea" 
ItemTextHoverExpandedCssClass="ItemArea" ItemTextSelectedCssClass="ItemArea">
</radP:RadPanelbar>
</td>
</tr>
</table>
