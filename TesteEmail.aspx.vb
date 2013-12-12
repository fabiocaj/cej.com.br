
Partial Class TesteEmail
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarInformacoes()

        End If

    End Sub

    Sub sCarregarInformacoes()

        lblSMTP.Text = ConfigurationManager.AppSettings("SMTPSERVER")

        Dim func As New clsAcessos
        Dim wParametros As New wsCash.wParametrizacoes
        Dim ws As New wsCash.wsCash

        ws = func.fRetornaWS()
        wParametros = ws.fParametros()

        With wParametros
            lblUsuarioAutenticacao.Text = .tEmail
            lblSenhaAutenticacao.Text = .tSenha
        End With

    End Sub


    Protected Sub cmdEnviar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEnviar.Click

        Dim func As New Funcoes
        lblResposta.Text = func.fEnviaEmail(txtPara.Text, txtDe.Text, "", "", txtAssunto.Text, txtMensagem.Text, "", "")

    End Sub

End Class
