<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDownloadsArtigo.ascx.vb" Inherits="ucDownloadsArtigo" %>
<table cellpadding="0" cellspacing="0" width="100%" id="Downloads">
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