Imports System.Data

Partial Class ucDetalhesArtigo
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Sub sCarregarPagina(ByVal wCodigoArtigoDetalhe As Integer)


        If Not IsNumeric(wCodigoArtigoDetalhe) Then
            Exit Sub
        End If

        Dim wArtigoDetalhes As New wsCash.wArtigoDetalhes
        Dim wPagina As New wsCash.wPagina
        Dim wVideo As New wsCash.wVideo
        Dim wFormulario As New wsCash.wFormulario
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wArtigoDetalhes = ws.fRetornaInformacoesDetalheArtigo(wCodigoArtigoDetalhe)

        With wArtigoDetalhes

            wVideo = ws.fRetornaVideo(.cVideo)
            wPagina = ws.fRetornaPagina(.cPagina)
            wFormulario = ws.fRetornaFormulario(wPagina.cFormulario)
            lblTitulo.Text = .tArtigoDetalhe

            Dim wPastaImgEditor As String = ""
            If ConfigurationManager.AppSettings("URLIMAGENS").IndexOf("http") > 0 Then
                wPastaImgEditor = ConfigurationManager.AppSettings("URLIMAGENS") & "Grupos/"
            Else
                wPastaImgEditor = "http://" & ConfigurationManager.AppSettings("URLIMAGENS") & "Grupos/"
            End If

            lblTexto.Text = wPagina.tDescPagina.Replace(Chr(10), "<br>").Replace("src=""Grupos", "src=""" & wPastaImgEditor)
            lblTexto.Text = lblTexto.Text.Replace(Chr(10), "<br>").Replace("src=""/Grupos", "src=""" & wPastaImgEditor)

            If .cDownload <> 0 Then
                Session("cTipoConsulta") = "D"
                Session("cDownload") = .cDownload
                Session("cCategoriaDownload") = 0
            Else
                Session("cDownload") = 0
                Session("cCategoriaDownload") = 0
                If .cCategoriaDownload <> 0 Then
                    Session("cTipoConsulta") = "C"
                    Session("cCategoriaDownload") = .cCategoriaDownload
                End If
            End If

            If .cPagina <> 0 Then
                phIframe.Controls.Clear()
                Session("cPaginaArtigo") = .cPagina

                Dim wControl As New Control
                wControl = Page.LoadControl("ucArtigoIframe.ascx")
                phIframe.Controls.Add(wControl)

            End If

        End With

        With wFormulario
            phFormulario.Controls.Clear()
            If .cFormulario <> 0 Then

                Session("wFormularioEmail") = .tEmail
                Session("wFormularioTitulo") = .tFormulario

                Dim wControl As New Control
                wControl = Page.LoadControl(.tUserControl)
                phFormulario.Controls.Add(wControl)

            End If

        End With

        With wArtigoDetalhes
            phDownloads.Controls.Clear()
            If .cCategoriaDownload <> 0 Or .cDownload <> 0 Then

                Dim wControl As New Control
                wControl = Page.LoadControl("ucDownloadsArtigo.ascx")
                phDownloads.Controls.Add(wControl)

            End If

        End With

        With wVideo

            If .cVideo <> 0 Then
                phVideo.Controls.Clear()
                Session("tCodigoVideo") = .tCodigoVideo

                Dim wControl As New Control
                wControl = Page.LoadControl("ucVideoSelecionado.ascx")
                phVideo.Controls.Add(wControl)

            End If

        End With

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Call sCarregarComboCategorias(Request("cArtigo"))
            Call sCarregarNomeArtigo()
            Call sCarregarPagina(cmbDetalhesArtigos.SelectedValue)
        End If

    End Sub

    Sub sCarregarNomeArtigo()

        Dim wSQL As String
        Dim ds As DataSet
        Dim func As New clsAcessos
        Dim wPortal As New wsCash.wPortal
        Dim wCategoriaArtigo As New wsCash.wCategoriaArtigo
        Dim ws As New wsCash.wsCash

        Dim wDepartamento As String = Request.Params("cDepartamento")
        Dim wSecao As String = Request.Params("cVitrineSecao")
        Dim wFabricante As String = Request.Params("cFAbricante")
        Dim wFlagHome As Boolean = True

        wSQL = " select * "
        wSQL += " from tbArtigos "
        wSQL += " where cArtigo = " & Request("cArtigo")

        ws = func.fRetornaWS()
        ds = ws.fRetornaDataSet(wSQL)

        lblNomeArtigo.Text = ds.Tables(0).Rows(0).Item("tArtigo")

        wCategoriaArtigo = ws.FRETORNAINFORMACOESCATEGORIAARTIGO(ds.Tables(0).Rows(0).Item("cCategoriaArtigo"))

        With wCategoriaArtigo
            lblCategoriaArtigo.Text = wCategoriaArtigo.tCategoriaArtigo
        End With

    End Sub

    Sub sCarregarComboCategorias(ByVal cArtigo As Integer)

        'Dim ds As DataSet
        Dim wPortal As New wsCash.wPortal
        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()
        Dim ds As New DataSet
        ds = ws.fRetornaDetalhesArtigos(func.fGrupo(), func.fPortal(), cArtigo)
        Call func.sCarregaCombo(ds, cmbDetalhesArtigos, "tArtigoDetalhe", "cArtigoDetalhe")
        If ds.Tables(0).Rows.Count > 1 Then
            cmbDetalhesArtigos.Visible = True
        Else
            cmbDetalhesArtigos.Visible = False
        End If

    End Sub

    Protected Sub cmbDetalhesArtigos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDetalhesArtigos.SelectedIndexChanged
        Call sCarregarPagina(cmbDetalhesArtigos.SelectedValue)
    End Sub
End Class
