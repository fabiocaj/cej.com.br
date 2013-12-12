Imports System.Data

Partial Class ucCategoriasArtigos
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call sCarregaCategoriasPortal()
        If Not Request("cArtCat") Is Nothing Then
            Call sCarregaGridArtigosCategoria(Request("cArtCat"))
            Call sConfiguraPaineis("C")
        Else
            Call sCarregaTopCategoriasPortal()
            Call sConfiguraPaineis("T")
        End If

    End Sub

    Public Sub sConfiguraPaineis(ByVal wConf As String)

        If wConf = "C" Then
            pnlCategoriasArtigos.Visible = True
            pnlTopartigos.Visible = False
        Else
            pnlCategoriasArtigos.Visible = False
            pnlTopartigos.Visible = True
        End If

    End Sub

    Public Sub sCarregaCategoriasPortal()

        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()
        ds = ws.fRetornaCategoriaArtigos(func.fGrupo(), func.fPortal())

        With dlCategoriasArtigos

            .DataSource = ds
            .DataBind()

        End With

    End Sub

    Public Sub sCarregaTopCategoriasPortal()

        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = ws.fRetornaTopArtigos(func.fGrupo(), func.fPortal(), wPortal.nTopArtigos)
        lblCountTop.Text = wPortal.nTopArtigos.ToString("00")
        With gvTopArtigos

            .DataSource = ds
            .DataBind()

        End With

    End Sub

    Public Sub sCarregaGridArtigosCategoria(ByVal cCategoria As Integer)

        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = ws.fRetornaArtigos_Categoria(func.fGrupo(), func.fPortal(), cCategoria)
        With gvArtigos

            .DataSource = ds
            .DataBind()

        End With

    End Sub

End Class
