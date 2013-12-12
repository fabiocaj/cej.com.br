<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVitrineDepartamentos.ascx.vb" Inherits="ucVitrineDepartamentos" %>
<table id="" width="160px" cellpadding="0" cellspacing="0" border="0">
    <tr>
        <td>
            <asp:DataList ID="dlAreas" runat="server" RepeatColumns="1"
                RepeatDirection="Horizontal">
                <HeaderStyle />
                <ItemTemplate>
                    <asp:Label ID="lblDepartamento" runat="server" Text='<% # fRetornaDepartamento(DataBinder.Eval(Container.DataItem, "cDepartamento"), DataBinder.Eval(Container.DataItem, "tDepartamento"))%>'> </asp:Label>
                </ItemTemplate>
            </asp:DataList>
        </td>
    </tr>
</table>
