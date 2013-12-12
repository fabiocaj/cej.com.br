Imports System.Data

Partial Class ucVideos
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim wCodigoVideo As Integer = 1

            wCodigoVideo = func.fRetornaParametroSeguro(Request.Params("cVideo"))
            If Not IsNumeric(wCodigoVideo) Then
                wCodigoVideo = 1
            End If
            lblCodigoVideo.Text = wCodigoVideo

            Call sCarregarVideo()
            Call sCarregarVideos(lblCodigoVideo.Text, "P")

        End If

    End Sub

    Sub sCarregarVideo()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select * "
        wSQL += " from tbVideos"
        wSQL += " where cVideo = " & lblCodigoVideo.Text

        ds = ws.fRetornaDataSet(wSQL)

        If ds.Tables(0).Rows.Count > 0 Then

            lblVideo.Text = fCarregarCodigoVideo(ds.Tables(0).Rows(0).Item("tCodigoVideo"))

        End If

    End Sub

    Sub sCarregarVideos(ByVal wCodigoVideo As Integer, ByVal wTipo As String)

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select top 5 cGrupo, *"
        wSQL += " from tbVideos V"
        wSQL += " where cGrupo in "
        wSQL += " ("
        wSQL += " select cGrupo from tbGrupoPortais"
        wSQL += " where cPortal = " & wPortal.cPortal
        wSQL += " )"
        wSQL += " and (cPortal = " & wPortal.cPortal & " or cPortal = 0)"

        If wCodigoVideo <> 0 Then
            If wTipo.ToUpper = "P" Then
                wSQL += " and cVideo > " & wCodigoVideo
            End If
        Else
            If wTipo.ToUpper = "A" Then
                wSQL += " and cVideo < " & wCodigoVideo
            End If
        End If

        wSQL += " order by dVideo "

        ds = ws.fRetornaDataSet(wSQL)

        With dlVideos
            .DataSource = ds
            .DataBind()
        End With

        If ds.Tables(0).Rows.Count > 0 Then
            lblCodigoVideoPrimeiro.Text = ds.Tables(0).Rows(0).Item("cVideo")
            lblCodigoVideoUltimo.Text = ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1).Item("cVideo")
        End If

    End Sub

    Function fCarregarCodigoVideo(ByVal wCodigoVideo As String) As String

        Dim wObjeto As String

        wObjeto = "<object width='700' height='400'>"

        wObjeto += "<param name='movie' value='http://www.youtube.com/v/---CODIGOVIDEO---&hl=pt_BR&fs=1&'></param>"
        wObjeto += "<param name='allowFullScreen' value='true'></param>"
        wObjeto += "<param name='allowscriptaccess' value='always'></param>"
        wObjeto += "<embed src='http://www.youtube.com/v/---CODIGOVIDEO---&hl=pt_BR&fs=1&' type='application/x-shockwave-flash' allowscriptaccess='always' allowfullscreen='true' width='770' height='420'></embed>"
        wObjeto += "</object>"

        wObjeto = wObjeto.Replace("---CODIGOVIDEO---", wCodigoVideo)

        Return wObjeto

    End Function


    Protected Sub cmdProximosVideos_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdProximosVideos.Click

        Call sCarregarVideos(lblCodigoVideoUltimo.Text, "P")

    End Sub

    Protected Sub cmdVideosAnteriores_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdVideosAnteriores.Click

        Call sCarregarVideos(lblCodigoVideoPrimeiro.Text, "A")

    End Sub

End Class
