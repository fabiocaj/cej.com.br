Imports System.Data

Partial Class ucRelacaoDetalhesLateral
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    'gambi para mostrar as informações do datalist
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim t(4) As String

        'dlResultados.DataSource = t
        'dlResultados.DataBind()

        If Not IsPostBack Then

            Call sCarregarDestaques()

        End If

    End Sub
    'fim da gambi

    Sub sCarregarDestaques()

        Dim ds As DataSet

        ds = func.fDestaques()

        With dlResultados

            .DataSource = ds
            .DataBind()

        End With

        If dlResultados.Items.Count = 0 Then

            pnlRelacaoDestaques.Visible = False

        End If

    End Sub

End Class
