<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucCategoriasArtigos.ascx.vb" Inherits="ucCategoriasArtigos" %>
<table id="ArtigoHeaderGrid">
<tr><th>Artigos</th></tr>
<tr><td style="padding:2px 0px 0px 7px">
<asp:DataList ID="dlCategoriasArtigos" runat="server" RepeatColumns="2" Width="100%">
    <ItemTemplate>
        <a href='Artigos.aspx?cArtCat=<%# DataBinder.Eval(Container.DataItem,"cCategoriaArtigo") %>'><%# DataBinder.Eval(Container.DataItem,"tCategoriaArtigo") %>  (<%#DataBinder.Eval(Container.DataItem, "nItens")%>)</a>
    </ItemTemplate>
</asp:DataList>
</td></tr>
</table>
<br />
<asp:Panel runat="server" ID="pnlCategoriasArtigos">
<table id="ArtigoHeaderGrid">
    <tr>
        <th>
            <asp:Label ID="lblNomeCategoria" runat="server"></asp:Label>
        </th>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="gvArtigos" runat="server" AutoGenerateColumns="False" 
                Width="100%" BorderWidth="0px">
                <Columns>
                    <asp:TemplateField HeaderText="Título">
                        <ItemTemplate>
                            <asp:HyperLink ID="hplArtigo" runat="server" 
                                NavigateUrl='<%# "DetalhesArtigo.aspx?cArtigo=" & DataBinder.Eval(Container.Dataitem,"cArtigo") %>' Text='<%# DataBinder.Eval(Container.Dataitem,"tArtigo") %>'></asp:HyperLink>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fonte">
                        <ItemTemplate>
                            <asp:HyperLink ID="hplFonte" runat="server" 
                                NavigateUrl='<%# "DetalhesArtigo.aspx?cArtigo=" & DataBinder.Eval(Container.Dataitem,"cArtigo") %>' Text='<%# DataBinder.Eval(Container.Dataitem,"tFonte") %>'></asp:HyperLink>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data">
                        <ItemTemplate>
                            <asp:HyperLink ID="hplData" runat="server" 
                                NavigateUrl='<%# "DetalhesArtigo.aspx?cArtigo=" & DataBinder.Eval(Container.Dataitem,"cArtigo") %>' Text='<%# DataBinder.Eval(Container.Dataitem,"dArtigo","{0:dd/MM/yyyy}") %>'></asp:HyperLink>
                        </ItemTemplate>
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Panel>
<asp:Panel runat="server" ID="pnlTopartigos">
<table id="ArtigoHeaderGrid">
    <tr>
        <th>
            Top <asp:Label ID="lblCountTop" runat="server"></asp:Label> - Artigos
        </th>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="gvTopArtigos" runat="server" AutoGenerateColumns="False" 
                Width="100%" BorderWidth="0px">
                <Columns>
                    <asp:TemplateField HeaderText="Título">
                        <ItemTemplate>
                            <asp:HyperLink ID="hplArtigo" runat="server" 
                                NavigateUrl='<%# "DetalhesArtigo.aspx?cArtigo=" & DataBinder.Eval(Container.Dataitem,"cArtigo") %>' Text='<%# DataBinder.Eval(Container.Dataitem,"tArtigo") %>'></asp:HyperLink>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fonte">
                        <ItemTemplate>
                            <asp:HyperLink ID="hplFonte" runat="server" 
                                NavigateUrl='<%# "DetalhesArtigo.aspx?cArtigo=" & DataBinder.Eval(Container.Dataitem,"cArtigo") %>' Text='<%# DataBinder.Eval(Container.Dataitem,"tFonte") %>'></asp:HyperLink>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data">
                        <ItemTemplate>
                            <asp:HyperLink ID="hplData" runat="server" 
                                NavigateUrl='<%# "DetalhesArtigo.aspx?cArtigo=" & DataBinder.Eval(Container.Dataitem,"cArtigo") %>' Text='<%# DataBinder.Eval(Container.Dataitem,"dArtigo","{0:dd/MM/yyyy}") %>'></asp:HyperLink>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Left" />
                        <ItemStyle HorizontalAlign="Left" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Panel>