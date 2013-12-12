<%@ Page Language="VB" AutoEventWireup="false" CodeFile="teste5.aspx.vb" Inherits="teste5" %>

<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc12" %>

<%@ Register Src="ucMenuPadrao.ascx" TagName="ucMenuPadrao" TagPrefix="uc11" %>

<%@ Register Src="ucMembros.ascx" TagName="ucMembros" TagPrefix="uc10" %>

<%@ Register Src="ucPublicidade.ascx" TagName="ucPublicidade" TagPrefix="uc7" %>
<%@ Register Src="ucpublicidade_main.ascx" TagName="ucpublicidade_main" TagPrefix="uc8" %>
<%@ Register Src="ucpublicidadel.ascx" TagName="ucpublicidadel" TagPrefix="uc9" %>

<%@ Register Src="ucBanners.ascx" TagName="ucBanners" TagPrefix="uc6" %>

<%@ Register Src="ucdestaque_banner.ascx" TagName="ucdestaque_banner" TagPrefix="uc5" %>

<%@ Register Src="ucLogo.ascx" TagName="ucLogo" TagPrefix="uc4" %>

<%@ Register Src="uclogotipo.ascx" TagName="uclogotipo" TagPrefix="uc3" %>

<%@ Register Src="ucbig_banner.ascx" TagName="ucbig_banner" TagPrefix="uc2" %>

<%@ Register Src="ucRedeCredenciadaComResultado.ascx" TagName="ucRedeCredenciadaComResultado"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
     
</head>
<body background="#ffffff" id="fundo2">
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;<uc12:ucMenus ID="UcMenus1" runat="server" />
    </div>
    </form>
</body>
</html>
