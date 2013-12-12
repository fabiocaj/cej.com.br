Imports System.data

Partial Class uctopo
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarCabecalho()

        End If

    End Sub

    Sub sCarregarCabecalho()

        Dim ws As New wsCash.wsCash
        Dim wPortal As New wsCash.wPortal
        Dim wSQL As String
        Dim ds As New DataSet
        Dim wArray As Array
        Dim func As New clsAcessos

        ws = func.fRetornaWS()

        wPortal = ws.fCarregarPortal(func.fPortal())

        With wPortal

            If .cPaginaFaleConosco <> 0 Then

                'hplFaleConosco.NavigateUrl = .cPaginaFaleConosco & "?cPagina=" & .cPaginaQuemSomos

            End If

            'hplQuemSomos.NavigateUrl = "~/DetalhesSecoes.aspx?" & "cPagina=" & .cPaginaQuemSomos
            'hplSejaParceiro.NavigateUrl = "~/DetalhesSecoes.aspx?" & "cPagina=" & .cPaginaSejaParceiro
            'hplFaleConosco.NavigateUrl = "~/DetalhesSecoes.aspx?cPagina=31"

            'hplFaleConosco.Text = "Fale Conosco"
            'hplQuemSomos.Text = "Quem Somos"
            'hplSejaParceiro.Text = "Seja Parceiro"

        End With

    End Sub


End Class
