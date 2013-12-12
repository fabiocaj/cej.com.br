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

Partial Class ucMenuRedeDescontos
    Inherits System.Web.UI.UserControl

    Dim wSQL As String
    Dim func As New Funcoes

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarPanelRedeDescontos()

        End If

    End Sub

    Sub sCarregarPanelRedeDescontos()

        Dim ds As DataSet
        Dim ws As New wsCash.wsCash
        Dim wParametros As New wsCash.wParametros
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        Dim clsAcessos As New clsAcessos
        wParametros = ws.fParametrosPortais()

        'wSQL = "  Select * , t.tPagina as tPaginaTemplate"
        'wSQL += " from tbSecaoItens SI"
        'wSQL += " join tbTemplates T on si.cTemplate = t.cTemplate"
        'wSQL += " where SI.cSecao = " & wParametros.cSecaoRedeDescontos 'Session("cSecao") 'wParametros.cSecaoRedeDescontos
        'wSQL += " order by cSequencia "

        wSQL = "  Select * , t.tPagina as tPaginaTemplate"
        wSQL += " from tbSecaoItens SI"
        wSQL += " join tbTemplates T on si.cTemplate = t.cTemplate"
        wSQL += " where SI.cSecao = " & wParametros.cSecaoRedeDescontos 'Session("cSecao") 'wParametros.cSecaoPadrao
        wSQL += " and SI.cGrupo = " & clsAcessos.fGrupo()
        wSQL += " and (SI.cPOrtal = 0 or SI.cPOrtal = " & clsAcessos.fPortal() & " ) "
        wSQL += " and lStatus = 1"
        wSQL += " order by cSequencia "

        ds = ws.fRetornaDataSet(wSQL)

        rpbRedeDescontos.DataFieldID = "cMenu"
        rpbRedeDescontos.DataFieldParentID = "cPai"
        rpbRedeDescontos.DataSource = ds
        rpbRedeDescontos.DataBind()

    End Sub

    Protected Sub rpbRedeDescontos_OnPanelItemDataBound(ByVal sender As Object, ByVal e As RadPanelbarPanelItemDataBoundEventArgs)

        If Not e.DataBoundDataRow.IsNull("tMenu") Then
            e.DataBoundPanelItem.Text = e.DataBoundDataRow("tMenu").ToString()
            If e.DataBoundDataRow("tPagina").ToString.Trim.Length > 0 Then
                e.DataBoundPanelItem.NavigateUrl = e.DataBoundDataRow("tPagina").ToString() & "?cSecao=" & e.DataBoundDataRow("cSecao").ToString() & "&cMenu=" & e.DataBoundDataRow("cMenu").ToString()
            Else
                e.DataBoundPanelItem.NavigateUrl = e.DataBoundDataRow("tPaginaTemplate").ToString() & "?cPagina=" & e.DataBoundDataRow("cPagina").ToString() & "&cSecao=" & e.DataBoundDataRow("cSecao").ToString() & "&cMenu=" & e.DataBoundDataRow("cMenu").ToString()
            End If

            e.DataBoundPanelItem.ItemExpandedCssClass = "ItensMenuPrincipalRedeDescontos"
            e.DataBoundPanelItem.Expanded = True
        End If

        'DataBindEvents.Text += "Binding PanelItem <b>" + e.DataBoundPanelItem.Text + "</b><br />"

    End Sub 'RadPanelbar1_OnPanelItemDataBound

End Class
