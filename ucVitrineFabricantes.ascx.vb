Imports System.Data
Imports System.IO


Partial Class ucVitrineFabricantes
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarFabricantes()
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

    Sub sCarregarFabricantes()

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        Dim wTemplate As String
        wTemplate = File.ReadAllText(Server.MapPath("~") & "/TemplateVitrineFabricantes.htm")

        Dim wCodigoSecao As String
        wCodigoSecao = func.fRetornaParametroSeguro(Request.Params("cVitrineSecao"))

        If wCodigoSecao Is Nothing Then
            Exit Sub
        End If

        If wCodigoSecao.Trim.Length = 0 Then
            Exit Sub
        End If

        If Not IsNumeric(wCodigoSecao.Trim) Then
            Exit Sub
        End If

        wSQL = " select cFabricante, tFabricante, cDepartamento, cSecao"
        wSQL += " from vwProdutos"
        wSQL += " where cSecao = " & wCodigoSecao
        wSQL += " group by cFabricante, tFabricante, cDepartamento, cSecao"
        wSQL += " order by tFabricante"

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = ws.fRetornaDataSet(wSQL)

        With dlAreas

            .DataSource = ds
            .DataBind()

            If .Items.Count = 0 Then
                .Visible = False
            Else
                .Visible = True
            End If

        End With

    End Sub

    Function fRetornaFabricante(ByVal wCodigoFabricante As Integer, ByVal wFabricante As String, ByVal wCodigoDepartamento As Integer, ByVal wCodigoSecao As Integer) As String

        Dim wAreaFormatada As String = ""
        Dim wTemplate As String
        wTemplate = File.ReadAllText(Server.MapPath("~") & "/TemplateVitrineFabricantes.htm")

        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wPagina() As String
        Dim wURLPagina As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        'wImagem = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "AREASIMAGENS", wImagem)

        wAreaFormatada = wTemplate
        wAreaFormatada = wAreaFormatada.Replace("---FABRICANTE---", wFabricante)
        'wAreaFormatada = wAreaFormatada.Replace("---IMAGEM---", wImagem)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGODEFABRICANTE---", wCodigoFabricante)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGO---", wCodigoFabricante)
        'wAreaFormatada = wAreaFormatada.Replace("---CODIGOPAGINA---", wCodigoPagina)

        'wURLPagina = "Vitrine.aspx" & "&cDepartamento=" & wCodigoDepartamento.ToString.Trim
        'wAreaFormatada = wAreaFormatada.Replace("---URL---", wURLPagina)

        'wURLPagina = "Vitrine.aspx" & "&cDepartamento=" & wCodigoFabricante.ToString.Trim

        'wPagina = Split(Request.ServerVariables("SCRIPT_NAME"), "/")
        'wURLPagina = wPagina(UBound(wPagina)) & "?cFabricante=" & wCodigoFabricante.ToString.Trim & "&cSecao=" & wCodigoSecao.ToString.Trim & "&cDepartamento=" & wCodigoDepartamento.ToString.Trim

        wURLPagina = "Vitrine.aspx" & "?cFabricante=" & wCodigoFabricante.ToString.Trim & "&cVitrineSecao=" & wCodigoSecao.ToString.Trim & "&cDepartamento=" & wCodigoDepartamento.ToString.Trim

        wAreaFormatada = wAreaFormatada.Replace("---URL---", wURLPagina)

        Return wAreaFormatada

    End Function

End Class