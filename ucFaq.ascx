<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucFaq.ascx.vb" Inherits="ucFaq" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<radA:RadAjaxPanel ID="rapFaq" runat="server" Width="100%">
<table cellpadding="0" cellspacing="0" width="100%" id="Downloads">
    <tr>
        <td style="height: 19px" class="linecombo">
            &nbsp;Pesquisa:
            <asp:TextBox ID="txtPesquisa" runat="server"></asp:TextBox>
            <asp:Button runat="server" ID="cmdPesquisar" Text="Pesquisar" CssClass="btComum" />
        </td>
    </tr>
    <tr>
        <td style="height: 19px">
            <asp:GridView ID="gvFaq" runat="server" AllowPaging="True" AutoGenerateColumns="False" Width="100%" BorderWidth="0">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="lblFaq" runat="server" Text='<% # DataBinder.Eval(Container.DataItem, "tFaq") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            </td>
    </tr>
</table>
</radA:RadAjaxPanel>
