<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucRedeCredenciadaComResultado.ascx.vb" Inherits="ucRedeCredenciadaComResultado" %>
<%@ Register Assembly="RadAjax.Net2" Namespace="Telerik.WebControls" TagPrefix="radA" %>

<radA:RadAjaxPanel ID="rapRede" runat="server" Width="100%" BackColor="White">
<table cellpadding="1" id="TabelaPesquisaResultado" width="100%">
    <tr>
        <td style="width: 86px">
        </td>
        <td style="width: 2px">
        </td>
        <td>
            &nbsp;</td>
    </tr>
        <tr>
            <td style="width: 86px" bgcolor="ghostwhite">
                Estado</td>
            <td style="width: 2px" bgcolor="ghostwhite">
                :</td>
            <td bgcolor="ghostwhite">
<asp:DropDownList ID="cmbEstados" runat="server" AutoPostBack="True">
</asp:DropDownList></td>
        </tr>
    <tr>
        <td style="width: 86px">
                Cidade</td>
        <td style="width: 2px">
            :</td>
        <td>
<asp:DropDownList ID="cmbCidades" runat="server" AutoPostBack="True">
</asp:DropDownList></td>
    </tr>
        <tr>
            <td style="width: 86px" bgcolor="#f8f8ff">
                Categoria</td>
            <td style="width: 2px" bgcolor="#f8f8ff">
                :</td>
            <td bgcolor="#f8f8ff">
<asp:DropDownList ID="cmbCategorias" runat="server">
</asp:DropDownList></td>
        </tr>
    <tr>
        <td style="width: 86px">
            <asp:Label ID="lblEspecialidade" runat="server" Text="Especialidade"></asp:Label></td>
        <td style="width: 2px">
            <asp:Label ID="lblDivisor" runat="server" Text=":"></asp:Label></td>
        <td colspan="1">
<asp:DropDownList ID="cmbEspecialidades" runat="server">
</asp:DropDownList></td>
    </tr>
    <tr>
        <td style="width: 86px">
        </td>
        <td style="width: 2px">
        </td>
        <td align="right" colspan="1">
<asp:Button ID="cmdConsultar" runat="server" Text="Consultar" /></td>
    </tr>
    </table>
<br />
<asp:GridView ID="gvResultados" runat="server" AutoGenerateColumns="False" Width="100%" AllowPaging="True">
    <Columns>
        <asp:TemplateField HeaderText="Resultado">
            <ItemTemplate >
                <asp:Label ID="lblCodigoAssociado" runat="server" Text='<%# Bind("cAssociado") %>'
                    Visible="false"></asp:Label>
                <asp:Label ID="lblAssociado" runat="server" Text='<%# fRetornaAssociado(DataBinder.Eval(Container.Dataitem, "tAssociado"), DataBinder.Eval(Container.Dataitem, "tEndereco"), DataBinder.Eval(Container.Dataitem, "tNumero"), DataBinder.Eval(Container.Dataitem, "tComplemento"), DataBinder.Eval(Container.Dataitem, "tTelefone1"), DataBinder.Eval(Container.Dataitem, "tSite"), DataBinder.Eval(Container.Dataitem, "tEmail"), DataBinder.Eval(Container.Dataitem, "tObservacao")) %>'></asp:Label>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Left" Font-Size="16px" Font-Names="arial" ForeColor="#ffffff" BackColor="#ff0000" />
            <ItemStyle Font-Size="11px" Font-Names="arial" ForeColor="#000000" Height="50px" />
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</radA:RadAjaxPanel>
