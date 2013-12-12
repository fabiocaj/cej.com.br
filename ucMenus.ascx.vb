Imports System.Data

Partial Class ucMenus
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If Not IsPostBack Then

        Call sCarregarMenus()

        '  End If

    End Sub

    Sub sCarregarMenus()

        Dim ws As New wsCash.wsCash
        Dim ds As dataset

        ws = func.fRetornaWS()
        ds = ws.fRetornaSecoes(func.fPortal())

        For I As Integer = 0 To ds.Tables(0).Rows.Count - 1

            'Session("cSecao") = ds.Tables(0).Rows(I).Item("cSecao")
            phMenus.Controls.Add(LoadControl(ds.Tables(0).Rows(I).Item("tUserControl")))

        Next

    End Sub

End Class
