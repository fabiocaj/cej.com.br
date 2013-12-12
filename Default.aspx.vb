
Partial Class _Default
    Inherits System.Web.UI.Page

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Colocar aqui o c�digo da Se��o para a rede credenciada
        Session("cSecao") = 1

        If Not IsPostBack Then

            Session("nomePagina") = Nothing

        End If

        If Session("nomePagina") Is Nothing Then

            Call sCarregaNomePagina()

            Page.Title = Session("nomePagina")

        Else

            Page.Title = Session("nomePagina")

        End If

        lblPopup.Text = func.fRetornaPopUp()

    End Sub

    Sub sCarregaNomePagina()

        Dim ws As New wsCash.wsCash
        Dim wPortal As New wsCash.wPortal
        Dim func As New clsAcessos

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())

        Session("nomePagina") = wPortal.tPortal

    End Sub

End Class
