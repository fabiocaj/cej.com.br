<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPainel.ascx.vb" Inherits="ucPainel" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<radP:RadPanelbar 
    ID="rpbPainel" 
    runat="server"
    CssFile="~/Panelbar/Examples/Programming/DataBinding/Panelbar.css"
    HeaderExpandedCssClass="panelbarHeaderExpand"
    HeaderCollapsedCssClass="panelbarHeaderCollapsed"
    HeaderHoverCollapsedCssClass="panelbarHeaderHover"
    HeaderHoverExpandedCssClass="panelbarHeaderHover"
    ItemCollapsedCssClass="panelbarItem"
    ItemDisabledCssClass="panelbarItemDisabled"
    ItemHoverCollapsedCssClass="panelbarItemHover"
    Width="200px"
    HeaderImagePosition="Right"
    ImagesBaseDir="~/Panelbar/Examples/Programming/DataBinding/Img/"
    OnPanelItemDataBound="rpbPainel_OnPanelItemDataBound">
</radP:RadPanelbar>
