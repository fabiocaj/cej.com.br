<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucNoticias.ascx.vb" Inherits="ucNoticias" %>
<asp:GridView ID="gvResultados" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="tTitulo" HeaderText="Not&#237;cias" />
    </Columns>
</asp:GridView>
