
Partial Class layout_mundialline_css_ucGaleriaDeltalhe
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarFoto()

        End If

    End Sub

    Sub sCarregarFoto()

        Dim wFoto As String
        wFoto = Request.Params("cID")
        Image1.ImageUrl = fRetornaImagem(wFoto)

    End Sub

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
