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

Partial Class ucMenuDepartamentosAreas
    Inherits System.Web.UI.UserControl

    Dim wSQL As String
    Dim func As New Funcoes

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Request("cDepartamento") = "" Then
            Call sCarregarPanelPadrao()
        End If

    End Sub

    Sub sCarregarPanelPadrao()

        Dim ds As DataSet
        Dim dsFilho As DataSet
        Dim ws As New wsCash.wsCash
        Dim wParametros As New wsCash.wParametros
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        Dim clsAcessos As New clsAcessos
        wParametros = ws.fParametrosPortais()

        wSQL += " select * "
        wSQL += " from tbDepartamentos d "
        wSQL += " where"
        wSQL += " d.cGrupo = " & clsAcessos.fGrupo()
        wSQL += " and (d.cPortal = 0 or d.cPortal = " & clsAcessos.fPortal() & " ) "
        wSQL += " and d.cDepartamento in "
        wSQL += " ( "
        wSQL += " Select dp.cDepartamento"
        wSQL += " From tbProdutos p "
        wSQL += " inner join tbDepartamentoSecoes ds "
        wSQL += " on p.cSecao = ds.cSecao"
        wSQL += " inner join tbDepartamentos dp "
        wSQL += " on dp.cDepartamento = ds.cDepartamento"
        wSQL += " ) "
        wSQL += " order by d.tDepartamento"

        ds = ws.fRetornaDataSet(wSQL)

        For wCount As Integer = 0 To ds.Tables(0).Rows.Count - 1

            Dim wPanelPai As New PanelItem()
            wPanelPai.Text = ds.Tables(0).Rows(wCount).Item("tDepartamento")
            wPanelPai.ItemExpandedCssClass = "ItensMenuPrincipalSaude"
            'wPanelPai.NavigateUrl = "Vitrine.aspx?cDepartamento=" & ds.Tables(0).Rows(wCount).Item("cDepartamento")
            wPanelPai.Expanded = True

            wSQL = " select * "
            wSQL += " from tbDepartamentoSecoes ds "
            wSQL += " where"
            wSQL += " ds.cGrupo = " & clsAcessos.fGrupo()
            wSQL += " and (ds.cPortal = 0 or ds.cPortal = " & clsAcessos.fPortal() & " ) "
            wSQL += " and ds.cDepartamento = " & ds.Tables(0).Rows(wCount).Item("cDepartamento")

            wSQL += " and ds.cSecao in "
            wSQL += " ( "
            wSQL += " Select ds.cSecao"
            wSQL += " From tbProdutos p "
            wSQL += " inner join tbDepartamentoSecoes ds "
            wSQL += " on p.cSecao = ds.cSecao"
            wSQL += " ) "

            wSQL += " order by ds.tSecao"

            dsFilho = ws.fRetornaDataSet(wSQL)

            For wCountFilho As Integer = 0 To dsFilho.Tables(0).Rows.Count - 1

                Dim wPanelFilho As New PanelItem()
                wPanelFilho.Text = dsFilho.Tables(0).Rows(wCountFilho).Item("tSecao")
                wPanelFilho.ItemExpandedCssClass = "ItensMenuPrincipalSaude"
                wPanelFilho.NavigateUrl = "Vitrine.aspx?cDepartamento=" & dsFilho.Tables(0).Rows(wCountFilho).Item("cDepartamento") & "&cSecao=" & dsFilho.Tables(0).Rows(wCountFilho).Item("cSecao")
                wPanelFilho.Expanded = True
                wPanelPai.PanelItems.Add(wPanelFilho)
                wPanelFilho.Dispose()


                '  wPanelFilho.Text = wPanelFilho.Text & "</td></tr><tr><td bgcolor=#ffffff height=5px>"



            Next

            rpbDepartamentosAreas.PanelItems.Add(wPanelPai)
        Next

        'rpbDepartamentosAreas.DataFieldID = "cDepartamento"
        'rpbDepartamentosAreas.DataFieldParentID = "cPai"
        'rpbDepartamentosAreas.DataSource = ds
        'rpbDepartamentosAreas.DataBind()

    End Sub

    Protected Sub rpbPadrao_OnPanelItemDataBound(ByVal sender As Object, ByVal e As RadPanelbarPanelItemDataBoundEventArgs)

        'If Not e.DataBoundDataRow.IsNull("tMenu") Then
        e.DataBoundPanelItem.Text = "TESTE"  'e.DataBoundDataRow("tMenu").ToString()
        '    'If e.DataBoundDataRow("tPagina").ToString.Trim.Length > 0 Then
        '    '    If e.DataBoundDataRow("tPagina").ToString().Contains("?") Then
        '    '        e.DataBoundPanelItem.NavigateUrl = e.DataBoundDataRow("tPagina").ToString() & "&cSecao=" & e.DataBoundDataRow("cSecao").ToString() & "&cMenu=" & e.DataBoundDataRow("cMenu").ToString()
        '    '    Else
        '    '        e.DataBoundPanelItem.NavigateUrl = e.DataBoundDataRow("tPagina").ToString() & "?cSecao=" & e.DataBoundDataRow("cSecao").ToString() & "&cMenu=" & e.DataBoundDataRow("cMenu").ToString()
        '    '    End If

        '    'Else
        '    '    e.DataBoundPanelItem.NavigateUrl = e.DataBoundDataRow("tPaginaTemplate").ToString() & "?cPagina=" & e.DataBoundDataRow("cPagina").ToString() & "&cSecao=" & e.DataBoundDataRow("cSecao").ToString() & "&cMenu=" & e.DataBoundDataRow("cMenu").ToString()
        '    'End If
        '    e.DataBoundPanelItem.ItemExpandedCssClass = "ItensMenuPrincipalPadrao"
        '    e.DataBoundPanelItem.Expanded = True

        'End If

    End Sub 'RadPanelbar1_OnPanelItemDataBound

End Class
