    <%@ Page Language="VB" AutoEventWireup="false" CodeFile="Eventos.aspx.vb" Inherits="_Eventos" %>
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
<%@ Register src="ucEventos.ascx" tagname="uceventos" tagprefix="uc11" %>
<%@ Register src="ucEventosDetalhes.ascx" tagname="ucEventosDetalhes" tagprefix="uc14" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
     <style type="text/css">
         .style1
         {
             width: 96%;
         }
         .style2
         {
             height: 41px;
             background-image: url('layout/mundialline/images/layoutseguros_10.gif');
             background-repeat: repeat-y;
         }
         .style3
         {
             height: 41px;
         }
         .style4
         {
             height: 41px;
             background-image: url('layout/mundialline/images/layoutseguros_12.gif');
             background-repeat: repeat-y;
         }
     </style>
     </head>
<body  >
<center>
<form id="form1" runat="server">
<table border="0" align="center" cellpadding="0" cellspacing="0" class="tabela_principal"  width="905">
<tr><td  height=50px>
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
<td align="left" valign="top"  >
<table width="100%" border="0" cellspacing="0" cellpadding="0">
<tr><td colspan=3> &nbsp;</td></tr>
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_01.gif" alt="Decorativo" /></td>
    <td class="cima" >
         
            <H1 class="TxtTituloNoticia"> 
               Agenda
           </H1></td>
    <td><img src="layout/mundialline/images/layoutseguros_06.gif" alt="Decorativo"/></td>
  </tr>
  <tr>
    <td class="style2" width="13"></td>
    <td bgcolor="#ffffff" class="style3">
        <uc11:uceventos ID="uceventos1" runat="server" />
      </td>
    <td class="style4" width="18"></td>
  </tr>
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_15.gif" alt="Decorativo" /></td>
    <td class="baixo" height="12"></td>
    <td><img src="layout/mundialline/images/layoutseguros_18.gif" alt="Decorativo" /></td>
  </tr>
</table>
    </tr>
<tr>
<td align="left" valign="top" >
    &nbsp;</tr>
<tr>
<td align="left" valign="top" >
    <table cellpadding="0" cellspacing="0"  width="100%">
        <tr>
            <td valign="top" class="style1">
                &nbsp;</td>
            
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
    </center>
</body>
</html>



