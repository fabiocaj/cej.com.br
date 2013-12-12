Imports System.IO
Imports System.IO.FileInfo
Imports System.Data

Partial Class ResultadoPesquisaRedeCredenciada
    Inherits System.Web.UI.Page

    Dim wSQL As String
    Dim func As New Funcoes

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarResultadoPesquisa()

        End If

    End Sub

    Sub sCarregarResultadoPesquisa()

        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        wSQL = "  Select * "
        wSQL += " from tbAssociados A"
        wSQL += " join tbCategorias C on a.cCategoria = c.cCategoria "

        If Session("cEspecialidade") <> "0" Then
            wSQL += " join tbAssociadosEspecialidades AE on AE.cAssociado = A.cAssociado "
            'wSQL += " join tbAssociadosEspecialidades AE on AE.cEspecialidade = " & Session("cEspecialidade")
        End If

        wSQL += " where cCidade = " & Session("cCidade")
        wSQL += " and c.cSecao = " & Session("cSecao")

        If Session("cCategoria") <> "0" Then
            wSQL += " and c.cCategoria = " & Session("cCategoria")
        End If

        If Session("cEspecialidade") <> "0" Then
            wSQL += " and AE.cEspecialidade = " & Session("cEspecialidade")
        End If

        'If Session("cEspecialidade") <> "0" Then
        '    wSQL += " and cEspecialidade = " & Session("cEspecialidade")
        'End If

        wSQL += " order by tAssociado "

        With gvResultados

            .DataSource = ws.fRetornaDataSet(wSQL)
            .DataBind()

        End With

    End Sub

    Function fRetornaAssociado(ByVal wAssociado As String, ByVal wEndereco As String, ByVal wNumero As String, ByVal wComplemento As String, ByVal wBairro As String, ByVal wTelefone As String, ByVal wSite As String, ByVal wEmail As String, ByVal wObservacao As String) As String

        Dim wCorpo As String

        wCorpo = func.fCarregarHTMLDetalhePesquisa(Server.MapPath("~"), "HTMLPESQUISA")

        wCorpo = wCorpo.Replace("--associado--", wAssociado.ToUpper)
        wCorpo = wCorpo.Replace("--observacao--", wObservacao)
        wCorpo = wCorpo.Replace("--endereco--", wEndereco)
        wCorpo = wCorpo.Replace("--numero--", wNumero)
        wCorpo = wCorpo.Replace("--complemento--", wComplemento)
        wCorpo = wCorpo.Replace("--telefone--", wTelefone)
        wCorpo = wCorpo.Replace("--site--", wSite)
        wCorpo = wCorpo.Replace("--email--", wEmail)
        wCorpo = wCorpo.Replace("--bairro--", wBairro)

        Return wCorpo

    End Function


    Protected Sub gvResultados_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvResultados.PageIndexChanging

        gvResultados.PageIndex = e.NewPageIndex.ToString
        Call sCarregarResultadoPesquisa()

    End Sub

    Protected Sub gvResultados_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvResultados.SelectedIndexChanged

    End Sub
End Class
