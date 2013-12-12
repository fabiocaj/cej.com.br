
Partial Class ucDetalhesNoticias
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim wCodigoNoticia As String

            wCodigoNoticia = Request.Params("cNoticia")

            If wCodigoNoticia Is Nothing Then
                Response.Redirect("Default.aspx")
            End If

            If wCodigoNoticia.Trim.Length > 0 Then

                Call sCarregarNoticia(wCodigoNoticia)

            End If

        End If

    End Sub

    Sub sCarregarNoticia(ByVal wCodigoNoticia As Integer)

        Dim wNoticia As New wsCash.wNoticia
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wNoticia = ws.fRetornaNoticia(wCodigoNoticia)

        With wNoticia
            lblFonte.Text = .tFonte
            lblTitulo.Text = .tTitulo

            Dim wPastaImgEditor As String = ""

            If ConfigurationManager.AppSettings("URLIMAGENS").IndexOf("http") > 0 Then
                wPastaImgEditor = ConfigurationManager.AppSettings("URLIMAGENS") & "Grupos/"
            Else
                wPastaImgEditor = "http://" & ConfigurationManager.AppSettings("URLIMAGENS") & "Grupos/"
            End If


            lblTexto.Text = .tNoticia.Replace(Chr(10), "<br>").Replace("src=""Grupos", "src=""" & wPastaImgEditor)

            If .tImagemGrande.Trim.Length = 0 Then
                imgImagem.Visible = False
            Else
                imgImagem.Visible = True
                imgImagem.ImageUrl = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMGRANDE", .tImagemGrande)
            End If

        End With

    End Sub

End Class
