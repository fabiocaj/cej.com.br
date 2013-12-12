Imports System.Data

Partial Class ucMembros
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    'gambi para mostrar as informações do datalist
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim t(3) As String

        'dlResultados.DataSource = t
        'dlResultados.DataBind()

        If Not IsPostBack Then

            Call sCarregarMembros()

        End If


    End Sub
    'fim da gambi

    Sub sCarregarMembros()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = func.fMembros()

        With dlResultados

            '.RepeatColumns = wPortal.qDestaquesColunas
            .DataSource = ds
            .DataBind()

        End With

    End Sub

    Function fQuebraTextoResenha(ByVal wTexto As String) As String
        Return wTexto

    End Function

    Function fQuebraTextoTitulo(ByVal wTexto As String) As String
        Return Left(wTexto, 15)

    End Function

    Function fRetornaImagemMembro(ByVal wCodigoMembro As Integer) As String

        Dim wURL As String = ""
        Dim ws As New wsCash.wsCash
        Dim wMembro As wsCash.wMembro

        ws.Url = ConfigurationManager.AppSettings("wsURL")
        wMembro = ws.fRetornaMembro(wCodigoMembro)

        If wMembro.tFoto.Trim.Length > 0 Then
            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "FOTOS", wMembro.tFoto)
        Else
            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "FOTOS", "Padrao.gif")
        End If

        Return wURL

    End Function

End Class
