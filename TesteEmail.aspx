<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TesteEmail.aspx.vb" Inherits="TesteEmail" %>

<%@ Register Src="ucPublicidadeLeft.ascx" TagName="ucPublicidadeLeft" TagPrefix="uc11" %>

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
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
    <link href="css/slider.css" media="screen" rel="stylesheet" type="text/css" />
     
</head>
<body background="#ffffff" id="fundo2">
    <form id="form1" runat="server">
    <div>
        &nbsp;&nbsp;&nbsp;<table>
            <tr>
                <td colspan="2">
                    <strong><span style="font-size: 14pt">Teste de Email</span></strong></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    De</td>
                <td>
                    <asp:TextBox ID="txtDe" runat="server" MaxLength="200" Width="400px">jairo@cej.com.br</asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Para</td>
                <td>
                    <asp:TextBox ID="txtPara" runat="server" MaxLength="200" Width="400px">almeida@cej.com.br</asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Assunto</td>
                <td>
                    <asp:TextBox ID="txtAssunto" runat="server" MaxLength="200" Width="400px">Teste de envio de e-mail</asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    Mensagem</td>
                <td>
                    <asp:TextBox ID="txtMensagem" runat="server" MaxLength="200" Width="400px">Mensagem enviado pela p&#225;gina de teste de envio de e-mail</asp:TextBox></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <strong><span style="font-size: 14pt">Configurações Usadas</span></strong></td>
            </tr>
            <tr>
                <td>
                    Servidor SMTP</td>
                <td>
                    <asp:Label ID="lblSMTP" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    Usuário Autenticação</td>
                <td>
                    <asp:Label ID="lblUsuarioAutenticacao" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    Senha Autenticação</td>
                <td>
                    <asp:Label ID="lblSenhaAutenticacao" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="cmdEnviar" runat="server" Text="Enviar" /></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblResposta" runat="server"></asp:Label></td>
            </tr>
        </table>
    </div>
        <br />
    </form>
</body>
</html>
