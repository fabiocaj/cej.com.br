Imports System.Configuration

Partial Class ucRedeCredenciada
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos
    Dim wSQL As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sConfiguraSecao()
            Call sCarregarComboEstados()
            Call sCarregarComboCidades()
            Call sCarregarComboCategorias()
            Call sCarregarComboEspecialidades()


        End If

    End Sub

    Sub sConfiguraSecao()

        Dim wSecao As New wsCash.wSecao
        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")
        wSecao = ws.fSecao(Session("cSecao"))

        'If Session("clsSecao") Is Nothing Then

        '    Dim wPortal As New wsCash.wPortal
        '    wPortal = ws.fCarregarPortal(func.fPortal())

        '    'Session("cSecao") = wPortal.cSecaoInicial

        '    'wSecao = ws.fSecao(Session("cSecao"))

        '    Session("clsSecao") = wSecao

        'Else
        '    wSecao = Session("clsSecao")

        'End If

        If wSecao.cEspecialidades = True Then
            pnlEspecialidades.Visible = True
        Else
            pnlEspecialidades.Visible = False
        End If

    End Sub

    Sub sCarregarComboEstados()

        Dim ws As New wsCash.wsCash
        Dim wEstadoPreferecial As Integer
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        wEstadoPreferecial = ws.fRetornaEstadoPreferencial()

        wSQL = "Select * from tbEstados order by tEstado "

        Call func.sCarregaCombo(ws.fRetornaDataSet(wSQL), cmbEstados, "tDescricao", "cEstado")

        If Not Session("cEstado") Is Nothing Then
            Call func.sSetaCombo(cmbEstados, Session("cEstado"))
        Else
            If wEstadoPreferecial <> 0 Then
                Call func.sSetaCombo(cmbEstados, wEstadoPreferecial)
            End If
        End If

    End Sub

    Sub sCarregarComboCidades()

        Dim ws As New wsCash.wsCash
        Dim wCidadePreferecial As Integer
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        wCidadePreferecial = ws.fRetornaCidadePreferencial()

        wSQL = "Select * from tbCidades where cEstado = " & cmbEstados.SelectedItem.Value & " order by tCidade "
        Call func.sCarregaCombo(ws.fRetornaDataSet(wSQL), cmbCidades, "tCidade", "cCidade")

        If Not Session("cCidade") Is Nothing Then
            Call func.sSetaCombo(cmbCidades, Session("cCidade"))
        Else
            If wCidadePreferecial <> 0 Then
                Call func.sSetaCombo(cmbCidades, wCidadePreferecial)
            End If
        End If

    End Sub

    Sub sCarregarComboCategorias()

        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        wSQL = "  Select c.tCategoria, c.cCategoria"
        wSQL += " from tbCategorias C "
        wSQL += " join tbAssociados A on C.cCategoria = A.cCategoria"
        wSQL += " where a.cCidade = " & cmbCidades.SelectedItem.Value
        wSQL += " and cSecao = " & Session("cSecao")
        wSQL += " group by c.tCategoria, c.cCategoria"
        wSQL += " order by c.tCategoria "

        Call func.sCarregaCombo(ws.fRetornaDataSet(wSQL), cmbCategorias, "tCategoria", "cCategoria", "(Todas as categorias)")

        If Not Session("cCategoria") Is Nothing Then
            Call func.sSetaCombo(cmbCategorias, Session("cCategoria"))
        End If

    End Sub

    Sub sCarregarComboEspecialidades()

        Dim ws As New wsCash.wsCash
        ws.Url = ConfigurationManager.AppSettings("wsURL")

        cmbEspecialidades.Items.Clear()

        'wSQL = "  Select E.tEspecialidade, E.cEspecialidade"
        'wSQL += " from tbEspecialidades E "
        'wSQL += " join tbAssociados A on E.cEspecialidade = A.cEspecialidade"
        'wSQL += " where a.cCidade = " & cmbCidades.SelectedItem.Value
        'If cmbCategorias.SelectedItem.Value <> "0" Then
        '    wSQL += " and A.cCategoria = " & cmbCategorias.SelectedItem.Value
        'End If
        'wSQL += " group by E.tEspecialidade, E.cEspecialidade"
        'wSQL += " order by E.tEspecialidade "

        wSQL = "  Select UPPER(E.tEspecialidade) as tEspecialidade, E.cEspecialidade "
        wSQL += " from tbEspecialidades E "
        wSQL += " join tbAssociados A on E.cCategoria = A.cCategoria  "
        wSQL += " join tbCategorias C on c.cCategoria = A.cCategoria "
        wSQL += " where a.cCidade = " & cmbCidades.SelectedItem.Value
        wSQL += " and cSecao = " & Session("cSecao")
        If cmbCategorias.SelectedItem.Value <> "0" Then
            wSQL += " and A.cCategoria = " & cmbCategorias.SelectedItem.Value
        End If
        wSQL += " group by E.tEspecialidade, E.cEspecialidade"
        wSQL += " order by E.tEspecialidade "


        'Select E.tEspecialidade, E.cEspecialidade 
        'from tbEspecialidades E  
        'join tbAssociados A on E.cCategoria = A.cCategoria 
        'join tbCategorias C on c.cCategoria = A.cCategoria
        'where a.cCidade = 1 
        'group by E.tEspecialidade, E.cEspecialidade 
        'order by E.tEspecialidade 


        Call func.sCarregaCombo(ws.fRetornaDataSet(wSQL), cmbEspecialidades, "tEspecialidade", "cEspecialidade", "(Todas as especialidades)")

        If Not Session("cEspecialidade") Is Nothing Then
            Call func.sSetaCombo(cmbEspecialidades, Session("cEspecialidade"))
        End If

    End Sub

    Protected Sub cmbEstados_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstados.SelectedIndexChanged

        Call sCarregarComboCidades()
        Call sCarregarComboCategorias()
        Call sCarregarComboEspecialidades()

    End Sub

    Protected Sub cmbCidades_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCidades.SelectedIndexChanged

        Call sCarregarComboCategorias()
        Call sCarregarComboEspecialidades()

    End Sub

    Protected Sub cmdConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click

        Call sConsultarRedeCredenciada()

    End Sub

    Sub sConsultarRedeCredenciada()

        Session("cEstado") = cmbEstados.SelectedItem.Value
        Session("cCidade") = cmbCidades.SelectedItem.Value
        If cmbCategorias.Items.Count <> 0 Then
            Session("cCategoria") = cmbCategorias.SelectedItem.Value
        Else
            Session("cCategoria") = "0"
        End If

        If cmbEspecialidades.Items.Count <> 0 Then
            Session("cEspecialidade") = cmbEspecialidades.SelectedItem.Value
        Else
            Session("cEspecialidade") = "0"
        End If

        rapRede.Redirect("ResultadoPesquisaRedeCredenciada.aspx")

    End Sub

    Protected Sub cmbCategorias_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCategorias.SelectedIndexChanged

        Call sCarregarComboEspecialidades()

    End Sub

End Class
