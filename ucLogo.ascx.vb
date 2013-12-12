
Partial Class ucLogo
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarLogo()

        End If

    End Sub

    Sub sCarregarLogo()

        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        Dim wURL As String = ws.fRetornaImagemLogo(ConfigurationManager.AppSettings("URLIMAGENS"), ConfigurationManager.AppSettings("PORTAL"))
        imgLogo.ImageUrl = wURL

    End Sub

End Class
