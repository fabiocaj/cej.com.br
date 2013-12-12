Imports System.Data
Imports System.IO

Partial Class ucVitrineDepartamentos
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarDepartamentos()
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

    Sub sCarregarDepartamentos()

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        Dim wTemplate As String
        wTemplate = File.ReadAllText(Server.MapPath("~") & "/TemplateVitrineDepartamentos.htm")

        wSQL = " Select * "
        wSQL += " from tbDepartamentos D "
        wSQL += " where cPortal = " & func.fPortal()
        wSQL += " and d.cDepartamento in "
        wSQL += " ( "
        wSQL += " Select dp.cDepartamento"
        wSQL += " From tbProdutos p "
        wSQL += " inner join tbDepartamentoSecoes ds "
        wSQL += " on p.cSecao = ds.cSecao"
        wSQL += " inner join tbDepartamentos dp "
        wSQL += " on dp.cDepartamento = ds.cDepartamento"
        wSQL += " ) "
        wSQL += " order by tDepartamento "

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = ws.fRetornaDataSet(wSQL)

        With dlAreas

            .DataSource = ds
            .DataBind()

        End With

    End Sub

    Function fRetornaDepartamento(ByVal wCodigoDepartamento As Integer, ByVal wDepartamento As String) As String

        Dim wAreaFormatada As String = ""
        Dim wTemplate As String
        wTemplate = File.ReadAllText(Server.MapPath("~") & "/TemplateVitrineDepartamentos.htm")
        Dim wPagina() As String

        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        Dim wURLPagina As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        'wImagem = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "AREASIMAGENS", wImagem)

        wAreaFormatada = wTemplate
        wAreaFormatada = wAreaFormatada.Replace("---DEPARTAMENTO---", wDepartamento)
        'wAreaFormatada = wAreaFormatada.Replace("---IMAGEM---", wImagem)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGODEPARTAMENTO---", wCodigoDepartamento)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGO---", wCodigoDepartamento)
        'wAreaFormatada = wAreaFormatada.Replace("---CODIGOPAGINA---", wCodigoPagina)

        'wURLPagina = "Vitrine.aspx" & "&cDepartamento=" & wCodigoDepartamento.ToString.Trim

        'wPagina = Split(Request.ServerVariables("SCRIPT_NAME"), "/")
        'wURLPagina = wPagina(UBound(wPagina)) & "?cDepartamento=" & wCodigoDepartamento.ToString.Trim

        wURLPagina = "Vitrine.aspx" & "?cDepartamento=" & wCodigoDepartamento.ToString.Trim

        wAreaFormatada = wAreaFormatada.Replace("---URL---", wURLPagina)

        Return wAreaFormatada

    End Function

End Class