
Partial Class ucnewsletter
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub cmdGravar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles cmdGravar.Click

        Call sGravar()

    End Sub

    Sub sGravar()

        If fVerificaEmail() Then

            Dim wErro As String

            If fVerificaCampo() Then

                Dim wNewsLetter As New wsCash.wNewsLetter
                Dim func As New clsAcessos

                With wNewsLetter

                    .cPortal = func.fPortal()
                    .tEmail = txtEmail.Text

                End With

                wErro = func.fManutencaoPortalUsuarioNewsLetter(wNewsLetter)

                If Left(wErro.ToUpper, 4) <> "ERRO" Then

                    txtEmail.Text = ""
                    lblMensagem2.Text = "<div class=""MessNewsletter3""></div>"

                Else

                    lblMensagem2.Text = "<div  class=""MessNewsletter2""></div>"

                End If

            End If

        Else

            lblMensagem2.Text = "<div  class=""MessNewsletter""></div>"

        End If

    End Sub

    Function fVerificaCampo() As Boolean

        If txtEmail.Text.Trim.Length = 0 Or txtEmail.Text = "Digite seu e-mail..." Then

            txtEmail.Focus()
            lblMensagem2.Text = "<div  class=""MessNewsletter""></div>"
            Return False

        End If

        Return True

    End Function

    Function fVerificaEmail() As Boolean

        'Fonte macoratti
        Dim strRegex As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))"
        strRegex += "([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"

        'cria um novo objeto 

        Dim re As Regex = New Regex(strRegex)

        'verifica se o email é valido

        If re.IsMatch(txtEmail.Text) Then

            Return (True)

        Else

            Return (False)

        End If

    End Function

End Class
