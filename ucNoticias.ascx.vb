Imports System.Data

Partial Class ucNoticias
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarNoticias()

        End If

    End Sub

    Sub sCarregarNoticias()

        Dim ds As dataset

        ds = func.fNoticias()

        With gvResultados

            .DataSource = ds
            .DataBind()

        End With

    End Sub


End Class
