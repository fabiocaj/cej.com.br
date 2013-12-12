Imports System.Data
Imports System.IO

Partial Class ucDownloads
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos
    Dim wSQL As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Session("wTemplateDownload") = File.ReadAllText(Server.MapPath("~") & "\TemplateDownload.htm")
            Call sCarregarComboCategorias()
            Call sCarregarDownloads()

        End If

    End Sub

    Sub sCarregarComboCategorias()

        'Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        wSQL = " select *"
        wSQL += " from tbCategoriasDownloads"
        wSQL += " where cPortal in ( select cportal from tbgrupoportais where cgrupo = " & func.fGrupo() & " ) "
        wSQL += " order by tCategoriaDownload"

        ws = func.fRetornaWS()

        'ds = ws.fRetornaDataSet(wSQL)

        Call func.sCarregaCombo(ws.fRetornaDataSet(wSQL), cmbCategorias, "tCategoriaDownload", "cCategoriaDownload", "Selecione")

    End Sub

    Sub sCarregarDownloads()

        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        wSQL = "  select *"
        wSQL += " from tbDownloads"
        wSQL += " where cCategoriaDownload = " & cmbCategorias.SelectedValue
        wSQL += " order by dDownload DESC"

        ws = func.fRetornaWS()

        With gvDownloads
            .DataSource = ws.fRetornaDataSet(wSQL)
            .DataBind()
        End With

    End Sub

    Protected Sub cmbCategorias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategorias.SelectedIndexChanged

        gvDownloads.PageIndex = 0
        Call sCarregarDownloads()

    End Sub

    Protected Sub gvDownloads_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvDownloads.PageIndexChanging

        gvDownloads.PageIndex = e.NewPageIndex.ToString
        Call sCarregarDownloads()

    End Sub

    Protected Sub gvDownloads_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvDownloads.RowDataBound

        Dim wDownload As New Label
        Dim ws As New wsCash.wsCash

        If e.Row.RowType = DataControlRowType.DataRow Then

            Dim wCorpo As String
            Dim wValues As System.Data.DataRowView = CType(e.Row.DataItem, System.Data.DataRowView)
            wDownload = CType(e.Row.FindControl("lblDownload"), Label)

            wCorpo = Replace(Session("wTemplateDownload"), "---nome---", wValues.Item("tDownload"))
            wCorpo = Replace(wCorpo, "---data---", CType(wValues.Item("dDownload"), Date).ToShortDateString)
            wCorpo = Replace(wCorpo, "---descricao---", wValues.Item("tDescricao"))
            If wValues.Item("tImagem") = "" Then
                wCorpo = Replace(wCorpo, "---caminhoimagem---", ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "DOWNLOADSIMAGENS", "Down.png"))
            Else
                wCorpo = Replace(wCorpo, "---caminhoimagem---", ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "DOWNLOADSIMAGENS", wValues.Item("tImagem")))
            End If
            wCorpo = Replace(wCorpo, "---caminhoarquivo---", ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "DOWNLOADS", wValues.Item("tArquivo")))

            wDownload.Text = wCorpo

        End If

    End Sub


End Class
