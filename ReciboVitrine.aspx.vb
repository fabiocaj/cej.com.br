Imports System.Data
Imports System.IO

Partial Class ReciboVitrine
    Inherits System.Web.UI.Page

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Call sManutencaoPedido()
            Call sEnviaEmailPedido()
            Session.Remove("Carrinho")
            Session.Remove("cPedido")
            Session.Remove("EnderecoCliente")
            Session("cPedido") = 0
            Session("EnderecoCliente") = New wsCash.wEnderecoCliente
            Session("Carrinho") = New clsCarrinho().sCriaCarrinho()

        End If

    End Sub

    Public Function fRetornaValor(ByVal wValor As Double) As String

        Return wValor.ToString("C2")

    End Function

    Public Sub sManutencaoPedido()

        Dim ws As New wsCash.wsCash
        Dim wPedido As New wsCash.wPedido
        Dim wEnderecoCliente As New wsCash.wEnderecoCliente
        Dim wParametrizacao As New wsCash.wParametrizacao
        Dim wParametros As New wsCash.wParametrizacoes

        ws = func.fRetornaWS()

        wEnderecoCliente = Session("EnderecoCliente")
        wParametrizacao = ws.FRETORNAPARAMETRIZACOES(func.fPortal())
        wParametros = ws.FRETORNAPARAMETROS()

        With wPedido

            .cPedido = IIf(IsNumeric(Session("cPedido")), Session("cPedido"), 0)
            .cCliente = Session("cCliente")
            .cPortal = func.fPortal()
            .cGrupo = func.fGrupo()
            .cEnderecoCliente = wEnderecoCliente.cEnderecoCliente
            .cFormaEntrega = IIf(IsNumeric(Session("cFormaEntrega")), Session("cFormaEntrega"), 0)
            .cFormaPagamento = IIf(IsNumeric(Session("cFormaPagamento")), Session("cFormaPagamento"), 0)
            .dPedido = Date.Now.ToShortDateString()
            .vFrete = IIf(IsNumeric(Session("vFrete")), Session("vFrete"), 0)
            .tPrazoEntrega = IIf(Session("tPrazoEntrega") Is Nothing, "", Session("tPrazoEntrega"))

        End With

        wPedido = ws.FMANUTENCAOPEDIDO(wPedido)

        Dim wSituacaoPedido As New wsCash.wSituacaoPedido

        With wSituacaoPedido
            .cPedido = wPedido.cPedido
            .cSituacaoPedido = wParametrizacao.cSituacaoPedidoPago
            .dSituacaoPedido = Date.Now.ToShortDateString
        End With

        ws.FMANUTENCAOSITUACAOPEDIDO(wSituacaoPedido)
        Session("cPedido") = wPedido.cPedido
        Call sManutencaoPedidoItens(wPedido.cPedido)

    End Sub

    Public Sub sManutencaoPedidoItens(ByVal cPedido As Integer)

        Dim ws As New wsCash.wsCash
        Dim wRetorno As New StringBuilder
        Dim dt As New DataTable

        ws = func.fRetornaWS()

        dt = Session("Carrinho")

        For wCount As Integer = 0 To dt.Rows.Count - 1

            Dim cProduto As Integer = dt.Rows(wCount).Item("cProduto")
            Dim wProduto As New wsCash.wProduto
            wProduto = ws.FRETORNAINFORMACOESPRODUTOS(cProduto)

            Dim wPedidoItens As New wsCash.wPedidoItens

            With wPedidoItens

                .cPedido = cPedido
                .cPedidoItem = 0
                .cProduto = cProduto
                .nItens = dt.Rows(wCount).Item("qtdProduto")
                .vUnitario = wProduto.vProduto

            End With

            ws.FMANUTENCAOPEDIDOITENS(wPedidoItens)

        Next

    End Sub

    Public Sub sEnviaEmailPedido() 'Função que irá enviar um e-mail de confirmação para o e-mail cadastrado da empresa, e para o email do cliente

        Dim wCorpo As New StringBuilder
        Dim ws As New wsCash.wsCash
        Dim wPortal As New wsCash.wPortal
        Dim wPath As String = Server.MapPath("templates/ucReciboVitrine.htm")
        Dim wReader As New StreamReader(wPath, New System.Text.ASCIIEncoding)
        Dim wProdutos As String = ""
        Dim nInicio As Integer = 0
        Dim nFinal As Integer = 0
        Dim wTotalGeral As Double = 0
        Dim wHTML As String = ""
        Dim wHTMLTrocado As String = ""

        ws = func.fRetornaWS()

        wPortal = ws.fRetornaPortal(func.fPortal())

        Dim wCliente As New wsCash.wCliente
        wCliente = ws.FCARREGACLIENTE(Session("cCliente"), New clsAcessos().fPortal())

        wCorpo.Append(wReader.ReadToEnd())
        wReader.Close()

        nInicio = wCorpo.ToString().IndexOf("<!--INICIO-->")
        nFinal = wCorpo.ToString().IndexOf("<!--FIM-->")
        wProdutos = wCorpo.ToString().Substring(nInicio, nFinal - nInicio)

        wHTML = wCorpo.ToString()

        wHTMLTrocado = wHTML.Replace(wProdutos, "--STRING--")

        Dim dt As New DataTable
        dt = Session("Carrinho")

        Dim wProdutosConcatenados As String = ""

        For wCount As Integer = 0 To dt.Rows.Count - 1

            Dim wProdutosNovo As String = wProdutos
            wProdutosNovo = wProdutosNovo.Replace("--tProduto--", fRetornaTexto(dt.Rows(wCount).Item("tProduto")))
            wProdutosNovo = wProdutosNovo.Replace("--nQtd--", dt.Rows(wCount).Item("qtdProduto"))
            wProdutosNovo = wProdutosNovo.Replace("--vUnitario--", CType(dt.Rows(wCount).Item("vUnitario"), Double).ToString("C2"))
            wProdutosNovo = wProdutosNovo.Replace("--vTotal--", CType(dt.Rows(wCount).Item("qtdProduto") * dt.Rows(wCount).Item("vUnitario"), Double).ToString("C2"))
            wTotalGeral += (dt.Rows(wCount).Item("qtdProduto") * dt.Rows(wCount).Item("vUnitario"))

            wProdutosConcatenados += wProdutosNovo

        Next

        wHTMLTrocado = wHTMLTrocado.Replace("--STRING--", wProdutosConcatenados)
        wHTMLTrocado = wHTMLTrocado.Replace("--vTotalGeral--", wTotalGeral.ToString("C2"))
        wHTMLTrocado = wHTMLTrocado.Replace("--cPedido--", Session("cPedido"))
        wHTMLTrocado = wHTMLTrocado.Replace("--dPedido--", Date.Now)
        wHTMLTrocado = wHTMLTrocado.Replace("--EmailEnvio--", fRetornaTexto(Session("tEmailCliente")))

        Dim wEnderecoCliente As New wsCash.wEnderecoCliente
        wEnderecoCliente = Session("EnderecoCliente")

        wHTMLTrocado = wHTMLTrocado.Replace("--tEnderecoCliente--", fRetornaTexto(wEnderecoCliente.tEnderecoCliente))
        wHTMLTrocado = wHTMLTrocado.Replace("--tNumeroCliente--", fRetornaTexto(wEnderecoCliente.tNumeroCliente))
        wHTMLTrocado = wHTMLTrocado.Replace("--tComplemento--", fRetornaTexto(wEnderecoCliente.tComplemento))
        wHTMLTrocado = wHTMLTrocado.Replace("--tCidade--", fRetornaTexto(wEnderecoCliente.tCidade))
        wHTMLTrocado = wHTMLTrocado.Replace("--tEstado--", fRetornaTexto(wEnderecoCliente.tEstado))
        wHTMLTrocado = wHTMLTrocado.Replace("--tCEP--", fRetornaTexto(wEnderecoCliente.tCep))
        wHTMLTrocado = wHTMLTrocado.Replace("--tPais--", fRetornaTexto(wEnderecoCliente.tPais))

        wHTML = wHTMLTrocado

        wHTML = wHTML.Replace("--cliente--", wCliente.tCliente)
        wHTML = wHTML.Replace("--empresa--", wPortal.tPortal)
        wHTML = wHTML.Replace("--imagemlogo--", wPortal.tImagemLogo)
        wHTML = wHTML.Replace("--emailempresa--", wPortal.tEmailPagSeguro)

        lblEmail.Text = wHTML.Replace("</edit>", "-->").Replace("<edit>", "<!--")

        ws.FENVIAEMAIL(wPortal.tEmailPagSeguro, Session("tEmailCliente"), wPortal.tEmailPagSeguro, "Pedido Num: " & Session("cPedido"), wHTML)

    End Sub

    Function fRetornaTexto(ByVal wInf As String) As String

        Dim wTexto As New StringWriter

        Server.HtmlEncode(wInf, wTexto)
        wInf = wTexto.ToString

        Return wInf

    End Function

End Class
