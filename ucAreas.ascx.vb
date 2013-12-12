Imports System.Data
Imports System.IO

Partial Class ucAreas
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '        If Not IsPostBack Then

        Call sCarregarAreas()
        '        End If

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

    Sub sCarregarAreas()

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        Dim wTemplate As String
        wTemplate = File.ReadAllText(Server.MapPath("~") & "/TemplateAreas.htm")

        wSQL = " Select * "
        wSQL += " from tbAreas A "
        wSQL += " join tbTemplates T on a.cTemplate = t.cTemplate"
        wSQL += " where cPortal = " & func.fPortal()
        wSQL += " order by tArea"

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = ws.fRetornaDataSet(wSQL)

        'Dim aAreas As New ArrayList
        'Dim wArea As String
        'For wContador As Integer = 0 To ds.Tables(0).Rows.Count - 1

        '    wArea = wTemplate
        '    wArea = wArea.Replace("---IMAGEM---", ds.Tables(0).Rows(wContador).Item("tImagem"))
        '    wArea = wArea.Replace("---AREA---", ds.Tables(0).Rows(wContador).Item("tArea"))

        '    aAreas.Add(wArea)

        'Next


        With dlAreas

            .DataSource = ds
            .DataBind()

        End With

    End Sub

    Function fRetornaArea(ByVal wCodigoArea As Integer, ByVal wArea As String, ByVal wImagem As String, ByVal wPagina As String, ByVal wCodigoPagina As String) As String

        Dim wAreaFormatada As String = ""
        Dim wTemplate As String
        wTemplate = File.ReadAllText(Server.MapPath("~") & "/TemplateAreas.htm")

        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        Dim wURLPagina As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wImagem = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "AREASIMAGENS", wImagem)

        wAreaFormatada = wTemplate
        wAreaFormatada = wAreaFormatada.Replace("---AREA---", wArea)
        wAreaFormatada = wAreaFormatada.Replace("---IMAGEM---", wImagem)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGOAREA---", wCodigoArea)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGO---", wCodigoArea)
        wAreaFormatada = wAreaFormatada.Replace("---CODIGOPAGINA---", wCodigoPagina)

        wURLPagina = wPagina & "?cPagina=" & wCodigoPagina.Trim & "&cArea=" & wCodigoArea.ToString.Trim
        wAreaFormatada = wAreaFormatada.Replace("---URL---", wURLPagina)

        Return wAreaFormatada

    End Function

End Class