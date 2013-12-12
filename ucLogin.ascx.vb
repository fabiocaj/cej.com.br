
Partial Class ucLogin
    Inherits System.Web.UI.UserControl

    Dim func As New wsCash.wsCash
    Dim wUsuario As New wsCash.wUsuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub cmdEntrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEntrar.Click

        Call sEntrar()

    End Sub

    Sub sEntrar()

        Dim wUsuario As New wsCash.wUsuario

        wUsuario = func.fLoginUsuario(txtCPF.Text, ConfigurationManager.AppSettings("Portal"))

        lblMensagem.Text = ""
        pnlLogin.Visible = True
        pnlUsuario.Visible = False
        lblInformativo.Visible = True

        With wUsuario

            If .cUsuario = 0 Then
                lblMensagem.Text = "Usuário inválido!"
                txtCPF.Focus()
                Exit Sub
            End If

            If Not .tSenha.Trim = txtSenha.Text.Trim Then
                lblMensagem.Text = "Senha Inválida!"
                txtSenha.Focus()
                Exit Sub
            End If

            Session("cUsuario") = .cUsuario
            Session("tUsuario") = .tUsuario

            lblUsuario.Text = .tUsuario

            pnlLogin.Visible = False
            pnlUsuario.Visible = True
            lblInformativo.Visible = False

        End With

    End Sub

    Protected Sub lnkSair_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkSair.Click

        Session("cUsuario") = ""
        Session("tUsuario") = ""

        txtCPF.Text = ""
        txtCPF.Focus()

        pnlLogin.Visible = True
        pnlUsuario.Visible = False
        lblInformativo.Visible = True

    End Sub
End Class
