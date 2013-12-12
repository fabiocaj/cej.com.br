<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucHomeRedeDescontos.ascx.vb" Inherits="ucHomeRedeDescontos" %>
<%@ Register Src="ucRedeCredenciada.ascx" TagName="ucRedeCredenciada" TagPrefix="uc1" %>
<table width="100%" border="0" cellpadding="0" cellspacing="0"   bgcolor="#ffffff">
  <tr>
    <td id="Titulo" class="bgright">
        <asp:Label ID="lblTitulo" runat="server" Width="190px"></asp:Label></td>
  </tr>
  <tr>
    <td class="bgright">
        <uc1:ucRedeCredenciada ID="UcRedeCredenciada1" runat="server" />
        </td>
  </tr>
</table>