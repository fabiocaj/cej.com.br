<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Galeria.aspx.vb" Inherits="RadControls_Galeria" %>


<%@ Register Src="ucDestaques.ascx" TagName="ucDestaques" TagPrefix="uc1" %>

<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc13" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc12" %>
<%@ Register Src="ucHomeRedeDescontos.ascx" TagName="ucHomeRedeDescontos" TagPrefix="uc15" %>
<%@ Register Src="ucnewsletter.ascx" TagName="ucnewsletter" TagPrefix="uc10" %>
<%@ Register Src="ucpublicidade_main.ascx" TagName="ucpublicidade_main" TagPrefix="uc9" %>
<%@ Register Src="ucbig_banner.ascx" TagName="ucbig_banner" TagPrefix="uc8" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc7" %>
<%@ Register Src="ucPublicidade.ascx" TagName="ucpublicidade" TagPrefix="uc6" %>
<%@ Register Src="ucultimas_noticias.ascx" TagName="ucultimas_noticias" TagPrefix="uc5" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc2" %>
<%@ Register Src="ucdestaque_noticias.ascx" TagName="ucdestaque_noticias" TagPrefix="uc3" %>
<%@ Register Src="ucdestaque_banner.ascx" TagName="ucdestaque_banner" TagPrefix="uc4" %> 
<%@ Register Assembly="RadInput.Net2" Namespace="Telerik.WebControls" TagPrefix="radI" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<%@ Register src="ucEventos.ascx" tagname="ucEventos" tagprefix="uc11" %>
<%@ Register src="ucdestaque_eventos.ascx" tagname="ucdestaque_eventos" tagprefix="uc12" %>
<%@ Register src="ucGaleria.ascx" tagname="ucGaleria" tagprefix="uc14" %>
<%@ Register src="ucGaleriaDeltalhe.ascx" tagname="ucGaleriaDeltalhe" tagprefix="uc16" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<title>Home Cash - Clube de Beneficios</title>
<script type="text/javascript" src="js/prototype.js"></script>
<script type="text/javascript" src="js/scriptaculous.js?load=effects,builder"></script>
<script type="text/javascript" src="js/lightbox.js"></script>
<link rel="stylesheet" href="css/lightbox.css" type="text/css" media="screen" />


<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />

	


<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		
</head>

<body bgproperties="fixed" topmargin="0" leftmargin="0" rightmargin="0" bottommargin="0">
<form id="form1" runat="server">
		
					
					
					
 

<div id="fellipe">
<div id="Daniel">

<center>

<table width="900px" border="0" cellpadding="0" cellspacing="0" >
  <tr>
    <td colspan="2">
    <uc6:ucpublicidade ID="Ucpublicidade1" runat="server" />
      </td>
  </tr>
  <tr>
    <td colspan="2" > 
<uc2:uctopo ID="Uctopo1" runat="server" />
      </td>
  </tr>
  <tr>
    <td  style="width:200px; vertical-align:top" valign=top   >
               <a href=Default.aspx><img src="imagens/leao2.png" border="0"></a><br />
               <uc13:ucMenus ID="UcMenus1" runat="server" />
            </td>
    <td  valign=top>
    <br>
    <table width="700px" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td valign=top >
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td id="Noticias" style="padding-left:5px">
    <table>
<tr>
<td class=Titulo style="width:200px">
Galeria
</td>
</tr>
</table>
        <uc14:ucGaleria ID="ucGaleria1" runat="server" />
        
        
      </td>
  </tr>
  </table>
    
      </td>
 
  </tr>

</table>
    </td>
  </tr>
  <tr>
    <td colspan="2">&nbsp;</td>
  </tr>
</table>
</center>
</div>


</div>



<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="100%" height="100%">
  <param name="movie" value="EricFinal.swf" />
  <param name="quality" value="high" />
  <param name="allowFullScreen" value="true" />
  <param name="wmode" value="opaque" />
  <param name="expressinstall" value="Scripts/expressInstall.swf" />
  <object type="application/x-shockwave-flash" data="EricFinal.swf" width="100%" height="100%">
    <!--<![endif]-->
    <param name="quality" value="high" />
    <param name="wmode" value="opaque" />
    <param name="swfversion" value="8.0.35.0" />
    <param name="expressinstall" value="Scripts/expressInstall.swf" />
  </object>


		</form>
<script type="text/javascript">
var gaJsHost = (("https:" == document.location.protocol) ? "https://ssl." : "http://www.");
document.write(unescape("%3Cscript src='" + gaJsHost + "google-analytics.com/ga.js' type='text/javascript'%3E%3C/script%3E"));
</script>
<script type="text/javascript">
try {
var pageTracker = _gat._getTracker("UA-10080180-25");
pageTracker._trackPageview();
} catch(err) {}</script>
</body>
</html>

