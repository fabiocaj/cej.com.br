<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucVideos.ascx.vb" Inherits="ucVideos" %>
<%@ Register assembly="RadAjax.Net2" namespace="Telerik.WebControls" tagprefix="radA" %>
<radA:RadAjaxPanel ID="rapVideo" runat="server" Width="100%" Height="100%">
       <table width="150px" border="0" id="RelacaoPlayVideo"  >
           <tr>
               <td>
                   <asp:Label ID="lblVideo" runat="server"></asp:Label>
                   <asp:Label ID="lblCodigoVideo" runat="server" Visible="False"></asp:Label>
                   <asp:Label ID="lblCodigoVideoPrimeiro" runat="server" Visible="False"></asp:Label>
                   <asp:Label ID="lblCodigoVideoUltimo" runat="server" Visible="False"></asp:Label>
               </td>
           </tr>
           <tr>
               <td>
                   <table >
                       <tr>
                           <td width="25px">
                               <asp:ImageButton ID="cmdVideosAnteriores" runat="server" CssClass="botaoLeft" 
                            ImageUrl="~/imagens/1.jpg" />
                           </td>
                           <td class="RelacaoVideos" >
                               <asp:DataList ID="dlVideos" runat="server" RepeatColumns="5">
                                   <ItemTemplate>
                                       <table >
                                           <tr>
                                               <td>
                                                   <a href='Videos.aspx?cVideo=<%# DataBinder.Eval(Container.DataItem, "cVideo") %>'>
                                                   <img src='http://i4.ytimg.com/vi/<%# DataBinder.Eval(Container.DataItem, "tCodigoVideo") %>/default.jpg' />
                                                   </a> 
                                               </td>
                                           </tr>
                                           <tr>
                                               <th >
                                                   <%#DataBinder.Eval(Container.DataItem, "tVideo")%></th>
                                           </tr>
                                       </table>
                                   </ItemTemplate>
                               </asp:DataList>
                           </td>
                           <td width="25px">
                               <asp:ImageButton ID="cmdProximosVideos" runat="server" 
                                   ImageUrl="~/imagens/2.jpg" />
                           </td>
                       </tr>
                   </table>
               </td>
           </tr>
       </table>
</radA:RadAjaxPanel>
