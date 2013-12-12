
Partial Class DetalhesMembros
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call fCarregaInformacoes(Request.Params("cMembro"))

    End Sub

    Public Sub fCarregaInformacoes(ByVal wCodigoMembro As Integer)
        Dim wURL As String = ""
        Dim ws As New wsCash.wsCash
        Dim wMembro As wsCash.wMembro

        ws.Url = ConfigurationManager.AppSettings("wsURL")
        wMembro = ws.fRetornaMembro(wCodigoMembro)

        With wMembro

            If .tFoto.Trim.Length > 0 Then
                wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "FOTOS", .tFoto)
            Else
                wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "FOTOS", "Padrao.gif")
            End If

            lblCargo.Text = .tCargo
            lblDepartamento.Text = .tDepartamento
            lblNome.Text = .tNome
            lblInformacoes.Text = .tInformacoes.Replace(Chr(10), "<br>").Replace("<br><br>", "<br>")
            imgFoto.ImageUrl = wURL

        End With

    End Sub

End Class
