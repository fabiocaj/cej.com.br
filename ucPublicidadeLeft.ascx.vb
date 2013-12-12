Imports System.Data

Partial Class ucPublicidadeLeft
    Inherits System.Web.UI.UserControl

    Protected Class clsPublicidadeLeft

        Private arquivo As String
        Private extensao As Integer
        Private link As String
        Private publicidadeLeft As String

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

        Public Property tPublicidade() As String
            Get
                Return publicidadeLeft
            End Get
            Set(ByVal value As String)
                publicidadeLeft = value
            End Set
        End Property

    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Session("cPonteiroPublicidadeEsquerdo") = 0
            Call sBindPublicidades(fCarregarPublicidadesLeft())

        End If

    End Sub


    Function fCarregarPublicidadesLeft() As ArrayList

        Dim func As New clsAcessos
        Dim ds As New DataSet
        Dim wPortal As New wsCash.wPortal
        Dim wContador As Integer = 0
        Dim aPublicidadesLeft As New ArrayList
        Dim aPublicidadesLeftRetorno As New ArrayList
        Dim wCount As Integer = 0
        Dim ws As New wsCash.wsCash

        'Construção da Array List Completo
        If Session("aPublicidadesLeft") Is Nothing Then

            'Carregar Data Set de Publicidades
            ws = func.fRetornaWS()
            wPortal = ws.fCarregarPortal(func.fPortal())
            Session("qPublicidadesEsquerdo") = wPortal.qPublicidadesEsquerdo

            ds = func.fRetornaLeftPublicidadeCadastrada()

            If ds.Tables(0).Rows.Count > 0 Then

                For I As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    Dim clsPublicidadeLeft As New clsPublicidadeLeft
                    clsPublicidadeLeft.tArquivo = ds.Tables(0).Rows(I).Item("tArquivo")
                    clsPublicidadeLeft.cExtensao = ds.Tables(0).Rows(I).Item("cTipoBanner")
                    clsPublicidadeLeft.tLink = IIf(ds.Tables(0).Rows(I).Item("tUrl") Is DBNull.Value, "", ds.Tables(0).Rows(I).Item("tUrl"))
                    clsPublicidadeLeft.tPublicidade = fRetornaPublicidadeLeft(clsPublicidadeLeft.tArquivo, clsPublicidadeLeft.cExtensao, clsPublicidadeLeft.tLink)
                    aPublicidadesLeft.Add(clsPublicidadeLeft)

                Next

                Session("aPublicidadesLeft") = aPublicidadesLeft

            End If

        Else

            aPublicidadesLeft = CType(Session("aPublicidadesLeft"), ArrayList)

        End If

        'Mostra lista de publicidades ou inibe exibição
        If Session("qPublicidadesEsquerdo") > 0 Then
            '   imgPublicidade.Visible = True
        Else
            ' imgPublicidade.Visible = False
            Return Nothing
        End If

        While wCount < Session("qPublicidadesEsquerdo")

            'Construindo o array de retorno de publicidades
            For I As Integer = Session("cPonteiroPublicidadeEsquerdo") To aPublicidadesLeft.Count - 1

                If wContador = Session("qPublicidadesEsquerdo") Then
                    Session("cPonteiroPublicidadeEsquerdo") = I
                    Exit For
                Else
                    wContador += 1
                End If

                aPublicidadesLeftRetorno.Add(aPublicidadesLeft(I))

                wCount += 1

                If I = aPublicidadesLeft.Count - 1 Then

                    Session("cPonteiroPublicidadeEsquerdo") = 0

                End If

            Next

            If aPublicidadesLeft.Count < Session("qPublicidadesEsquerdo") Then

                wCount = Session("qPublicidadesEsquerdo") + 1
                Session("cPonteiroPublicidadeEsquerdo") = 0

            End If

        End While

        Return aPublicidadesLeftRetorno

    End Function

    Sub sBindPublicidades(ByVal aPublicidadesLeft As ArrayList)

        With dlPublicidadesLeft
            .DataSource = aPublicidadesLeft
            .DataBind()
        End With

        If dlPublicidadesLeft.Items.Count = 0 Then
            '  imgPublicidade.Visible = False

        End If

    End Sub

    Protected Sub ratPublicidadesLeft_Tick(ByVal sender As Object, ByVal e As Telerik.WebControls.TickEventArgs) Handles ratPublicidadesLeft.Tick

        Call sBindPublicidades(fCarregarPublicidadesLeft())

    End Sub

    Function fRetornaPublicidadeLeft(ByVal wArquivo As String, ByVal wTipoBAnner As Integer, ByVal wLink As String) As String


        Dim ws As New wsCash.wsCash
        Dim wTagImg As String

        ws.Url = ConfigurationManager.AppSettings("wsURL")

        Dim wURL As String

        wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "BANNER", wArquivo)

        If wTipoBAnner = 1 Then

            wTagImg = " <object id=" & Chr(34) & "FlashID" & Chr(34) & " classid=" & Chr(34) & "clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" & Chr(34) & " width=" & Chr(34) & "180" & Chr(34) & " height=" & Chr(34) & "90" & Chr(34) & ">"
            wTagImg += " <param name=" & Chr(34) & "movie" & Chr(34) & " value=" & Chr(34) & wURL & Chr(34) & "/>"
            wTagImg += " <param name=" & Chr(34) & "quality" & Chr(34) & " value=" & Chr(34) & "high" & Chr(34) & "/>"
            wTagImg += "  <param name=" & Chr(34) & "wmode" & Chr(34) & " value=" & Chr(34) & "opaque" & Chr(34) & "/>"
            wTagImg += " <param name=" & Chr(34) & "swfversion" & Chr(34) & " value=" & Chr(34) & "9.0.45.0" & Chr(34) & "/>"
            wTagImg += " <param name=" & Chr(34) & "expressinstall" & Chr(34) & " value=" & Chr(34) & "Scripts/expressInstall.swf" & Chr(34) & " />"
            wTagImg += " </object>"

        Else

            If wLink <> "" Then

                wLink.Replace("http://", "")

                wTagImg = "<a href=" & Chr(34) & "http://" & wLink.Trim & Chr(34) & " target=" & Chr(34) & "_blank " & Chr(34) & "><img src=" & Chr(34) & wURL & Chr(34) & " style=" & Chr(34) & "width: 180px; height: 90px" & Chr(34) & " /></a>"

            Else

                wTagImg = "<img src=" & Chr(34) & wURL & Chr(34) & " style=" & Chr(34) & "width: 180px; height: 90px" & Chr(34) & " />"

            End If

        End If

        Return wTagImg

    End Function

End Class
