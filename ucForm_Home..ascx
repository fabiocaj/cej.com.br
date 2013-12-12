<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucForm_Home..ascx.vb" Inherits="ucForm_Home" %>

<asp:Panel ID="pnlFormulario" runat="server">
    <table class=formHome  border="0">
        <tr>
            <td style="padding-left:5px">
                <asp:TextBox ID="Nome" runat="server" Width="275Px" Text=Nome 
                    onclick="this.value='';" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left:5px">
                <asp:TextBox ID="Email" runat="server" Width="275Px" Text=E-mail 
                    onclick="this.value='';" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left:5px">
                <asp:TextBox ID="Telefone" runat="server" Width="275Px" Text=Telefone 
                    onclick="this.value='';" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-left:5px; padding-top:5px;" valign=top >
                <asp:TextBox ID="Mensagem" runat="server"  Width="275Px" Height="140px"  
                    Text=Mensagem onclick="this.value='';" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="padding-right:50px;" align="right">
                <asp:Button ID="cmdEnviar" runat="server" CssClass="btComumT" 
                Text="Enviar" Width="54px" />
            </td>
        </tr>
    </table>
</asp:Panel>
<br />