<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucProdutos.ascx.vb" Inherits="ucProdutos" %>
<asp:DataList ID="dlProdutos" RepeatColumns="2" RepeatDirection="Horizontal" runat="server"
    Width="100%">
    <ItemTemplate>
        <asp:Label ID="lblProduto" runat="server">
                        <%#DataBinder.Eval(Container.DataItem, "cProduto")%>
        </asp:Label>
    </ItemTemplate>
    <ItemStyle VerticalAlign="top" />
</asp:DataList>
