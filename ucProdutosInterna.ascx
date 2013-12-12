<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucProdutosInterna.ascx.vb" Inherits="ucProdutos" %>
<center >
<asp:DataList ID="dlProdutos" RepeatColumns="1" RepeatDirection="Horizontal" runat="server" 
                Width="100%">
    <ItemTemplate > 
                    <asp:Label ID="lblProduto" runat="server">
                        <%#DataBinder.Eval(Container.DataItem, "cProduto")%>
                    </asp:Label>
    </ItemTemplate>
    <ItemStyle VerticalAlign="top" />
</asp:DataList>