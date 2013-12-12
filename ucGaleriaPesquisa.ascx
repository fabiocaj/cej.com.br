<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucGaleriaPesquisa.ascx.vb" Inherits="ucGaleriaPesquisa" %>
<%@ Register assembly="RadAjax.Net2" namespace="Telerik.WebControls" tagprefix="radA" %>
<meta http-equiv="Content-Type" content="text/html; charset=windows-1250" />
<link href="css_pirobox/css.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css_pirobox/demo5/style.css" class="piro_style" media="screen" title="white" rel="stylesheet" type="text/css" />

<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/pirobox.js"></script>
<script type="text/javascript">
    $(document).ready(function() {
        $().piroBox({
            my_speed: 400, //animation speed
            bg_alpha: 0.3, //background opacity
            slideShow: true, // true == slideshow on, false == slideshow off
            slideSpeed: 4, //slideshow duration in seconds(3 to 6 Recommended)
            close_all: '.piro_close,.piro_overlay'// add class .piro_overlay(with comma)if you want overlay click close piroBox
        });
    });
</script>
<table width="100%" border="0" cellspacing="0" cellpadding="0" align="left">
  <tr>
    <td id="fontegaleriaimagem" height="49">
            <h1 class=TxtTituloNoticia>Galeria de Imagens</h1>
                </td>
  </tr>
  <tr>
    <td bgcolor="#ffffff">
        &nbsp;<table id="GaleriaImagem" cellpadding="0" cellspacing="0">
        <tr>
            <td class="GaleriaImagemTituloMain"></td>
        </tr>
        <tr>
            <td>
                <table cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td class="CampoPesquisaImagens">
<table cellpadding="0" cellspacing="0"  >
<tr><td valign=top>
   
    &nbsp; &nbsp;</td>
<td valign=top nowrap>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
  <td valign=top >&nbsp; <asp:DropDownList ID="cmbRelacaoCategorias" runat="server">    </asp:DropDownList></td>
  <td valign=top >&nbsp;<asp:TextBox ID="txtPesquisar" runat="server"  ></asp:TextBox></td>
  <td valign=top >&nbsp;<asp:Button ID="cmdPesquisar" runat="server" Text="Pesquisar" CssClass="btComum" /></td>
  <td valign=top >&nbsp; <asp:Button ID="cmdTop10" runat="server" Text="Top 10 Álbuns" CssClass="btComum" /></td>
  
  
  </tr>
</table>

    
  </td>
<tr><td colspan="2" height="5PX" ></td>
</table>
                            <span class="spancaminho">Voc&ecirc; esta em:                             <asp:Label ID="lblCategoria" runat="server" Visible="true"></asp:Label>
&nbsp;-
                            <asp:Label ID="lblAlbum" runat="server"></asp:Label></span>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="pnlAlbuns" runat="server"><br>
