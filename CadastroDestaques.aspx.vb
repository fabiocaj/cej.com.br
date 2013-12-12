Imports System.Data
Imports System.IO
Imports Telerik.WebControls

Partial Class CadastroDestaques
    Inherits System.Web.UI.Page
    Dim wSQL As String
    Dim func As New clsDestaques
    Dim wDestaque As New clsDestaques.wDestaque

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("cUsuario") = "" Then
            Response.Redirect("Default.aspx")
        End If

        Form.DefaultButton = "cmdPesquisar"
        txtPesquisar.Focus()

        Page.Title = "CMS - Destaques"

        If Not IsPostBack Then

            Session("ds") = Nothing
            Session("dsNoticias") = Nothing
            Call sCarregarComboPortais()
            Call sCarregarComboCategoriaNoticias()
            Call sCarregarGrid(txtPesquisar.Text)
            cmdExcluir2.Visible = False

        End If

        If Request.Browser.Browser.ToLowerInvariant() = "firefox" Then
            Dim browserCheckedField As System.Reflection.FieldInfo = GetType(RadEditor).GetField("_browserCapabilitiesRetrieved", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            browserCheckedField.SetValue(radDestaque, True)
            Dim browserSupportedField As System.Reflection.FieldInfo = GetType(RadEditor).GetField("_isSupportedBrowser", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            browserSupportedField.SetValue(radDestaque, True)
        End If

        Dim imagepath() As String = {"~/Grupos/" & Session("cGrupo")}
        radDestaque.UploadImagesPaths = imagepath
        radDestaque.ImagesPaths = imagepath
        radDestaque.DeleteImagesPaths = imagepath

    End Sub


    Public Sub sCarregarComboCategoriaNoticias()

        wSQL = "SELECT * FROM TBCATEGORIASNOTICIAS Where cPortal =" & cmbPortais.SelectedValue & " ORDER BY TCATEGORIANOTICIA "
        func.sCarregaCombo(wSQL, cmbCategoria, "tCategoriaNoticia", "cCategoriaNoticia", "Sem Categoria Definida")

    End Sub

    Sub sCarregarComboPortais()

        wSQL = "  select * "
        wSQL += " from tbPortais "
        wSQL += " where cPortal in "
        wSQL += " ("
        wSQL += " select cPortal "
        wSQL += " from tbPortalUsuarios "
        wSQL += " where cUsuario = " & Session("cUsuario")
        wSQL += " and cStatus = 1"
        wSQL += " ) "
        wSQL += " order by tPortal "

        Call func.sCarregaCombo(wSQL, cmbPortaisGV, "tPortal", "cPortal", "(Todos os Portais)")
        Call func.sCarregaCombo(wSQL, cmbPortais, "tPortal", "cPortal", "(Todos os Portais)")

    End Sub

    Protected Sub cmdNovo2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNovo2.Click

        Call sNovoNoticia()

    End Sub

    Protected Sub cmdNovo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNovo.Click

        lblResposta.Text = ""
        Call sNovoNoticia()

    End Sub

    Protected Sub cmdPesquisar2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPesquisar2.Click

        Call sPesquisar()

    End Sub

    Protected Sub cmdPesquisar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click

        Call sPesquisar()

    End Sub

    Sub sCarregarGrid(ByVal wFiltro As String)

        Call sConfigurarPaineis("P")

        wSQL = "  Select isnull(tPortal,'(Todos os Portais)') as tPortal,* "
        wSQL += " from tbDestaques d "
        wSQL += " left join tbPortais p "
        wSQL += " on d.cPortal = p.cPortal "
        wSQL += " where tDestaque like '%" & wFiltro.Trim & "%'"
        wSQL += " and cGrupo = " & Session("cGrupo")
        If cmbPortaisGV.SelectedValue <> "0" Then
            wSQL += " and d.cPortal = " & cmbPortaisGV.SelectedValue
        Else
            wSQL += " and (d.cPortal = 0 "
            wSQL += " or d.cPortal in "
            wSQL += " ( "
            wSQL += "  select p.cPortal"
            wSQL += " from tbPortais P"
            wSQL += " join tbPortalUsuarios PU on p.cPortal = pu.cPortal"
            wSQL += " where cStatus = 1"
            wSQL += " and cUsuario = " & Session("cUsuario")
            wSQL += " )) "
        End If
        wSQL += " order by tChamada, tTitulo "

        Session("ds") = func.fRetornaDataSet(wSQL)

        With gvResultados
            .DataSource = CType(Session("ds"), DataSet)
            .DataBind()

            If .Rows.Count = 0 Then
                lblResposta.Text = func.fTexto("Sem resultados", "mensagem")
                .Visible = False
            Else
                lblResposta.Text = ""
                .Visible = True
            End If

        End With

    End Sub

    Sub sNovoNoticia()

        Call sConfigurarPaineis("F")
        lblCodigo.Text = "0"
        cmbPortaisGV.Focus()
        txtTitulo.Text = ""
        txtChamada.Text = ""
        radDestaque.Html = ""
        txtDataDestaque.SelectedDate = Date.Today
        imgPequena.Visible = False
        cmdExcluir.Visible = False
        chkStatus.Checked = False
        hplVisualizacao.Visible = False

    End Sub

    Sub sPesquisar()

        Call sConfigurarPaineis("P")
        Session("ds") = Nothing
        Call sCarregarGrid(txtPesquisar.Text)

    End Sub


    Protected Sub cmdGravar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGravar.Click

        Call sGravarDestaque()

    End Sub

    Sub sGravarDestaque()

        If fValidaDestaque() Then

            wDestaque = func.fCarregarDestaque(lblCodigo.Text)

            With wDestaque
                .cPortal = cmbPortais.SelectedItem.Value
                .cDestaque = lblCodigo.Text
                .dDestaque = txtDataDestaque.SelectedDate
                .tTitulo = txtTitulo.Text
                .tChamada = txtChamada.Text
                .tDestaque = radDestaque.Html
                .cCategoria = cmbCategoria.SelectedValue
                .lStatus = chkStatus.Checked
                .cGrupo = Session("cGrupo")
            End With

            lblResposta.Text = func.fTexto(func.fManutencaoDestaque(wDestaque), "mensagem")

            If Not Left(lblResposta.Text, 4).ToUpper = "ERRO" Then
                Call sGravarImagens(wDestaque)
                Call sNovoNoticia()
            End If

        End If

    End Sub

    Function fValidaDestaque() As Boolean

        lblResposta.Text = ""

        If txtTitulo.Text.Trim.Length = 0 Then
            lblResposta.Text = func.fTexto("Campo Título do Destaque obrigatório.", "mensagem")
            txtTitulo.Focus()
            Return False
        End If

        If txtChamada.Text.Trim.Length = 0 Then
            lblResposta.Text = func.fTexto("Campo Chamada do Destaque obrigatório.", "mensagem")
            txtChamada.Focus()
            Return False
        End If

        If radDestaque.Html.Trim.Length = 0 Then
            lblResposta.Text = func.fTexto("Campo Destaque obrigatório.", "mensagem")
            Return False
        End If

        Return True

    End Function

    Sub sGravarImagens(ByVal wDestaque As clsDestaques.wDestaque)

        Dim wResposta As String
        Dim wArquivo As String = wDestaque.tImagem

        wResposta = func.fGravarImagem(fuImagem, Server.MapPath("~") & "\Destaques\", wArquivo, wDestaque.cDestaque)

        If Left(wResposta.Trim.ToUpper, 4) <> "ERRO" Then
            wDestaque.tImagem = wArquivo
            Call func.fManutencaoDestaque(wDestaque)
        End If

    End Sub

    Function fRetornaNivel(ByVal wNivel As String) As String

        Select Case wNivel.ToUpper

            Case "A"
                Return "Administrador"

            Case "U"
                Return "Usuário"

            Case Else
                Return "Sem nível definido"

        End Select

    End Function

    Function fRetornaStatus(ByVal wStatus As Boolean) As String

        Select Case wStatus

            Case False
                Return "Inativo"

            Case True
                Return "Ativo"

            Case Else
                Return "Sem status definido"

        End Select

    End Function

    Protected Sub gvResultados_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvResultados.PageIndexChanging

        gvResultados.PageIndex = e.NewPageIndex.ToString
        Call sCarregarGrid(txtPesquisar.Text)

    End Sub

    Protected Sub gvResultados_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvResultados.SelectedIndexChanging

        'e.NewSelectedIndex

        Dim wCodigo As Integer
        wCodigo = CType(gvResultados.Rows(e.NewSelectedIndex).FindControl("lnkCodigo"), LinkButton).Text
        Call sCarregarFormulario(wCodigo)

    End Sub

    Sub sCarregarFormulario(ByVal wCodigo As Integer)

        Call sConfigurarPaineis("F")

        wDestaque = func.fCarregarDestaque(wCodigo)

        imgPequena.Visible = False

        With wDestaque
            lblCodigo.Text = .cDestaque
            txtTitulo.Text = .tTitulo
            txtChamada.Text = .tChamada
            radDestaque.Html = .tDestaque
            txtDataDestaque.SelectedDate = .dDestaque
            chkStatus.Checked = .lStatus
            Try
                cmbCategoria.SelectedValue = .cCategoria
            Catch ex As Exception

            End Try

            Dim wPortal As New clsPortais.wPortal
            Dim clsPortais As New clsPortais

            wPortal = clsPortais.fCarregarPortal(.cPortal)

            If Not wPortal Is Nothing Then
                If Not wPortal.tURL Is Nothing Then

                    If wPortal.tURL.Contains("http") Then
                        hplVisualizacao.NavigateUrl = wPortal.tURL & "/DetalhesDestaques.aspx?cDestaque=" & .cDestaque
                    Else
                        hplVisualizacao.NavigateUrl = "http://" & wPortal.tURL & "/DetalhesDestaques.aspx?cDestaque=" & .cDestaque
                    End If

                Else

                    hplVisualizacao.NavigateUrl = "DetalhesDestaques.aspx?cDestaque=" & .cDestaque

                End If
            End If

            hplVisualizacao.Visible = True

            Call func.sSetaCombo(cmbPortais, .cPortal)

            imgPequena.ImageUrl = func.fRetornaURLImagem(Request.ServerVariables("SERVER_NAME"), "IMAGEMDESTAQUE", .tImagem)

            If .tImagem = "" Then
                cmdExcluir2.Visible = False
            Else
                cmdExcluir2.Visible = True
            End If

            cmdExcluir.Visible = True

            If .tImagem.Trim.Length > 0 Then
                imgPequena.Visible = True
            End If

        End With

    End Sub

    Sub sConfigurarPaineis(ByVal wPainel As String)

        Page.Title = "CMS - Cadastro de Destaques"

        If wPainel = "P" Then 'Painel Pesquisar
            lblTitulo.Text = "Relação de Destaques Cadastrados"
            pnlPesquisa.Visible = True
            pnlFormulario.Visible = False
            Page.Form.DefaultButton = "cmdPesquisar"
            txtPesquisar.Focus()

        ElseIf wPainel = "F" Then 'Painel Formulário
            lblTitulo.Text = "Cadastro de Destaques"
            pnlPesquisa.Visible = False
            pnlFormulario.Visible = True
            Page.Form.DefaultButton = "cmdGravar"
            cmbPortaisGV.Focus()

        ElseIf wPainel = "S" Then 'Painel Seções
            lblTitulo.Text = "Cadastro de Destaques/Seções"
            pnlPesquisa.Visible = False
            pnlFormulario.Visible = False
            Page.Form.DefaultButton = "cmdGravar"
            cmbPortaisGV.Focus()

        End If


    End Sub

    Sub sExcluir()

        Dim func As New Funcoes
        Dim wCodigo As String
        Dim wCampo1 As String = "Destaque"
        Dim wCampo2 As String = "Destaques"

        wCodigo = lblCodigo.Text

        Session("wTitulo") = "Cadastro de " & wCampo2 & " (Confirmação de Exclusão)"
        Session("wExcluir") = "Deseja realmente excluir este " & wCampo1 & "? '" & txtTitulo.Text.ToUpper & "'"
        Session("wSQL") = "Delete from tbDestaques where cDestaque = " & wCodigo
        Session("wMensagemSim") = wCampo1 & " Excluído com Sucesso!"
        Session("wMensagemErro") = "ERRO: Problema na Exclusão do " & wCampo1 & "!"
        Session("wMensagemNao") = wCampo1 & " NÃO Excluído"
        Session("wPaginaRetorno") = "CadastroDestaques.aspx"
        Response.Redirect("Confirmacao.aspx")

    End Sub

    Protected Sub cmdExcluir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExcluir.Click
        Call sExcluir()
    End Sub

    Protected Sub cmdExcluir2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExcluir2.Click
        Call sExcluirImagem(1)
    End Sub

    Sub sExcluirImagem(ByVal wImagem As Byte)

        Dim wPath As String
        Dim wDestaque As New clsDestaques.wDestaque
        Dim func As New clsDestaques

        wPath = Server.MapPath("\cash_painel\Noticias\Pequena" & lblImagem.Text)

        If File.Exists(wPath) Then

            File.Delete(wPath)
            wDestaque = func.fCarregarDestaque(lblCodigo.Text)
            With wDestaque
                .tImagem = ""
            End With
            func.fManutencaoDestaque(wDestaque)

        Else

            wDestaque = func.fCarregarDestaque(lblCodigo.Text)
            With wDestaque
                .tImagem = ""
            End With
            func.fManutencaoDestaque(wDestaque)

        End If

        cmdExcluir2.Visible = False

        If cmdExcluir2.Visible = False Then

            Call sNovoNoticia()

        End If

    End Sub

    Protected Sub cmbPortais_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPortaisGV.SelectedIndexChanged
        Call sCarregarComboCategoriaNoticias()
    End Sub

    Protected Sub cmbPortaisGV_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPortaisGV.SelectedIndexChanged

        cmbPortais.SelectedValue = cmbPortaisGV.SelectedValue
        Call sCarregarComboCategoriaNoticias()
        Call sCarregarGrid(txtPesquisar.Text)

    End Sub

    Protected Sub gvResultados_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvResultados.SelectedIndexChanged

    End Sub
End Class