<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucForm_RedeSaude.ascx.vb" Inherits="ucForm_RedeSaude" %>
<asp:Panel ID="pnlFormulario" runat="server">
<table border="0" cellpadding="0" cellspacing="0" width="100%" style="border:1px solid #cccccc; background:#eeeeee">
    <tr>
        <td align="left" style="padding-left:8px; padding-top:8px;font-family:Arial; font-size:12px"  >
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="220">
            *Nome</td>
        <td style="width: 100px">
            Email</td>
    </tr>
    <tr>
        <td style="width: 100px">
              <asp:TextBox ID="Nome" runat="server" Width="200px"></asp:TextBox></td>
        <td style="width: 100px">
              <asp:TextBox ID="Email" runat="server" Width="200px"></asp:TextBox></td>
    </tr>
</table>
<table cellpadding="1" cellspacing="0">
    <tr>
        <td style="width: 100px">
            Telefone</td>
    </tr>
    <tr>
        <td style="width: 100px">
              <asp:TextBox ID="Telefone" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
</table>
        </td>
    </tr>
</table>
    <br />
    <table border="0" cellpadding="0" cellspacing="0" width="100%" style="border:1px solid #cccccc; background:#eeeeee">
    <tr>
        <td align="left" style="padding-left:8px; padding-top:8px;font-family:Arial; font-size:12px" >
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="300">
            Cobertura</td>
        <td style="width: 100px">
            Plano</td>
    </tr>
    <tr>
        <td style="width: 100px">
            
              <asp:DropDownList ID="Cobertura" runat="server" Width="280px">
              <asp:ListItem>Selecione a Cobertura</asp:ListItem>
                  <asp:ListItem>Hospitalar / Interna&#231;&#245;es</asp:ListItem>
                  <asp:ListItem>Global - Consultas, exames, parto e interna&#231;&#245;es</asp:ListItem>
                  </asp:DropDownList></td>
        <td style="width: 100px">
           <asp:DropDownList ID="Plano" runat="server">
            <asp:ListItem>Selecione o plano</asp:ListItem>
            <asp:ListItem>Sul Am&eacute;rica</asp:ListItem>
            <asp:ListItem>Bradesco</asp:ListItem>
            <asp:ListItem>Samcil</asp:ListItem>
            <asp:ListItem>Amil</asp:ListItem>
            <asp:ListItem>Unimed</asp:ListItem>
            <asp:ListItem>Amico</asp:ListItem>
            <asp:ListItem>Blue Life</asp:ListItem>
          </asp:DropDownList></td>
    </tr>
</table>
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="180">
            J&aacute; Possui Plano de Saude ?</td>
        <td width="180">
            Qual plano</td>
        <td style="width: 100px">
            Periodo</td>
    </tr>
    <tr>
        <td style="width: 100px">
            <asp:RadioButton ID="Sim" runat="server" Text="Sim" />
              &nbsp;<asp:RadioButton ID="Não" runat="server" Text="Não" /></td>
        <td style="width: 100px">
              <asp:TextBox ID="Qual_Plano" runat="server" Width="150px"></asp:TextBox></td>
        <td style="width: 100px">
              <asp:TextBox ID="Quanto_Tempo" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
</table>
        </td>
    </tr>
</table>
    <br />
    <table border="0" cellpadding="1" cellspacing="0" width="100%" style="border:1px solid #cccccc; background:#eeeeee">
    <tr>
        <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial"  >
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="180">
            *Nome</td>
        <td style="width: 100px">
            Parentesco</td>
        <td style="width: 100px">
            Nascimento</td>
    </tr>
    <tr>
        <td style="width: 100px">
              <asp:TextBox ID="Nome01" runat="server"></asp:TextBox></td>
        <td style="width: 100px">
          
          
            <asp:DropDownList ID="Parentesco01" runat="server">
              <asp:ListItem>Selecione</asp:ListItem>
              <asp:ListItem>Titular</asp:ListItem>
              <asp:ListItem>Pai</asp:ListItem>
              <asp:ListItem>M&atilde;e</asp:ListItem>
              <asp:ListItem>Filho</asp:ListItem>
              <asp:ListItem>C&ocirc;njuge</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 100px">
              <asp:TextBox ID="Nascimento01" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
