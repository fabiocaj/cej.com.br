Imports System.Data
Imports System.IO

Partial Class ucGaleriaPesquisa
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos
    Dim wSQL As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Call sCarregarComboCategorias()
            Call sConfiguraPaineis("P")
            Call sCarregarTop10Albuns()

        End If

    End Sub

    Sub sConfiguraPaineis(ByVal wTipo As String)

        pnlAlbuns.Visible = False
        pnlCategorias.Visible = False
        pnlFotos.Visible = False
        pnlGalerias.Visible = False
        pnlFotos.Visible = False

        Select Case wTipo.ToUpper

            Case "P"
                pnlGalerias.Visible = True

            Case "C"
                pnlCategorias.Visible = True

            Case "A"
                pnlAlbuns.Visible = True

            Case "F"
                pnlFotos.Visible = True

        End Select

    End Sub

    Sub sCarregarTop10Albuns()

        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()

        Call sConfiguraPaineis("P")

        'wSQL = " select "
        'wSQL += " top 10 "
        'wSQL += " max(af.dCadastro) as dCadastro, af.cAlbum, tAlbum, tCategoriaFoto"
        'wSQL += " from tbAlbumFotos AF"
        'wSQL += " join tbAlbuns A on a.cAlbum = af.cAlbum"
        'wSQL += " join tbCategoriasFotos CF on cf.cCategoriaFoto = a.cCategoriaFoto"
        'wSQL += " where a.cPortal = " & func.fPortal
        'wSQL += " group by af.dCadastro, af.cAlbum, tAlbum, tCategoriaFoto"
        'wSQL += " order by af.dCadastro DESC"

        wSQL = "  select  "
        wSQL += " top 10  "
        wSQL += " max(af.dCadastro) as dCadastro, af.cAlbum, tAlbum, count(1) as qFotos,cCategoriaFoto "
        wSQL += " from tbAlbumFotos AF "
        wSQL += " join tbAlbuns A on a.cAlbum = af.cAlbum "
        wSQL += " WHERE a.cPortal = " & func.fPortal
        wSQL += " group by af.dCadastro, af.cAlbum, tAlbum,cCategoriaFoto"

        With gvGalerias
            .DataSource = ws.fRetornaDataSet(wSQL)
            .DataBind()
        End With

    End Sub

    Sub sCarregarComboCategorias()

        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()

        wSQL = "  select cf.tCategoriaFoto, cf.cCategoriaFoto"
        wSQL += " from tbAlbumFotos AF"
        wSQL += " join tbAlbuns A on af.cAlbum = a.cAlbum"
        wSQL += " join tbCategoriasFotos CF on cf.cCategoriaFoto = a.cCategoriaFoto"
        wSQL += " where a.cPortal = " & func.fPortal
        wSQL += " group by cf.tCategoriaFoto, cf.cCategoriaFoto"

        Call func.sCarregaCombo(ws.fRetornaDataSet(wSQL), cmbRelacaoCategorias, "tCategoriaFoto", "cCategoriaFoto", "(Todas as Categorias)")

    End Sub

    Sub sCarregaComboCategorias()

        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()

        wSQL = "  select * "
        wSQL += " from tbCategoriasFotos"
        wSQL += " where cPortal = " & func.fPortal()
        wSQL += " order by tCategoriaFoto"

        Call func.sCarregaCombo(wSQL, cmbRelacaoCategorias, "tCategoria", "cCategoria", "(Todas as Categorias)")

    End Sub

    Sub sPesquisarGalerias()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String
        Dim wCodigoEvento As Integer = Request.Params("id")

        Call sConfiguraPaineis("C")

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select tCategoriaFoto, a.cCategoriaFoto, count(1) as qFotos "
        wSQL += " from tbAlbumFotos AF"
        wSQL += " left join tbAlbuns A on a.cAlbum = af.cAlbum "
        wSQL += " join tbCategoriasFotos CF on a.cCategoriaFoto = cf.cCategoriaFoto "
        wSQL += " where ( tAlbum like '%" & txtPesquisar.Text.Trim & "%' or af.tLegenda like '%" & txtPesquisar.Text.Trim & "%' )"
        wSQL += " and a.cPortal = " & wPortal.cPortal

        If cmbRelacaoCategorias.SelectedValue <> "0" Then
            wSQL += " and a.cCategoriaFoto = " & cmbRelacaoCategorias.SelectedValue
        End If

        wSQL += " group by a.cCategoriaFoto, tCategoriaFoto"

        ds = ws.fRetornaDataSet(wSQL)

        With gvCategorias
            .DataSource = ds
            .DataBind()
        End With

    End Sub

    Sub sCarregarAlbuns(ByVal wCodigoCategoria As Integer)

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String
        Dim wCodigoEvento As Integer = Request.Params("id")

        Call sConfiguraPaineis("A")

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select tAlbum, a.cAlbum, tCategoriaFoto, cf.cCategoriaFoto, count(1) as qFotos"
        wSQL += " from tbAlbuns A"
        wSQL += " left join tbAlbumFotos AF on a.cAlbum = af.cAlbum"
        wSQL += " join tbCategoriasFotos CF on a.cCategoriaFoto = cf.cCategoriaFoto"
        wSQL += " where "
        wSQL += " ( af.tLegenda like '%" & txtPesquisar.Text.Trim & "%' )"
        wSQL += " and a.cPortal = " & wPortal.cPortal
        wSQL += " and a.cCategoriaFoto = " & wCodigoCategoria
        wSQL += " group by tAlbum, a.cAlbum, tCategoriaFoto, cf.cCategoriaFoto "

        ds = ws.fRetornaDataSet(wSQL)

        With gvAlbuns
            .DataSource = ds
            .DataBind()
        End With

    End Sub

    Sub sCarregarFotos(ByVal wCodigoAlbum As Integer)

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String
        Dim wCodigoEvento As Integer = Request.Params("id")

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select tAlbum, a.cAlbum, tCategoriaFoto, tFoto, Case tLegenda When '' then 'Sem Legenda' else tLegenda END as tLegenda, af.dCadastro, cFoto"
        wSQL += " from tbAlbumFotos AF "
        wSQL += " left join tbAlbuns A on a.cAlbum = af.cAlbum "
        wSQL += " join tbCategoriasFotos CF on a.cCategoriaFoto = cf.cCategoriaFoto "
        wSQL += " where ( af.tLegenda like '%" & txtPesquisar.Text.Trim & "%' )"
        wSQL += " and a.cPortal = " & wPortal.cPortal
        wSQL += " and a.cAlbum = " & wCodigoAlbum
        wSQL += " order by af.dCadastro, tLegenda, cFoto"

        ds = ws.fRetornaDataSet(wSQL)

        With dlFotos
            .DataSource = ds
            .DataBind()
        End With

    End Sub

    Function fCarregarGalerias(ByVal wCodigoAlbum As Integer, ByVal wAlbum As String) As String

        Dim wTemplateGaleria As String = Session("wTemplatePesquisaGaleria")
        'Dim wImagem As String = "http://i4.ytimg.com/vi/---CODIGOLINK---/default.jpg"

        'wImagem = wImagem.Replace("---CODIGOLINK---", wCodigoLink)
        wTemplateGaleria = wTemplateGaleria.Replace("---TITULO---", wAlbum)
        wTemplateGaleria = wTemplateGaleria.Replace("---CODIGOALBUM---", wCodigoAlbum)
        'wTemplateVideo = wTemplateVideo.Replace("---CHAMADA---", wChamada)
        'wTemplateVideo = wTemplateVideo.Replace("---DATA---", wData)
        'wTemplateVideo = wTemplateVideo.Replace("---IMAGEM---", wImagem)
        'wTemplateVideo = wTemplateVideo.Replace("---VIEWS---", "")

        Return wTemplateGaleria

    End Function

    Protected Sub cmbRelacaoCategorias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRelacaoCategorias.SelectedIndexChanged

    End Sub

    Function fRetornaImagem(ByVal wFoto As String, ByVal wCodigoAlbum As Integer) As String

        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        wFoto = "/" & wCodigoAlbum & "/" & wFoto
        Dim wURL As String

        wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "ALBUM", wFoto)

        Return wURL

    End Function

    Protected Sub cmdPesquisar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click

        lblAlbum.Text = ""
        lblCategoria.Text = ""

        If cmbRelacaoCategorias.SelectedValue <> "0" Then
            Call sCarregarAlbuns(cmbRelacaoCategorias.SelectedValue)
        Else
            Call sPesquisarGalerias()
        End If


    End Sub

    Protected Sub cmdTop10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdTop10.Click

        lblAlbum.Text = ""
        lblCategoria.Text = ""
        Call sCarregarTop10Albuns()

    End Sub

    Protected Sub gvCategorias_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvCategorias.SelectedIndexChanging

        lblAlbum.Text = ""
        lblCategoria.Text = ""
        Dim wCodigo As Integer
        wCodigo = CType(gvCategorias.Rows(e.NewSelectedIndex).FindControl("lblCodigo"), Label).Text
        lblCategoria.Text = CType(gvCategorias.Rows(e.NewSelectedIndex).FindControl("lnkCategoria"), LinkButton).Text
        lblAlbum.Text = ""
        Call sCarregarAlbuns(wCodigo)

    End Sub

    Protected Sub gvAlbuns_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvAlbuns.SelectedIndexChanging

        lblAlbum.Text = ""
        lblCategoria.Text = ""
        Call sConfiguraPaineis("F")

        Dim wCodigoAlbum As Integer
        wCodigoAlbum = CType(gvAlbuns.Rows(e.NewSelectedIndex).FindControl("lblCodigo"), Label).Text

        lblCategoria.Text = CType(gvAlbuns.Rows(e.NewSelectedIndex).FindControl("lnkAlbum"), LinkButton).Text
        lblAlbum.Text = CType(gvAlbuns.Rows(e.NewSelectedIndex).FindControl("lnkCategoria"), LinkButton).Text

        Call sCarregarFotos(wCodigoAlbum)

        Dim wCodigoCategoria As Integer
        wCodigoCategoria = CType(gvAlbuns.Rows(e.NewSelectedIndex).FindControl("lblCodigoCategoria"), Label).Text
        Call sCarregarAlbunsRelacionados(wCodigoAlbum, wCodigoCategoria)

    End Sub

    Sub sCarregarAlbunsRelacionados(ByVal wCodigoAlbum As Integer, ByVal wCodigoCategoria As Integer)

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select *"
        wSQL += " from tbAlbuns"
        wSQL += " where cPortal = " & wPortal.cPortal
        wSQL += " and cCategoriaFoto = " & wCodigoCategoria
        wSQL += " and cAlbum <> " & wCodigoAlbum
        wSQL += " order by tAlbum"

        ds = ws.fRetornaDataSet(wSQL)




    End Sub

    Protected Sub gvAlbuns_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvAlbuns.SelectedIndexChanged

    End Sub

    Protected Sub gvGalerias_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvGalerias.SelectedIndexChanging
        Call sConfiguraPaineis("F")
        lblAlbum.Text = ""
        lblCategoria.Text = ""

        Dim wCodigoAlbum As Integer
        wCodigoAlbum = CType(gvGalerias.Rows(e.NewSelectedIndex).FindControl("lblCodigo"), Label).Text
        Call sCarregarFotos(wCodigoAlbum)

        Dim wCodigoCategoria As Integer
        wCodigoCategoria = CType(gvGalerias.Rows(e.NewSelectedIndex).FindControl("lblCodigoCategoria"), Label).Text
        lblCategoria.Text = CType(gvGalerias.Rows(e.NewSelectedIndex).FindControl("lnkAlbum"), LinkButton).Text
        Call sCarregarAlbunsRelacionados(wCodigoAlbum, wCodigoCategoria)
    End Sub

    Protected Sub gvGalerias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvGalerias.SelectedIndexChanged

    End Sub

    Protected Sub gvCategorias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvCategorias.SelectedIndexChanged

    End Sub
End Class

