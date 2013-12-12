<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucGaleriaDeltalhe.ascx.vb" Inherits="layout_mundialline_css_ucGaleriaDeltalhe" %>



<table class="tabelaGaleria" cellpadding="0" cellspacing="0">
   <tr>
        <td align=right>
  
        </td>
    </tr>
    <tr>
        <td align=center>
            <asp:Image ID="Image1" runat="server" 
                ImageUrl="http://www.minhamoto.info/wp-content/uploads/2008/11/eric-granado1.jpg" />
        </td>
    </tr>
    <tr>
        <td>
            <table class="style1">
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="botaoLeft" 
                            ImageUrl="~/imagens/1.jpg" />
                    </td>
                    <td style="width:100%">
                        <asp:DataList ID="DataList1" runat="server" RepeatColumns="5">
                                  <ItemTemplate>
                        <table class="style1">
                                <tr>
                                    <td>
                                        <img src="http://i4.ytimg.com/vi/HW5p7_w-Mu8/default.jpg" /></td>
                                </tr>
                                <tr>
                                    <td>
                                        titulo</td>
                                </tr>
                                <tr>
                                    <td>
                                        exibições</td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        </asp:DataList>
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/imagens/2.jpg" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
