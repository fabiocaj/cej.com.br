<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDestaques.ascx.vb" Inherits="ucDestaques" %>
<table id="DestaquesHome" border="0" cellpadding="0" cellspacing="0" width="100%">
    <tr>
        <td>
<asp:DataList ID="dlDestaques" RepeatColumns="1" RepeatDirection="Horizontal" 
                runat="server" Width="100%">
    <ItemTemplate > 
        <TABLE cellSpacing="0" cellPadding="0" border="0" align=center >
                    <TR> 
               <td align="left">                    
               <!--<a href='<%# "DetalhesDestaques.aspx?cDestaque=" & DataBinder.Eval(Container.DataItem,"cDestaque") %>'> -->
               <h1 class="Subtitulo"><%#DataBinder.Eval(Container.DataItem, "tTitulo")%></h1>
               <!-- </a> -->
               </td>
           </TR>
                 <TR>
                <TD align="left"  >
                <!--  -->
                <h2 class="Resenha">
                <a href='<%# "DetalhesDestaques.aspx?cDestaque=" & DataBinder.Eval(Container.DataItem,"cDestaque") %>' class='Links'>
                <%#DataBinder.Eval(Container.DataItem, "tChamada")%>
                </a>
                </h2>
               <!--   -->
                </TD>
            </TR>
              <TR>
                <TD align=center  id="semimagem">
                <%#fRetornaCaminhoImagem(DataBinder.Eval(Container.DataItem, "tImagem"))%></TD>
           </TR>
        </TABLE>
    </ItemTemplate>
    <ItemStyle VerticalAlign="top" />
</asp:DataList></td>
    </tr>
</table>
