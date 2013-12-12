<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucdestaque_noticias.ascx.vb" Inherits="ucdestaque_noticias" %>
<%@ Register assembly="RadAjax.Net2" namespace="Telerik.WebControls" tagprefix="radA" %>


<link href="layout/mundialline/css/estilos.css" rel="stylesheet" type="text/css" />

                                <table width="100%" border="0" cellpadding="0" cellspacing="0" id="Noticias">
  <tr>
    <td >
        <radA:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
                <radA:AjaxSetting AjaxControlID="cmbCategorias">
                    <UpdatedControls>
                        <radA:AjaxUpdatedControl ControlID="RadAjaxPanel1" />
                    </UpdatedControls>
                </radA:AjaxSetting>
            </AjaxSettings>
        </radA:RadAjaxManager>
        <div class="rowElem">
        <asp:DropDownList ID="cmbCategorias" runat="server" AutoPostBack="True" Width=440px  >
        </asp:DropDownList>
        	</div>
      </td>
  </tr>
  <tr>
    <td class="linha2">
        <radA:RadAjaxPanel ID="RadAjaxPanel1" LoadingPanelID="AjaxLoadingPanel1" runat="server" height="100%" width="100%">
            <table width="100%">
                <tr>
                    <td width="100%" ><asp:DataList ID="dlResultados" runat="server" RepeatColumns="1" 
                            Width="100%">
                        <ItemTemplate>
                            <table border="0" cellpadding="0" cellspacing="0" width="440px" >
                                <tr>
                                    <td width="100px">
                                        <img id="bordag2" 
                                            alt='<%#fQuebraTextoTitulo(DataBinder.Eval(Container.DataItem, "tTitulo"))%>' 
                                            height="93" 
                                            src='<%#fRetornaImagemNoticia(DataBinder.Eval(Container.DataItem, "cNoticia"))%>' 
                                            width="114" /> </td>
                                    <td align="left" class="coluna2" valign="top" >
                                        <table id="Txt_Modulos0" border="0" cellpadding="0" cellspacing="0" 
                                            width="100%">
                                            <tr>
                                                <td style="padding-left:5px">
                                                    <h1 class="Subtitulo">
                                                        <%#fQuebraTextoTitulo(DataBinder.Eval(Container.DataItem, "tTitulo"))%><h1 />
                                                        </h1>
                                                    </td>
                                            </tr>
                                            <tr>
                                                <td height="4px">
                                                    </td>
                                            </tr>
                                                <tr>
                                                    <td>
                                                        <h2 class="Resenha">
                                                            <a class="Links" 
                                                                href='DetalhesNoticias.aspx?cNoticia=<%# DataBinder.Eval(Container.DataItem, "cNoticia")%>'>
                                                            <%#fQuebraTextoResenha(DataBinder.Eval(Container.DataItem, "tChamada"))%> </a>
                                                            <h2 />
                                                            </h2>
                                                        </td>
                                                    </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <hr/ width="98%"></hr/>
                                    </td></tr></table></ItemTemplate></asp:DataList></td></tr></table><radA:AjaxLoadingPanel ID="AjaxLoadingPanel1" Runat="server" height="75px" 
            width="75px">
            <img alt="loading..." src="RadControls/Ajax/Skins/Default/Loading.gif" /></radA:AjaxLoadingPanel></radA:RadAjaxPanel></td></tr></table>