Imports Microsoft.VisualBasic
Imports System.Data

Public Class clsCarrinho

    Public Class wCarrinho

        Public cPedido As Integer
        Public cProduto As Integer
        Public tProduto As String
        Public tImagemProduto As String
        Public vUnitarioProduto As Double
        Public vPeso As Double
        Public qtdproduto As Double
        Public vTotalProduto As Double
        Public vAltura As Double
        Public vLargura As Double

    End Class

    Public Function sInsereItemCarrinho(ByVal wCarrinho As wCarrinho, ByVal dt As DataTable) As DataTable

        Dim dr As DataRow
        Dim wProdutoExistente As Boolean = False

        'Iremos varrer o DataTable, para saber se o produto já foi adicionado ao carrinho
        'Se o produto já foi adicionado ao Carrinho apenas atualizaremos a quantidade de itens
        With wCarrinho
            For Each dr In dt.Rows
                If dr("cProduto") = .cProduto Then
                    dr("qtdProduto") += .qtdproduto
                    wProdutoExistente = True
                    Exit For
                End If
            Next
        End With

        'Se o produto não estiver no carrinho iremos adiciona-lo
        If Not wProdutoExistente Then

            With wCarrinho
                dr = dt.NewRow
                dr("cProduto") = .cProduto
                dr("tProduto") = .tProduto
                dr("qtdProduto") = .qtdproduto
                dr("vUnitario") = .vUnitarioProduto
                dr("tImagemProduto") = .tImagemProduto
                dr("vPeso") = .vPeso
                dr("vAltura") = .vAltura
                dr("vLargura") = .vLargura
            End With

            dt.Rows.Add(dr)

        End If

        Return dt

    End Function

    Public Function sCriaCarrinho() As DataTable

        Dim dt As New DataTable("Carrinho")

        dt.Columns.Add("cPedido")
        dt.Columns.Add("tImagemProduto")
        dt.Columns.Add("cProduto")
        dt.Columns.Add("tProduto")
        dt.Columns.Add("vUnitario")
        dt.Columns.Add("vPeso")
        dt.Columns.Add("qtdProduto")
        dt.Columns.Add("vAltura")
        dt.Columns.Add("vLargura")

        Return dt

    End Function

End Class
