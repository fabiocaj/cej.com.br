<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucRedeCredenciada.ascx.vb" Inherits="ucRedeCredenciada" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<rada:radajaxpanel id="rapRede" runat="server" width="100%">
<table width="95%" border="0" cellpadding="0" cellspacing="0">

  <tr>
    <td style="width: 35px" class="TituloRedeDescontosInternas">&nbsp;Estado:</td>
  </tr>
  
  <tr>
    <td colspan="1" class="TituloRedeDescontosInternas"><asp:DropDownList id="cmbEstados" AutoPostBack="True" runat="server" Width="170px" CssClass="ImputRedeDescontos"></asp:DropDownList></td>
  </tr>
    <tr>
        <td colspan="1"></td>
    </tr>
  <tr>
    <td style="width: 35px" class="TituloRedeDescontosInternas">Cidade:</td>
  </tr>
  <tr>
    <td colspan="1" class="TituloRedeDescontosInternas"><asp:DropDownList id="cmbCidades" AutoPostBack="True" runat="server" Width="170px" CssClass="ImputRedeDescontos"></asp:DropDownList></td>
  </tr>
    <tr>
        <td colspan="1"></td>
    </tr>
    <tr>
        <td style="width: 35px; height: 20px;" class="TituloRedeDescontosInternas">Categoria:</td>
    </tr>
  <tr>
    <td align="left" colspan="1" class="TituloRedeDescontosInternas"><asp:DropDownList id="cmbCategorias" runat="server" Width="170px" CssClass="ImputRedeDescontos" AutoPostBack="True"></asp:DropDownList></td>
  </tr>
  <tr>
    <td colspan="1"></td>
  </tr>
  <asp:Panel ID="pnlEspecialidades" runat="Server">
    <tr>
        <td style="width: 35px; height: 19px;" class="TituloRedeDescontosInternas">Especialidade:</td>
    </tr>
  <tr>
    <td align="left" colspan="1" class="TituloRedeDescontosInternas"><asp:DropDownList id="cmbEspecialidades" runat="server" Width="170px" CssClass="ImputRedeDescontos"></asp:DropDownList></td>
  </tr>
  </asp:Panel>
  <tr>
    <td colspan="1"></td>
  </tr>
  <tr>
    <td align=right style="padding:9px 9px 0px 0px"><asp:Button id="cmdConsultar" runat="server" Text=""  CssClass="btConsultaRede"></asp:Button></td>
  </tr>
</table></rada:radajaxpanel>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
