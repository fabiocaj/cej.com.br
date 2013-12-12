<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default3.aspx.vb" Inherits="Default3" %>

<%@ Register src="ucDetalhesSecoes.ascx" tagname="ucDetalhesSecoes" tagprefix="uc8" %>
<%@ Register src="uclogotipo.ascx" tagname="uclogotipo" tagprefix="uc7" %>
<%@ Register src="ucRodape.ascx" tagname="ucRodape" tagprefix="uc12" %>
<%@ Register src="ucMenus.ascx" tagname="ucMenus" tagprefix="uc13" %>
<%@ Register src="ucProdutosInterna.ascx" tagname="ucProdutosInterna" tagprefix="uc11" %>
<%@ Register src="ucMenuDepartamentosAreas.ascx" tagname="ucMenuDepartamentosAreas" tagprefix="uc10" %>
<%@ Register src="ucVitrineNavegacao.ascx" tagname="ucVitrineNavegacao" tagprefix="uc9" %>
<%@ Register src="ucVitrineSecoes.ascx" tagname="ucVitrineSecoes" tagprefix="uc7" %>
<%@ Register src="ucVitrineFabricantes.ascx" tagname="ucVitrineFabricantes" tagprefix="uc6" %>
<%@ Register src="ucVitrineDepartamentos.ascx" tagname="ucVitrineDepartamentos" tagprefix="uc5" %>

<%@ Register src="ucDetalhesProduto.ascx" tagname="ucDetalhesProduto" tagprefix="uc12" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
html{
	height:100%;
	font-family:Arial;
	
	}

*{margin:0;padding:0;}
	*{
	font-family:Arial;
	}
		
body{font:10px Georgia,Serif;}

body{
	height:100%;
	margin:0 0 0 0;
	background-image:url('imagens/crbst_Fundo_20OK3.png');
	background-repeat:repeat-x;
	background-color:#FFF;
	background-position: center top ; 
		font-family:Arial;
	}
	
.tabela_principal{border:0}



.TxtTituloNoticia{font-family:Arial; font-size:17px; color:#000; padding: 0px 15px 0px 5px; font-weight:bold;
                  text-align:left;}
	
h1
{
font-family:Arial;	
color:#999999;
	
	}

hr{background-color:#CCC;height:1px;}

p
{
	font-family:Arial;
	color#555;
	font-size:13px;
	line-height:15px;
	
	
	
	}

.textoRodape 
{
	font-family:Arial;
	font-size:15px;
	color:#fff;
	text-align:left;
	
	}
.textoRodape
{
	font-family:Arial;
	font-size:15px;
	color:#fff;
	text-align:left;
	
	}
	
a:link, a:visited, a:active {
text-decoration: none;

font-family:Arial;

}
    </style>
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
<td >
    &nbsp;</td>
<td valign="top" width="100%" align="right"   >&nbsp;</td>
</tr>
   
</table>
</td>
</tr>
<tr>
<td align="LEFT" valign="top"   style="height:" >
    <table class="style1" cellpadding=5 cellspacing=5>
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
                                                    <table class="style1">
                                                        <tr>
                                                            <td>
                                                                <uc9:ucVitrineNavegacao ID="ucVitrineNavegacao1" runat="server" />
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <uc12:ucDetalhesProduto ID="ucDetalhesProduto1" runat="server" />
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
