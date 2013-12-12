Imports System.Data

Partial Class ucdestaque_noticias
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim t(3) As String

        'dlResultados.DataSource = t
        'dlResultados.DataBind()

        If Not IsPostBack Then

            func.fCarregaCategoriasNoticias(cmbCategorias)
            Call sCarregarDestaques()

        End If

    End Sub
    'fim da gambi

    Sub sCarregarDestaques()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        If Not IsNumeric(cmbCategorias.SelectedValue) Then
            ds = func.fNoticiasDestaques("0")
        Else
            ds = func.fNoticiasDestaques(cmbCategorias.SelectedValue)
        End If

        With dlResultados

            .RepeatColumns = wPortal.qDestaquesColunas
            .DataSource = ds
            .DataBind()
        End With

    End Sub

    'Exibe apenas 100 caracteres e adiciona ... ao final'
    'Esta configuração vai depender muito da maneira que o cliente deseja em duas colinas em uma coluna'
    'Fellipe Sousa'
    Function fQuebraTextoResenha(ByVal wTexto As String) As String
        Dim wRetorno As String = ""
        If wTexto.LastIndexOf(" ") < 0 Then
            wRetorno = Left(wTexto, 255) & "..."
        Else
            wRetorno = wTexto.Substring(0, Left(wTexto, 255).LastIndexOf(" ")) & "..."
        End If

        Return wRetorno

    End Function

    'Exibe apenas 50 caracteres e adiciona ... ao final'
    'Esta configuração vai depender muito da maneira que o cliente deseja em duas colinas em uma coluna'
    'Fellipe Sousa'
    Function fQuebraTextoTitulo(ByVal wTexto As String) As String
        Dim wRetorno As String = ""
        If wTexto.LastIndexOf(" ") < 0 Then
            wRetorno = Left(wTexto, 100) & "..."
        Else
            wRetorno = wTexto.Substring(0, Left(wTexto, 100).LastIndexOf(" ")) & "..."
        End If

        Return wRetorno


    End Function

    Function fRetornaImagemNoticia(ByVal wCodigoNoticia As Integer) As String

        Dim wURL As String = ""
        Dim ws As New wsCash.wsCash
        Dim wNoticia As wsCash.wNoticia

        ws.Url = ConfigurationManager.AppSettings("wsURL")
        wNoticia = ws.fRetornaNoticia(wCodigoNoticia)

        If wNoticia.tImagemPequena.Trim.Length > 0 Then
            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMPEQUENA", wNoticia.tImagemPequena)
        Else
            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMPEQUENA", "Padrao.gif")
        End If

        Return wURL

    End Function

    Protected Sub cmbCategorias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategorias.SelectedIndexChanged
        Call sCarregarDestaques()
    End Sub
End Class
