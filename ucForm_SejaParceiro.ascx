<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucForm_SejaParceiro.ascx.vb" Inherits="ucForm_SejaParceiro" %>
<asp:Panel ID="pnlFormulario" runat="server">
<table border="0" cellpadding="0" cellspacing="0" width="100%" style="border:1px solid #cccccc; background:#eeeeee">
    <tr>
        <td align="left" style="padding-left:8px; padding-top:8px;font-family:Arial; font-size:12px"  >
            Estabelecimento Comercial<br />
            <br />
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="400" style="height: 20px">
                        Empresa</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Empresa_Comer" runat="server" Width="380px"></asp:TextBox></td>
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
                        <asp:TextBox ID="Endereco_Comer" runat="server" Width="300px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Bairro_Comer" runat="server" Width="150px"></asp:TextBox></td>
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
                        <asp:TextBox ID="Cidade_Comer" runat="server" Width="150px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Estado_Comer" runat="server" Width="150px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="CEP_Comer" runat="server" Width="80px"></asp:TextBox></td>
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
                        <asp:TextBox ID="Tel_Comer" runat="server" Width="100px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Fax_Comer" runat="server" Width="100px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Email_Comer" runat="server" Width="150px"></asp:TextBox></td>
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
                        <asp:TextBox ID="Site_Comer" runat="server" Width="150px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Contato_Comer" runat="server" Width="130px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="CNPJ_Comer" runat="server" Width="150px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="170">
                        Inscrição Estadual</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="InscricaoEstadual_Comer" runat="server" Width="400px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="170">
                        Ramo de Atividade</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Ramo_Comer" runat="server" Width="400px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="170">
                        Produtos/Serviços</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="ProdutoServico_Comer" runat="server" Width="400px"></asp:TextBox></td>
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
<br />