</table>
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="180">
            *Nome</td>
        <td style="width: 100px">
            Parentesco</td>
        <td style="width: 100px">
            Nascimento</td>
    </tr>
    <tr>
        <td style="width: 100px">
              <asp:TextBox ID="Nome02" runat="server"></asp:TextBox></td>
        <td style="width: 100px">
                <asp:DropDownList ID="Parentesco02" runat="server">
              <asp:ListItem>Selecione</asp:ListItem>
              <asp:ListItem>Titular</asp:ListItem>
              <asp:ListItem>Pai</asp:ListItem>
              <asp:ListItem>M&atilde;e</asp:ListItem>
              <asp:ListItem>Filho</asp:ListItem>
              <asp:ListItem>C&ocirc;njuge</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 100px">
              <asp:TextBox ID="Nascimento02" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
</table>
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="180">
            *Nome</td>
        <td style="width: 100px">
            Parentesco</td>
        <td style="width: 100px">
            Nascimento</td>
    </tr>
    <tr>
        <td style="width: 100px">
            <asp:TextBox ID="Nome03" runat="server"></asp:TextBox></td>
        <td style="width: 100px">
                <asp:DropDownList ID="Parentesco03" runat="server">
              <asp:ListItem>Selecione</asp:ListItem>
              <asp:ListItem>Titular</asp:ListItem>
              <asp:ListItem>Pai</asp:ListItem>
              <asp:ListItem>M&atilde;e</asp:ListItem>
              <asp:ListItem>Filho</asp:ListItem>
              <asp:ListItem>C&ocirc;njuge</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 100px">
              <asp:TextBox ID="Nascimento03" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
</table>
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="180">
            *Nome</td>
        <td style="width: 100px">
            Parentesco</td>
        <td style="width: 100px">
            Nascimento</td>
    </tr>
    <tr>
        <td style="width: 100px">
              <asp:TextBox ID="Nome04" runat="server"></asp:TextBox></td>
        <td style="width: 100px">
                <asp:DropDownList ID="Parentesco04" runat="server">
              <asp:ListItem>Selecione</asp:ListItem>
              <asp:ListItem>Titular</asp:ListItem>
              <asp:ListItem>Pai</asp:ListItem>
              <asp:ListItem>M&atilde;e</asp:ListItem>
              <asp:ListItem>Filho</asp:ListItem>
              <asp:ListItem>C&ocirc;njuge</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 100px">
              <asp:TextBox ID="Nascimento04" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
</table>
<table cellpadding="1" cellspacing="0">
    <tr>
        <td width="180">
            *Nome</td>
        <td style="width: 100px">
            Parentesco</td>
        <td style="width: 100px">
            Nascimento</td>
    </tr>
    <tr>
        <td style="width: 100px">
              <asp:TextBox ID="Nome05" runat="server"></asp:TextBox></td>
        <td style="width: 100px">
            <asp:DropDownList ID="Parentesco05" runat="server">
              <asp:ListItem>Selecione</asp:ListItem>
              <asp:ListItem>Titular</asp:ListItem>
              <asp:ListItem>Pai</asp:ListItem>
              <asp:ListItem>M&atilde;e</asp:ListItem>
              <asp:ListItem>Filho</asp:ListItem>
              <asp:ListItem>C&ocirc;njuge</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 100px">
              <asp:TextBox ID="Nascimento05" runat="server" Width="100px"></asp:TextBox></td>
    </tr>
</table>
        </td>
    </tr>
</table>
    <br />
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td align="right" style="padding-right: 20px">
                <asp:Button ID="cmdEnviar" runat="server" Text="Enviar" /></td>
        </tr>
    </table>
</asp:Panel>
<br />