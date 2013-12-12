<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDetalhesProduto.ascx.vb" Inherits="ucDetalhesProduto" %>
<%@ Register assembly="RadTabStrip.Net2" namespace="Telerik.WebControls" tagprefix="radTS" %>
<%@ Register src="ucImagensProdutos.ascx" tagname="ucImagensProdutos" tagprefix="uc1" %>
<table cellpadding="0" cellspacing="0" ID="DetalhesProdutos">
    <tr>
        <td class="DP-EspacoImagem">
            <table cellpadding="0" cellspacing="0" >
                <tr>
                    <td>
                        <asp:Image ID="imgProduto" runat="server" Height="190px" />
                    </td>
                </tr>
                <tr>
                    <td>
                       </td>
                </tr>
            </table>
        </td>
        <td>
            <table cellpadding="0" cellspacing="0" width="100%">
                <tr>
                    <td style="PADDING-TOP: 8px">
                        <h1>
                            <asp:Label ID="lblProduto" runat="server" CssClass="nomeProduto" 
                                Text="lblProduto"></asp:Label>
                        </h1>
                        <h2>
                            <asp:Label ID="lblFabricante" runat="server" CssClass="fabricante" 
                                Text="lblFabricante"></asp:Label>
                        </h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <h3 class="chamada">
                            <asp:Label ID="lblChamada" runat="server" Text="lblChamada"></asp:Label>
                        </h3>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <!-- <span class="DP-DePrecoFinal"><asp:Label ID="lblValorProduto" runat="server" 
                            Visible="False"></asp:Label></span> -->
                    </td>
                </tr>
                <tr>
                    <td align="right" style="HEIGHT: 57px">
                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                            <tr>
                                <td align="left">
                                    <asp:Button ID="cmdAdicionar" runat="server" CssClass="btComum" 
                                        Text="Adicionar" />
                                </td>
                                <td align="right">
                                    <span class="DP-DePreco"><!-- <asp:Label ID="lblDePrecoProduto" runat="server" Text="lblDePrecoProduto"></asp:Label>-->
                                    <br />
                                    </span>&nbsp;<span class="DP-DePrecoFinal"><!--<asp:Label ID="lblPrecoProduto" runat="server" Text="lblPrecoProduto"></asp:Label>--> 
                                    </span>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    </table>
<table cellpadding="0" cellspacing="0" width="100%" id="TABsProdutos">
    <tr>
        <td class=DetalhesProdutos>
            <radTS:RadTabStrip ID="rtsProduto" runat="server" MultiPageID="rmpProduto" ClickSelectedTab="True">
                 <Tabs>
                        <radTS:Tab ID="MasterTabProduto" runat="server" Text="Descrição do Produto" PageViewID="TabProduto"></radTS:Tab>                            
                        <radTS:Tab ID="MasterTabIncluso" runat="server" Text="Itens Inclusos" PageViewID="TabIncluso"></radTS:Tab>                            
                        <radTS:Tab ID="MasterTabDadosTecnicos" runat="server" Text="Dados Técnicos" PageViewID="TabDadosTecnicos"></radTS:Tab>                            
                        <radTS:Tab ID="MasterTabModoUsar" runat="server" Text="Modo de Usar" PageViewID="TabModoUsar"></radTS:Tab>                            
                        <radTS:Tab ID="MasterTabConexoes" runat="server" Text="Conexões" PageViewID="TabConexoes"></radTS:Tab>                            
                        <radTS:Tab ID="MasterTabImagens" runat="server" Text="Imagens" PageViewID="TabImagens"></radTS:Tab>                            
                  </Tabs>
            </radTS:RadTabStrip>
            <radTS:radmultipage id="rmpProduto" runat="server" width="100%">
                <radTS:pageview id="TabProduto" runat="server">
                    <asp:Label ID="lblDescricaoProduto" runat="server" 
                    Text="lblDescricaoProduto" CssClass="TP-TextoGeral"></asp:Label>
                </radTS:pageview>
                <radTS:pageview id="TabIncluso" runat="server">
                    <asp:Label ID="lblItensInclusos" runat="server" Text="lblItensInclusos" 
                    CssClass="TP-TextoGeral"></asp:Label>
                </radTS:pageview>
                <radTS:pageview id="TabDadosTecnicos" runat="server">
                    <asp:Label ID="lblDadostecnicos" runat="server" Text="lblDadostecnicos" 
                    CssClass="TP-TextoGeral"></asp:Label>
                </radTS:pageview>
                <radTS:pageview id="TabModoUsar" runat="server" width="100%">
                    <asp:Label ID="lblModoUsar" runat="server" Text="lblModoUsar" 
                    CssClass="TP-TextoGeral"></asp:Label>
                </radTS:pageview>
                <radTS:pageview id="TabConexoes" runat="server" width="100%" 
                    CssClass="TP-TextoGeral">
                    <asp:Label ID="lblConexoes" runat="server" Text="lblConexoes" 
                    CssClass="TP-TextoGeral"></asp:Label>
                </radTS:pageview>
                <radTS:pageview id="TabImagens" runat="server" width="100%" CssClass="TP-TextoGeral">
                    <uc1:ucImagensProdutos ID="ucImagensProdutos1" runat="server" />
                    <a id="hook" name="hook"></a>
                </radTS:pageview>
            </radTS:radmultipage>
        </td>
    </tr>
    <tr>
        <td class="TP-TextoDescricao" >
            &nbsp;</td>
    </tr>
</table>