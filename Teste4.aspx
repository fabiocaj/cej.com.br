<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Teste4.aspx.vb" Inherits="Teste4" %>

<%@ Register Src="ucpublicidade_main.ascx" TagName="ucpublicidade_main" TagPrefix="uc7" %>

<%@ Register Src="ucdestaque_banner.ascx" TagName="ucdestaque_banner" TagPrefix="uc6" %>

<%@ Register Src="ucRedeCredenciadaComResultado.ascx" TagName="ucRedeCredenciadaComResultado"
    TagPrefix="uc5" %>

<%@ Register Src="ucDicionario.ascx" TagName="ucDicionario" TagPrefix="uc4" %>

<%@ Register Src="ucMenus.ascx" TagName="ucMenus" TagPrefix="uc3" %>

<%@ Register Src="ucHomeRedeDescontos.ascx" TagName="ucHomeRedeDescontos" TagPrefix="uc2" %>

<%@ Register Src="ucPublicidade.ascx" TagName="ucPublicidade" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <uc6:ucdestaque_banner ID="Ucdestaque_banner1" runat="server" />
        <uc7:ucpublicidade_main ID="Ucpublicidade_main1" runat="server" />
        <br />
        <br />
        <br />
        <uc6:ucdestaque_banner ID="Ucdestaque_banner2" runat="server" />
    </form>
</body>
</html>
