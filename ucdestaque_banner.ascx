<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucdestaque_banner.ascx.vb" Inherits="ucdestaque_banner" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>

<table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td>            
        </td>
    </tr>
    <tr>
        <td>
        <radA:RadAjaxPanel ID="rapDestaqueBanner" runat="server">
        <asp:DataList ID="dlPublicidades" runat="server">
            <ItemTemplate>
                <asp:Label ID="lblDestaqueBanner" Text='<%# DataBinder.Eval(Container.DataItem, "tHalfBanner") %>' runat="server"></asp:Label>
            </ItemTemplate>
        </asp:DataList>
            <asp:Label ID="lblControle" runat="server" Text="0" Visible=false></asp:Label>
            <radA:RadAjaxTimer ID="ratDestaqueBanner" runat="server" Interval="3000" />
        </radA:RadAjaxPanel>
        </td>
    </tr>
</table>