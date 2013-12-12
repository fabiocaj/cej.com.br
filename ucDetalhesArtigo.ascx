<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDetalhesArtigo.ascx.vb" Inherits="ucDetalhesArtigo" %>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />

<table border="0" cellpadding="0" cellspacing="0" width="100%" ID="Detalhe-Artigo">
  <tr>
    <td  class="textos"><img src="../img/dot.gif" width="1" height="5" border="0" /></td>
  </tr>
    <tr valign="top">
        <td valign="top" class="Titulo">
            <asp:Label ID="lblTitulo" runat="server" CssClass="TxtTituloNoticia"></asp:Label>
                    </td>
    </tr>
    
    <tr valign="top">
        <td class="texto" valign="top" height="10">
            <table cellpadding="0" cellspacing="0" width="100%" >
                <tr>
                    <td class="Caminho">
            <asp:Label ID="lblCategoriaArtigo" runat="server" ></asp:Label>&nbsp;- <asp:Label ID="lblNomeArtigo" runat="server" ></asp:Label>
                    </td>
                    <td class="Caminho" width="100px">
Parte do artigo<asp:DropDownList ID="cmbDetalhesArtigos" runat="server" AutoPostBack="True"></asp:DropDownList>
</td>
                </tr>
            </table>
        </td>
    </tr>
    
    <tr valign="top">
        <td valign="top" height="15">
        </td>
    </tr>
  <tr valign="top">
    <td  class="texto" valign="top">
      <div align="justify">
        <p>
            <asp:Label ID="lblTexto" runat="server" CssClass="TxtNoticia"></asp:Label></p>
      </div></td>
  </tr>
  <tr valign="top">
    <td  class="texto" valign="top">
        <asp:PlaceHolder ID="phFormulario" runat="server"></asp:PlaceHolder>
    </td>
  </tr>
  <tr valign="top">
    <td  class="texto" valign="top">
        <asp:PlaceHolder ID="phIframe" runat="server"></asp:PlaceHolder>
    </td>
  </tr>
    <tr valign="top">
        <td class="texto" valign="top" >
            <asp:PlaceHolder ID="phDownloads" runat="server"></asp:PlaceHolder>
        </td>
    </tr>
    <tr valign="top">
        <td class="texto" valign="top" >
            <asp:PlaceHolder ID="phVideo" runat="server"></asp:PlaceHolder>
        </td>
    </tr>
</table>