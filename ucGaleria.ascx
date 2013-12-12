<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucGaleria.ascx.vb" Inherits="ucGaleria" %>
     
    <asp:DataList ID="dlFotos" runat="server" RepeatColumns="5">
    <ItemTemplate>
    <table  border="0">
<tr>
    <td  style="width:125px;" rowspan="2">

			
				<a href='<%# fRetornaImagem( DataBinder.Eval(Container.DataItem, "tFoto") ) %>' rel="lightbox[roadtrip]"><img src='<%# fRetornaImagem( DataBinder.Eval(Container.DataItem, "tFoto") ) %>'  width=120px></a>
    </td>

    <td class="Subtitulo">
        <%#DataBinder.Eval(Container.DataItem, "tLegenda")%></td>
</tr>
<table>
<table>
<tr>
    <td class="Resenha" style="height:50px;">
      </td>
</tr>
</table>

    </ItemTemplate>
    </asp:DataList>
