
Partial Class uciFrame
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarPagina(Request.Params("cPagina"))

        End If

    End Sub

    Sub sCarregarPagina(ByVal wCodigoPagina As String)

        Dim wPagina As New wsCash.wPagina
        Dim ws As New wsCash.wsCash

        If wCodigoPagina = "" Then
            wCodigoPagina = "32"
        End If

        ws = func.fRetornaWS()
        wPagina = ws.fRetornaPagina(wCodigoPagina)

        Dim wiFrame As String

        With wPagina

            If .tLinkiFrame.Trim.Length > 0 Then
                wiFrame = "<iframe src='http://" & wPagina.tLinkiFrame.Replace("http://", "") & "' width='" & .nLargura & "' height='" & .nAltura & "' frameborder='0'>"
                wiFrame += "</iframe>"
            Else
                wiFrame = ""
            End If

        End With

        lbliFrame.Text = wiFrame

    End Sub

End Class
