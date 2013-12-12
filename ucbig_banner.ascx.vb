Imports System.Data

Partial Class ucbig_banner
    Inherits System.Web.UI.UserControl

    Protected Class clsBigBanner

        Private arquivo As String
        Private extensao As Integer
        Private link As String
        Private tipolink As String
        Private descricao As String

        Public Property tArquivo() As String
            Get
                Return arquivo
            End Get
            Set(ByVal value As String)
                arquivo = value
            End Set
        End Property

        Public Property cExtensao() As Integer
            Get
                Return extensao
            End Get
            Set(ByVal value As Integer)
                extensao = value
            End Set
        End Property

        Public Property tLink() As String
            Get
                Return link
            End Get
            Set(ByVal value As String)
                link = value
            End Set
        End Property

        Public Property tTipoLink() As String
            Get
                Return tipolink
            End Get
            Set(ByVal value As String)
                tipolink = value
            End Set
        End Property

        Public Property tBanner() As String
            Get
                Return descricao
            End Get
            Set(ByVal value As String)
                descricao = value
            End Set
        End Property

    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim a As Integer

            a = 1
            'lblBigBanners.Text = fCarregarBigBanners()

        End If

    End Sub

    Function fCarregarBigBanners() As String

        Dim func As New clsAcessos
        Dim ds As New DataSet
        Dim wPortal As New wsCash.wPortal
        Dim wContador As Integer = 0
        Dim aBigBanners As New ArrayList
        Dim wCount As Integer = 0
        Dim ws As New wsCash.wsCash
        Dim wBigBanner As String = ""

        If Session("wBigBanners") Is Nothing Then

            'Carregar Data Set de Detaques Banners
            ws = func.fRetornaWS()

            ds = ws.fRetornaBigBannerCadastrado(func.fPortal())

            If ds.Tables(0).Rows.Count > 0 Then

                For I As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    Dim clsBigBanner As New clsBigBanner

                    With clsBigBanner
                        .tArquivo = ds.Tables(0).Rows(I).Item("tArquivo")
                        .cExtensao = ds.Tables(0).Rows(I).Item("cTipoBanner")
                        .tLink = IIf(ds.Tables(0).Rows(I).Item("tUrl") Is DBNull.Value, "", ds.Tables(0).Rows(I).Item("tUrl"))
                        .tTipoLink = IIf(ds.Tables(0).Rows(I).Item("tTipoLink") Is DBNull.Value, "", ds.Tables(0).Rows(I).Item("tTipoLink"))
                        .tBanner = IIf(ds.Tables(0).Rows(I).Item("tBanner") Is DBNull.Value, "", ds.Tables(0).Rows(I).Item("tBanner"))
                        aBigBanners.Add(clsBigBanner)
                    End With

                Next

            End If

            wBigBanner = fRetornaBigBanners(aBigBanners)
            Session("wBigBanners") = wBigBanner

        Else

            wBigBanner = Session("wBigBanners")

        End If

        Return wBigBanner

    End Function


    Function fRetornaBigBanners(ByVal aBigBanners As ArrayList) As String

        Dim ws As New wsCash.wsCash
        Dim wTagImg As String = ""
        Dim wURL As String
        Dim func As New clsAcessos

        ws = func.fRetornaWS

        For wCount As Integer = 0 To aBigBanners.Count - 1

            wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "BANNER", aBigBanners(wCount).tArquivo).Trim()

            If aBigBanners(wCount).cExtensao = 1 Then

                wTagImg += " <li>"
                wTagImg += " <object id=" & Chr(34) & "FlashID" & Chr(34) & " classid=" & Chr(34) & "clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" & Chr(34) & " width=" & Chr(34) & "709" & Chr(34) & " height=" & Chr(34) & "210" & Chr(34) & ">"
                wTagImg += " <param name=" & Chr(34) & "movie" & Chr(34) & " value=" & Chr(34) & wURL & Chr(34) & "/>"
                wTagImg += " <param name=" & Chr(34) & "quality" & Chr(34) & " value=" & Chr(34) & "high" & Chr(34) & "/>"
                wTagImg += "  <param name=" & Chr(34) & "wmode" & Chr(34) & " value=" & Chr(34) & "opaque" & Chr(34) & "/>"
                wTagImg += " <param name=" & Chr(34) & "swfversion" & Chr(34) & " value=" & Chr(34) & "9.0.45.0" & Chr(34) & "/>"
                wTagImg += " <param name=" & Chr(34) & "expressinstall" & Chr(34) & " value=" & Chr(34) & "Scripts/expressInstall.swf" & Chr(34) & " />"
                wTagImg += " </object>"
                wTagImg += " </li>"

            Else

                If aBigBanners(wCount).tLink <> "" Then

                    aBigBanners(wCount).tLink.Replace("http://", "")

                    Dim wHTTP As String = ""

                    Select Case aBigBanners(wCount).tTipoLink.Trim.toUpper

                        Case "_BLANK"
                            wHTTP = "http://"

                        Case "_SELF"
                            wHTTP = ""

                    End Select

                    wTagImg += "<li><img src=" & Chr(34) & wURL & Chr(34) & " border='0' usemap='#bigbanner' alt='" & aBigBanners(wCount).tBanner.Trim.toUpper & "' /></a></li>"
                    wTagImg += " <map name='bigbanner' id='bigbanner'><area shape='rect' coords='3,5,704,204' href=" & Chr(34) & wHTTP & aBigBanners(wCount).tLink.Trim & Chr(34) & " target=" & Chr(34) & aBigBanners(wCount).tTipoLink.trim & Chr(34) & " /></map>"
                Else

                    wTagImg += "<li><img src=" & Chr(34) & wURL & Chr(34) & " alt='" & aBigBanners(wCount).tBanner.Trim.toUpper & "' /></li>"

                End If

            End If

        Next

        Return wTagImg

    End Function

End Class
