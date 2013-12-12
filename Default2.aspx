<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<%@ Register src="ucMenuDepartamentosAreas.ascx" tagname="ucMenuDepartamentosAreas" tagprefix="uc10" %>
<%@ Register src="ucVitrineNavegacao.ascx" tagname="ucVitrineNavegacao" tagprefix="uc9" %>
<%@ Register src="ucProdutos.ascx" tagname="ucProdutos" tagprefix="uc8" %>
<%@ Register src="ucVitrineSecoes.ascx" tagname="ucVitrineSecoes" tagprefix="uc7" %>
<%@ Register src="ucVitrineFabricantes.ascx" tagname="ucVitrineFabricantes" tagprefix="uc6" %>
<%@ Register src="ucVitrineDepartamentos.ascx" tagname="ucVitrineDepartamentos" tagprefix="uc5" %>
<%@ Register src="ucRodape.ascx" tagname="ucRodape" tagprefix="uc4" %>
<%@ Register src="ucbig_banner.ascx" tagname="ucbig_banner" tagprefix="uc3" %>
<%@ Register src="uclogotipo.ascx" tagname="uclogotipo" tagprefix="uc2" %>
<%@ Register src="uctopo.ascx" tagname="uctopo" tagprefix="uc1" %>
<%@ Register src="ucVitrineNavegacao.ascx" tagname="ucVitrineNavegacao" tagprefix="uc10" %>
<%@ Register src="ucDetalhesProduto.ascx" tagname="ucDetalhesProduto" tagprefix="uc9" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
html{
	height:100%
	
	}

*{margin:0;padding:0;}body{font:10px Georgia,Serif;}

body{
	height:100%;
	margin:0 0 0 0;
	background-image:url('imagens/crbst_Fundo_20OK2.png');
	background-repeat:repeat-x;
	background-color:#FFF;
	background-position: center top ;
        }



.tabela_principal{border:0}



#Topo 
{
	padding-top:1px;
	

	}
	

#Topo td{ height:34px; padding-top:5px }
			
				

.anythingSlider .wrapper{width:907px;overflow:auto;height:210px;margin:0;position:absolute;}
.anythingSlider .wrapper ul{width:9999px;list-style:none;position:absolute;top:0;left:0;margin:0;}

.pontilhado{background-image:url('layout/mundialline/images/pontilhado.gif');
background-repeat:repeat-y;width:11px;
        }
        .style1
        {
            text-decoration: none;
            border-style: none;
            border-color: inherit;
            border-width: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table border="0" align="center" cellpadding="0" cellspacing="0" class="tabela_principal" bgcolor="#ffffff" width="905">
<tr>
<td valign="top" >
    <uc1:uctopo ID="uctopo1" runat="server" />
</td>
</tr>

<tr>
<td valign="top"><br>
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td>
<img src="layout/mundialline/images/espaco.gif" width="11px"/></td>
<td  >
    <uc2:uclogotipo ID="uclogotipo1" runat="server" />
</td>
<td style="width: 12px" >
<img src="layout/mundialline/images/espaco.gif" width="11px"/></td>
<td valign="top" >
    <uc3:ucbig_banner ID="ucbig_banner1" runat="server" />
    </td>
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
<table align="center" border="0" cellpadding="0" cellspacing="0">
<tr>
<td valign="top">
<img src="layout/mundialline/images/espaco.gif" /></td>
<td valign="top">
    <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td >
                <uc7:ucVitrineSecoes ID="ucVitrineSecoes1" runat="server" />
                </td>
        </tr>
                <tr>
            <td >
                &nbsp;</td>
        </tr>
                <tr>
            <td >
                <uc6:ucVitrineFabricantes ID="ucVitrineFabricantes1" runat="server" />
                    </td>
        </tr>
                <tr>
            <td >
                &nbsp;</td>
        </tr>
        </table>
    <br />
    &nbsp;</td>
<td valign="top">
<img src="layout/mundialline/images/espaco.gif" width="5px"/></td>
<td class="pontilhado" valign="top">
<img src="layout/mundialline/images/pontilhado.gif" /></td>
<td valign="top" width="850">
    <table cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td >
                <uc5:ucVitrineDepartamentos ID="ucVitrineDepartamentos1" runat="server"  />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr><td><table  border="0" cellpadding="0" cellspacing="0" id="Box-ComportaTodosProdutos">
	<tr>
		<td>
			<img src="layout/mundialline/images/BordaVitrine_01.gif" width="15" height="41" alt=""></td>
		<td class="top" >
            <uc10:ucVitrineNavegacao ID="ucVitrineNavegacao1" runat="server" />
        </td>
		<td>
			<img src="layout/mundialline/images/BordaVitrine_03.gif" width="17" height="41" alt=""></td>
	</tr>
	<tr>
	    <td class="left"></td>
		<td class="main">
            <uc9:ucDetalhesProduto ID="ucDetalhesProduto1" runat="server" />
            </td> 
            <td class="right"></td>
	</tr>
	<tr>
		<td>
			<img src="layout/mundialline/images/BordaVitrine_07.gif" width="15" height="19" alt=""></td>
		<td class="bottom"></td>
		<td>
			<img src="layout/mundialline/images/BordaVitrine_09.gif" width="17" height="19" alt=""></td>
	</tr>
</table></td></tr>
        
    </table>
    </td>
<td class="pontilhado">
<img src="layout/mundialline/images/pontilhado.gif" /></td>
<td valign="top">
<table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td valign="top" height="10px">&nbsp;</td>
    </tr>
    <tr>
        <td valign="top">
            &nbsp;</td>
    </tr>
    <tr>
        <td valign="top" height="10">
        </td>
    </tr>
    <tr>
        <td valign="top" style="height: 10px">
            &nbsp;</td>
    </tr>
</table>
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td><uc4:ucRodape ID="ucRodape1" runat="server" />
    </td>
</tr>
</table>
    </form>
</body>
</html>
