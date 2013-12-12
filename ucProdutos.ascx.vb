Imports System.Data
Imports System.IO

Partial Class ucProdutos
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Session("wTemplateProduto") = File.ReadAllText(Server.MapPath("~") & "/Templates/ProdutoEmColuna.htm")
            Call sCarregarProdutos()
        End If

    End Sub

    Public Function fRetornaCaminhoImagem(ByVal wImagem As String) As String

        Dim wCorpo As String = ""
        Dim ws As New wsCash.wsCash

        wCorpo = "<IMG src='---caminhoimagem---' width='110px' border='0' />"

        If wImagem <> "" Then
            'wCorpo = Replace(wCorpo, "---caminhoimagem---", ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMDESTAQUE", wImagem))

        Else
            wCorpo = ""
        End If

        Return wCorpo

    End Function

    Sub sCarregarProdutos()

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        Dim wDepartamento As String = Request.Params("cDepartamento")
        Dim wSecao As String = Request.Params("cVitrineSecao")
        Dim wFabricante As String = Request.Params("cFAbricante")
        Dim wFlagHome As Boolean = True

        wSQL = " select * "
        wSQL += " from vwProdutos "
        wSQL += " where cPortal = " & func.fPortal()
        wSQL += " and lStatus = 1 "

        If IsNumeric(wDepartamento) Then
            wSQL += " and cDepartamento = " & wDepartamento
            wFlagHome = False
        End If

        If IsNumeric(wSecao) Then
            wSQL += " and cSecao = " & wSecao
            wFlagHome = False
        End If

        If IsNumeric(wFabricante) Then
            wSQL += " and cFabricante = " & wFabricante
            wFlagHome = False
        End If

        If wFlagHome = True Then
            wSQL += " and lDestaqueHome =  1 "
        End If

        wSQL += " order by tProduto "

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = ws.fRetornaDataSet(wSQL)

        With dlProdutos

            .DataSource = ds
            .DataBind()
            ' .RepeatColumns = IIf(wPortal.qDestaquesColunas = 0, 1, wPortal.qDestaquesColunas)

        End With

    End Sub

    Protected Sub dlProdutos_ItemDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DataListItemEventArgs) Handles dlProdutos.ItemDataBound

        Dim wProduto As Label
        Dim wTemplate As String
        Dim wDetalheProduto As String

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        Dim wDescontoDepartamento As Double = CType(e.Item.DataItem, DataRowView).Row.Item("pDescontoDepartamento")
        Dim wDescontoSecao As Double = CType(e.Item.DataItem, DataRowView).Row.Item("pDescontoSecao")
        Dim wDescontoProduto As Double = CType(e.Item.DataItem, DataRowView).Row.Item("pDescontoProduto")
        Dim wPrecoProduto As Double = CType(e.Item.DataItem, DataRowView).Row.Item("vProduto")
        Dim wPrecoProdutoDesconto As Double = CType(e.Item.DataItem, DataRowView).Row.Item("vProduto")

        wTemplate = Session("wTemplateProduto")
        wDetalheProduto = wTemplate

        wProduto = CType(e.Item.FindControl("lblProduto"), Label)

        Dim wQueryString As String = ""
        wQueryString = Request.ServerVariables("QUERY_STRING")

        If wQueryString = "" Then
            wQueryString = "?cProduto=" & CType(e.Item.DataItem, DataRowView).Row.Item("cProduto").ToString
        Else
            'wQueryString = "?" & wQueryString & "&cProduto=" & CType(e.Item.DataItem, DataRowView).Row.Item("cProduto").ToString
            wQueryString = "?cProduto=" & CType(e.Item.DataItem, DataRowView).Row.Item("cProduto").ToString
            wQueryString += "&cVitrineSecao=" & CType(e.Item.DataItem, DataRowView).Row.Item("cSecao").ToString
            wQueryString += "&cDepartamento=" & CType(e.Item.DataItem, DataRowView).Row.Item("cDepartamento").ToString
            wQueryString += "&cFabricante=" & CType(e.Item.DataItem, DataRowView).Row.Item("cFabricante").ToString
        End If

        wDetalheProduto = wDetalheProduto.Replace("---nomeproduto---", CType(e.Item.DataItem, DataRowView).Row.Item("tProduto").ToString)
        wDetalheProduto = wDetalheProduto.Replace("---codigoproduto---", wQueryString)
        wDetalheProduto = wDetalheProduto.Replace("---nomeimagem---", CType(e.Item.DataItem, DataRowView).Row.Item("tProduto").ToString)

        wDetalheProduto = wDetalheProduto.Replace("---brevedescricao---", Left(CType(e.Item.DataItem, DataRowView).Row.Item("tDescricao").ToString, 500))


        If ws.fRetornaImagemProdutoDestaque(CType(e.Item.DataItem, DataRowView).Row.Item("cProduto").ToString) = "" Then
            wDetalheProduto = wDetalheProduto.Replace("<inibe>", "<!--")
            wDetalheProduto = wDetalheProduto.Replace("</inibe>", "-->")
        Else
            wDetalheProduto = wDetalheProduto.Replace("---caminhoimagem---", ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "produtos", ws.fRetornaImagemProdutoDestaque(CType(e.Item.DataItem, DataRowView).Row.Item("cProduto").ToString)))
        End If

        If wDescontoProduto <> 0 Then
            wPrecoProdutoDesconto = wPrecoProduto - (wPrecoProduto * (wDescontoProduto / 100))
        Else

            If wDescontoSecao <> 0 Then
                wPrecoProdutoDesconto = wPrecoProduto - (wPrecoProduto * (wDescontoSecao / 100))
            Else

                If wDescontoDepartamento <> 0 Then
                    wPrecoProdutoDesconto = wPrecoProduto - (wPrecoProduto * (wDescontoDepartamento / 100))
                End If

            End If

        End If

        If wPrecoProduto = wPrecoProdutoDesconto Then
            wDetalheProduto = wDetalheProduto.Replace("---precoproduto---", wPrecoProduto.ToString("C2"))
            wDetalheProduto = wDetalheProduto.Replace("---deprecoproduto---", "")

        Else
            wDetalheProduto = wDetalheProduto.Replace("---precoproduto---", wPrecoProdutoDesconto.ToString("C2"))
            wDetalheProduto = wDetalheProduto.Replace("---deprecoproduto---", wPrecoProduto.ToString("C2"))

        End If

        wProduto.Text = wDetalheProduto

    End Sub

End Class