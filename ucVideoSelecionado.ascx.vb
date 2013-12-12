Imports System.Data
Partial Class ucVideoSelecionado
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblVideo.Text = fCarregarCodigoVideo(Session("tCodigoVideo"))

    End Sub

    Function fCarregarCodigoVideo(ByVal tCodigoVideo As String) As String

        Dim wObjeto As String

        wObjeto = "<object width='900' height='400'>"

        wObjeto += "<param name='movie' value='http://www.youtube.com/v/---CODIGOVIDEO---&hl=pt_BR&fs=1&'></param>"
        wObjeto += "<param name='allowFullScreen' value='true'></param>"
        wObjeto += "<param name='allowscriptaccess' value='always'></param>"
        wObjeto += "<embed src='http://www.youtube.com/v/---CODIGOVIDEO---&hl=pt_BR&fs=1&' type='application/x-shockwave-flash' allowscriptaccess='always' allowfullscreen='true' width='900' height='400'></embed>"
        wObjeto += "</object>"

        wObjeto = wObjeto.Replace("---CODIGOVIDEO---", tCodigoVideo)

        Return wObjeto

    End Function

End Class
