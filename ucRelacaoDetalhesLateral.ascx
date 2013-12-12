<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucRelacaoDetalhesLateral.ascx.vb" Inherits="ucRelacaoDetalhesLateral" %>
<asp:Panel ID="pnlRelacaoDestaques" runat="server">
    <table width="100%" border="0" cellpadding="0" cellspacing="0" id="Ultimas_Noticias" bgcolor="#ffffff">
      <tr>
        <td class="Titulo">
            Relação de Destaques</td>
      </tr>
      <tr>
        <td height="5"></td>
      </tr>
      <tr>
        <td bordercolor="#ffffff" >
            <asp:DataList ID="dlResultados" runat="server" Width="171px">
                <ItemTemplate>
               <table style="width: 200px">
                        <tr>
                            <td width="10" >
                                <img src="layout/mundialline/images/aponta.gif" /></td>
                            <td style="width: 190px" >
                                <a class="Ultimas_noticias" href="DetalhesDestaques.aspx?cDestaque=<%#DataBinder.Eval(Container.DataItem, "cDestaque")%>">
                                    <%#DataBinder.Eval(Container.DataItem, "tTitulo")%></a></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList></td>
      </tr>
    </table>
</asp:Panel>
