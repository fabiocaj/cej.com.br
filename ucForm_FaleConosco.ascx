<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucForm_FaleConosco.ascx.vb" Inherits="ucForm_FaleConosco" %>
<asp:Panel ID="pnlFormulario" runat="server">



<table border="0" cellpadding="0" cellspacing="0" width="100%" class="contatojair">
    <tr>
        <td align="left" style="padding-left:8px; padding-top:8px;font-family:Arial; font-size:12px"  >
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="220">
            *Nome</td>
        <td width="230px">
            Email</td>
        <td style="width: 100px">
            Telefone</td>
    </tr>
    <tr>
        <td style="width: 100px">
              <asp:TextBox ID="Nome" runat="server" Width="200px"></asp:TextBox></td>
        <td style="width: 100px">
              <asp:TextBox ID="Email" runat="server" Width="200px"></asp:TextBox></td>
        <td style="width: 100px">
            <asp:TextBox ID="Telefone" runat="server" Width="100px"></asp:TextBox>
        </td>
    </tr>
</table>
            <table cellpadding="1" cellspacing="0">
    <tr>
        <td style="width: 100px">
            Mensagem</td>
    </tr>
    <tr>
        <td style="width: 100px">
            <asp:TextBox ID="Mensagem" runat="server"  Width="557px" Height="140px" ></asp:TextBox> </td>
    </tr>   
                <tr>
                    <td align=right style="padding-top:3px">
                        <asp:Button ID="cmdEnviar" runat="server" CssClass="btComum" Text="Enviar" />
                    </td>
                </tr>
</table>
            <br />
            <br />
        </td>
    </tr>
</table>
</asp:Panel>
<br />