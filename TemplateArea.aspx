<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TemplateArea.aspx.vb" Inherits="TemplateArea" %>
<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc13" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc12" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc7" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc2" %>
<%@ Register Assembly="RadInput.Net2" Namespace="Telerik.WebControls" TagPrefix="radI" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<%@ Register src="ucDestaques.ascx" tagname="ucDestaques" tagprefix="uc16" %>
<%@ Register src="ucAreas.ascx" tagname="ucAreas" tagprefix="uc18" %>
<%@ Register src="ucMenuArea.ascx" tagname="ucMenuArea" tagprefix="uc1" %>
<%@ Register src="ucnewsletter.ascx" tagname="ucnewsletter" tagprefix="uc10" %>
<%@ Register src="ucDetalhesSecoes.ascx" tagname="ucDetalhesSecoes" tagprefix="uc4" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
     </head>
<body  >
<form id="form1" runat="server">
<center>
<table border="0" align="center" cellpadding="0" cellspacing="0" class="tabela_principal"  width="905">
<tr><td height=50px;>
    <uc2:uctopo ID="uctopo1" runat="server" />
</td></tr> 
<tr>
<td valign="top" >
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td>
<uc7:uclogotipo ID="Uclogotipo1" runat="server" /></td>
<td valign="top" width="100%" align="left"  >
    
                &nbsp;</td>
</tr>
</table>
</td>
</tr>
<tr><td width="100%" valign="top">
                <br />
                </td></tr> 
<tr><td width="100%" valign="top" id=menu>
                <uc13:ucMenus ID="UcMenus2" runat="server" />
            </td></tr> 
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
<tr>
<td align="left" valign="top" >
                <uc4:ucDetalhesSecoes ID="ucDetalhesSecoes1" runat="server"  />
            </tr>
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
</table>
<uc12:ucRodape ID="ucRodape1" runat="server" />
    </form>
    </center>
</body>
</html>