<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DetalhesMembros.aspx.vb" Inherits="DetalhesMembros" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<link href="membros/css/StyleSheet.css" rel="stylesheet" type="text/css" />
<body>
    <form id="form1" runat="server">
        <br><br><table  border="0" cellpadding="0" cellspacing="0" align="center">
	    <tr>
		    <td>
			    <img src="membros/img/box_01.png" width="32" height="19" alt=""></td>
		    <td height="19px" style="background-image:url(membros/img/box_02.png); background-repeat:repeat-x">
			    </td>
		    <td>
			    <img src="membros/img/box_03.png" width="24" height="19" alt=""></td>
	    </tr>
	    <tr>
		    <td width="32px" style="background-image:url(membros/img/box_04.png); background-repeat:repeat-y">
			    </td>
		    <td bgcolor="#ffffff">
    <table border="0" align="center" cellpadding="0" cellspacing="0" width="800">
      <tr>
        <td class="imagem" width="220">
            <asp:Image runat="server" ID="imgFoto" Width="213" Height="266" />
        </td>
        <td width="800" valign="top">
        
            <table border="0" cellpadding="0" cellspacing="0" width="100%">
                <tr>
                    <td align="left" class="header">
                        <asp:Label ID="lblNome" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left" height="30">
                    </td>
                </tr>
                <tr>
                    <td align="left" class="ajustetd">
                        <span class="titulo">Cargo:</span> <span class="descricao">
                        <asp:Label ID="lblCargo" runat="server"></asp:Label>
                        </span>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="ajustetd">
                        <span class="titulo">Departamento:</span> <span class="descricao">
                        <asp:Label ID="lblDepartamento" runat="server"></asp:Label>
                        </span>
                    </td>
                </tr>
                <tr>
                    <td align="left" class="ajustetd">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="left" class="ajustetd">
                        <span class="titulo">Informações Gerais</span>
                    </td>
                </tr>
                <tr>
                    <td height="4px">
                    </td>
                </tr>
                <tr>
                    <td align="left" class="ajustetd">
                        <span class="descricao">
                        <asp:Label ID="lblInformacoes" runat="server"></asp:Label>
                        </span>&nbsp;</td>
                </tr>
            </table>
        </td>
      </tr>
        <tr>
            <td bgcolor="#626262" colspan="2" height="25" valign="top">
            </td>
        </tr>
    </table>
    </td>
		    <td width="24px" style="background-image:url(membros/img/box_06.png); background-repeat:repeat-y">
			    </td>
	    </tr>
	    <tr>
		    <td>
			    <img src="membros/img/box_07.png" width="32" height="26" alt=""></td>
		    <td height="26px" style="background-image:url(membros/img/box_08.png); background-repeat:repeat-x">
    			
		    <td>
			    <img src="membros/img/box_09.png" width="24" height="26" alt=""></td>
	    </tr>
    </table></center>
    </form>
</body>
</html>
