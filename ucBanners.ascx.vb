Imports System.Data

Partial Class ucBanners
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarBanners()

        End If

    End Sub

    Sub sCarregarBanners()

        Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wPortal = ws.fCarregarPortal(func.fPortal())
        ds = func.fCampanhaBanners(1)

        With rrPortal

            .DataSource = ds
            .DataBind()

        End With

    End Sub

    Function fRetornaHTMLBanner(ByVal wArquivo As String, ByVal wTipoArquivo As Integer) As String

        Dim wCorpo As String = ""

        Select Case wTipoArquivo

            Case 1 'Flash

                wCorpo = "<object classid='clsid:D27CDB6E-AE6D-11cf-96B8-444553540000' codebase='http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,19,0'"
                wCorpo += "width='LARGURA' height='ALTURA' title='flash' id='flash' border='0'>"
                wCorpo += "<param name='movie' value='images/movie.swf'>"
                wCorpo += "<param name='quality' value='High'>"
                wCorpo += "<param name='menu' value='false'>"
                wCorpo += "<param name='swliveconnect' value='true'>"
                wCorpo += "<param name='wmode' value='transparent'>"
                wCorpo += "<embed src='images/movie.swf' quality='High' pluginspage='http://www.macromedia.com/go/getflashplayer'"
                wCorpo += "type='application/x-shockwave-flash' width='LARGURA' height='ALTURA' menu='false' swliveconnect='true'"
                wCorpo += "wmode='transparent' name='flash'></embed>"
                wCorpo += "</object>"

            Case 2 'Imagem
                wCorpo = "<img src='images/" & wArquivo & "' alt='' style='border:0px;'/>"

        End Select

        Return wCorpo

    End Function

End Class
