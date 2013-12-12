<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ucForm_SegurosPessoais.ascx.vb" Inherits="ucForm_SegurosPessoais" %>
<asp:Panel ID="pnlFormulario" runat="server">
<table border="0" cellpadding="0" cellspacing="0" style="border-right: #cccccc 1px solid;
    border-top: #cccccc 1px solid; background: #eeeeee; border-left: #cccccc 1px solid;
    border-bottom: #cccccc 1px solid" width="100%">
    <tr>
        <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial">
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="220">
                        *Nome Segurado</td>
                    <td style="width: 100px">
                        Nascimento</td>
                    <td style="width: 100px">
                        Sexo</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Nome_Principal" runat="server" Width="200px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Nascimento_Principal" runat="server" Width="80px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:RadioButton ID="M_Principal" runat="server" Text="M" />&nbsp;<asp:RadioButton
                            ID="F_Principal" runat="server" Text="F" /></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="110">
                        Altura</td>
                    <td style="width: 100px">
                        Peso</td>
                    <td style="width: 100px">
                        Estado Civil</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Altura_Principal" runat="server" Width="80px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Peso_Principal" runat="server" Width="80px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:DropDownList ID="EstadoCivil_Principal" runat="server">
                            <asp:ListItem>Solteiro</asp:ListItem>
                            <asp:ListItem>Casado</asp:ListItem>
                            <asp:ListItem>Vi&#250;vo</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="140">
                        Profissão</td>
                    <td width="140">
                        Ocupação</td>
                    <td style="width: 100px">
                        CPF</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Profissão" runat="server" Width="130px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Ocupação" runat="server" Width="130px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="CPF" runat="server" Width="100px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="120">
                        RG</td>
                    <td width="130">
                        Órgão Expeditor</td>
                    <td width="120">
                        Data Expedição</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="RG_Principal" runat="server" Width="100px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="OrgaoExpeditor_Principal" runat="server" Width="100px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="DataExpedicao_Principal" runat="server" Width="100px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="120">
                        Endereço</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Endereco_Principal" runat="server" Width="350px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="140">
                        Bairro</td>
                    <td width="140">
                        Cidade</td>
                    <td width="50">
                        UF</td>
                    <td width="90">
                        CEP</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Bairro_Principal" runat="server" Width="120px"></asp:TextBox></td>
                    <td style="width: 130px">
                        <asp:TextBox ID="Cidade_Principal" runat="server" Width="120px"></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="UF_Principal" runat="server" Width="40px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="CEP_Principal" runat="server" Width="80px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="160">
                        Email</td>
                    <td width="120">
                        Telefone</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Email_Principal" runat="server" Width="150px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Telefone_Principal" runat="server" Width="110px"></asp:TextBox></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    <br />
<table border="0" cellpadding="0" cellspacing="0" style="border-right: #cccccc 1px solid;
    border-top: #cccccc 1px solid; background: #eeeeee; border-left: #cccccc 1px solid;
    border-bottom: #cccccc 1px solid" width="100%">
    <tr>
        <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial">
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="220">
                        *Nome Conjugue</td>
                    <td style="width: 100px">
                        Nascimento</td>
                    <td style="width: 100px">
                        Sexo</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Nome_Conjugue" runat="server" Width="200px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Nascimento_Conjugue" runat="server" Width="80px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:RadioButton ID="M__Conjugue" runat="server" Text="M" />
                        <asp:RadioButton
                            ID="F_Conjugue" runat="server" Text="F" /></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="110">
                        Altura</td>
                    <td style="width: 100px">
                        Peso</td>
                    <td style="width: 100px">
                        Estado Civil</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Altura__Conjugue" runat="server" Width="80px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Peso_Conjugue" runat="server" Width="80px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:DropDownList ID="EstadoCivil_Conjugue" runat="server">
                            <asp:ListItem>Solteiro</asp:ListItem>
                            <asp:ListItem>Casado</asp:ListItem>
                            <asp:ListItem>Vi&#250;vo</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="140">
                        Profissão</td>
                    <td width="140">
                        Ocupação</td>
                    <td style="width: 100px">
                        CPF</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Profissao_Conjugue" runat="server" Width="130px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Ocupacao_Conjugue" runat="server" Width="130px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="CPF_Conjugue" runat="server" Width="100px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="120">
                        RG</td>
                    <td width="130">
                        Órgão Expeditor</td>
                    <td width="120">
                        Data Expedição</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="RG_Conjugue" runat="server" Width="100px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="OrgaoExpeditor_Conjugue" runat="server" Width="100px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="DataExpedicao_Conjugue" runat="server" Width="100px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="120">
                        Endereço</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Endereco_Conjugue" runat="server" Width="350px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="140">
                        Bairro</td>
                    <td width="140">
                        Cidade</td>
                    <td width="50">
                        UF</td>
                    <td width="90">
                        CEP</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Bairro_Conjugue" runat="server" Width="120px"></asp:TextBox></td>
                    <td style="width: 130px">
                        <asp:TextBox ID="Cidade_Conjugue" runat="server" Width="120px"></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="UF_Conjugue" runat="server" Width="40px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="CEP_Conjugue" runat="server" Width="80px"></asp:TextBox></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="160">
                        Email</td>
                    <td width="120">
                        Telefone</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="Email_Conjugue" runat="server" Width="150px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:TextBox ID="Telefone_Conjugue" runat="server" Width="110px"></asp:TextBox></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    <br />
