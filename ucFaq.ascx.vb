Imports System.Data
Imports System.IO

Partial Class ucFaq
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos
    Dim wSQL As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Session("wTemplateFaq") = File.ReadAllText(Server.MapPath("~") & "\TemplateFaq.htm")
            Call fCarregarFAQ()

        End If

    End Sub

    Sub fCarregarFAQ()

        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        wSQL = "  select *"
        wSQL += " from tbFAQs "
        wSQL += " where cPortal in ( select cportal from tbgrupoportais where cgrupo = " & func.fGrupo() & " ) "
        wSQL += " and (tFAQ like '%" & txtPesquisa.Text & "%' or tDescricao like '%" & txtPesquisa.Text & "%') "
        wSQL += " order by dFaq DESC"

        ws = func.fRetornaWS()

        With gvFaq
            .DataSource = ws.fRetornaDataSet(wSQL)
            .DataBind()
        End With

    End Sub

    Protected Sub gvFaq_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvFaq.PageIndexChanging

        gvFaq.PageIndex = e.NewPageIndex.ToString
        Call fCarregarFAQ()

    End Sub

    Public wcount As Integer = 0
    Protected Sub gvFaq_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvFaq.RowDataBound

        Dim wFaq As New Label
        Dim ws As New wsCash.wsCash

        If e.Row.RowType = DataControlRowType.Header Then
            wcount = 0
        End If

        If e.Row.RowType = DataControlRowType.DataRow Then

            Dim wCorpo As String
            Dim wValues As System.Data.DataRowView = CType(e.Row.DataItem, System.Data.DataRowView)
            wFaq = CType(e.Row.FindControl("lblFaq"), Label)
            wcount += 1
            wCorpo = Replace(Session("wTemplateFaq"), "---titulo---", wValues.Item("tFAQ"))
            wCorpo = Replace(wCorpo, "--var1--", "CollapsiblePanel" & wcount)
            wCorpo = Replace(wCorpo, "---descricao---", wValues.Item("tDescricao"))
            wFaq.Text = wCorpo

        End If

    End Sub

    Protected Sub cmdPesquisar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPesquisar.Click
        Call fCarregarFAQ()
    End Sub
End Class