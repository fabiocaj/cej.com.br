<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ReciboVitrine.aspx.vb" Inherits="ReciboVitrine" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc14" %>
<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc12" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc1" %>
<%@ Register Src="ucMembros.ascx" TagName="ucMembros" TagPrefix="uc15" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc2" %>
<%@ Register Src="Ucbig_banner.ascx" TagName="Ucbig_banner" TagPrefix="uc3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml" ><head id="Head1" runat="server">
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
<link href="membros/static_files/help.css" rel="stylesheet" type="text/css" media="all" /><script type="text/javascript">
var GB_ROOT_DIR = "./membros/greybox/";
    </script><script type="text/javascript" src="membros/greybox/AJS.js"></script><script type="text/javascript" src="membros/greybox/AJS_fx.js"></script><script type="text/javascript" src="membros/greybox/gb_scripts.js"></script><link href="membros/greybox/gb_styles.css" rel="stylesheet" type="text/css" media="all" /><script type="text/javascript" src="membros/static_files/help.js"></script></head><body><form id="form1" runat="server">
    <div></div>
    <table border="0" align="center" cellpadding="0" cellspacing="0" class="tabela_principal" bgcolor="#ffffff" width="905">
<tr>
<td valign="top" >
    <uc1:uctopo ID="Uctopo2" runat="server" />
</td>
</tr>

<tr>
<td valign="top">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td>
<img src="layout/mundialline/images/espaco.gif" width="11px"/></td>
<td  >
    &nbsp;<uc2:uclogotipo ID="Uclogotipo2" runat="server" /></td>
<td style="width: 12px" >
<img src="layout/mundialline/images/espaco.gif" width="11px"/></td>
<td valign="top" >
    &nbsp;<uc3:ucbig_banner ID="Ucbig_banner2" runat="server" /></td>
</tr>
</table>
</td>
</tr>
<tr>
<td valign="top" height="10">
</td>
</tr>
<tr>
<td align="left" valign="top" >
<table align="center" border="0" cellpadding="0" cellspacing="0" width="100%">
<tr>
<td valign="top">
    <table width="100%">
        <tr>
            <td>
                <asp:Label ID="lblEmail" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td><uc14:ucRodape ID="UcRodape1" runat="server" />
</td>
</tr>
</table>
    </form>
</body>
</html>