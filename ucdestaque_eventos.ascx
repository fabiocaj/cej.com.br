<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucdestaque_eventos.ascx.vb" Inherits="uceventos" %>
    
    <asp:DataList ID="dlEventos" runat="server" Width="100%">
        <ItemTemplate>
            <table  border="0" cellpadding="0" cellspacing="0" width="100%">
                <tr>
                <td class="Subtitulo"  rowspan="5" width="105" align="left">
                    <a href='DetalhesEventos.aspx?id=<%# DataBinder.Eval(Container.DataItem, "cEvento")%>'>
                    <img ID="bordag1" height="64" 
                        src='<%# fRetornaImagemEvento(DataBinder.Eval(Container.DataItem, "tImagemPequena"))%>' 
                        width="90" /></a></td>                  
                    <td class="Subtitulo" width="88%">
                        <%# DataBinder.Eval(Container.DataItem, "tEvento") %></td>
              </tr>
               <tr>
                   <td align="left" class="Resenha">
                       <%# DataBinder.Eval(Container.DataItem, "dEventoInicio", "{0:dd/MM/yyyy}") %> -
                       <%# DataBinder.Eval(Container.DataItem, "dEventoFim", "{0:dd/MM/yyyy}") %></td>
              </tr>
              <tr>
                  <td align="left" class="Resenha">
                      <%#DataBinder.Eval(Container.DataItem, "tInformacoes")%></td>
              </tr>
              <tr>
                  <td class="Resenha">
                      Local: <%# DataBinder.Eval(Container.DataItem, "tLocal") %><br />
                  </td>
              </tr>
              <tr>
                  <td class="saibaMais">
                      <a href='DetalhesEventos.aspx?id=<%# DataBinder.Eval(Container.DataItem, "cEvento") %>'>
                      Saiba Mais &gt;&gt;</a></td>
              </tr>
              <tr>
                <td class="saibaMais" colspan="3">  
                    <img src="imagens/lineH.png" /></td>
              </tr>
            </table>
             
        </ItemTemplate>
    
    </asp:DataList>
