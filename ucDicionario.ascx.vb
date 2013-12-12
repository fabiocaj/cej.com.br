Imports System.Data

Partial Class ucDicionario
    Inherits System.Web.UI.UserControl


    Dim wSQL As String
    Dim func As New Funcoes

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarCombos()

        End If
    End Sub

    Sub sCarregarCombos()

        Call sCarregarComboDicionarios()
        Call sCarregarComboVerbetes()
        Call sCarregarDescricaoVerbete()

    End Sub

    Sub sCarregarComboDicionarios()

        Dim ds As DataSet
        Dim ws As New wsCash.wsCash
        Dim wParametros As New wsCash.wParametros
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        wParametros = ws.fParametrosPortais()

        wSQL = "  Select * "
        wSQL += " from tbDicionarios "
        wSQL += " order by tDicionario "

        ds = ws.fRetornaDataSet(wSQL)

        Call func.sCarregaCombo(ds, cmbDicionarios, "tDicionario", "cDicionario")

    End Sub


    Sub sCarregarComboVerbetes()

        Dim ds As DataSet
        Dim ws As New wsCash.wsCash
        Dim wParametros As New wsCash.wParametros
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        wParametros = ws.fParametrosPortais()

        wSQL = "  Select * "
        wSQL += " from tbDicionarioVerbetes "
        wSQL += " where cDicionario = " & cmbDicionarios.SelectedItem.Value
        wSQL += " order by tVerbete "

        ds = ws.fRetornaDataSet(wSQL)

        Call func.sCarregaCombo(ds, cmbVerbetes, "tVerbete", "cVerbete")

    End Sub



    Protected Sub cmbVerbetes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVerbetes.SelectedIndexChanged

        Call sCarregarDescricaoVerbete()

    End Sub

    Sub sCarregarDescricaoVerbete()

        Dim ds As DataSet
        Dim ws As New wsCash.wsCash
        Dim wParametros As New wsCash.wParametros
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        wParametros = ws.fParametrosPortais()

        wSQL = "  Select * "
        wSQL += " from tbDicionarioVerbetes "
        wSQL += " where cVerbete = " & cmbVerbetes.SelectedItem.Value

        ds = ws.fRetornaDataSet(wSQL)

        lblDescricao.Text = ds.Tables(0).Rows(0).Item("tDescricao").ToString

    End Sub


    Protected Sub cmbDicionarios_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDicionarios.SelectedIndexChanged

        Call sCarregarComboVerbetes()
        Call sCarregarDescricaoVerbete()

    End Sub

End Class
