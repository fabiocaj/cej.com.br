Imports System.Data

Partial Class ucEventosDetalhes
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarEvento()

        End If

    End Sub

    Sub sCarregarEvento()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        Dim wCodigoEvento As Integer = Request.Params("id")

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select *"
        wSQL += " from tbEventos E"
        wSQL += " where cEvento = " & wCodigoEvento

        ds = ws.fRetornaDataSet(wSQL)

        If ds.Tables(0).Rows.Count > 0 Then

            lblEvento.Text = ds.Tables(0).Rows(0).Item("tEvento")
            lblDescricao.Text = ds.Tables(0).Rows(0).Item("tDescricao")

            lblDataInicio.Text = ds.Tables(0).Rows(0).Item("dEventoInicio")
            lblDataFim.Text = ds.Tables(0).Rows(0).Item("dEventoFim")

            lblLocal.Text = ds.Tables(0).Rows(0).Item("tLocal")

            lblEmail.Text = ds.Tables(0).Rows(0).Item("tEmail")
            lblTelefone.Text = ds.Tables(0).Rows(0).Item("tTelefone")
        End If


    End Sub

End Class
