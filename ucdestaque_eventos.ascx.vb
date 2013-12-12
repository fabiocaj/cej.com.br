Imports System.Data

Partial Class uceventos
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarEventos()

        End If

    End Sub

    Sub sCarregarEventos()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select top " & wPortal.qEventosHomePage & " cGrupo, *"
        wSQL += " from tbEventos E"
        wSQL += " where cGrupo in "
        wSQL += " ("
        wSQL += " select cGrupo from tbGrupoPortais"
        wSQL += " where cPortal = " & wPortal.cPortal
        wSQL += " )"
        wSQL += " and dEventoInicio >= '" & func.fTransformaAnoMesDia(Date.Today.ToShortDateString) & "'"
        wSQL += " and (cPortal = " & wPortal.cPortal & " or cPortal = 0)"
        wSQL += " order by dEventoInicio"

        ds = ws.fRetornaDataSet(wSQL)

        With dlEventos

            .RepeatColumns = wPortal.qEventosColunasHomePage

            .DataSource = ds
            .DataBind()


        End With

    End Sub

    Public Function fRetornaImagemEvento(ByVal wImagemPequena As Object) As String

        Dim wURL As String = ""
        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        If Not wImagemPequena Is DBNull.Value Then
            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMPEQUENAEVENTOS", wImagemPequena.ToString())
        Else
            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "IMAGEMPEQUENA", "Padrao.gif")
        End If

        Return wURL

    End Function

    Protected Sub dlEventos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dlEventos.SelectedIndexChanged

    End Sub
End Class
