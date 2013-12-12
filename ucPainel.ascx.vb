Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports Telerik.WebControls


Partial Class ucPainel
    Inherits System.Web.UI.UserControl

    Dim wSQL As String
    Dim func As New Funcoes

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarPanel()

        End If

    End Sub

    Sub sCarregarPanel()

        wSQL = "  select *"
        wSQL += " from tbSecaoItens "
        wSQL += " where cSecao = 1 "
        wSQL += " order by cSequencia"

        Dim dsPanelBar As DataSet

        dsPanelBar = func.fRetornaDataSet(wSQL)

        rpbPainel.DataFieldID = "cMenu"
        rpbPainel.DataFieldParentID = "cPai"
        rpbPainel.DataSource = dsPanelBar
        rpbPainel.DataBind()

    End Sub

    Protected Sub rpbPainel_OnPanelItemDataBound(ByVal sender As Object, ByVal e As RadPanelbarPanelItemDataBoundEventArgs)

        If Not e.DataBoundDataRow.IsNull("tMenu") Then
            e.DataBoundPanelItem.Text = e.DataBoundDataRow("tMenu").ToString()
        End If

        'DataBindEvents.Text += "Binding PanelItem <b>" + e.DataBoundPanelItem.Text + "</b><br />"

    End Sub 'RadPa

End Class
