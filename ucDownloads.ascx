<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDownloads.ascx.vb" Inherits="ucDownloads" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<radA:RadAjaxPanel ID="rapDownloads" runat="server" Width="100%">
<table cellpadding="0" cellspacing="0" width="100%" id="Downloads">
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td style="height: 19px" align="left" class="linecombo">
            &nbsp;
            Selecione a categoria:
            <asp:DropDownList ID="cmbCategorias" runat="server" Width="200px" AutoPostBack="True">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="height: 19px">
            </td>
    </tr>
    <tr>
        <td style="height: 19px">
            <asp:GridView ID="gvDownloads" runat="server" AllowPaging="True" AutoGenerateColumns="False" Width="100%" BorderWidth="0">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="lblDownload" runat="server" Text='<% # DataBinder.Eval(Container.DataItem, "tDownload") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</radA:RadAjaxPanel>
