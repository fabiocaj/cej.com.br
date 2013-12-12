Imports System.Data
Imports System.IO

Partial Class ucDetalhesProduto
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Call sCarregarProduto()
        End If

    End Sub

    Public Function fRetornaCaminhoImagem(ByVal wImagem As String) As String

        Dim wCorpo As String = ""
        Dim ws As New wsCash.wsCash

        wCorpo = "<IMG src='---caminhoimagem---' hight='20px' border='0' />"

        If wImagem <> "" Then
            wCorpo = Replace(wCorpo, "---caminhoimagem---", ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMDESTAQUE", wImagem))

        Else
            wCorpo = ""
        End If

        Return wCorpo

    End Function

    Sub sCarregarProduto()

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        Dim wDepartamento As String = Request.Params("cDepartamento")
        Dim wSecao As String = Request.Params("cVitrineSecao")
        Dim wFabricante As String = Request.Params("cFAbricante")
        Dim wProduto As String = Request.Params("cProduto")
        Dim wFlagHome As Boolean = True

        wSQL = " select * "
        wSQL += " from vwProdutos "
        wSQL += " where 1=1 "

        If IsNumeric(wProduto) Then
            wSQL += " and cProduto = " & wProduto
            wFlagHome = False
        Else
            Response.Redirect("default.aspx")
        End If

        'If IsNumeric(wDepartamento) Then
        '    wSQL += " and cDepartamento = " & wDepartamento
        '    wFlagHome = False
        'End If

        'If IsNumeric(wSecao) Then
        '    wSQL += " and cSecao = " & wSecao
        '    wFlagHome = False
        'End If

        'If IsNumeric(wFabricante) Then
        '    wSQL += " and cFabricante = " & wFabricante
        '    wFlagHome = False
        'End If

        'If wFlagHome = True Then
        '    wSQL += " and lDestaqueHome =  1 "
        'End If

        wSQL += " order by tProduto "
        ds = ws.fRetornaDataSet(wSQL)

        If Not ds.Tables(0).Rows(0).Item("tProduto") Is DBNull.Value Then
            lblProduto.Text = ds.Tables(0).Rows(0).Item("tProduto")
            lblFabricante.Text = ds.Tables(0).Rows(0).Item("tFabricante")
        End If

        If Not ds.Tables(0).Rows(0).Item("tDescricao") Is DBNull.Value Then
            lblChamada.Text = ds.Tables(0).Rows(0).Item("tDescricao")
            lblChamada.Text = lblChamada.Text.Replace(Chr(13), "<br>")
        End If

        If Not ds.Tables(0).Rows(0).Item("tDescricaoProduto") Is DBNull.Value Then
            lblDescricaoProduto.Text = ds.Tables(0).Rows(0).Item("tDescricaoProduto")
            lblDescricaoProduto.Text = lblDescricaoProduto.Text.Replace(Chr(13), "<br>")
            If ds.Tables(0).Rows(0).Item("tDescricaoProduto").ToString().Trim() = "" Then
                rtsProduto.Tabs(0).Visible = False
            Else
                rtsProduto.Tabs(0).Visible = True
            End If
        End If

        If Not ds.Tables(0).Rows(0).Item("tItensInclusos") Is DBNull.Value Then
            lblItensInclusos.Text = ds.Tables(0).Rows(0).Item("tItensInclusos")
            lblItensInclusos.Text = lblItensInclusos.Text.Replace(Chr(13), "<br>")
            If ds.Tables(0).Rows(0).Item("tItensInclusos").ToString().Trim() = "" Then
                rtsProduto.Tabs(1).Visible = False
            Else
                rtsProduto.Tabs(1).Visible = True
            End If
        End If

        If Not ds.Tables(0).Rows(0).Item("tDadosTecnicos") Is DBNull.Value Then
            lblDadostecnicos.Text = ds.Tables(0).Rows(0).Item("tDadosTecnicos")
            lblDadostecnicos.Text = lblDadostecnicos.Text.Replace(Chr(13), "<br>")
            If ds.Tables(0).Rows(0).Item("tDadosTecnicos").ToString().Trim() = "" Then
                rtsProduto.Tabs(2).Visible = False
            Else
                rtsProduto.Tabs(2).Visible = True
            End If
        End If

        If Not ds.Tables(0).Rows(0).Item("tModoUsar") Is DBNull.Value Then
            lblModoUsar.Text = ds.Tables(0).Rows(0).Item("tModoUsar")
            lblModoUsar.Text = lblModoUsar.Text.Replace(Chr(13), "<br>")
            If ds.Tables(0).Rows(0).Item("tModoUsar").ToString().Trim() = "" Then
                rtsProduto.Tabs(3).Visible = False
            Else
                rtsProduto.Tabs(3).Visible = True
            End If
        End If

        If Not ds.Tables(0).Rows(0).Item("tConexoes") Is DBNull.Value Then
            lblConexoes.Text = ds.Tables(0).Rows(0).Item("tConexoes")
            lblConexoes.Text = lblConexoes.Text.Replace(Chr(13), "<br>")
            If ds.Tables(0).Rows(0).Item("tConexoes").ToString().Trim() = "" Then
                rtsProduto.Tabs(4).Visible = False
            Else
                rtsProduto.Tabs(4).Visible = True
            End If
        End If

        If Not ds.Tables(0).Rows(0).Item("cProduto") Is DBNull.Value Then
            imgProduto.ImageUrl = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "produtos", ws.fRetornaImagemProdutoDestaque(ds.Tables(0).Rows(0).Item("cProduto").ToString))
        End If

        Call sConfiguraAbas(ds.Tables(0).Rows(0).Item("cPortal"))

        Dim wDescontoDepartamento As Double = ds.Tables(0).Rows(0).Item("pDescontoDepartamento")
        Dim wDescontoSecao As Double = ds.Tables(0).Rows(0).Item("pDescontoSecao")
        Dim wDescontoProduto As Double = ds.Tables(0).Rows(0).Item("pDescontoProduto")
        Dim wPrecoProduto As Double = ds.Tables(0).Rows(0).Item("vProduto")
        Dim wPrecoProdutoDesconto As Double = ds.Tables(0).Rows(0).Item("vProduto")

        If wDescontoProduto <> 0 Then
            wPrecoProdutoDesconto = wPrecoProduto - (wPrecoProduto * (wDescontoProduto / 100))
        Else

            If wDescontoSecao <> 0 Then
                wPrecoProdutoDesconto = wPrecoProduto - (wPrecoProduto * (wDescontoSecao / 100))
            Else

                If wDescontoDepartamento <> 0 Then
                    wPrecoProdutoDesconto = wPrecoProduto - (wPrecoProduto * (wDescontoDepartamento / 100))
                End If

            End If

        End If

        If wPrecoProduto = wPrecoProdutoDesconto Then
            'wDetalheProduto = wDetalheProduto.Replace("---precoproduto---", wPrecoProduto.ToString("C2"))
            'wDetalheProduto = wDetalheProduto.Replace("---deprecoproduto---", "")

            lblDePrecoProduto.Text = ""
            lblPrecoProduto.Text = wPrecoProduto.ToString("C2")
            lblValorProduto.Text = wPrecoProduto

        Else
            'wDetalheProduto = wDetalheProduto.Replace("---precoproduto---", wPrecoProdutoDesconto.ToString("C2"))
            'wDetalheProduto = wDetalheProduto.Replace("---deprecoproduto---", wPrecoProduto.ToString("C2"))

            lblDePrecoProduto.Text = "de " & wPrecoProduto.ToString("C2")
            lblPrecoProduto.Text = "por " & wPrecoProdutoDesconto.ToString("C2")
            lblValorProduto.Text = wPrecoProdutoDesconto

        End If

        rtsProduto.SelectedIndex = 0
        rmpProduto.SelectedIndex = 0

        If wPortal.lTipoLoja <> "V" Then 'V = Vitrine, O = Orçamento, L = Pagseguro, C- Convencional
            cmdAdicionar.Visible = True
        Else
            cmdAdicionar.Visible = False
        End If

    End Sub

    Public Sub sConfiguraAbas(ByVal cPortal As Integer)

        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        With wPortal

            If IIf(.tAbaDescricaoProduto Is DBNull.Value, "", .tAbaDescricaoProduto).Trim <> "" Then
                rtsProduto.Tabs(0).Text = .tAbaDescricaoProduto
            Else
                rtsProduto.Tabs(0).Text = "Descrição do Produto"
            End If

            If IIf(.tAbaItensInclusos Is DBNull.Value, "", .tAbaItensInclusos).Trim <> "" Then
                rtsProduto.Tabs(1).Text = .tAbaItensInclusos
            Else
                rtsProduto.Tabs(1).Text = "Itens Inclusos"
            End If

            If IIf(.tAbaDadosTecnicos Is DBNull.Value, "", .tAbaDadosTecnicos).Trim <> "" Then
                rtsProduto.Tabs(2).Text = .tAbaDadosTecnicos
            Else
                rtsProduto.Tabs(2).Text = "Dados Técnicos"
            End If

            If IIf(.tAbaMododeUsar Is DBNull.Value, "", .tAbaMododeUsar).Trim <> "" Then
                rtsProduto.Tabs(3).Text = .tAbaMododeUsar
            Else
                rtsProduto.Tabs(3).Text = "Modo de Usar"
            End If

            If IIf(.tAbaConexoes Is DBNull.Value, "", .tAbaConexoes).Trim <> "" Then
                rtsProduto.Tabs(4).Text = .tAbaConexoes
            Else
                rtsProduto.Tabs(4).Text = "Conexões"
            End If

            'Dim dsImg As New DataSet

            'dsImg = ws.FRETORNAIMAGENSPRODUTOS(Request.Params("cProduto"))

            'If dsImg.Tables(0).Rows.Count > 0 Then
            '    rtsProduto.Tabs(5).Visible = True
            'Else
            '    rtsProduto.Tabs(5).Visible = False
            'End If

            Dim dsImg As New DataSet

            dsImg = ws.FRETORNAIMAGENSPRODUTOS(Request.Params("cProduto"))

            If dsImg.Tables(0).Rows.Count > 1 Then
                rtsProduto.Tabs(5).Visible = True
                rtsProduto.SelectedIndex = 0
                rmpProduto.SelectedIndex = 0
            Else
                rtsProduto.Tabs(1).Selected = True
                rtsProduto.Tabs(5).Visible = False
                rtsProduto.SelectedIndex = 1
                rmpProduto.SelectedIndex = 1
            End If

        End With


    End Sub

    Protected Sub cmdAdicionar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdicionar.Click
        Dim wCarrinho As New clsCarrinho.wCarrinho
        Dim clsCarrinho As New clsCarrinho

        If Session("Carrinho") Is Nothing Then

            Session("Carrinho") = clsCarrinho.sCriaCarrinho()

        End If

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wProduto As String = Request.Params("cProduto")

        wSQL = " select * "
        wSQL += " from vwProdutos "
        wSQL += " where 1=1 "

        If IsNumeric(wProduto) Then
            wSQL += " and cProduto = " & wProduto
        End If

        ds = ws.fRetornaDataSet(wSQL)

        With wCarrinho
            .cProduto = ds.Tables(0).Rows(0).Item("cProduto")
            .tProduto = ds.Tables(0).Rows(0).Item("tProduto")
            .qtdproduto = 1
            .tImagemProduto = imgProduto.ImageUrl
            .vUnitarioProduto = CType(lblValorProduto.Text, Double)
            .vPeso = ds.Tables(0).Rows(0).Item("vPeso")
            .vAltura = ds.Tables(0).Rows(0).Item("vAltura")
            .vLargura = ds.Tables(0).Rows(0).Item("vLargura")
        End With

        Session("Carrinho") = clsCarrinho.sInsereItemCarrinho(wCarrinho, Session("Carrinho"))

        Response.Redirect("Carrinho.aspx")
    End Sub
End Class