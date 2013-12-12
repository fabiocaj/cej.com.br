<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucpublicidade_main.ascx.vb" Inherits="ucpublicidade_main" %>

<%--<img src="layout/mundialline/images/referencia.gif" height="120" width="280" />--%>
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
                <asp:Label ID="lblDestaqueBanner" Text='<%# DataBinder.Eval(Container.DataItem, "tDestaqueBanner") %>' runat="server"></asp:Label>
            </ItemTemplate>
        </asp:DataList>
            <radA:RadAjaxTimer ID="ratDestaqueBanner" runat="server" Interval="5000" />
        </radA:RadAjaxPanel>
        </td>
    </tr>
</table>
<asp:Label ID="lblPonteiro" runat="server"></asp:Label>