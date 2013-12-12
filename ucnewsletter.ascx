<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucnewsletter.ascx.vb" Inherits="ucnewsletter" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>
<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />
<radA:RadAjaxPanel ID="RadAjaxPanel1" runat="server">
</radA:RadAjaxPanel>
<table border="0" cellpadding="0" cellspacing="0" id="newsletter" />
    <tr>
        <td  valign="bottom" align="left" ><asp:Label ID="lblMensagem2" runat="server"></asp:Label>&nbsp;<table  width="460" height="30" border="0" cellpadding="0" cellspacing="0">
	<tr>
		<td align="right">
			<img src="layout/mundialline/images/newsletternew_01.png" style="width:14px; height:30px" /></td>
		<td align="left"  >
            <asp:TextBox ID="txtEmail" runat="server" value='Digite seu e-mail...' 
                onFocus="this.value=='Digite seu e-mail...'?this.value='':void(0)" 
                onBlur="if(this.value=='')this.value='Digite seu e-mail...';" Width="380px"></asp:TextBox>
            </td>
		<td align="right">
			<div class="alinhabt"><asp:ImageButton ID="cmdGravar" runat="server" Height="30px" Width="81px" ImageUrl="~/layout/mundialline/images/newsletternew_03.png" /></div>
                </td>
	</tr>
</table>
            </td>
    </tr>
   </table>
