<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ResultadoPesquisaRedeCredenciada.aspx.vb" Inherits="ResultadoPesquisaRedeCredenciada" EnableEventValidation="false" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<%@ Register Src="ucPublicidade.ascx" TagName="ucPublicidade" TagPrefix="uc12" %>
<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc11" %>
<%@ Register Src="ucRodape.ascx" TagName="ucRodape" TagPrefix="uc10" %>
<%@ Register Src="ucRedeDescontos.ascx" TagName="ucRedeDescontos" TagPrefix="uc8" %>
<%@ Register Src="ucHomeRedeDescontos.ascx" TagName="ucHomeRedeDescontos" TagPrefix="uc9" %>
<%@ Register Src="ucRedeCredenciada.ascx" TagName="ucRedeCredenciada" TagPrefix="uc7" %>
<%@ Register Src="uctopo.ascx" TagName="uctopo" TagPrefix="uc1" %>
<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc2" %>
<%@ Register Src="ucbig_banner.ascx" TagName="ucbig_banner" TagPrefix="uc3" %>
<%@ Register Src="ucMenuRedeDescontos.ascx" TagName="ucMenuRedeDescontos" TagPrefix="uc4" %>
<%@ Register Src="ucMenuSaude.ascx" TagName="ucMenuSaude" TagPrefix="uc5" %>
<%@ Register Src="ucpublicidadel.ascx" TagName="ucpublicidadel" TagPrefix="uc6" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Home Cash - Clube de Beneficios</title>
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
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
                <uc11:ucMenus ID="UcMenus1" runat="server" />
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
    <radA:RadAjaxPanel ID="RadAjaxPanel1" runat="server" Width="100%">
        <asp:GridView ID="gvResultados" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="0" Border="0" AllowPaging="True">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="lblCodigoAssociado" runat="server" visible="false" Text='<%# Bind("cAssociado") %>'></asp:Label>
                        <asp:Label ID="lblAssociado" runat="server" Text='<%# fRetornaAssociado(DataBinder.Eval(Container.Dataitem, "tAssociado"), DataBinder.Eval(Container.Dataitem, "tEndereco"), DataBinder.Eval(Container.Dataitem, "tNumero"), DataBinder.Eval(Container.Dataitem, "tComplemento"), DataBinder.Eval(Container.Dataitem, "tBairro"), DataBinder.Eval(Container.Dataitem, "tTelefone1"), DataBinder.Eval(Container.Dataitem, "tSite"), DataBinder.Eval(Container.Dataitem, "tEmail"), DataBinder.Eval(Container.Dataitem, "tObservacao")) %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle CssClass="header_resultado" />
                </asp:TemplateField>
            </Columns>
            <RowStyle BorderWidth="0px" />
            <FooterStyle Font-Names="Onyx" />
            <PagerStyle CssClass="paginacao" HorizontalAlign="Right" />
        </asp:GridView>
    </radA:RadAjaxPanel>
</td>
<td class="pontilhado">
<img src="layout/mundialline/images/pontilhado.gif" /></td>
<td valign="top">
<table border="0" cellpadding="0" cellspacing="0">
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
        <td valign="top">
            <uc12:ucPublicidade ID="UcPublicidade1" runat="server" />
        </td>
    </tr>
    <tr>
        <td valign="top" style="height: 10px">
        </td>
    </tr>
</table>
</td>
</tr>
</table>
    <br />
</td>
</tr>
<tr>
<td>
    <uc10:ucRodape ID="UcRodape1" runat="server" />
</td>
</tr>
</table>
    </form>
</body>
</html>



