<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMenuPadrao.ascx.vb"
    Inherits="ucMenuPadrao" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<%@ Register Assembly="RadMenu.Net2" Namespace="Telerik.WebControls" TagPrefix="radM" %>
<table cellpadding="0" cellspacing="0" border="0" align=right >
    <tr>
        <td style="vertical-align:bottom; padding-top:11px" >
            <radM:RadMenu ID="rpbPadrao" runat="server" BorderWidth="0" BorderStyle="None" CollapseDelay="200"
                Skin="Default" SkinID="Default" SkinsPath="RadControls/Menu/Skins">
                <CollapseAnimation Duration="100" />
            </radM:RadMenu>
        </td>
    </tr>
</table>
