Imports System.data

Partial Class ucpublicidadel
    Inherits System.Web.UI.UserControl

    'gambi para mostrar as informações do datalist
    'Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    'Dim t(2) As String

    'DataList1.DataSource = t
    'DataList1.DataBind()

    ' End Sub
    'fim da gambi

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            dlPublicidade.DataSource = Nothing
            dlPublicidade.DataBind()

            Call sQtdPublicidade()
            Call sCarregaDatalist()
            Call sRetornaPublicidades()
            Call sSetaPublicidades()

        End If

    End Sub

    Sub sCarregaDatalist()

        dlPublicidade.DataSource = "1"
        dlPublicidade.DataBind()

    End Sub

    Function fCarregaPortal() As wsCash.wPortal

        Dim ws As New wsCash.wsCash
        Dim wPortal As New wsCash.wPortal
        Dim func As New clsAcessos

        func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        Return wPortal

    End Function

    Sub sQtdPublicidade()

        Dim func As New clsAcessos
        Dim ws As New wsCash.wsCash
        Dim wPortal As New wsCash.wPortal

        wPortal = fCarregaPortal()

        lblQtdPublicidade.Text = wPortal.qPublicidades

    End Sub

    Protected Sub rjtTimer_Tick(ByVal sender As Object, ByVal e As Telerik.WebControls.TickEventArgs) Handles rjtTimer.Tick

        Call sSetaPublicidades()

    End Sub

    Sub sRetornaPublicidades()

        Dim func As New clsAcessos
        Dim ws As New wsCash.wsCash
        Dim ds As New DataSet

        lblPublicidades.Text = ""

        ds = func.fRetornaPublicidadeCadastrada()

        For wCount As Integer = 0 To ds.Tables(0).Rows.Count - 1

            lblPublicidades.Text += ds.Tables(0).Rows(wCount).Item("tArquivo")

            If wCount < ds.Tables(0).Rows.Count - 1 Then

                lblPublicidades.Text += "#"

            End If

        Next

    End Sub

    Function fExibirPublicidades() As String

        Dim wStr As String

        wStr = " <ul><img src=""layout/mundialline/images/referencia.gif"" style=""width: 190px; height: 67px"" /></ul>"
        wStr += " <ul style=""height:8px;""></ul>"
        wStr += " <ul><img src=""layout/mundialline/images/referencia.gif"" style=""width: 190px; height: 67px"" /></ul>"

        Return lblItens.Text

    End Function

    Sub sSetaPublicidades()

        Call sCarregaDatalist()

        Dim wCount As Integer = 1
        Dim wCount2 As Integer = 0
        Dim ds As New DataSet
        Dim wArray As Array
        Dim ws As New wsCash.wsCash

        wArray = lblPublicidades.Text.Split("#")

        If lblwCount.Text = "" Then

            lblwCount.Text = 0

        End If

        If lblwCount.Text <> 0 Then

            wCount2 = lblwCount.Text

        End If

        While wCount <= lblQtdPublicidade.Text

            ' lblItens.Text += " <ul><img src=" & ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLBANNERS"), "", wArray(wCount2)) & " style=""width: 190px; height: 67px"" /></ul>"
            'lblItens.Text += " <ul style=""height:8px;""></ul>"

            If wCount = lblQtdPublicidade.Text Then

                lblwCount.Text = wCount2

            End If

            If wCount2 = wArray.Length - 1 Then

                wCount2 = 0

            End If

            wCount2 += 1
            wCount += 1

        End While

    End Sub

End Class
