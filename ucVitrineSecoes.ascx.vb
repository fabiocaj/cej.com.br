Imports System.Data
Imports System.IO

Partial Class ucVitrineSecoes
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarDepartamentoSecoes()
        End If

    End Sub

    Public Function fRetornaCaminhoImagem(ByVal wImagem As String) As String

        Dim wCorpo As String = ""
        Dim ws As New wsCash.wsCash

        wCorpo = "<IMG src='---caminhoimagem---' width=110 border='0' />"

        If wImagem <> "" Then
            wCorpo = Replace(wCorpo, "---caminhoimagem---", ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMDESTAQUE", wImagem))

        Else
            wCorpo = ""
        End If

        Return wCorpo

    End Function

    Sub sCarregarDepartamentoSecoes()

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        Dim wTemplate As String
        wTemplate = File.ReadAllText(Server.MapPath("~") & "/TemplateVitrineDepartamentoSecoes.htm")

        Dim wCodigoDepartamento As String
        wCodigoDepartamento = func.fRetornaParametroSeguro(Request.Params("cDepartamento"))

        If wCodigoDepartamento Is Nothing Then
            Exit Sub
        End If

        If wCodigoDepartamento.Trim.Length = 0 Then
            Exit Sub
        End If

        If Not IsNumeric(wCodigoDepartamento.Trim) Then
            Exit Sub
        End If

        wSQL = " Select * "
        wSQL += " from tbDepartamentoSecoes D "
        wSQL += " where cDepartamento = " & wCodigoDepartamento
        wSQL += " and d.cSecao in "
        wSQL += " ( "
        wSQL += " Select ds.cSecao"
        wSQL += " From tbProdutos p "
        wSQL += " inner join tbDepartamentoSecoes ds "
        wSQL += " on p.cSecao = ds.cSecao"
        wSQL += " ) "
        wSQL += " order by tSecao "

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = ws.fRetornaDataSet(wSQL)

        With dlAreas

            .DataSource = ds
            .DataBind()

        End With

    End Sub

    Function fRetornaSecao(ByVal wCodigoSecao As Integer, ByVal wSecao As String, ByVal wCodigoDepartamento As Integer) As String

        Dim wAreaFormatada As String = ""
        Dim wTemplate As String
        wTemplate = File.ReadAllText(Server.MapPath("~") & "/TemplateVitrineDepartamentoSecoes.htm")

        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wPagina() As String
        Dim wURLPagina As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        'wImagem = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "AREASIMAGENS", wImagem)

        wAreaFormatada = wTemplate
        wAreaFormatada = wAreaFormatada.Replace("---SECAO---", wSecao)
        'wAreaFormatada = wAreaFormatada.Replace("---IMAGEM---", wImagem)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGODESECAO---", wCodigoSecao)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGO---", wCodigoSecao)
        'wAreaFormatada = wAreaFormatada.Replace("---CODIGOPAGINA---", wCodigoPagina)

        'wURLPagina = "Vitrine.aspx" & "&cDepartamento=" & wCodigoDepartamento.ToString.Trim
        'wAreaFormatada = wAreaFormatada.Replace("---URL---", wURLPagina)

        'wURLPagina = "Vitrine.aspx" & "&cDepartamento=" & wCodigoDepartamento.ToString.Trim

        'wPagina = Split(Request.ServerVariables("SCRIPT_NAME"), "/")
        'wURLPagina = wPagina(UBound(wPagina)) & "?cDepartamento=" & wCodigoDepartamento.ToString.Trim & "&cVitrineSecao=" & wCodigoSecao.ToString.Trim

        wURLPagina = "Vitrine.aspx" & "?cDepartamento=" & wCodigoDepartamento.ToString.Trim & "&cVitrineSecao=" & wCodigoSecao.ToString.Trim

        wAreaFormatada = wAreaFormatada.Replace("---URL---", wURLPagina)

        Return wAreaFormatada

    End Function

End Class