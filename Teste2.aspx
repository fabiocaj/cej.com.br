<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Teste2.aspx.vb" Inherits="Teste2" %>

<%@ Register Src="ucLogo.ascx" TagName="ucLogo" TagPrefix="uc10" %>

<%@ Register Src="ucbig_banner.ascx" TagName="ucbig_banner" TagPrefix="uc9" %>

<%@ Register Src="ucMenuSegurosFinancas.ascx" TagName="ucMenuSegurosFinancas" TagPrefix="uc8" %>

<%@ Register Src="ucBanners.ascx" TagName="ucBanners" TagPrefix="uc7" %>

<%@ Register Src="ucDestaques.ascx" TagName="ucDestaques" TagPrefix="uc6" %>

<%@ Register Src="ucLogin.ascx" TagName="ucLogin" TagPrefix="uc4" %>
<%@ Register Src="ucNoticias.ascx" TagName="ucNoticias" TagPrefix="uc5" %>

<%@ Register Src="ucMenuRedeDescontos.ascx" TagName="ucMenuRedeDescontos" TagPrefix="uc3" %>

<%@ Register Src="ucPainel.ascx" TagName="ucPainel" TagPrefix="uc2" %>

<%@ Register Src="ucMenuSaude.ascx" TagName="ucMenuSaude" TagPrefix="uc1" %>

<%@ Register Assembly="RadPanelbar.Net2" Namespace="Telerik.WebControls" TagPrefix="radP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="css/page.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;<uc9:ucbig_banner ID="Ucbig_banner1" runat="server" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <uc10:ucLogo ID="UcLogo1" runat="server" />
        <br />
        <br />
        <br />
        <table>
            <tr>
                <td>
                    Panel na página</td>
                <td>
                    User Control</td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    Place Holder</td>
                <td>
                </td>
                <td>
                    sfasdfsadf</td>
            </tr>
            <tr>
                <td>
                    <uc1:ucMenuSaude ID="UcMenuSaude1" runat="server" />
                </td>
                <td>
                    <uc3:ucMenuRedeDescontos ID="UcMenuRedeDescontos1" runat="server" />
                </td>
                <td>
                    <uc8:ucMenuSegurosFinancas ID="UcMenuSegurosFinancas1" runat="server" />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <uc4:ucLogin ID="UcLogin1" runat="server" />
    </div>
        <br />
        <uc5:ucNoticias ID="UcNoticias1" runat="server" />
        <br />
        <uc6:ucDestaques ID="UcDestaques1" runat="server" />
        <br />
        <br />
        
<%--        <object classid='clsid:D27CDB6E-AE6D-11cf-96B8-444553540000' 
            codebase='http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0'
            width='LARGURA' height='ALTURA' title='flash' 
            id='flash' border='0'>
            <param name='movie' value='images/movie.swf'/>
            <param name='quality' value='High'/>
            <param name='menu' value='false'/>
            <param name='swliveconnect' value='true'/>
            <param name='wmode' value='transparent'/>
            <embed src='images/movie.swf' quality='High' pluginspage='http://www.macromedia.com/go/getflashplayer'
            type='application/x-shockwave-flash' width='LARGURA' height='ALTURA' menu='false' 
            swliveconnect='true'wmode='transparent' name='flash'>
            </embed>
        </object>--%>
        
    <object id="FlashID" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="760" height="100">
  <param name="movie" value="images/movie.swf" />
  <param name="quality" value="high" />
  <param name="wmode" value="opaque" />
  <param name="swfversion" value="9.0.45.0" />

  <param name="expressinstall" value="Scripts/expressInstall.swf" />
</object>

  <object type="application/x-shockwave-flash" data="images/movie.swf" width="760" height="100">
 
    <param name="quality" value="high" />
    <param name="wmode" value="opaque" />
    <param name="swfversion" value="9.0.45.0" />
   
  </object>
        
        
        
    </form>
</body>
</html>
