<%@ Page Language="VB" AutoEventWireup="false" CodeFile="galeriaPesquisa.aspx.vb" Inherits="galeriaPesquisa" %>
<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc13" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc12" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc7" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc2" %>
<%@ Register src="ucnewsletter.ascx" tagname="ucnewsletter" tagprefix="uc10" %>
<%@ Register src="ucGaleriaPesquisa.ascx" tagname="ucGaleriaPesquisa" tagprefix="uc15" %>
<%@ Register Assembly="RadInput.Net2" Namespace="Telerik.WebControls" TagPrefix="radI" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<%@ Register src="ucbig_banner.ascx" tagname="ucbig_banner" tagprefix="uc15" %>
<%@ Register src="ucDetalhesSecoes.ascx" tagname="ucDetalhesSecoes" tagprefix="uc8" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


<title>Jair Bloch - Galeria de Imagens</title> 
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
 
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>  
     </head>
    
<body >
<center>
<form id="form1" runat="server">
<table border="0" cellpadding="0" cellspacing="0" class="tabela_principal" width="905">
<tr><td height="20px" >

</td></tr> 
<tr>
<td valign="top" >
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td >
<uc7:uclogotipo ID="Uclogotipo1" runat="server" /></td>
<td valign="top" width="100%" align="right"   ><uc13:ucMenus ID="UcMenus2" runat="server" /></td>
</tr>
   
</table>
</td>
</tr>
<tr>
<td align="left" valign="top" >
    <table cellpadding="0" cellspacing="0"  width="100%">
        <tr>
            <td valign="top" width="96%"><uc15:ucbig_banner ID="ucbig_bannerSlider1" runat="server" />
               
            </td>
        </tr>
    </table>
    </tr>
<tr>
<td align="left" valign="top" >
    <uc15:ucGaleriaPesquisa ID="ucGaleriaPesquisa1" runat="server" />
    </tr>
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
</table>
    </form>
    </center>
</body>
</html>