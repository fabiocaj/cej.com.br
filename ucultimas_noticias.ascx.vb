Imports System.Data

Partial Class ucultimas_noticias
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    'gambi para mostrar as informações do datalist
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim t(4) As String

        'dlResultados.DataSource = t
        'dlResultados.DataBind()

        If Not IsPostBack Then

            Call sCarregarNoticias()

        End If

    End Sub
    'fim da gambi

    Sub sCarregarNoticias()

        Dim ds As dataset

        ds = func.fNoticias()

        With dlResultados

            .DataSource = ds
            .DataBind()

        End With

        If dlResultados.Items.Count = 0 Then

            pnlUltimasNoticias.Visible = False

        End If

    End Sub

End Class
