<%@ Page Language="VB" AutoEventWireup="false" CodeFile="teste3.aspx.vb" Inherits="teste3" %>

<%@ Register Src="ucLogo.ascx" TagName="ucLogo" TagPrefix="uc1" %>
<%@ Register Src="ucNoticias.ascx" TagName="ucNoticias" TagPrefix="uc2" %>
<%@ Register Src="ucdestaque_noticias.ascx" TagName="ucdestaque_noticias" TagPrefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:ucLogo ID="UcLogo1" runat="server" />
        <br />
        <br />
        <uc3:ucdestaque_noticias ID="Ucdestaque_noticias1" runat="server" />
        &nbsp;</div>
    </form>
</body>
</html>
