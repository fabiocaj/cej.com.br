Imports System.Data
Partial Class ucDetalhesDestaques
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim cDestaque As String

            cDestaque = Request.Params("cDestaque")

            If cDestaque Is Nothing Then
                Response.Redirect("Default.aspx")
            End If

            If cDestaque.Trim.Length > 0 Then

                Call sCarregarDestaque(cDestaque)

            End If

        End If

    End Sub

    Sub sCarregarDestaque(ByVal cDestaque As Integer)

        Dim wDestaque As New wsCash.wDestaque
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wDestaque = ws.fRetornaDestaqueInformacao(cDestaque)

        With wDestaque
            lblTitulo.Text = .tTitulo

            Dim wPastaImgEditor As String = ""
            If ConfigurationManager.AppSettings("URLIMAGENS").IndexOf("http") > 0 Then
                wPastaImgEditor = ConfigurationManager.AppSettings("URLIMAGENS") & "Grupos/"
            Else
                wPastaImgEditor = "http://" & ConfigurationManager.AppSettings("URLIMAGENS") & "Grupos/"
            End If
            lblTexto.Text = .tDestaque.Replace(Chr(10), "<br>").Replace("src=""Grupos", "src=""" & wPastaImgEditor)

            If .tImagem.Trim.Length = 0 Then
                imgImagem.Visible = False
            Else
                imgImagem.Visible = True
                imgImagem.ImageUrl = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMDESTAQUE", .tImagem)
            End If

        End With

    End Sub

End Class
