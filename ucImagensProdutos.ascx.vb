Imports System.Data

Partial Class ucImagensProdutos
    Inherits System.Web.UI.UserControl
    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        Call sCarregarImagens(func.fRetornaParametroSeguro(Request.Params("cProduto")))
        'End If
    End Sub

    Public Function fRetornaURLImagens(ByVal cProduto As Integer, ByVal tImagem As String) As String

        Dim wURL As String = ""

        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        If tImagem.Trim.Length > 0 Then
            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "PRODUTOS", "/" & cProduto & "/" & tImagem)
        Else
            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMPEQUENA", "Padrao.gif")
        End If

        Return wURL

    End Function

    Sub sCarregarImagens(ByVal wCodigoVeiculo As Integer)

        Dim wsCash As New wsCash.wsCash
        Dim ds As New DataSet

        wsCash = func.fRetornaWS()

        ds = wsCash.FRETORNAIMAGENSPRODUTOS(wCodigoVeiculo)
        With dlFotos
            .DataSource = ds
            .DataBind()
        End With

        
    End Sub

End Class