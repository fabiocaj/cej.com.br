<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucLogin.ascx.vb" Inherits="ucLogin" %>
<%@ Register Assembly="RadInput.Net2" Namespace="Telerik.WebControls" TagPrefix="radI" %>
<table width="100%">
    <tr>
        <td rowspan="4">
            <asp:Label ID="lblInformativo" runat="server" Text="Caso seja o seu primeiro acesso<br>informe o CPF e deixe a senha em branco"></asp:Label></td>
        <td rowspan="4">
            <asp:Panel ID="pnlUsuario" runat="server">
                Bem-vindo
                <asp:Label ID="lblUsuario" runat="server"></asp:Label><br />
                <asp:LinkButton ID="lnkSair" runat="server">Caso não seja você clique aqui</asp:LinkButton></asp:Panel>
            <asp:Panel ID="pnlLogin" runat="server">
                <table width="100%">
                    <tr>
                        <td>
                            CPF</td>
                        <td>
            Senha</td>
                    </tr>
                    <tr>
                        <td>
            <radI:RadMaskedTextBox ID="txtCPF" runat="server" Mask="###.###.###-##"></radI:RadMaskedTextBox></td>
                        <td>
            <asp:TextBox ID="txtSenha" runat="server" MaxLength="10" TextMode="Password"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
            <asp:Button ID="cmdEntrar" runat="server" Text="Entrar" /></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 21px; text-align: center">
            <asp:Label ID="lblMensagem" runat="server"></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 21px; text-align: center">
                            <asp:LinkButton ID="lnkLembrarSenha" runat="server">Clique aqui para lembrar a sua senha</asp:LinkButton></td>
                    </tr>
                </table>
            </asp:Panel>
            <br />
        </td>
    </tr>
</table>
