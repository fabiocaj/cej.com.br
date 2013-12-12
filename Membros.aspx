<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Membros.aspx.vb" Inherits="Membros" %>
<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc13" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc12" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc7" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc2" %>
<%@ Register src="ucnewsletter.ascx" tagname="ucnewsletter" tagprefix="uc10" %>
<%@ Register src="ucGaleriaPesquisa.ascx" tagname="ucGaleriaPesquisa" tagprefix="uc15" %>
<%@ Register Assembly="RadInput.Net2" Namespace="Telerik.WebControls" TagPrefix="radI" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>
<%@ Register src="ucMembros.ascx" tagname="ucMembros" tagprefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
<link href="membros/static_files/help.css" rel="stylesheet" type="text/css" media="all" />
 <script type="text/javascript">
     var GB_ROOT_DIR = "./membros/greybox/";
    </script>
    <script type="text/javascript" src="membros/greybox/AJS.js"></script>
    <script type="text/javascript" src="membros/greybox/AJS_fx.js"></script>
    <script type="text/javascript" src="membros/greybox/gb_scripts.js"></script>
    <link href="membros/greybox/gb_styles.css" rel="stylesheet" type="text/css" media="all" />
    <script type="text/javascript" src="membros/static_files/help.js"></script>
<title>Equipe - Jair Bloch</title>
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
<table width="100%" border="0" cellspacing="0" cellpadding="0" align="center">
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_01.gif" /></td>
    <td class="cima" height="49">
            <h1 class="TxtTituloNoticia">Equipe Jair Bloch</h1>
                </td>
    <td><img src="layout/mundialline/images/layoutseguros_06.gif"/></td>
  </tr>
  <tr>
    <td class="esquerda" width="13"></td>
    <td bgcolor="#ffffff">


    <uc1:ucMembros ID="ucMembros1" runat="server" />
            </td>
    <td class="direita" width="18"></td>
  </tr>
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_15.gif" /></td>
    <td class="baixo" height="12"></td>
    <td><img src="layout/mundialline/images/layoutseguros_18.gif" /></td>
  </tr>
</table>

&nbsp;</tr>
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