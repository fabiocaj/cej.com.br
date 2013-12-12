Imports System.Data

Partial Class ucGaleria
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim wCodigoAlbum As Integer = 1

            wCodigoAlbum = func.fRetornaParametroSeguro(Request.Params("cGaleria"))
            If Not IsNumeric(wCodigoAlbum) Then
                wCodigoAlbum = 1
            End If

            Call sCarregarAlbum(wCodigoAlbum)

        End If

    End Sub

    Sub sCarregarAlbum(ByVal wCodigoAlbum As Integer)

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL += " select * "
        wSQL += " from tbAlbumFotos "
        wSQL += " where cAlbum = " & wCodigoAlbum
        wSQL += " order by dCadastro"

        ds = ws.fRetornaDataSet(wSQL)

        With dlFotos
            .DataSource = ds
            .DataBind()
        End With

    End Sub

    Function fCarregarCodigoAlbum(ByVal wCodigoAlbum As String) As String

        Dim wObjeto As String

        wObjeto = "<object width='700' height='400'>"

        wObjeto += "<param name='movie' value='http://www.youtube.com/v/---CODIGOAlbum---&hl=pt_BR&fs=1&'></param>"
        wObjeto += "<param name='allowFullScreen' value='true'></param>"
        wObjeto += "<param name='allowscriptaccess' value='always'></param>"
        wObjeto += "<embed src='http://www.youtube.com/v/---CODIGOAlbum---&hl=pt_BR&fs=1&' type='application/x-shockwave-flash' allowscriptaccess='always' allowfullscreen='true' width='700' height='400'></embed>"
        wObjeto += "</object>"

        wObjeto = wObjeto.Replace("---CODIGOAlbum---", wCodigoAlbum)

        Return wObjeto

    End Function

    Function fRetornaImagem(ByVal wFoto As String) As String

        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        Dim wCodigoAlbum As Integer = 1
        wCodigoAlbum = func.fRetornaParametroSeguro(Request.Params("cGaleria"))

        wFoto = "/" & wCodigoAlbum & "/" & wFoto
        Dim wURL As String

        wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "ALBUM", wFoto)

        Return wURL

    End Function


End Class
