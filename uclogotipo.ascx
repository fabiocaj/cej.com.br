<%@ Control Language="VB" AutoEventWireup="false" CodeFile="uclogotipo.ascx.vb" Inherits="uclogotipo" %>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<table width="190" >
    <tr>
        <td align="center" valign="top" style="padding:0px 0px 0px 0px;"  >
<asp:Image ID="imgLogo" runat="server" style="border:0px;" usemap="#Map" Alt="Logotipo" /></td>
    </tr>
</table>
<map name="Map" id="Map">
  <area shape="rect" coords="3,2,143,102" href="Home.aspx">
</map>
