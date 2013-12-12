Imports System.IO
Imports System.IO.FileInfo
Imports System.Data

Partial Class DetalhesSecoes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Session("nomePagina") = Nothing

        End If

        If Session("nomePagina") Is Nothing Then

            Call sCarregaNomePagina()

            Page.Title = Session("nomePagina")

        Else

            Page.Title = Session("nomePagina")

        End If

    End Sub

    Sub sCarregaNomePagina()

        Dim ws As New wsCash.wsCash
        Dim wPortal As New wsCash.wPortal
        Dim func As New clsAcessos
        'Dim wSecao As New wsCash.wSecao

        'wSecao = Session("clsSecao")

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        Session("nomePagina") = wPortal.tPortal '& " - " & wSecao.tSecao

    End Sub

End Class