<asp:GridView runat=server ID="gvAlbuns" AllowPaging="True" 
    AutoGenerateColumns="False" BorderWidth="0px" Width="100%">
      <Columns>
      
               <asp:TemplateField HeaderText="Álbum">
               <ItemTemplate>
                    <asp:LinkButton ID="lnkAlbum" runat="server" CausesValidation="False" 
                        CommandName="Select" 
                        Text='<% # DataBinder.Eval(Container.Dataitem, "tAlbum") %>'></asp:LinkButton>
                    <asp:Label ID="lblCodigo" runat="server" Visible="false"  
                        Text='<%# DataBinder.Eval(Container.DataItem, "cAlbum") %>'></asp:Label>
                    <asp:Label ID="lblCodigoCategoria" runat="server" Visible="false" 
                        Text='<%# DataBinder.Eval(Container.DataItem, "cCategoriaFoto") %>'></asp:Label>
               </ItemTemplate>
              <HeaderStyle HorizontalAlign="Left" />
          </asp:TemplateField>
                 <asp:TemplateField HeaderText="Categoria">
    <ItemTemplate>
        <asp:LinkButton ID="lnkCategoria" runat="server" CausesValidation="False" 
                        CommandName="Select" 
                        
            Text='<% # DataBinder.Eval(Container.Dataitem, "tCategoriaFoto") %>'></asp:LinkButton>
    </ItemTemplate>
        <HeaderStyle HorizontalAlign="Left" />
    </asp:TemplateField>
      <asp:TemplateField HeaderText="Quantidade de Fotos">
          <ItemTemplate>
            <asp:Label ID="lblQuantidade" runat="server" 
                  Text='<%# DataBinder.Eval(Container.DataItem, "qFotos") %>'></asp:Label>
          </ItemTemplate>
              <HeaderStyle HorizontalAlign="Left" />
          </asp:TemplateField>
          </Columns>
    </asp:GridView> 
                            </asp:Panel>
    
                <br>
            </td>
    </tr>
        <tr>
            <td>
                <asp:Panel ID="pnlCategorias" runat="server">
                <asp:GridView runat=server ID="gvCategorias" AllowPaging="True" 
                AutoGenerateColumns="False" BorderWidth="0px" Width="100%">
                  <Columns>
                <asp:TemplateField HeaderText="Categorias">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkCategoria" runat="server" CausesValidation="False" 
                    CommandName="Select" 
                    Text='<% # DataBinder.Eval(Container.Dataitem, "tCategoriaFoto") %>'></asp:LinkButton>
                </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" />
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Quantidade de Fotos">
                      <ItemTemplate>
                            <asp:Label ID="lblQuantidade" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "qFotos") %>'></asp:Label>
                            <asp:Label ID="lblCodigo" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container.DataItem, "cCategoriaFoto") %>'></asp:Label>
                      </ItemTemplate>
                          <HeaderStyle HorizontalAlign="Left" />
                      </asp:TemplateField>
                </Columns>
                     </asp:GridView>
                </asp:Panel>
                <asp:Panel ID="pnlGalerias" runat="server">
                    <asp:GridView ID="gvGalerias" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" BorderWidth="0px" Width="100%">
                        <Columns>
                                               <asp:TemplateField HeaderText="Álbum">
                                               <ItemTemplate>
                                                    <asp:LinkButton ID="lnkAlbum" runat="server" CausesValidation="False" 
                                                        CommandName="Select" 
                                                        Text='<% # DataBinder.Eval(Container.Dataitem, "tAlbum") %>'></asp:LinkButton>
                                                    <asp:Label ID="lblCodigo" runat="server" Visible="false"  Text='<%# DataBinder.Eval(Container.DataItem, "cAlbum") %>'></asp:Label>
                                                    <asp:Label ID="lblCodigoCategoria" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container.DataItem, "cCategoriaFoto") %>'></asp:Label>
                                               </ItemTemplate>
                                              <HeaderStyle HorizontalAlign="Left" />
                                          </asp:TemplateField>
                            <asp:TemplateField HeaderText="Quant. Imagem">
                                <ItemTemplate>
                                    <asp:Label ID="lblFotos" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "qFotos") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Data do Cadastro">
                                <ItemTemplate>
                                    <asp:Label ID="lblData" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "dCadastro", "{0:dd/MM/yyyy}") %>'></asp:Label>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
              </td>
    </tr>
</table>
<table cellpadding="0">
    <tr>
        <td valign="top">
            <asp:Panel runat="server" ID="pnlFotos">
            <asp:DataList ID="dlFotos" runat="server" RepeatColumns="7">
                <ItemTemplate>
                    <table border="0">
                        <tr>
                            <td rowspan="2" style="width:125px;">
            <div class="demo">
            <a href='<%# fRetornaImagem( DataBinder.Eval(Container.DataItem, "tFoto"), DataBinder.Eval(Container.DataItem, "cAlbum") ) %>' class="pirobox_gall" title='<%#DataBinder.Eval(Container.DataItem, "tLegenda")%>'>
            <img src='<%# fRetornaImagem( DataBinder.Eval(Container.DataItem, "tFoto"), DataBinder.Eval(Container.DataItem, "cAlbum") ) %>' 
                                    width="120px">
            </a></div>
                            </td>
                            <td >&nbsp;&nbsp;</td>
                        </tr>
                        </table>
                </ItemTemplate>
            </asp:DataList>
        </asp:Panel>
        </td>
    </tr>
</table>

        
        
        
        
        
        
        
        
        
        
        
        </td>
  </tr>
  </table>