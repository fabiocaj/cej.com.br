<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucpublicidadel.ascx.vb" Inherits="ucpublicidadel" %>
<%@ Register Assembly="RadRotator.Net2" Namespace="Telerik.WebControls" TagPrefix="radR" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
&nbsp;<table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td>
            <img src="layout/mundialline/images/titpublicidade.gif" />
        </td>
    </tr>
    <tr>
        <td>
            <radA:RadAjaxPanel ID="RadAjaxPanel1" runat="server">
                <asp:DataList ID="dlPublicidade" runat="server">
                    <ItemTemplate>                    
                        <%--<table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td height="8">
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 100px" align="left">
                                    <img src="layout/mundialline/images/referencia.gif" style="width: 190px; height: 67px" />
                                </td>
                            </tr>
                        </table>--%>
                        <div>
                            <%=fExibirPublicidades()%>                           
                        </div>
                   </ItemTemplate>
                </asp:DataList>
                <asp:Label ID="lblQtdPublicidade" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="lblwCount" runat="server" Visible="false"></asp:Label>               
                <asp:Label ID="lblItens" runat="server" Visible="false"></asp:Label>
                <asp:Label ID="lblPublicidades" runat="server" Visible="false"></asp:Label>
               <radA:RadAjaxTimer ID="rjtTimer"
                    runat="server" Interval="4000" />
            </radA:RadAjaxPanel>
        </td>
    </tr>
</table>
