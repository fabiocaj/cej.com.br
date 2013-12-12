
Partial Class uclogotipo
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarLogo()

        End If

    End Sub

    Sub sCarregarLogo()

        If Session("wLogoTipo") Is Nothing Then

            Dim ws As New wsCash.wsCash
            ws.Url = ConfigurationManager.AppSettings("wsURL")

            Dim wURL As String = ws.fRetornaImagemLogo(ConfigurationManager.AppSettings("URLIMAGENS"), ConfigurationManager.AppSettings("PORTAL"))


            Session("wLogoTipo") = wURL

        End If

        imgLogo.ImageUrl = Session("wLogoTipo")

    End Sub

End Class
