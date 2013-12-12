<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPublicidadeLeft.ascx.vb" Inherits="ucPublicidadeLeft" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<table width="100%" border="0" cellspacing="0" cellpadding="0" align="center">
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_01.gif" /></td>
    <td class="cima" height="49">
            <h1 class="TxtTituloNoticia">Studios</h1>
                </td>
    <td><img src="layout/mundialline/images/layoutseguros_06.gif"/></td>
  </tr>
  <tr>
    <td class="esquerda" width="13"></td>
    <td bgcolor="#ffffff">
         <radA:RadAjaxPanel ID="rapPublicidadesLeft" runat="server" Height="100%" 
                HorizontalAlign="NotSet" LoadingPanelID="" 
                meta:resourcekey="rapPublicidadesLeftResource1" ScrollBars="None">
        <asp:DataList ID="dlPublicidadesLeft" runat="server" 
                meta:resourcekey="dlPublicidadesLeftResource1">
            <ItemTemplate>
                <asp:Label ID="lblPublicidadeLeft" 
                    Text='<%# DataBinder.Eval(Container.DataItem, "tPublicidade") %>' 
                    runat="server" meta:resourcekey="lblPublicidadeLeftResource1"></asp:Label>
            </ItemTemplate>
        </asp:DataList>
            <radA:RadAjaxTimer ID="ratPublicidadesLeft" runat="server" Interval="3000" 
                AutoStart="True" meta:resourcekey="ratPublicidadesLeftResource1" />
        </radA:RadAjaxPanel></td>
    <td class="direita" width="18"></td>
  </tr>
  <tr>
    <td><img src="layout/mundialline/images/layoutseguros_15.gif" /></td>
    <td class="baixo" height="12"></td>
    <td><img src="layout/mundialline/images/layoutseguros_18.gif" /></td>
  </tr>
</table>


