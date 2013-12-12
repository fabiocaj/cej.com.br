<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucAreas.ascx.vb" Inherits="ucAreas" %>
<table border="0px" cellpadding="0px" cellspacing="0px">
<tr><td>
<asp:DataList ID="dlAreas" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" >
    <ItemTemplate>
        <asp:Label ID="lblArea" runat="server" 
        Text='<% # fRetornaArea(DataBinder.Eval(Container.DataItem, "cArea"), DataBinder.Eval(Container.DataItem, "tArea"), DataBinder.Eval(Container.DataItem, "tImagem"), DataBinder.Eval(Container.DataItem, "tPagina"), DataBinder.Eval(Container.DataItem, "cPagina") ) %>'></asp:Label>
    </ItemTemplate>
</asp:DataList>
</td></tr>
</table>