<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDetalhesNoticias.ascx.vb" Inherits="ucDetalhesNoticias" %>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_01.gif" alt="Decorativo" /></td>
    <td class="cima" >
           <H1 class="TxtTituloNoticia"> <asp:Label ID="lblTitulo" runat="server" ></asp:Label></H1>
            </td>
    <td><img src="layout/mundialline/images/layoutseguros_06.gif" alt="Decorativo"/></td>
  </tr>
  <tr>
    <td class="esquerda" width="13"></td>
    <td bgcolor="#ffffff">
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td height="15" valign="top">
                </td>
            </tr>
            <tr valign="top">
                <td valign="top">
                    <table align="left" border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <table border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td valign="top">
                                            <asp:Image ID="imgImagem" runat="server" Height="300" Width="228" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <div align="justify">
                        <p>
                            <asp:Label ID="lblTexto" runat="server"></asp:Label>
                        </p>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="TxtNoticia" height="25px">
                    <b>Fonte:</b>
                    <asp:Label ID="lblFonte" runat="server" CssClass="TxtNoticia"></asp:Label>
                </td>
            </tr>
        </table>
            </td>
    <td class="direita" width="18"></td>
  </tr>
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_15.gif" alt="Decorativo" /></td>
    <td class="baixo" height="12"></td>
    <td><img src="layout/mundialline/images/layoutseguros_18.gif" alt="Decorativo" /></td>
  </tr>
</table>
