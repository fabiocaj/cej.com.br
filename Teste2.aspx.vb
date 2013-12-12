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

Partial Class Teste2
    Inherits System.Web.UI.Page

    Dim wSQL As String
    Dim func As New Funcoes

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Call sCarregarPanel()
        'Call sCarregarPH()

    End Sub

    Sub scarregarPH()

        'Dim wUC1 As New Control
        'wUC1 = Me.LoadControl("ucPainel.ascx")
        'phPaineis.Controls.Add(wUC1)

        'Dim wUC2 As New Control
        'wUC2 = Me.LoadControl("ucPainel.ascx")
        'phPaineis.Controls.Add(wUC2)

    End Sub


    Sub sCarregarPanel()

        wSQL = "  select *"
        wSQL += " from tbSecaoItens "
        wSQL += " where cSecao = 1 "
        wSQL += " order by cSequencia"

        'Dim dsPanelBar As dataset

        'dsPanelBar = func.fRetornaDataSet(wSQL)

        'RadPanelbar1.DataFieldID = "cMenu"
        'RadPanelbar1.DataFieldParentID = "cPai"
        'RadPanelbar1.DataSource = dsPanelBar
        'RadPanelbar1.DataBind()

    End Sub

    Protected Sub RadPanelbar1_OnPanelItemDataBound(ByVal sender As Object, ByVal e As RadPanelbarPanelItemDataBoundEventArgs)

        If Not e.DataBoundDataRow.IsNull("tMenu") Then
            e.DataBoundPanelItem.Text = e.DataBoundDataRow("tMenu").ToString()
        End If

        'DataBindEvents.Text += "Binding PanelItem <b>" + e.DataBoundPanelItem.Text + "</b><br />"

    End Sub 'RadPanelbar1_OnPanelItemDataBound


End Class
