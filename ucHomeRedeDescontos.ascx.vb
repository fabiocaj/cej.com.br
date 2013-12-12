
Partial Class ucHomeRedeDescontos
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos
    Dim wSQL As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sConfiguraSecao()

        End If

    End Sub


    Sub sConfiguraSecao()

        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        Dim wPortal As New wsCash.wPortal
        wPortal = ws.fCarregarPortal(func.fPortal())

        If Request.Params("cSecao") <> "" Then
            Session("cSecao") = Request.Params("cSecao")
        Else
            If Session("cSecao") Is Nothing Then
                Session("cSecao") = wPortal.cSecaoInicial
            End If
        End If

        If Request.Params("cMenu") <> "" Then
            Dim wMenu As New wsCash.wMenu
            wMenu = ws.fMenu(Request.Params("cMenu"))

            If wMenu.cSecaoTemplate <> 0 Then
                Session("cSecao") = wMenu.cSecaoTemplate
            End If

        End If

        Dim wSecao As New wsCash.wSecao
        wSecao = ws.fSecao(Session("cSecao"))

        lblTitulo.Text = wSecao.tSecao
        lblTitulo.CssClass = wSecao.tCSS
        'lblTitulo.CssClass = "TituloRedeDescontos"


    End Sub


End Class
