Imports System.IO
Imports System.IO.FileInfo
Imports System.Data

Partial Class DetalhesNoticias
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim ws As New wsCash.wsCash
            Dim wPortal As New wsCash.wPortal
            Dim func As New clsAcessos

            ws = func.fRetornaWS()
            wPortal = ws.fCarregarPortal(func.fPortal())

            Page.Title = wPortal.tPortal

        End If

    End Sub

End Class
