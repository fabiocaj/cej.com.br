Imports System.Data

Partial Class ucDestaques
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarDestaques()
        End If

    End Sub

    Public Function fRetornaCaminhoImagem(ByVal wImagem As String) As String

        Dim wCorpo As String = ""
        Dim ws As New wsCash.wsCash

        wCorpo = "<IMG src='---caminhoimagem---' width='322px' height='213px' border="0" alt='Imagem notícia destaque' />"

        If wImagem <> "" Then
            wCorpo = Replace(wCorpo, "---caminhoimagem---", ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMDESTAQUE", wImagem))

        Else
            wCorpo = ""
        End If

        Return wCorpo

    End Function

    Sub sCarregarDestaques()

        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        ds = func.fDestaques()
        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        With dlDestaques

            .DataSource = ds
            .DataBind()
            ' .RepeatColumns = IIf(wPortal.qDestaquesColunas = 0, 1, wPortal.qDestaquesColunas)

        End With

    End Sub

End Class