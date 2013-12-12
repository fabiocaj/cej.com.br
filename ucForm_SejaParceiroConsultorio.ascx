<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucForm_SejaParceiroConsultorio.ascx.vb" Inherits="ucForm_SejaParceiroConsultorio" %>
<asp:Panel ID="pnlFormulario" runat="server">
    <table border="0" cellpadding="0" cellspacing="0" style="border-right: #cccccc 1px solid;
        border-top: #cccccc 1px solid; background: #eeeeee; border-left: #cccccc 1px solid;
        border-bottom: #cccccc 1px solid" width="100%">
        <tr>
            <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial">
                Cadastre sua empresa ou seu consultório<br />
                <br />
                <table cellpadding="1" cellspacing="0">
                    <tr>
                        <td style="height: 20px" width="400">
                            Empresa</td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:TextBox ID="Empresa" runat="server" Width="380px"></asp:TextBox></td>
                    </tr>
                </table>
                <table cellpadding="1" cellspacing="0">
                    <tr>
                        <td width="320">
                            Endereço</td>
                        <td style="width: 100px">
                            Bairro</td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:TextBox ID="Endereco" runat="server" Width="300px"></asp:TextBox></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="Bairro" runat="server" Width="150px"></asp:TextBox></td>
                    </tr>
                </table>
                <table cellpadding="1" cellspacing="0">
                    <tr>
                        <td width="170">
                            Cidade</td>
                        <td width="170">
                            Estado</td>
                        <td style="width: 100px">
                            CEP</td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:TextBox ID="Cidade" runat="server" Width="150px"></asp:TextBox></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="Estado" runat="server" Width="150px"></asp:TextBox></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="CEP" runat="server" Width="80px"></asp:TextBox></td>
                    </tr>
                </table>
                <table cellpadding="1" cellspacing="0">
                    <tr>
                        <td width="120">
                            Tel</td>
                        <td width="120">
                            Fax</td>
                        <td style="width: 100px">
                            Email</td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:TextBox ID="Tel" runat="server" Width="100px"></asp:TextBox></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="Fax" runat="server" Width="100px"></asp:TextBox></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="Email" runat="server" Width="150px"></asp:TextBox></td>
                    </tr>
                </table>
                <table cellpadding="1" cellspacing="0">
                    <tr>
                        <td width="170">
                            Site</td>
                        <td width="150">
                            Contato</td>
                        <td style="width: 100px">
                            CNPJ</td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:TextBox ID="Site" runat="server" Width="150px"></asp:TextBox></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="Contato" runat="server" Width="130px"></asp:TextBox></td>
                        <td style="width: 100px">
                            <asp:TextBox ID="CNPJ" runat="server" Width="150px"></asp:TextBox></td>
                    </tr>
                </table>
                <table cellpadding="1" cellspacing="0">
                    <tr>
                        <td width="170">
                            Inscrição Estadual</td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:TextBox ID="IncricaoEstadual" runat="server" Width="400px"></asp:TextBox></td>
                    </tr>
                </table>
                <table cellpadding="1" cellspacing="0">
                    <tr>
                        <td width="170">
                            Especialidades</td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:TextBox ID="Especialidades" runat="server" Width="400px"></asp:TextBox></td>
                    </tr>
                </table>
                <table cellpadding="1" cellspacing="0">
                    <tr>
                        <td width="170">
                            Procedimentos Existentes</td>
                    </tr>
                    <tr>
                        <td style="width: 100px">
                            <asp:TextBox ID="Procedimentos" runat="server" Width="400px"></asp:TextBox></td>
                    </tr>
                </table>
                <br />
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td align="right" style="padding-right: 20px">
                            <asp:Button ID="cmdEnviar" runat="server" Text="Enviar" /></td>
                    </tr>
                </table>
                <br />
            </td>
        </tr>
    </table>
</asp:Panel>
