<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucPesquisarVideos.ascx.vb" Inherits="ucPesquisarVideos" %>
<table cellpadding="0" cellspacing="0" width="100%" id="Downloads">
    <tr>
        <td style="height: 19px" class="linecombo">
            &nbsp;Pesquisa:
            <asp:TextBox ID="txtPesquisar" runat="server" ></asp:TextBox>
    <asp:Button ID="cmdPesquisar" runat="server" Text="Pesquisar"  CssClass="btComum"/>
        </td>
    </tr>
    <tr>
        <td ><br/>
<asp:GridView ID="gvVideos" runat="server" AutoGenerateColumns="False" 
    ShowHeader="False" Width="100%" BorderStyle="None" BorderWidth="0">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:HyperLink ID="hplVideo" runat="server" NavigateUrl="" Text='<%# fCarregarVideos(DataBinder.Eval(Container.DataItem, "cVideo"), DataBinder.Eval(Container.DataItem, "tVideo"), DataBinder.Eval(Container.DataItem, "tChamada"), DataBinder.Eval(Container.DataItem, "dVideo"), DataBinder.Eval(Container.DataItem, "tCodigoVideo")) %>'></asp:HyperLink>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
            
            </td>
    </tr>
</table>



<br>
