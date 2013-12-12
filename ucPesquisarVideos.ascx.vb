Imports System.Data
Imports System.IO

Partial Class ucPesquisarVideos
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim wVideo As String

        If Not IsPostBack Then

            wVideo = File.ReadAllText(Server.MapPath("~") & "\Templates\VideoResultado.htm")
            Session("wTemplatePesquisaVideo") = wVideo

            Call sCarregarVideos()

        End If

        If Session("wTemplatePesquisaVideo") Is Nothing Then
            wVideo = File.ReadAllText(Server.MapPath("~") & "\Templates\VideoResultado.htm")
            Session("wTemplatePesquisaVideo") = wVideo
        End If

    End Sub

    Sub sCarregarVideos()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        Dim wCodigoEvento As Integer = Request.Params("id")

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
        wSQL += " order by dVideo "

        ds = ws.fRetornaDataSet(wSQL)

        With gvVideos
            .DataSource = ds
            .DataBind()
        End With

    End Sub

    Protected Sub cmdPesquisar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click

        Call sPesquisarVideos()

    End Sub

    Sub sPesquisarVideos()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        Dim wCodigoEvento As Integer = Request.Params("id")

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select cGrupo, *"
        wSQL += " from tbVideos V"
        wSQL += " where cGrupo in "
        wSQL += " ("
        wSQL += " select cGrupo from tbGrupoPortais"
        wSQL += " where cPortal = " & wPortal.cPortal
        wSQL += " )"
        wSQL += " and (tVideo like '%" & txtPesquisar.Text.Trim & "%' or tChamada like '%" & txtPesquisar.Text.Trim & "%')"
        wSQL += " and (cPortal = " & wPortal.cPortal & " or cPortal = 0)"
        wSQL += " order by dVideo "

        ds = ws.fRetornaDataSet(wSQL)

        With gvVideos
            .DataSource = ds
            .DataBind()
        End With

    End Sub

    Function fCarregarVideos(ByVal wCodigoVideo As Integer, ByVal wVideo As String, ByVal wChamada As String, ByVal wData As Date, ByVal wCodigoLink As String) As String

        Dim wTemplateVideo As String = Session("wTemplatePesquisaVideo")
        Dim wImagem As String = "http://i4.ytimg.com/vi/---CODIGOLINK---/default.jpg"

        wImagem = wImagem.Replace("---CODIGOLINK---", wCodigoLink)
        wTemplateVideo = wTemplateVideo.Replace("---TITULO---", wVideo)
        wTemplateVideo = wTemplateVideo.Replace("---CODIGOVIDEO---", wCodigoVideo)
        wTemplateVideo = wTemplateVideo.Replace("---CHAMADA---", wChamada)
        wTemplateVideo = wTemplateVideo.Replace("---DATA---", wData)
        wTemplateVideo = wTemplateVideo.Replace("---IMAGEM---", wImagem)
        wTemplateVideo = wTemplateVideo.Replace("---VIEWS---", "")

        Return wTemplateVideo

    End Function

    Protected Sub gvVideos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvVideos.SelectedIndexChanged

    End Sub
End Class
