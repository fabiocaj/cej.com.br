e<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Faq.aspx.vb" Inherits="Faq" %>
<%@ Register Src="ucPublicidadeLeft.ascx" TagName="ucPublicidadeLeft" TagPrefix="uc11" %>
<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc13" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc12" %>
<%@ Register Src="ucpublicidade_main.ascx" TagName="ucpublicidade_main" TagPrefix="uc9" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc7" %>
<%@ Register Src="ucpublicidade.ascx" TagName="ucpublicidade" TagPrefix="uc6" %>
<%@ Register Src="ucultimas_noticias.ascx" TagName="ucultimas_noticias" TagPrefix="uc5" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc2" %>
<%@ Register Src="ucdestaque_noticias.ascx" TagName="ucdestaque_noticias" TagPrefix="uc3" %>
<%@ Register Assembly="RadInput.Net2" Namespace="Telerik.WebControls" TagPrefix="radI" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<%@ Register src="ucDestaques.ascx" tagname="ucDestaques" tagprefix="uc16" %>
<%@ Register src="ucNoticias.ascx" tagname="ucNoticias" tagprefix="uc4" %>
<%@ Register src="ucDetalhesNoticias.ascx" tagname="ucDetalhesNoticias" tagprefix="uc17" %>
<%@ Register src="ucAreas.ascx" tagname="ucAreas" tagprefix="uc18" %>
<%@ Register src="ucDetalhesSecoes.ascx" tagname="ucDetalhesSecoes" tagprefix="uc8" %>
<%@ Register src="ucMenuArea.ascx" tagname="ucMenuArea" tagprefix="uc1" %>
<%@ Register src="ucbig_banner.ascx" tagname="ucbig_banner" tagprefix="uc19" %>
<%@ Register src="ucnewsletter.ascx" tagname="ucnewsletter" tagprefix="uc10" %>
<%@ Register src="ucpublicidadel.ascx" tagname="ucpublicidadel" tagprefix="uc14" %>
<%@ Register src="ucFaq.ascx" tagname="ucFaq" tagprefix="uc15" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<title>Jair Bloch - Central de Downloads</title>
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="layout/mundialline/SpryAssets/SpryCollapsiblePanel.css" rel="stylesheet" type="text/css" />
<script src="layout/mundialline/SpryAssets/SpryCollapsiblePanel.js" type="text/javascript"></script>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
</head>
     </head>
<body  >
<form id="form1" runat="server">


<table border="0" align="center" cellpadding="0" cellspacing="0" class="tabela_principal"  width="905">
<tr><td>
    <uc2:uctopo ID="uctopo1" runat="server" />
</td></tr> 
<tr>
<td valign="top" >
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td>
<uc7:uclogotipo ID="Uclogotipo1" runat="server" /></td>
<td valign="top" width="100%" align="left"  >
    
                <uc10:ucnewsletter ID="ucnewsletter1" runat="server" />
                </td>
</tr>
</table>
</td>
</tr>
<tr><td width="100%" valign="top">
                <br />
                </td></tr> 
<tr><td width="100%" valign="top">
                <uc13:ucMenus ID="UcMenus2" runat="server" />
            </td></tr> 
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
<tr>
<td align="left" valign="top" >
    <table cellpadding="0" cellspacing="0"  width="100%">
        <tr>
            <td valign="top" width="96%">
                <uc8:ucDetalhesSecoes ID="ucDetalhesSecoes1" runat="server" /><br/>
                <uc15:ucFaq ID="ucFaq1" runat="server" />
            </td>
            <td valign="top">   
                </td>
            <td valign="top" align="right" style="padding:0px 80px 0px 0px">
                <uc11:ucPublicidadeLeft ID="ucPublicidadeLeft1" runat="server" />
            </td>
        </tr>
    </table>
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
</body>
</html>