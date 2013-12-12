<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucForm_ContatoRodape.ascx.vb" Inherits="ucForm_ContatoRodape" %>
	
<asp:Panel ID="pnlFormulario" runat="server">

<table  border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td width="24" height="24">&nbsp;</td>
    <td>&nbsp;</td>
    <td width="24" height="24"></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td class=fundoRed>
    <table class="fundoForm" border="0">
    <tr>
        <td>
            <p class="textoForm">
                Nome</p>
        </td>
        <td>
           <asp:TextBox ID="TextBox1" runat="server" Width=250px> </asp:TextBox> 
        </td>
    </tr>
    <tr>
        <td>
            <p class="textoForm">
                E-Mail</p>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"  Width=250px></asp:TextBox> 
        </td>
    </tr>
    <tr>
        <td>
            <p class="textoForm">
                Telefone</p>
        </td>
        <td>
           <asp:TextBox ID="TextBox3" runat="server"  Width=250px></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align=right style="padding-right:12px;" colspan="2">
            <asp:Button ID="cmdEnviar" runat="server" Text="Enviar"  CssClass="btComum" />
        </td>
    </tr>
    <tr>
        <td class="style2">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

    
    </td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td width="24" height="24">&nbsp;</td>
    <td>&nbsp;</td>
    <td width="24" height="24">&nbsp;</td>
  </tr>
</table>
</asp:Panel>

<p>
            &nbsp;</p>


