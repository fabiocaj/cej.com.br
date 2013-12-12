<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucDetalhesSecoes.ascx.vb" Inherits="ucDetalhesSecoes" %>

<%@ Register src="uciFrame.ascx" tagname="uciFrame" tagprefix="uc1" %>

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td >
           <H1 class="TxtTituloNoticia"> 
               <asp:Label ID="lblTitulo" runat="server" ></asp:Label>
               <hr width="100%">
           </H1>
            </td>
  </tr>
  <tr>
    <td bgcolor="#ffffff">
        <table border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr valign="top">
                <td valign="top">
                    <table align="left" border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <table border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td valign="top">
                                            <asp:Image ID="imgImagem" runat="server" WIDTH="200" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2" width="10px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <div align="justify">
                        <p>
                            <asp:Label ID="lblTexto" runat="server" ></asp:Label>
                        </p>
                    </div>
                </td>
            </tr>
        </table>
        <center><uc1:uciFrame ID="uciFrame1" runat="server" />
        <br/><br/>
            <asp:PlaceHolder ID="phFormulario" runat="server"></asp:PlaceHolder>
               <asp:PlaceHolder ID="phVideo" runat="server"></asp:PlaceHolder></center>
            </td>
  </tr>
  </table>