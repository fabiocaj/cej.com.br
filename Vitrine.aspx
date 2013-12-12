<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Vitrine.aspx.vb" Inherits="Vitrine" %>

<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc1" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc2" %>
<%@ Register Src="ucbig_banner.ascx" TagName="ucbig_banner" TagPrefix="uc3" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc4" %>
<%@ Register Src="ucVitrineDepartamentos.ascx" TagName="ucVitrineDepartamentos" TagPrefix="uc5" %>
<%@ Register Src="ucVitrineFabricantes.ascx" TagName="ucVitrineFabricantes" TagPrefix="uc6" %>
<%@ Register Src="ucVitrineSecoes.ascx" TagName="ucVitrineSecoes" TagPrefix="uc7" %>
<%@ Register Src="ucProdutos.ascx" TagName="ucProdutos" TagPrefix="uc8" %>
<%@ Register Src="ucVitrineNavegacao.ascx" TagName="ucVitrineNavegacao" TagPrefix="uc9" %>
<%@ Register src="ucMenuDepartamentosAreas.ascx" tagname="ucMenuDepartamentosAreas" tagprefix="uc10" %>
<%@ Register src="ucForm_Home..ascx" tagname="ucForm_Home" tagprefix="uc24" %>
<%@ Register src="ucProdutos.ascx" tagname="ucProdutos" tagprefix="uc23" %>
<%@ Register src="ucbig_banner.ascx" tagname="ucbig_banner" tagprefix="uc15" %>
<%@ Register src="uclogotipo.ascx" tagname="uclogotipo" tagprefix="uc7" %>
<%@ Register src="ucMenus.ascx" tagname="ucMenus" tagprefix="uc13" %>
<%@ Register src="ucProdutosInterna.ascx" tagname="ucProdutosInterna" tagprefix="uc11" %>
<%@ Register src="ucRodape.ascx" tagname="ucRodape" tagprefix="uc12" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<link href="css/paginasinternas.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
    <link type="text/css" rel="stylesheet" href="/sitecej.com.br/App_Themes/Saude/RadPanelbar/Styles/Saude.css" />
    </head>
<body onload="location.hash='bookmark';">
<form id="form1" runat="server">
<table class="" height="100%" style="100%"  width="100%"  cellpadding="0" cellspacing="0" border="0">
    <tr>
        <td valign=top align=center>
<table border="0" cellpadding="0" cellspacing="0"  width="905" height="100%" style="height:100%" class="tabela_principal">
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
   
<tr>
<td  colspan="2" >
    <br />
    </td>
</tr>
  <tr>
<td  class="TxtTituloNoticia" colspan="2" >
     <span>Produtos</span></td>
</tr> 
</table>
</td>
</tr>
<tr>
<td align="LEFT" valign="top"   style="height:" >
    <table  cellpadding=5 cellspacing=5>
        <tr>
            <td width=100 valign=top>
                            <table border="0" cellpadding="0" cellspacing="0"  width=113px  >
                                <tr>
                                    <td >
                                        <uc10:ucMenuDepartamentosAreas ID="ucMenuDepartamentosAreas1" runat="server" />
                                        <uc7:ucVitrineSecoes ID="ucVitrineSecoes1" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <uc6:ucVitrineFabricantes ID="ucVitrineFabricantes1" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td > <table  border="0" cellpadding="0" cellspacing="0" width=163px; class="" ><tr><td class="ItensMenuPrincipalSaude">Departamentos</td></tr><tr><td><uc5:ucVitrineDepartamentos ID="ucVitrineDepartamentos1" runat="server" /></td></tr></table></td>
                                </tr>
                                <tr>
                                    <td>
                                          
                                    </td>
                                </tr>
                            </table>
            </td>
            <td valign=top>
                                                    <table  width=200px cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td>
                                                    <uc9:ucVitrineNavegacao ID="ucVitrineNavegacao1" runat="server"  />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td><br>
                                                    <uc11:ucProdutosInterna ID="ucProdutosInterna1" runat="server" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                    </td>
        </tr>
        </table>
                
    </tr>
</table>
        </td>
    </tr>
    <tr>
        <td valign=bottom>
            <uc12:ucRodape ID="ucRodape1" runat="server" />
        </td>
    </tr>
</table>

    

    </form>
    </body>
</html>
