<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucMembros.ascx.vb" Inherits="ucMembros" %>
<table width="100%" border="0" cellpadding="0" cellspacing="0" id="Membros">
  <tr>
    <td class="MembrosTituloMain">
        &nbsp;</td>
  </tr>
  <tr>
    <td class="linha2">
        <table width="100%">
            <tr>
                <td width="100%" ><asp:DataList ID="dlResultados" runat="server" RepeatColumns="6" 
                        Width="100%">
                    <ItemTemplate>
                    <table><tr><td id="fundomembro">
                    
                    
                    
                    
                    <table width="90" border="0" cellspacing="0" cellpadding="0" >
    <tr>
        <td height="10" valign="bottom" class="efeito"  >
            <a href='<%# "DetalhesMembros.aspx?cMembro=" & DataBinder.Eval(Container.DataItem, "cMembro")%>' title='<%#fQuebraTextoTitulo(DataBinder.Eval(Container.DataItem, "tNome"))%>' rel="gb_pageset[search_sites]" ><img height="64" src='<%#fRetornaImagemMembro(DataBinder.Eval(Container.DataItem, "cMembro"))%>'  id="Img1" width="90"/></a>
                </td>
    </tr>
    <tr>
        <td align="center" valign="middle" height="17px" class="nomefoto">
            <%#fQuebraTextoTitulo(DataBinder.Eval(Container.DataItem, "tNome"))%></td>
    </tr>
    <tr>
        <td height="5px" align="center" valign="top"  ></td>
    </tr>
</table> 
                    
                    
                    </td></tr></table>
                    
                    
                   
                    
                    
                    
                    
                            <!-- <table border="0" cellpadding="0" cellspacing="0" id="Modulos" width="100%" >
                            <tr>
                                <td width="100">
                                    <a href='<%# "DetalhesMembros.aspx?cMembro=" & DataBinder.Eval(Container.DataItem, "cMembro")%>' title='<%#fQuebraTextoTitulo(DataBinder.Eval(Container.DataItem, "tNome"))%>' rel="gb_pageset[search_sites]" ><img height="64" src='<%#fRetornaImagemMembro(DataBinder.Eval(Container.DataItem, "cMembro"))%>'  id="bordag1" width="90"/></a></td>
                                <td align="left" class="coluna2" valign="top" >
                                    <table id="Txt_Modulos" border="0" cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                            <td class="Subtitulo"><%#fQuebraTextoTitulo(DataBinder.Eval(Container.DataItem, "tNome"))%></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" height="2">
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <hr />
                                </td>
                            </tr>
                        </table> -->
                        
                        
                    </ItemTemplate>
                    </asp:DataList></td>
            </tr>
        </table>
    </td>
  </tr>
</table>