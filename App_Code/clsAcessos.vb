Imports Microsoft.VisualBasic
Imports System.Data
Imports System.IO
Imports System.Text


Public Class clsAcessos
    Inherits Funcoes

    Dim ws As New wsCash.wsCash
    Dim wSecao As New wsCash.wSecao

    Function fPortal() As Integer

        Return ConfigurationManager.AppSettings("Portal")

    End Function

    Function fGrupo() As Integer

        Return ConfigurationManager.AppSettings("GRUPO")

    End Function

    Function fRetornaWS()

        ws.Url = ConfigurationManager.AppSettings("wsURL")
        Return ws

    End Function

    Function fConfiguraSecao(ByVal wCodigoSecao As Integer) As wsCash.wSecao

        ws = fRetornaWS()

        Dim wSecao As New wsCash.wSecao
        wSecao = ws.fSecao(wCodigoSecao)

        Return wSecao

    End Function

    Function fRetornaUsuario(ByVal wCPF As String, ByVal wCodigoPortal As Integer) As wsCash.wUsuario

        ws = fRetornaWS()

        Dim wUsuario As New wsCash.wUsuario
        wUsuario = ws.fLoginUsuario(wCPF, wCodigoPortal)

        Return wUsuario

    End Function

    Sub fCarregaCategoriasNoticias(ByVal cmbCategorias As DropDownList)

        ws = fRetornaWS()

        Dim ds As New DataSet
        ds = ws.fRetornaCategoriasNoticias(fPortal())

        With cmbCategorias
            .DataTextField = "tCategoriaNoticia"
            .DataValueField = "cCategoriaNoticia"
            .DataSource = ds
            .DataBind()
        End With

        cmbCategorias.Items.Insert(0, "Todas")

    End Sub

    Function fNoticias() As DataSet

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal

        ws = fRetornaWS()
        wPortal = ws.fCarregarPortal(fPortal())

        With wPortal
            ds = ws.fRetornaNoticiasPortal(fGrupo(), wPortal.cPortal, .qNoticias, .qDestaques)
        End With

        Return ds

    End Function

    Function fNoticiasDestaques(ByVal cCategoria As Integer) As DataSet

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal

        ws = fRetornaWS()
        wPortal = ws.fCarregarPortal(fPortal())

        Dim wSQL As String = ""
        Dim wGrupo As String = fGrupo()

        With wPortal
            If cCategoria <> 0 Then
                ds = ws.fRetornaDestaquesComCategorias(fGrupo(), fPortal(), .qDestaques, wSQL, cCategoria)
            Else
                ds = ws.fRetornaDestaquesPortal(wGrupo, wPortal.cPortal, .qDestaques, wSQL)
            End If

        End With

        Return ds

    End Function

    Function fDestaques() As DataSet

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal

        ws = fRetornaWS()
        wPortal = ws.fCarregarPortal(fPortal())

        With wPortal
            ds = ws.fRetornarDestaquesPortal(fGrupo(), fPortal(), .qDestaques)
        End With

        Return ds

    End Function

    Function fMembros() As DataSet

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal

        ws = fRetornaWS()
        wPortal = ws.fCarregarPortal(fPortal())

        With wPortal
            ds = ws.fRetornaMembros(.cPortal)
        End With

        Return ds

    End Function

    Function fCampanhaBanners(ByVal wCodigoTamanhoBanner As Integer) As DataSet

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal

        ws = fRetornaWS()
        wPortal = ws.fCarregarPortal(fPortal())

        With wPortal
            ds = ws.fRetornaCampanhaBanners(fGrupo(), wCodigoTamanhoBanner)
        End With

        Return ds

    End Function

#Region "Portal"

    Function fCarregarPortal() As wsCash.wPortal

        Dim wPortal As New wsCash.wPortal

        ws = fRetornaWS()
        wPortal = ws.fCarregarPortal(fPortal())

        Return wPortal

    End Function

    Function fManutencaoPortalUsuarioNewsLetter(ByRef wNewsLetter As wsCash.wNewsLetter) As String

        ws = fRetornaWS()

        Return ws.fManutencaoPortalUsuarioNewsLetter(wNewsLetter)

    End Function

#End Region

#Region "Publicidade"

    Function fRetornaPublicidadeCadastrada() As DataSet

        ws = fRetornaWS()

        Return ws.fRetornaPublicidadeCadastrada(fPortal())

    End Function

    Function fRetornaLeftPublicidadeCadastrada() As DataSet

        ws = fRetornaWS()

        Dim wSQL As String = ""

        Dim ds As New DataSet
        ds = ws.fRetornaPublicidadeLeftCadastrada(fPortal())

        Return ds

    End Function

    Function fRetornaQtdPublicidadeCadastrada()

        ws = fRetornaWS()

        Return ws.fRetornaQtdPublicidadeCadastrada(fPortal())

    End Function

#End Region

