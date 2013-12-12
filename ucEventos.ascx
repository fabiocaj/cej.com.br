<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucEventos.ascx.vb" Inherits="ucEvento" %>
<%@ Register assembly="RadCalendar.Net2" namespace="Telerik.WebControls" tagprefix="rad" %>
<%@ Register assembly="RadAjax.Net2" namespace="Telerik.WebControls" tagprefix="rad" %>
<rad:RadAjaxPanel ID="rapEventos" runat="server">
    <table border="0" width="98%" height="100%">
        <tr>
            <td valign=top class="Resenha">
                <img src="layout/mundialline/images/setainformacao.jpg" 
                    style="width: 21px; height: 9px" />&nbsp; Clique no evento desejado para 
                visualizar os detalhes, clique em uma data desejada no calendário para 
                visualizar os eventos existentes.<br />
                <br />
                <asp:DataList ID="PEventos" runat="server" Width="100%">
                    <ItemTemplate>
                        <table border="0" cellpadding="0" cellspacing="0" width="100%" id="tbEventos">
                            <tr>
                                <td class="Resenha" align="left">
                                    <a href='<%# "DetalhesEventos.aspx?id=" & DataBinder.Eval(Container.DataItem, "cEvento")%>'>
                                    <%# DataBinder.Eval(Container.DataItem, "tEvento") %> </a> 
                                    <span> - </span> 
                                    <span class="dataevento">
                                    <%# DataBinder.Eval(Container.DataItem, "dEventoInicio", "{0:dd/MM/yyyy}") %> - 
                                    <%# DataBinder.Eval(Container.DataItem, "dEventoFim", "{0:dd/MM/yyyy}") %>
                                    </span> 
                                    </td>
                            </tr>
                       
                                <td class="Resenha">
                                    <%#DataBinder.Eval(Container.DataItem, "tInformacoes")%><br>Local:
                                    <%# DataBinder.Eval(Container.DataItem, "tLocal") %><br />
                                </td>
                            </tr>
                      
                            <tr>
                                <td class="saibaMais">
                                    <hr></hr>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
            <td class="pontilhado" valign="top">
                </td>
            <td valign="top" align="center" width="150">
                <rad:RadCalendar ID="rcEventos1" Runat="server" 
                    CssClass="calendarWrapper2" EnableMultiSelect="False" EnableViewSelector="True" 
                    OperationType="Server" Skin="Default">
                </rad:RadCalendar>
                <br />
                <br />
                <rad:RadCalendar ID="rcEventos2" Runat="server" 
                    CssClass="calendarWrapper2" EnableMultiSelect="False" EnableViewSelector="True" 
                    OperationType="Server" Skin="Default">
                </rad:RadCalendar>
            </td>
        </tr>
    </table>
    &nbsp;<rad:AjaxLoadingPanel ID="AjaxLoadingPanel1" Runat="server" height="75px" 
        width="75px">
    <img alt="loading..." src="RadControls/Ajax/Skins/Default/Loading.gif" />
</rad:AjaxLoadingPanel>
    
</rad:RadAjaxPanel>
<rad:RadAjaxManager ID="RadAjaxManager1" runat="server">
    <AjaxSettings>
        <rad:AjaxSetting AjaxControlID="rcEventos1">
            <UpdatedControls>
                <rad:AjaxUpdatedControl ControlID="rapEventos" 
                    LoadingPanelID="AjaxLoadingPanel1" />
            </UpdatedControls>
        </rad:AjaxSetting>
        <rad:AjaxSetting AjaxControlID="rcEventos2">
            <UpdatedControls>
                <rad:AjaxUpdatedControl ControlID="rapEventos" 
                    LoadingPanelID="AjaxLoadingPanel1" />
            </UpdatedControls>
        </rad:AjaxSetting>
    </AjaxSettings>
</rad:RadAjaxManager>



<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
                        
                    



