Imports System.Data

Partial Class ucPublicidade
    Inherits System.Web.UI.UserControl

    Protected Class clsPublicidade

        Private arquivo As String
        Private extensao As Integer
        Private link As String
        Private publicidade As String

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
                Return publicidade
            End Get
            Set(ByVal value As String)
                publicidade = value
            End Set
        End Property

    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Session("cPonteiroPublicidade") = 0
            Call sBindPublicidades(fCarregarPublicidades())

        End If

    End Sub


    Function fCarregarPublicidades() As ArrayList

        Dim func As New clsAcessos
        Dim ds As New DataSet
        Dim wPortal As New wsCash.wPortal
        Dim wContador As Integer = 0
        Dim aPublicidades As New ArrayList
        Dim aPublicidadesRetorno As New ArrayList
        Dim wCount As Integer = 0
        Dim ws As New wsCash.wsCash

        'Construção da Array List Completo
        If Session("aPublicidades") Is Nothing Then

            'Carregar Data Set de Publicidades
            ws = func.fRetornaWS()
            wPortal = ws.fCarregarPortal(func.fPortal())
            Session("qPublicidades") = wPortal.qPublicidades

            ds = func.fRetornaPublicidadeCadastrada()

            If ds.Tables(0).Rows.Count > 0 Then

                For I As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    Dim clsPublicidade As New clsPublicidade
                    clsPublicidade.tArquivo = ds.Tables(0).Rows(I).Item("tArquivo")
                    clsPublicidade.cExtensao = ds.Tables(0).Rows(I).Item("cTipoBanner")
                    clsPublicidade.tLink = IIf(ds.Tables(0).Rows(I).Item("tUrl") Is DBNull.Value, "", ds.Tables(0).Rows(I).Item("tUrl"))
                    clsPublicidade.tPublicidade = fRetornaPublicidade(clsPublicidade.tArquivo, clsPublicidade.cExtensao, clsPublicidade.tLink)
                    aPublicidades.Add(clsPublicidade)

                Next

                Session("aPublicidades") = aPublicidades

            End If

        Else

            aPublicidades = CType(Session("aPublicidades"), ArrayList)

        End If

        'Mostra lista de publicidades ou inibe exibição
        'If Session("qPublicidades") > 0 Then
        'imgPublicidade.Visible = True
        ' Else
        ' imgPublicidade.Visible = False
        'Return Nothing
        ' End If

        While wCount < Session("qPublicidades")

            'Construindo o array de retorno de publicidades
            For I As Integer = Session("cPonteiroPublicidade") To aPublicidades.Count - 1

                If wContador = Session("qPublicidades") Then
                    Session("cPonteiroPublicidade") = I
                    Exit For
                Else
                    wContador += 1
                End If

                aPublicidadesRetorno.Add(aPublicidades(I))

                wCount += 1

                If I = aPublicidades.Count - 1 Then

                    Session("cPonteiroPublicidade") = 0

                End If

            Next

            If aPublicidades.Count < Session("qPublicidades") Then

                wCount = Session("qPublicidades") + 1
                Session("cPonteiroPublicidade") = 0

            End If

        End While

        Return aPublicidadesRetorno

    End Function

    Sub sBindPublicidades(ByVal aPublicidades As ArrayList)

        With dlPublicidades
            .DataSource = aPublicidades
            .DataBind()
        End With

        If dlPublicidades.Items.Count = 0 Then

            '  imgPublicidade.Visible = False

        End If

    End Sub

    Protected Sub ratPublicidades_Tick(ByVal sender As Object, ByVal e As Telerik.WebControls.TickEventArgs) Handles ratPublicidades.Tick

        Call sBindPublicidades(fCarregarPublicidades())

    End Sub

    Function fRetornaPublicidade(ByVal wArquivo As String, ByVal wTipoBAnner As Integer, ByVal wLink As String) As String


        Dim ws As New wsCash.wsCash
        Dim wTagImg As String

        ws.Url = ConfigurationManager.AppSettings("wsURL")

        Dim wURL As String

        wURL = ws.fRetornaURLImagem(ConfigurationManager.AppSettings("URLIMAGENS"), "BANNER", wArquivo)

        If wTipoBAnner = 1 Then

            wTagImg = " <object id=" & Chr(34) & "FlashID" & Chr(34) & " classid=" & Chr(34) & "clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" & Chr(34) & " width=" & Chr(34) & "auto" & Chr(34) & " height=" & Chr(34) & "67" & Chr(34) & ">"
            wTagImg += " <param name=" & Chr(34) & "movie" & Chr(34) & " value=" & Chr(34) & wURL & Chr(34) & "/>"
            wTagImg += " <param name=" & Chr(34) & "quality" & Chr(34) & " value=" & Chr(34) & "high" & Chr(34) & "/>"
            wTagImg += "  <param name=" & Chr(34) & "wmode" & Chr(34) & " value=" & Chr(34) & "opaque" & Chr(34) & "/>"
            wTagImg += " <param name=" & Chr(34) & "swfversion" & Chr(34) & " value=" & Chr(34) & "9.0.45.0" & Chr(34) & "/>"
            wTagImg += " <param name=" & Chr(34) & "expressinstall" & Chr(34) & " value=" & Chr(34) & "Scripts/expressInstall.swf" & Chr(34) & " />"
            wTagImg += " </object>"

        Else

            If wLink <> "" Then

                wLink.Replace("http://", "")

                wTagImg = "<a href=" & Chr(34) & "http://" & wLink.Trim & Chr(34) & " target=" & Chr(34) & "_blank " & Chr(34) & "><img src=" & Chr(34) & wURL & Chr(34) & " style=" & Chr(34) & "width:auto; height:auto" & Chr(34) & " /></a>"

            Else

                wTagImg = "<img src=" & Chr(34) & wURL & Chr(34) & " style=" & Chr(34) & "width: auto; height: auto" & Chr(34) & " />"

            End If

        End If

        Return wTagImg

    End Function

End Class
