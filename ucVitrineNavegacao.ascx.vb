Imports System.Data
Imports System.IO


Partial Class ucVitrineNavegacao
    Inherits System.Web.UI.UserControl

    Dim func As New clsAcessos

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Call sCarregarVitrineNavegacao()

        End If

    End Sub

    Sub sCarregarVitrineNavegacao()

        Dim wSQL As String
        Dim ws As New wsCash.wsCash
        ws = func.fRetornaWS()
        Dim ds As New DataSet

        Dim wDepartamento As Double = Request.Params("cDepartamento")
        Dim wSecao As Double = Request.Params("cVitrineSecao")
        Dim wFabricante As Double = Request.Params("cFabricante")

        lblNavegacao.Text = ""
        lblNavegacao.Text += "<A HREF='Vitrine.aspx' class=SVitrineNavegacao >DESTAQUES</a><img src=imagens/separacao.jpg />.   "

        If wDepartamento <> "0" Then
            wSQL = "Select * from tbDepartamentos where cDepartamento = " & wDepartamento
            ds = ws.fRetornaDataSet(wSQL)

            lblNavegacao.Text += "<A HREF='Vitrine.aspx?cDepartamento=" & wDepartamento & "' class=SVitrineNavegacao>" & ds.Tables(0).Rows(0).Item("tDepartamento").ToString.ToUpper & "</a><img src=imagens/separacao.jpg />.   "
        End If

        If wSecao <> "0" Then
            wSQL = "Select * from tbDepartamentoSecoes where cSecao = " & wSecao
            ds = ws.fRetornaDataSet(wSQL)

            lblNavegacao.Text += "<A HREF='Vitrine.aspx?cDepartamento=" & wDepartamento & "&cVitrineSecao=" & wSecao & "' class=SVitrineNavegacao  >" & ds.Tables(0).Rows(0).Item("tSecao").ToString.ToUpper & "</a><img src=imagens/separacao.jpg />.   "
        End If

        If wFabricante <> "0" Then
            wSQL = "Select * from tbFabricantes where cFabricante = " & wFabricante
            ds = ws.fRetornaDataSet(wSQL)

            lblNavegacao.Text += "<A HREF='Vitrine.aspx?cDepartamento=" & wDepartamento & "&cVitrineSecao=" & wSecao & "&cFabricante=" & wFabricante & "'  class=SVitrineNavegacao >" & ds.Tables(0).Rows(0).Item("tFabricante").ToString.ToUpper & "</a> "
        End If

        lblNavegacao.Text = Left(lblNavegacao.Text, lblNavegacao.Text.Length - 3)

    End Sub

End Class