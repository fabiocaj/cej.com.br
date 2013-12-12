<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucultimas_noticias.ascx.vb" Inherits="ucultimas_noticias" %>
<asp:Panel ID="pnlUltimasNoticias" runat="server">
</asp:Panel>
<table width="100%" border="0" cellspacing="0" cellpadding="0" align="center">
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_01.gif" /></td>
    <td class="cima" height="49">
            <h1 class="TxtTituloNoticia">Últimas Notícias</h1>
                </td>
    <td><img src="layout/mundialline/images/layoutseguros_06.gif"/></td>
  </tr>
  <tr>
    <td class="esquerda" width="13"></td>
    <td bgcolor="#ffffff">
    <asp:DataList ID="dlResultados" runat="server" Width="171px">
        <ItemTemplate>
            <table cellpadding="0px" cellspacing="0px" class="tracoultimanoticias" style="width: 200px">
                <tr>
                    <td width="10">
                        <img src="layout/mundialline/images/aponta.gif" /></td>
                    <td style="width: 190px" align="left">
                        <a  href='DetalhesNoticias.aspx?cNoticia=<%#DataBinder.Eval(Container.DataItem, "cNoticia")%>' class="Ultimas_noticias">
                        <%#DataBinder.Eval(Container.DataItem, "tTitulo")%></a></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    
            </td>
    <td class="direita" width="18"></td>
  </tr>
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_15.gif" /></td>
    <td class="baixo" height="12"></td>
    <td><img src="layout/mundialline/images/layoutseguros_18.gif" /></td>
  </tr>
</table>


