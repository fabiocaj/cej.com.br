Imports System.Data

Partial Class ucEvento
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarEventos(Date.Today)
            rcEventos1.SelectedDate = Date.Today
            rcEventos2.FocusedDate = Date.Today.AddMonths(1)
            'rcEventos2.SelectedDate = Date.Today.AddMonths(1)

        End If

    End Sub

    Sub sCarregarEventos(ByVal wData As Date)

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        Dim wSQL As String

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        wSQL = "  select cGrupo, *"
        wSQL += " from tbEventos E"
        wSQL += " where cGrupo in "
        wSQL += " ("
        wSQL += " select cGrupo from tbGrupoPortais"
        wSQL += " where cPortal = " & wPortal.cPortal
        wSQL += " )"
        wSQL += " and dEventoInicio >= '" & func.fTransformaAnoMesDia(wData.ToShortDateString) & "'"
        wSQL += " and (cPortal = " & wPortal.cPortal & " or cPortal = 0)"
        wSQL += " order by dEventoInicio"

        ds = ws.fRetornaDataSet(wSQL)

        With PEventos

            .DataSource = ds
            .DataBind()

        End With

    End Sub


    Protected Sub PEventos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PEventos.SelectedIndexChanged

    End Sub

    Protected Sub rcEventos1_SelectionChanged(ByVal sender As Object, ByVal e As Telerik.WebControls.Base.Calendar.Events.SelectedDatesEventArgs) Handles rcEventos1.SelectionChanged

        If e.SelectedDates.Count - 1 >= 0 Then
            Call sCarregarEventos(e.SelectedDates(e.SelectedDates.Count - 1).[Date].ToShortDateString)
        End If

    End Sub

    Private Sub SelectedDateChange(ByVal sender As Object, ByVal e As Telerik.WebControls.Base.Calendar.Events.SelectedDatesEventArgs) Handles rcEventos2.SelectionChanged

        If e.SelectedDates.Count - 1 >= 0 Then
            Call sCarregarEventos(e.SelectedDates(e.SelectedDates.Count - 1).[Date].ToShortDateString)
        End If

    End Sub 'SelectedDateChange

    Protected Sub rcEventos2_SelectionChanged(ByVal sender As Object, ByVal e As Telerik.WebControls.Base.Calendar.Events.SelectedDatesEventArgs) Handles rcEventos2.SelectionChanged

        If e.SelectedDates.Count - 1 >= 0 Then
            Call sCarregarEventos(e.SelectedDates(e.SelectedDates.Count - 1).[Date].ToShortDateString)
        End If
    End Sub

    Protected Sub rcEventos1_DayRender(ByVal sender As Object, ByVal e As Telerik.WebControls.Base.Calendar.Events.DayRenderEventArgs) Handles rcEventos1.DayRender

        Dim func As New clsAcessos
        Dim ds As New DataSet
        Dim wSQL As String
        Dim ws As New wsCash.wsCash

        Dim wDia As Date

        wDia = e.Day.Date

        ws = func.fRetornaWS()

        wSQL = "  select *"
        wSQL += " from tbEventos"
        wSQL += " where cPortal = " & func.fPortal()
        wSQL += " and '" & func.fTransformaAnoMesDia(wDia.ToShortDateString) & "' between dEventoInicio and dEventoFim"
        'wSQL += " and dEventoInicio >= '" & func.fTransformaAnoMesDia(wDia.ToShortDateString) & "' and dEventoFim <= '" & func.fTransformaAnoMesDia(wDia.ToShortDateString) & "'"

        ds = ws.fRetornaDataSet(wSQL)
        If ds.Tables(0).Rows.Count > 0 Then
            e.Cell.Attributes.Add("id", "CalendarDay")
            'e.Cell.CssClass = "CalendarDay"
        End If

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

    Protected Sub rcEventos2_DayRender(ByVal sender As Object, ByVal e As Telerik.WebControls.Base.Calendar.Events.DayRenderEventArgs) Handles rcEventos2.DayRender

        Dim func As New clsAcessos
        Dim ds As New DataSet
        Dim wSQL As String
        Dim ws As New wsCash.wsCash

        Dim wDia As Date

        wDia = e.Day.Date

        ws = func.fRetornaWS()

        wSQL = "  select *"
        wSQL += " from tbEventos"
        wSQL += " where cPortal = " & func.fPortal()
        wSQL += " and '" & func.fTransformaAnoMesDia(wDia.ToShortDateString) & "' between dEventoInicio and dEventoFim"
        'wSQL += " and dEventoInicio <= '" & func.fTransformaAnoMesDia(wDia.ToShortDateString) & "' and dEventoFim >= '" & func.fTransformaAnoMesDia(wDia.ToShortDateString) & "'"

        ds = ws.fRetornaDataSet(wSQL)
        If ds.Tables(0).Rows.Count > 0 Then
            e.Cell.Attributes.Add("id", "CalendarDay")
            'e.Cell.CssClass = "CalendarDay"
        End If

    End Sub

End Class
