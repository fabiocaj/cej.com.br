    <%@ Page Language="VB" AutoEventWireup="false" CodeFile="DetalhesEventos.aspx.vb" Inherits="DetalhesEventos" %>
<%@ Register Src="ucdestaque_banner.ascx" TagName="ucdestaque_banner" TagPrefix="uc15" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc14" %>
<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc12" %>
<%@ Register Src="ucDetalhesSecoes.ascx" TagName="ucDetalhesSecoes" TagPrefix="uc13" %>
<%@ Register Src="ucRedeDescontos.ascx" TagName="ucRedeDescontos" TagPrefix="uc8" %>
<%@ Register Src="ucHomeRedeDescontos.ascx" TagName="ucHomeRedeDescontos" TagPrefix="uc9" %>
<%@ Register Src="ucRedeCredenciada.ascx" TagName="ucRedeCredenciada" TagPrefix="uc7" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc1" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc2" %>
<%@ Register Src="ucbig_banner.ascx" TagName="ucbig_banner" TagPrefix="uc3" %>
<%@ Register Src="ucMenuRedeDescontos.ascx" TagName="ucMenuRedeDescontos" TagPrefix="uc4" %>
<%@ Register Src="ucMenuSaude.ascx" TagName="ucMenuSaude" TagPrefix="uc5" %>
<%@ Register Src="ucpublicidade.ascx" TagName="ucpublicidade" TagPrefix="uc6" %>
<%@ Register src="ucEventos.ascx" tagname="ucEventos" tagprefix="uc17" %>
<%@ Register src="ucdestaque_eventos.ascx" tagname="ucdestaque_eventos" tagprefix="uc10" %>
<%@ Register src="ucEventosDetalhes.ascx" tagname="ucEventosDetalhes" tagprefix="uc11" %>
<%@ Register src="ucEventos.ascx" tagname="ucEventos" tagprefix="uc20" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>:: Jair Bloch </title>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
  <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    </head>
<body>
    <form id="form1" runat="server">
   <center>
<table border="0" align="center" cellpadding="0" cellspacing="0" class="tabela_principal"  width="905">
<tr><td height="50px" >
    <uc1:uctopo ID="uctopo1" runat="server" />
</td></tr> 
<tr>
<td valign="top" >
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-top:5px;">
<uc2:uclogotipo ID="Uclogotipo1" runat="server" /></td>
<td valign="top" width="100%" align="left"  >
    
                &nbsp;</td>
</tr>
</table>
</td>
</tr>
<tr>
<td valign="top" height="10" id=menu>
                <uc12:ucMenus ID="UcMenus1" runat="server" />
</td>
</tr>
<tr>
<td valign="top" height="10" >
                &nbsp;</td>
</tr>
<tr>
<td valign="top" height="10" >
<table width="100%" border="0" cellspacing="0" cellpadding="0">
<tr><td colspan=3> &nbsp;</td></tr>
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_01.gif" alt="Decorativo" /></td>
    <td class="cima" >
         
            <H1 class="TxtTituloNoticia"> 
                Eventos
           </H1></td>
    <td><img src="layout/mundialline/images/layoutseguros_06.gif" alt="Decorativo"/></td>
  </tr>
  <tr>
    <td class="esquerda" width="13"></td>
    <td bgcolor="#ffffff">
                <uc11:ucEventosDetalhes ID="ucEventosDetalhes1" runat="server" />
      </td>
    <td class="direita" width="18"></td>
  </tr>
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_15.gif" alt="Decorativo" /></td>
    <td class="baixo" height="12"></td>
    <td><img src="layout/mundialline/images/layoutseguros_18.gif" alt="Decorativo" /></td>
  </tr>
</table>
                   </td>
</tr>
<tr>
<td align="left" valign="top" bgcolor="#ffffff">
<table align="center" border="0" cellpadding="0" cellspacing="0">
</table>
</td>
</tr>
<tr>
<td>&nbsp;</td>
</tr>
</table>
<table width="100%">
           <tr>
               <td>
                   <uc14:ucRodape ID="UcRodape1" runat="server" />
               </td>
           </tr>
       </table>
       

    </form>
    </center>
</body>
</html>