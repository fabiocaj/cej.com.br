<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDicionario.ascx.vb" Inherits="ucDicionario" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<radA:RadAjaxPanel ID="rapDicionario" runat="server" Width="100%">


<table width="100%" border="0" cellpadding="0" cellspacing="0"   bgcolor="#ffffff" id="Ultimas_Noticias">

  <tr>
    <td class="Titulo"  >
        Dicionário
        </td>
  </tr>
  <tr>
    <td style="background-image:url(images/fundodasredes.gif); background-repeat:no-repeat">
      
      
      
<table cellspacing="0">
    <tr>
        <td height="2"></td>
    </tr>
    <tr>
        <td class="TituloRedeDescontosInternas">
            Seção:</td>
    </tr>
    <tr>
        <td class="TituloRedeDescontosInternas">
            <asp:DropDownList ID="cmbDicionarios" runat="server" AutoPostBack="True" CssClass="ImputRedeDescontos" Width="170px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td class="TituloRedeDescontosInternas">
            Especialidade:</td>
    </tr>
    <tr>
        <td class="TituloRedeDescontosInternas">
            <asp:DropDownList ID="cmbVerbetes" runat="server" AutoPostBack="True" CssClass="ImputRedeDescontos" Width="170px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td height="5">
        </td>
    </tr>
    <tr>
        <td>
            &nbsp; &nbsp;
            <asp:Label ID="lblDescricao" runat="server" CssClass="ImputRedeDescontos" Width="170px"></asp:Label></td>
    </tr>
    <tr>
        <td height="8">
        </td>
    </tr>
</table>
      
      
        </td>
  </tr>
</table>


</radA:RadAjaxPanel>
