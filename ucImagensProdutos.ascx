<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucImagensProdutos.ascx.vb"
    Inherits="ucImagensProdutos" %>

<link href="css_pirobox/css.css" media="screen" rel="stylesheet" type="text/css" />
<link href="css_pirobox/demo5/style.css" class="piro_style" media="screen" title="white" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/pirobox.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $().piroBox({
            my_speed: 400, //animation speed
            bg_alpha: 0.3, //background opacity
            slideShow: true, // true == slideshow on, false == slideshow off
            slideSpeed: 4, //slideshow duration in seconds(3 to 6 Recommended)
            close_all: '.piro_close,.piro_overlay'// add class .piro_overlay(with comma)if you want overlay click close piroBox
        });
    });
</script>
<asp:DataList ID="dlFotos" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
    <ItemTemplate>
        <a href="<%# fRetornaURLImagens(DataBinder.Eval(Container.DataItem, "cProduto"),DataBinder.Eval(Container.DataItem, "tImagem")) %>" class="pirobox_gall">
            <img src='<%# fRetornaURLImagens(DataBinder.Eval(Container.DataItem, "cProduto"),DataBinder.Eval(Container.DataItem, "tImagem")) %>' alt="CMS - CEJ Informática" width="140"></a>
    </ItemTemplate>
    <ItemStyle VerticalAlign="Top"></ItemStyle>
</asp:DataList>