<table border="0" cellpadding="0" cellspacing="0" style="border-right: #cccccc 1px solid;
    border-top: #cccccc 1px solid; background: #eeeeee; border-left: #cccccc 1px solid;
    border-bottom: #cccccc 1px solid" width="100%">
    <tr>
        <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial">
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="320">
                        Nome Dependente 01</td>
                    <td style="width: 100px">
                        Sexo</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="NomeDependente01" runat="server" Width="300px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:RadioButton ID="M_Dependete01" runat="server" Text="M" />
                        <asp:RadioButton
                            ID="F_Dependete01" runat="server" Text="F" /></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="320">
                        Nome Dependente 02</td>
                    <td style="width: 100px">
                        Sexo</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="NomeDependente02" runat="server" Width="300px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:RadioButton ID="M_Dependete02" runat="server" Text="M" />
                        <asp:RadioButton
                            ID="F_Dependete02" runat="server" Text="F" /></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="320">
                        Nome Dependente 03</td>
                    <td style="width: 100px">
                        Sexo</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="NomeDependente03" runat="server" Width="300px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:RadioButton ID="M_Dependete03" runat="server" Text="M" />
                        <asp:RadioButton
                            ID="F_Dependete03" runat="server" Text="F" /></td>
                </tr>
            </table>
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td width="320">
                        Nome Dependente 04</td>
                    <td style="width: 100px">
                        Sexo</td>
                </tr>
                <tr>
                    <td style="width: 100px">
                        <asp:TextBox ID="NomeDependente04" runat="server" Width="300px"></asp:TextBox></td>
                    <td style="width: 100px">
                        <asp:RadioButton ID="M_Dependete04" runat="server" Text="M" />
                        <asp:RadioButton
                            ID="F_Dependete04" runat="server" Text="F" /></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    <br />
<table border="0" cellpadding="0" cellspacing="0" style="border-right: #cccccc 1px solid;
    border-top: #cccccc 1px solid; background: #eeeeee; border-left: #cccccc 1px solid;
    border-bottom: #cccccc 1px solid" width="100%">
    <tr>
        <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial">
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td>
                        <asp:CheckBox ID="RendaHospitalar" runat="server" Text="Renda Hospitalar - Limite de idade - 64 anos" /></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="Garantias" runat="server">
        <asp:ListItem>Selecione as garantias</asp:ListItem>
        <asp:ListItem>Di&aacute;ria por interna&ccedil;&atilde;o hospitalar</asp:ListItem>
        <asp:ListItem>Di&aacute;ria por interna&ccedil;&atilde;o em UTI</asp:ListItem>
        <asp:ListItem>Di&aacute;ria por interna&ccedil;&atilde;o decorrente de doen&ccedil;as graves (opcional)</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        OBS:
                        <br />
                        Doenças Graves: Derrame, Cancêr, Ponte de Safena e Infarto.<br>
                        <br>
                        Valor segurado/dia:
                        <br />
                        de R$100,00 (cem reais) a R$1.400,00 (um mil e quatrocentos reais)</td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    <br />
