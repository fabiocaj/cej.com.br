<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FaleConosco.aspx.vb" Inherits="FaleConosco" %>

<%@ Register Assembly="RadInput.Net2" Namespace="Telerik.WebControls" TagPrefix="radI" %>

<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc14" %>

<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc12" %>

<%@ Register Src="ucDetalhesSecoes.ascx" TagName="ucDetalhesSecoes" TagPrefix="uc13" %>
<%@ Register Src="ucNoticias.ascx" TagName="ucNoticias" TagPrefix="uc10" %>
<%@ Register Src="ucultimas_noticias.ascx" TagName="ucultimas_noticias" TagPrefix="uc11" %>
<%@ Register Src="ucRedeDescontos.ascx" TagName="ucRedeDescontos" TagPrefix="uc8" %>
<%@ Register Src="ucHomeRedeDescontos.ascx" TagName="ucHomeRedeDescontos" TagPrefix="uc9" %>
<%@ Register Src="ucRedeCredenciada.ascx" TagName="ucRedeCredenciada" TagPrefix="uc7" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc1" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc2" %>
<%@ Register Src="ucbig_banner.ascx" TagName="ucbig_banner" TagPrefix="uc3" %>
<%@ Register Src="ucMenuRedeDescontos.ascx" TagName="ucMenuRedeDescontos" TagPrefix="uc4" %>
<%@ Register Src="ucMenuSaude.ascx" TagName="ucMenuSaude" TagPrefix="uc5" %>
<%@ Register Src="ucpublicidade.ascx" TagName="ucpublicidade" TagPrefix="uc6" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Home Cash - Clube de Beneficios</title>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div></div>
    <table border="0" align="center" cellpadding="0" cellspacing="0" class="tabela_principal" bgcolor="#ffffff" width="905">
<tr>
<td valign="top" >
    <uc1:uctopo ID="Uctopo2" runat="server" />
</td>
</tr>

<tr>
<td valign="top">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td>
<img src="layout/mundialline/images/espaco.gif" width="11px"/></td>
<td  >
    &nbsp;<uc2:uclogotipo ID="Uclogotipo2" runat="server" />
</td>
<td style="width: 12px" >
<img src="layout/mundialline/images/espaco.gif" width="11px"/></td>
<td valign="top" >
    &nbsp;<uc3:ucbig_banner ID="Ucbig_banner2" runat="server" />
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
            <td style="width: 100px">
                <uc12:ucMenus ID="UcMenus1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                &nbsp;
            </td>
        </tr>
    </table>
    <br />
    &nbsp;</td>
<td valign="top">
<img src="layout/mundialline/images/espaco.gif" width="5px"/></td>
<td class="pontilhado" valign="top">
<img src="layout/mundialline/images/pontilhado.gif" /></td>
<td valign="top" width="850">
    <table width="100%">
        <tr>
            <td  class="secaofaleconosco">
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr>
                        <td style="width: 61px">
                            Nome</td>
                        <td style="width: 4px">
                            :</td>
                        <td style="width: 100px">
                            <radI:RadMaskedTextBox ID="RadMaskedTextBox1" runat="server" Width="250px" ></radI:RadMaskedTextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 61px">
                            Telefone</td>
                        <td style="width: 4px">
                            :</td>
                        <td style="width: 100px">
                            <radI:RadMaskedTextBox ID="RadMaskedTextBox2" runat="server"></radI:RadMaskedTextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 61px">
                            E-mail</td>
                        <td style="width: 4px">
                            :</td>
                        <td style="width: 100px">
                            <radI:RadMaskedTextBox ID="RadMaskedTextBox3" runat="server"></radI:RadMaskedTextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 61px">
                            </td>
                        <td style="width: 4px">
                        </td>
                        <td style="width: 100px">
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 61px; height: 15px">
                            Mensagem:</td>
                        <td style="width: 4px; height: 15px">
                        </td>
                        <td style="width: 100px; height: 15px">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox1" runat="server" Height="112px" Width="256px"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</td>
<td class="pontilhado">
<img src="layout/mundialline/images/pontilhado.gif" /></td>
<td valign="top">
<table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td valign="top" height="10px"></td>
    </tr>
    <tr>
        <td valign="top">
            <uc9:ucHomeRedeDescontos ID="UcHomeRedeDescontos1" runat="server" />
        </td>
    </tr>
    <tr>
        <td valign="top" height="10">
        </td>
    </tr>
    <tr>
        <td valign="top" style="height: 10px">
            <uc6:ucpublicidade ID="Ucpublicidade1" runat="server" />
        </td>
    </tr>
</table>
</td>
</tr>
</table>
</td>
</tr>
<tr>
<td><uc14:ucRodape ID="UcRodape1" runat="server" />
</td>
</tr>
</table>
    </form>
</body>
</html>