#Region "Big Banner"

    Function fRetornaBigBannerCadastrado() As DataSet

        ws = fRetornaWS()

        Return ws.fRetornaBigBannerCadastrado(fPortal())

    End Function

    Function fRetornaQtdBigBannerCadastrado()

        ws = fRetornaWS()

        Return ws.fRetornaQtdBigBannerCadastrado(fPortal())

    End Function

#End Region

#Region "Destaque Banner"

    Function fRetornaDestaqueBannerCadastrado() As DataSet

        ws = fRetornaWS()

        Return ws.fRetornaDestaqueBannerCadastrado(fPortal())

    End Function

    Function fRetornaQtdDestaqueBannerCadastrado()

        ws = fRetornaWS()

        Return ws.fRetornaQtdDestaqueBannerCadastrado(fPortal())

    End Function

#End Region

#Region "Half Banner"

    Function fRetornaHalfBannerCadastrado() As DataSet

        ws = fRetornaWS()

        Return ws.fRetornaHalfBannerCadastrado(fPortal())

    End Function

    Function fRetornaQtdHalfBannerCadastrado()

        ws = fRetornaWS()

        Return ws.fRetornaQtdHalfBannerCadastrado(fPortal())

    End Function

#End Region


#Region "Pesquisa"

    ''' <summary>
    ''' Função que carrega informações dos Noticias
    ''' </summary>
    ''' <param name="wFiltro">Esse parametro é o campo de Pesquisa</param>
    ''' <param name="wTipo">Esse Parametro é se vai ser Contador(C) ou Informações(I)</param>
    ''' <remarks></remarks>
    Public Function fCarregaInformacoesNoticias(ByVal wFiltro As String, ByVal wTipo As String) As DataSet

        Dim wSQL As String = ""
        Dim ds As New DataSet
        Dim func As New clsAcessos

        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()

        If wTipo.Trim = "C" Then
            wSQL += " SELECT 'NOTICIAS' AS TCATEGORIA, COUNT(1) AS NQTD"
        Else
            wSQL += " SELECT * "
        End If

        wSQL += " FROM tbNoticias "
        wSQL += " WHERE (tTitulo LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tChamada LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tNoticia LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tFonte LIKE '%" & func.fPreparaPalavra(wFiltro) & "%') "
        wSQL += " AND CPORTAL = " & func.fPortal()

        ds = ws.fRetornaDataSet(wSQL)

        Return ds

    End Function

    ''' <summary>
    ''' Função que carrega informações dos Notícias
    ''' </summary>
    ''' <param name="wFiltro">Esse parametro é o campo de Pesquisa</param>
    ''' <param name="wTipo">Esse Parametro é se vai ser Contador(C) ou Informações(I)</param>
    ''' <remarks></remarks>
    Public Function fCarregaInformacoesAlbuns(ByVal wFiltro As String, ByVal wTipo As String) As DataSet

        Dim wSQL As String = ""
        Dim ds As New DataSet
        Dim func As New clsAcessos

        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()

        If wTipo.Trim = "C" Then
            wSQL += " SELECT 'ALBUNS' AS TCATEGORIA, COUNT(1) AS NQTD"
        Else
            wSQL += " SELECT * "
        End If

        wSQL += " FROM TBALBUNS A "
        wSQL += " INNER JOIN TBALBUMFOTOS AF "
        wSQL += " ON AF.CALBUM = A.CALBUM "
        wSQL += " INNER JOIN TBCATEGORIASFOTOS CF "
        wSQL += " ON CF.CCATEGORIAFOTO = A.CCATEGORIAFOTO "
        wSQL += " WHERE (TALBUM LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR TFOTO LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR TLEGENDA LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR TCATEGORIAFOTO LIKE '%" & func.fPreparaPalavra(wFiltro) & "%') "
        wSQL += " AND CF.CPORTAL = " & func.fPortal()
        wSQL += " AND A.CPORTAL = " & func.fPortal()

        ds = ws.fRetornaDataSet(wSQL)

        Return ds

    End Function

    ''' <summary>
    ''' Função que carrega informações dos Eventos
    ''' </summary>
    ''' <param name="wFiltro">Esse parametro é o campo de Pesquisa</param>
    ''' <param name="wTipo">Esse Parametro é se vai ser Contador(C) ou Informações(I)</param>
    ''' <remarks></remarks>
    Public Function fCarregaInformacoesEventos(ByVal wFiltro As String, ByVal wTipo As String) As DataSet

        Dim wSQL As String = ""
        Dim ds As New DataSet
        Dim func As New clsAcessos

        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()

        If wTipo.Trim = "C" Then
            wSQL += " SELECT 'EVENTOS' AS TCATEGORIA, COUNT(1) AS NQTD"
        Else
            wSQL += " SELECT * "
        End If

        wSQL += " FROM tbEventos "
        wSQL += " WHERE (tEvento LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tDescricao LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tLocal LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tEmail LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tSite LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tInformacoes LIKE '%" & func.fPreparaPalavra(wFiltro) & "%') "
        wSQL += " AND CPORTAL = " & func.fPortal()

        ds = ws.fRetornaDataSet(wSQL)

        Return ds

    End Function

    ''' <summary>
    ''' Função que carrega informações dos Videos
    ''' </summary>
    ''' <param name="wFiltro">Esse parametro é o campo de Pesquisa</param>
    ''' <param name="wTipo">Esse Parametro é se vai ser Contador(C) ou Informações(I)</param>
    ''' <remarks></remarks>
    Public Function fCarregaInformacoesVideos(ByVal wFiltro As String, ByVal wTipo As String) As DataSet

        Dim wSQL As String = ""
        Dim ds As New DataSet
        Dim func As New clsAcessos

        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()

        If wTipo.Trim = "C" Then
            wSQL += " SELECT 'VIDEOS' AS TCATEGORIA, COUNT(1) AS NQTD"
        Else
            wSQL += " SELECT * "
        End If

        wSQL += " FROM tbVideos "
        wSQL += " WHERE (tVideo LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tChamada LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tLink LIKE '%" & func.fPreparaPalavra(wFiltro) & "%') "
        wSQL += " AND CPORTAL = " & func.fPortal()

        ds = ws.fRetornaDataSet(wSQL)

        Return ds

    End Function

    ''' <summary>
    ''' Função que carrega informações dos FAQ
    ''' </summary>
    ''' <param name="wFiltro">Esse parametro é o campo de Pesquisa</param>
    ''' <param name="wTipo">Esse Parametro é se vai ser Contador(C) ou Informações(I)</param>
    ''' <remarks></remarks>
    Public Function fCarregaInformacoesFAQ(ByVal wFiltro As String, ByVal wTipo As String) As DataSet

        Dim wSQL As String = ""
        Dim ds As New DataSet
        Dim func As New clsAcessos

        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()

        If wTipo.Trim = "C" Then
            wSQL += " SELECT 'FAQ' AS TCATEGORIA, COUNT(1) AS NQTD"
        Else
            wSQL += " SELECT * "
        End If

        wSQL += " FROM tbFAQs "
        wSQL += " WHERE (tFAQ LIKE '%" & func.fPreparaPalavra(wFiltro) & "%' "
        wSQL += " OR tDescricao LIKE '%" & func.fPreparaPalavra(wFiltro) & "%') "
        wSQL += " AND CPORTAL = " & func.fPortal()

        ds = ws.fRetornaDataSet(wSQL)

        Return ds

    End Function

    Public Function fRetornaPopUp() As String

        Dim wSQL As String = ""
        Dim wCorpo As New StringBuilder
        Dim ds As New DataSet
        Dim currentContext As System.Web.HttpContext = System.Web.HttpContext.Current
        Dim wPath As String = currentContext.Server.MapPath("Templates/PopUp.htm")
        Dim wReader As New StreamReader(wPath, New System.Text.ASCIIEncoding)
        Dim wHTML As String = ""
        Dim wPagina As wsCash.wPagina
        Dim ws As New wsCash.wsCash

        ws = fRetornaWS()
        wCorpo.Append(wReader.ReadToEnd())
        wReader.Close()

        ds = ws.fRetornaPopups(fPortal, fGrupo)

        If ds.Tables(0).Rows.Count > 0 Then

            wHTML = wCorpo.ToString()

            wHTML = wHTML.Replace("---width---", ds.Tables(0).Rows(0).Item("nLargura"))
            wHTML = wHTML.Replace("---height---", ds.Tables(0).Rows(0).Item("nAltura"))
            wHTML = wHTML.Replace("---cor---", "#" & ds.Tables(0).Rows(0).Item("tCor"))
            wPagina = ws.fRetornaPagina(ds.Tables(0).Rows(0).Item("cPagina"))

            Dim wPastaImgEditor As String = ""
            If ConfigurationManager.AppSettings("URLIMAGENS").IndexOf("http") > 0 Then
                wPastaImgEditor = ConfigurationManager.AppSettings("URLIMAGENS") & "Grupos/"
            Else
                wPastaImgEditor = "http://" & ConfigurationManager.AppSettings("URLIMAGENS") & "Grupos/"
            End If

            Dim wConteudoPagina As String = ""

            wConteudoPagina = wPagina.tDescPagina.Replace(Chr(10), "<br>").Replace("src=""Grupos", "src=""" & wPastaImgEditor)
            wConteudoPagina = wConteudoPagina.Replace(Chr(10), "<br>").Replace("src=""/Grupos", "src=""" & wPastaImgEditor)
            wHTML = wHTML.Replace("---conteudo---", wConteudoPagina)

        Else
            wHTML = ""
        End If

        Return wHTML

    End Function

#End Region

End Class