<table border="0" cellpadding="0" cellspacing="0" style="border-right: #cccccc 1px solid;
    border-top: #cccccc 1px solid; background: #eeeeee; border-left: #cccccc 1px solid;
    border-bottom: #cccccc 1px solid" width="100%">
    <tr>
        <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial">
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td>
                        <asp:CheckBox ID="AssistenciaFuneral" runat="server" Text="Assistência Funeral 24H- limite de Idade 60 anos" /></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="PlanoAssistenciaFuneral" runat="server">
      <asp:ListItem>Selecione o plano</asp:ListItem>
      <asp:ListItem>Individual</asp:ListItem>
      <asp:ListItem>Casal (titular e C&#244;njugue)</asp:ListItem>
      <asp:ListItem>Familiar (titular, c&#244;njugue e filhos dependentes)</asp:ListItem>
    
                            
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:DropDownList ID="PadraoServico" runat="server">
                        <asp:ListItem>Selecione o padr&#227;o de servi&#231;o</asp:ListItem>
                        <asp:ListItem>Nobre</asp:ListItem>
                        <asp:ListItem>Luxo</asp:ListItem>
                        <asp:ListItem>Super Luxo</asp:ListItem>
                    </asp:DropDownList></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    <br />
<table border="0" cellpadding="0" cellspacing="0" style="border-right: #cccccc 1px solid;
    border-top: #cccccc 1px solid; background: #eeeeee; border-left: #cccccc 1px solid;
    border-bottom: #cccccc 1px solid" width="100%">
    <tr>
        <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial">
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td>
                        <asp:CheckBox ID="SeguroVida" runat="server" Text="Seguro de Vida" /></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="Plano01" runat="server" Text="Plano 01" /></td>
                </tr>
                <tr>
                    <td>
                        - Idade limitado a 65 anos
                        <br />
                        - Morte Natural ou Acidental</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="Plano02" runat="server" Text="Plano 02" /></td>
                </tr>
                <tr>
                    <td>
                        - Idade limitado a 65 anos<br />
                        - Morte Natural<br>
      -	Morte Acidental com indeniza&ccedil;&atilde;o em dobro:<br>
      -	Invalidez Permanente Total e Parcial por Acidente</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="Plano03" runat="server" Text="Plano 03" /></td>
                </tr>
                <tr>
                    <td>
                        - Idade limitado a 65 anos<br />
                        - Morte Natural<br>
      -	Morte Acidental<br>
      Obs.: Car&ecirc;ncia de 1 (um) ano</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="Plano04" runat="server" Text="Plano 04" /></td>
                </tr>
                <tr>
                    <td>
                        - Idade limitado a 65 anos<br />
                        - Morte Natural<br>
      -	Morte Acidental com indeniza&ccedil;&atilde;o em dobro: <br>
      -	Invalidez Permanente Total e Parcial por Acidente;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="AntecipacaoIndenizacao" runat="server" Text="Antecipação da indenização em caso de:" /></td>
                </tr>
                <tr>
                    <td>
      - 
      Derrame (AVC);<br>
      - C&acirc;ncer; <br>
      - Ponte de Safena: <br>
      - Cirurgia de v&aacute;lvulas card&iacute;acas e  aorta</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        Indique o valor do seguro desejado: R$ &nbsp;<asp:TextBox ID="ValorDesejado" runat="server"
                            Width="100px"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td>
                        <asp:CheckBox ID="RendaTemporaria" runat="server" Text="Renda Temporária por incapacidade (doença ou acidente)" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="Noventa" runat="server" Text="90 Dias" /><br />
                        <asp:RadioButton ID="CentoeOitenta" runat="server" Text="180 Dias" />
                        <br />
                        <asp:RadioButton ID="TrezentosSessentaCinco" runat="server" Text="365 Dias" /></td>
                </tr>
            </table>
            <br />
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td>Valores da Renda Mensal</td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="Quinhentos" runat="server" Text="R$500,00" /><br />
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="R$1.000,00" />
                        <br />
                        <asp:RadioButton ID="MilQuinhentos" runat="server" Text="R$1.500,00" /><br />
                        <asp:RadioButton ID="DoisMil" runat="server" Text="R$2.000,00" />
                        <br />
                        <asp:RadioButton ID="TresMil" runat="server" Text="R$3.000,00" /><br />
                        <asp:RadioButton ID="QuatroMil" runat="server" Text="R$4.000,00" /><br />
                        <asp:RadioButton ID="CincoMil" runat="server" Text="R$5.000,00" /><br />
                        <asp:RadioButton ID="SeisMil" runat="server" Text="R$6.000,00" /><br />
                        <asp:RadioButton ID="OitoMil" runat="server" Text="R$8.000,00" /><br />
                        <asp:RadioButton ID="DezMil" runat="server" Text="R$10.000,00" /></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    <br />
<table border="0" cellpadding="0" cellspacing="0" style="border-right: #cccccc 1px solid;
    border-top: #cccccc 1px solid; background: #eeeeee; border-left: #cccccc 1px solid;
    border-bottom: #cccccc 1px solid" width="100%">
    <tr>
        <td align="left" style="padding-left: 8px; font-size: 12px; padding-top: 8px; font-family: Arial">
            <table cellpadding="1" cellspacing="0">
                <tr>
                    <td>
                        <asp:CheckBox ID="PrevidenciaPrivada" runat="server" Text="Previdência Privada" /></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        Renda Desejada:</td>
                </tr>
                <tr>
                    <td>
                        R$ &nbsp;<asp:TextBox ID="RendaDesejada" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
      Indicar a data que deseja aposentar:<strong></strong></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="DataAposentadoria" runat="server" Width="100px"></asp:TextBox></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
    <br />
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td align="right" style="padding-right: 20px">
                <asp:Button ID="cmdEnviar" runat="server" Text="Enviar" /></td>
        </tr>
    </table>
</asp:Panel>
