Imports System.Data.SQL
Imports System.Data.SqlClient
Imports System.Web.Mail
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Web.Security
Imports System.Web.UI.WebControls
Imports system.data
Imports Telerik.WebControls

Public Class wPermissao

    Public wCodigoUsuario As Integer
    Public wCodigoModulo As Integer
    Public wInclusao As Integer
    Public wExclusao As Integer
    Public wAlteracao As Integer
    Public wConsulta As Integer
    Public wMenu As Integer
    Public wOutros As Integer

End Class

Public Class wObjeto

    Public Codigo As Integer
    Public Nome As String
    Public Valor As Double
    Public Observacao As String
    Public CodigoTipoObjeto As Integer
    Public foto As String

End Class

Public Class wCliente

    Public Grupo As Integer
    Public Codigo As Integer
    Public nome As String
    Public nomefantasia As String
    Public endereco As String
    Public bairro As String
    Public cidade As String
    Public estado As String
    Public CEP As String
    Public emailcobranca As String
    Public emailadm As String
    Public telefone As String
    Public CNPJCPF As String
    Public INSCRESTADUAL As String
    Public INSCRMUNICIPAL As String
    Public DataAlteracao As Date
    Public Status As Integer

End Class

Public Class Funcoes

    Inherits System.ComponentModel.Component

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
    End Sub

#End Region

    Public Function fExecutaStoreProcedure(ByVal wParametro2 As SqlParameter, ByVal wNomeStore As String, ByVal wAmbiente As String) As DataSet

        Dim conn As SqlConnection
        Dim sql_adapter As New SqlDataAdapter
        Dim ds As New DataSet

        conn = fAbrirBD(wAmbiente)

        'Cria a Store Procedure
        sql_adapter = New SqlDataAdapter(wNomeStore, conn)
        'Define o Tipo da Store Procedure

        sql_adapter.SelectCommand.CommandType = CommandType.StoredProcedure
        'define o tipo de dados do par‚metro a ser recebido

        sql_adapter.SelectCommand.Parameters.Add(wParametro2)

        'preenche o dataset com os dados da sp
        sql_adapter.Fill(ds, "STOREPROCEDURE")
        'exibe os dados no datagrid
        Return ds

    End Function

    Public Function fExecutaStoreProcedure(ByVal wParametro As SqlParameter, ByVal wParametro2 As SqlParameter, ByVal wNomeStore As String, ByVal wAmbiente As String) As DataSet

        Dim conn As SqlConnection
        Dim sql_adapter As New SqlDataAdapter
        Dim ds As New DataSet

        conn = fAbrirBD(wAmbiente)

        'Cria a Store Procedure
        sql_adapter = New SqlDataAdapter(wNomeStore, conn)
        'Define o Tipo da Store Procedure

        sql_adapter.SelectCommand.CommandType = CommandType.StoredProcedure
        'define o tipo de dados do par‚metro a ser recebido

        sql_adapter.SelectCommand.Parameters.Add(wParametro)
        sql_adapter.SelectCommand.Parameters.Add(wParametro2)

        'preenche o dataset com os dados da sp
        sql_adapter.Fill(ds, "STOREPROCEDURE")
        'exibe os dados no datagrid
        Return ds

    End Function

    Public Function fExecutaStoreProcedure(ByVal wParametro As SqlParameter, ByVal wParametro2 As SqlParameter, ByVal wParametro3 As SqlParameter, ByVal wParametro4 As SqlParameter, ByVal wNomeStore As String, ByVal wAmbiente As String) As DataSet

        Dim conn As SqlConnection
        Dim sql_adapter As New SqlDataAdapter
        Dim ds As New DataSet

        conn = fAbrirBD(wAmbiente)

        'Cria a Store Procedure
        sql_adapter = New SqlDataAdapter(wNomeStore, conn)
        'Define o Tipo da Store Procedure

        sql_adapter.SelectCommand.CommandType = CommandType.StoredProcedure
        'define o tipo de dados do par‚metro a ser recebido

        sql_adapter.SelectCommand.Parameters.Add(wParametro)
        sql_adapter.SelectCommand.Parameters.Add(wParametro2).Direction = ParameterDirection.Output
        sql_adapter.SelectCommand.Parameters.Add(wParametro3).Direction = ParameterDirection.Output
        sql_adapter.SelectCommand.Parameters.Add(wParametro4).Direction = ParameterDirection.Output

        'preenche o dataset com os dados da sp
        sql_adapter.Fill(ds, "STOREPROCEDURE")
        'exibe os dados no datagrid
        Return ds

    End Function

    ''' <summary>
    ''' FunÁ„o que retorna um valor Int32
    ''' </summary>
    ''' <param name="wSQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fRetornaExecuteScalarDouble(ByVal wSQL As String) As Double

        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim Valor As Double
        Dim wAmbiente As String

        wAmbiente = ConfigurationManager.AppSettings.Get("AMBIENTE")

        conn = fAbrirBD(wAmbiente)

        cmd = New SqlCommand(wSQL, conn)

        Valor = cmd.ExecuteScalar()

        Return Valor

    End Function

    ''' <summary>
    ''' FunÁ„o que retorna um valor Int32
    ''' </summary>
    ''' <param name="wSQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fRetornaExecuteScalarInt32(ByVal wSQL As String) As Int32

        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim Valor As Int32
        Dim wAmbiente As String

        wAmbiente = ConfigurationManager.AppSettings.Get("AMBIENTE")

        conn = fAbrirBD(wAmbiente)

        cmd = New SqlCommand(wSQL, conn)

        Valor = cmd.ExecuteScalar()

        Return Valor

    End Function

    Public Function fAbrirBD(ByVal wDSN As String) As SqlConnection

        Dim conn As SqlConnection
        Dim wFlag As Boolean = True
        Dim wContador As Integer = 0

        Do While wFlag = True

            Try
                Select Case wDSN

                    Case "SQL"
                        conn = New SqlConnection(ConfigurationManager.AppSettings("CASH"))

                    Case "DUALTEC"
                        conn = New SqlConnection(ConfigurationManager.AppSettings("CASH"))

                    Case "ACCESS"
                        conn = New SqlConnection(ConfigurationManager.AppSettings("CASH"))

                    Case "ORACLE"
                        conn = New SqlConnection(ConfigurationManager.AppSettings("CASH"))
                End Select

                conn.Open()

                Return conn

            Catch ex As Exception

                wContador += 1

                If wContador > 100 Then
                    wFlag = False
                End If

            End Try

        Loop

        Return Nothing

    End Function

    Public Function fAbrirBD_Oracle(ByVal wDSN As String) As SqlConnection

        Dim conn As SqlConnection

        wDSN = "Provider=MSDAORA;Data Source=baan;User ID=baandb;Password=baandb;"
        'wDSN = "DSN=Extranet_des; uid=baandb; pwd=baandb"

        Select Case wDSN

            Case "SQL"
                conn = New SqlConnection(wDSN)

            Case "ACCESS"
                conn = New SqlConnection(wDSN)

            Case "ORACLE"
                conn = New SqlConnection(wDSN)

            Case Else
                conn = New SqlConnection(wDSN)

        End Select

        conn.Open()

        Return conn

    End Function

    Public Function fConfiguraSeguranca(ByVal wNivelUsuario As Integer)

        Dim wResposta As Boolean
        Select Case wNivelUsuario

            Case 1 ' Diretor

                wResposta = True


            Case 2 'Gerente
                wResposta = True


            Case 3 'Colaborador
                wResposta = False

            Case 4 'Auditor
                wResposta = False

            Case 5 'Auditor
                wResposta = False



        End Select
        Return wResposta

    End Function
    Public Function fRetornaDataReader_Oracle(ByVal wSQL As String, ByVal wDSN As String) As SqlDataReader

        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        conn = fAbrirBD_Oracle(wDSN)

        cmd = New SqlCommand(wSQL, conn)

        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)



        dr.Close()
        dr = Nothing

        conn.Close()
        conn = Nothing
        Return dr
    End Function

    Public Function fRetornaDataReader(ByVal wSQL As String) As SqlDataReader

        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim wAmbiente As String

        'wSQL = Replace(wSQL, ", ''", ", ''''")
        'wSQL = Replace(wSQL, "''", "'")
        'wSQL = Replace(wSQL, ", ''", ", '")
        'wSQL = Replace(wSQL, "'''", "'")
        wSQL = fRetornaApostrofo(wSQL)

        wAmbiente = ConfigurationSettings.AppSettings("AMBIENTE")

        conn = fAbrirBD(wAmbiente)

        cmd = New SqlCommand(wSQL, conn)

        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Return dr

    End Function

    Public Function fRetornaDataReader2(ByVal wSQL As String) As SqlDataReader

        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim wAmbiente As String

        wAmbiente = ConfigurationSettings.AppSettings("AMBIENTE")

        conn = fAbrirBD(wAmbiente)

        wSQL = fRetornaApostrofo(wSQL)

        cmd = New SqlCommand(wSQL, conn)

        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Return dr

        dr.Close()
        dr = Nothing

        conn.Close()
        conn = Nothing


    End Function

    Public Function fRetornaDataSet(ByVal wSQL As String) As DataSet

        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim wAmbiente As String

        'wSQL = Replace(wSQL, "''", "'")
        wSQL = fRetornaApostrofo(wSQL)

        wAmbiente = ConfigurationSettings.AppSettings("AMBIENTE")

        conn = fAbrirBD(wAmbiente)

        da = New SqlDataAdapter(wSQL, conn)
        ds = New DataSet
        da.Fill(ds, "LM")

        Return ds

    End Function

    Public Function fRetornaDataSet(ByVal wSQL As String, ByVal wAmbiente As String) As DataSet

        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet

        wSQL = Replace(wSQL, "''", "'")

        'wAmbiente = ConfigurationSettings.AppSettings("AMBIENTE")

        conn = fAbrirBD(wAmbiente)

        da = New SqlDataAdapter(wSQL, conn)
        ds = New DataSet
        da.Fill(ds, "LM")

        Return ds

    End Function

    Public Function fRetornaParametroSeguro(ByVal wParam As Object) As String

        If wParam Is Nothing Then
            wParam = ""
        End If

        wParam = Replace(wParam, "'", "")
        wParam = Replace(wParam, "delete", "")

        Return wParam

    End Function

    Public Function fExecutaSQL(ByVal wSQL As String, ByVal wDSN As String, ByVal wMensagemOK As String, ByVal wMensagemErro As String) As String

        Dim conn As SqlConnection
        Dim cmd As SqlCommand
        Dim wResposta As String

        Try
            conn = fAbrirBD(wDSN)
            cmd = New SqlCommand(wSQL, conn)
            cmd.ExecuteNonQuery()
            wResposta = wMensagemOK

        Catch
            wResposta = wMensagemErro & " - " & Err.Description & " - " & Err.Number

            'If Err.Number = 5 Then
            '    wResposta = wMensagemErro
            'End If

        Finally
            conn.Close()
            conn = Nothing
        End Try

        Return wResposta

    End Function
    Public Sub sDesativaComponentes(ByRef wCompontente As WebControl)

        wCompontente.Enabled = False

    End Sub


    Public Function fVerificaExistencia(ByVal wTabela As String, ByVal wCampo As String, ByVal wDado As String, ByVal wCodigoGrupo As String)

        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wResposta As Integer

        wSQL = "Select * from " & wTabela & _
                " where " & wCampo & " = '" & wDado & "'"

        If Not wCodigoGrupo = "" Then

            wSQL += " and cGrupo = " & wCodigoGrupo

        End If

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then
            wResposta = True
        Else
            wResposta = False
        End If

        dr.Close()
        dr = Nothing

        Return wResposta

    End Function

    Public Function fVerificaExistenciaCPF(ByVal wCPF As String)

        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wResposta As Integer

        wSQL = "  SELECT *"
        wSQL += " FROM IG_PESSOAS P"
        wSQL += " LEFT JOIN IG_ORIGENS_PESSOA OP ON P.ID_PESSOA = OP.ID_PESSOA"
        wSQL += " WHERE ( NR_CPF + NR_DIG_CPF = '" & wCPF.Trim & "' ) "

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then
            wResposta = True
        Else
            wResposta = False
        End If

        dr.Close()
        dr = Nothing

        Return wResposta

    End Function


    Public Function fVerificaExistenciaMARC(ByVal wTabela As String, ByVal wCampo As String, ByVal wDado As String, ByVal wCodigoGrupo As String)
        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wResposta As Integer

        wSQL = "Select * from " & wTabela & _
                " where " & wCampo & " like '%" & wDado.Trim & "%'"

        If Not wCodigoGrupo = "" Then

            wSQL += " and cGrupo = " & wCodigoGrupo

        End If

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then
            wResposta = True
        Else
            wResposta = False
        End If

        dr.Close()
        dr = Nothing

        Return wResposta

    End Function

    Public Function fVerificaExistenciaCodigo(ByVal wTabela As String, ByVal wCampo As String, ByVal wCodigo As Integer)
        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wResposta As Integer

        wSQL = "Select * from " & wTabela & _
                " where " & wCampo & " = " & Str(wCodigo)

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then
            wResposta = True
        Else
            wResposta = False
        End If

        dr.Close()
        dr = Nothing

        Return wResposta

    End Function

    Public Function fRetornaValor(ByVal wValor As String)

        wValor = Replace(wValor, ".", "")
        wValor = Replace(wValor, ",", ".")
        Return wValor

    End Function

    Public Function fRetornaPermissao(ByVal wCodigoUsuario As Integer, ByVal wModulo As Integer) As wPermissao

        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wPermissao As New wPermissao

        wSQL = "Select * from tbUsuarioItensMenu, tbItensMenu " & _
                " where (tbUsuarioItensMenu.cItemMenu = tbItensMenu.cItemMenu) and " & _
                " cUsuario = " & wCodigoUsuario & _
                " and tbUsuarioItensMenu.cItemMenu = " & wModulo

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then

            With wPermissao
                .wCodigoUsuario = dr("cUsuario")
                .wCodigoModulo = dr("cItemMenu")
                .wInclusao = dr("cIncluir")
                .wExclusao = dr("cExcluir")
                .wAlteracao = dr("cAlterar")
                .wConsulta = dr("cPesquisar")
                .wMenu = dr("cMenu")
                .wOutros = dr("cOutros")
            End With

        End If

        dr.Close()
        dr = Nothing

        If wCodigoUsuario = 0 Then
            With wPermissao
                .wCodigoUsuario = True
                .wCodigoModulo = True
                .wInclusao = True
                .wExclusao = True
                .wAlteracao = True
                .wConsulta = True
                .wMenu = True
                .wOutros = True
            End With

        End If

        Return wPermissao

    End Function

    Sub sEnviaEmail(ByVal tEmailPara As String, ByVal tEmailDe As String, ByVal tEmailCC As String, ByVal tEmailCCO As String, ByVal wTitulo As String, ByVal wCorpo As String, ByVal wArquivo As String, ByVal wPrioridade As String)

        Dim func As New clsAcessos
        Dim wParametros As New wsCash.wParametrizacoes
        Dim ws As New wsCash.wsCash
        Dim wPortal As New wsCash.wPortal

        ws = func.fRetornaWS()
        wParametros = ws.fParametros
        wPortal = ws.fRetornaPortal(func.fPortal)

        Dim objectoEmail As New MailMessage
        Dim wEmail As String
        Dim wServidorSMTP As String

        If tEmailPara = "" Then
            tEmailPara = ws.fRetornaEmailPortalGrupo(ConfigurationManager.AppSettings("GRUPO"), ConfigurationManager.AppSettings("PORTAL"))
        End If

        If tEmailDe = "" Then
            tEmailDe = ws.fRetornaEmailPortalGrupo(ConfigurationManager.AppSettings("GRUPO"), ConfigurationManager.AppSettings("PORTAL"))
        End If

        wServidorSMTP = ConfigurationManager.AppSettings("SMTPSERVER")
        'wServidorSMTP = "cerebro"

        'Se a ConfiguraÁ„o do Portal possuir o SMTP configurado, iremos utilizar.
        If wPortal.tSmtp = "" Then
            wServidorSMTP = ConfigurationManager.AppSettings("SMTPSERVER")
        Else
            wServidorSMTP = wPortal.tSmtp
        End If

        'wEmail = fLerArquivo(warquivo)
        wEmail = Replace(wCorpo, "<<CORPO>>", wCorpo)

        If wPortal.tEmailSmtp.Trim.Length > 0 Then
            objectoEmail.From = wPortal.tEmailSmtp
        Else
            objectoEmail.From = tEmailDe
        End If

        'objectoEmail.From = tEmailDe
        objectoEmail.To = tEmailPara
        'objectoEmail.From = tEmailDe
        objectoEmail.Cc = tEmailCC
        objectoEmail.Bcc = tEmailCCO
        'tb pode ser MailFormat.Html em vez de MailFormat.Text
        objectoEmail.BodyFormat = MailFormat.Html
        'outras opÁıes s„o High, e Low
        If (wPrioridade = "High") Then
            objectoEmail.Priority = MailPriority.High
        Else
            If (wPrioridade = "Low") Then
                objectoEmail.Priority = MailPriority.Low
            Else
                objectoEmail.Priority = MailPriority.Normal
            End If
        End If
        objectoEmail.Subject = wTitulo
        'objectoEmail.Body = "Viva," & vbCrLf & vbCrLf & "Este È um exemplo de envio de e-mail"
        objectoEmail.Body = wEmail
        'objectoEmail.UrlContentBase = True
        'objectoEmail.UrlContentLocation = True
        'objectoEmail.BodyEncoding = System.Text.Encoding.ASCII

        'If wServidorSMTP.ToUpper.Trim <> "CEREBRO" Then
        '    objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1") 'basic authentication
        '    objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", wParametros.tEmail) 'set your username here
        '    objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", wParametros.tSenha) 'set your password here
        'End If

        If wServidorSMTP.ToUpper.Trim <> "CEREBRO" Then

            If wPortal.tEmailSmtp <> "" Then

                If wPortal.tSmtp.Contains("gmail") Then
                    'UtilizaÁ„o de SSl 
                    objectoEmail.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpusessl") = True
                    objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1") 'basic authentication
                Else
                    objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1") 'basic authentication
                End If

                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", wPortal.tEmailSmtp) 'set your username here
                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", wPortal.tSenhaSmtp) 'set your password here
                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", wPortal.nPorta) 'set your Port here
            Else
                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1") 'basic authentication
                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", wParametros.tEmail) 'set your username here
                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", wParametros.tSenha) 'set your password here
            End If

        End If

        SmtpMail.SmtpServer = wServidorSMTP
        SmtpMail.Send(objectoEmail)

    End Sub

    Function fEnviaEmail(ByVal tEmailPara As String, ByVal tEmailDe As String, ByVal tEmailCC As String, ByVal tEmailCCO As String, ByVal wTitulo As String, ByVal wCorpo As String, ByVal wArquivo As String, ByVal wPrioridade As String) As String

        Try

            Dim func As New clsAcessos
            Dim wParametros As New wsCash.wParametrizacoes
            Dim ws As New wsCash.wsCash

            ws = func.fRetornaWS()
            wParametros = ws.fParametros

            Dim objectoEmail As New MailMessage
            Dim wEmail As String
            Dim wServidorSMTP As String

            wServidorSMTP = ConfigurationManager.AppSettings("SMTPSERVER")
            'wServidorSMTP = "cerebro"

            'wEmail = fLerArquivo(warquivo)
            wEmail = Replace(wCorpo, "<<CORPO>>", wCorpo)

            objectoEmail.To = tEmailPara
            objectoEmail.From = tEmailDe
            objectoEmail.Cc = tEmailCC
            objectoEmail.Bcc = tEmailCCO
            'tb pode ser MailFormat.Html em vez de MailFormat.Text
            objectoEmail.BodyFormat = MailFormat.Html
            'outras opÁıes s„o High, e Low
            If (wPrioridade = "High") Then
                objectoEmail.Priority = MailPriority.High
            Else
                If (wPrioridade = "Low") Then
                    objectoEmail.Priority = MailPriority.Low
                Else
                    objectoEmail.Priority = MailPriority.Normal
                End If
            End If
            objectoEmail.Subject = wTitulo
            'objectoEmail.Body = "Viva," & vbCrLf & vbCrLf & "Este È um exemplo de envio de e-mail"
            objectoEmail.Body = wEmail
            'objectoEmail.UrlContentBase = True
            'objectoEmail.UrlContentLocation = True
            'objectoEmail.BodyEncoding = System.Text.Encoding.ASCII

            If wServidorSMTP.ToUpper.Trim <> "CEREBRO" Then
                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1") 'basic authentication
                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", wParametros.tEmail) 'set your username here
                objectoEmail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", wParametros.tSenha) 'set your password here
            End If

            SmtpMail.SmtpServer = wServidorSMTP
            SmtpMail.Send(objectoEmail)

            Return "E-mail enviado com sucesso"

        Catch ex As Exception

            Return "ERRO : Problemas ao enviar E-mail : " & ex.Message

        End Try

    End Function


    Function fRetornaObjeto(ByVal wCodigo As String) As wObjeto

        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wUser As New wObjeto

        wSQL = "Select * from tbObjetos where cObjeto = " & wCodigo

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then

            With wUser

                .Nome = dr("tObjeto")
                .Codigo = dr("cObjeto")
                .Valor = dr("vObjeto")
                .Observacao = dr("tObservacao")
                .CodigoTipoObjeto = dr("cTipoObjeto")
                If Not dr("tFoto") Is DBNull.Value Then
                    .foto = dr("tFoto")
                End If

            End With

        End If

        dr.Close()
        dr = Nothing

        Return wUser

    End Function

    Function fDataInvertida(ByVal wData As Date) As String

        Dim wDataInvertida

        wDataInvertida = Format(wData, "yyyy/MM/dd")

        Return wDataInvertida

    End Function
    Function fDataInvertidaBase(ByVal wData As String) As String

        Dim wDataIvertidaBase As String


        'wDataIvertidaBase = CType(wData, Date)
        wDataIvertidaBase = FormatDateTime(wData, DateFormat.LongDate)          '"MM-dd-yyyy HH:MM:00").ToString

        Return wDataIvertidaBase

    End Function


    Function fTrasformaTrue(ByVal wTrueFalse As String) As String

        If wTrueFalse = True Then

            wTrueFalse = "Ativo"

        ElseIf wTrueFalse = False Then
            wTrueFalse = "Desativado"

        End If

        Return wTrueFalse

    End Function
    Function fDataDemostra(ByVal wData As Date) As Date

        Dim wDataDemostra As Date

        wDataDemostra = Format(wData, "dd/MM/yyyy HH:mm:s").ToString          '("dd/MM/yyyy  HH:MM:18"))

        Return wData

    End Function
    Function fDataDiaMesAnoComHora(ByVal wData As Date) As Date

        Dim wDataIvertidaBase As Date

        wDataIvertidaBase = CType(wData, Date).ToString("dd-MM-yyyy HH:MM:00")

        Return wData

    End Function

    Function fRetornaData(ByVal wData As Date) As String

        Dim wDataInvertida

        wDataInvertida = Format(wData, "dd/MM/yyyy")

        Return wDataInvertida

    End Function

    Function fTransformaAnoMesDia(ByVal Data As String)

        If Data = "" Then
            Return ""

        Else

            Dim Barra_1, Barra_2 As Integer
            Dim dia, mes, ano As String
            Dim DataCerta As String

            Barra_1 = InStr(1, Data, "/")
            Barra_2 = InStr(Barra_1 + 1, Data, "/")

            dia = Mid(Data, 1, Barra_1 - 1)
            mes = Mid(Data, Barra_1 + 1, Barra_2 - Barra_1 - 1)
            ano = Mid(Data, Barra_2 + 1)

            DataCerta = ano + "/" + mes + "/" + dia
            Return DataCerta

        End If

    End Function

    Function fTransformaMesDiaAno(ByVal Data As String)

        Dim Barra_1, Barra_2 As Integer
        Dim dia, mes, ano, DataCerta As String

        Barra_1 = InStr(1, Data, "/")
        Barra_2 = InStr(Barra_1 + 1, Data, "/")

        dia = Mid(Data, 1, Barra_1 - 1)
        mes = Mid(Data, Barra_1 + 1, Barra_2 - Barra_1 - 1)
        ano = Mid(Data, Barra_2 + 1)

        DataCerta = mes + "/" + dia + "/" + ano

        Return DataCerta

    End Function
    Function fTransformaDiaMesAno(ByVal Data As String)

        Dim Barra_1, Barra_2 As Integer
        Dim dia, mes, ano, DataCerta As String

        Data = CDate(Data)
        dia = Day(Data)
        If dia < 10 Then dia = "0" & CStr(dia)
        mes = Month(Data)

        If mes < 10 Then mes = "0" & CStr(mes)
        ano = Year(Data)

        If ano < 1900 Then ano = ano + 1900

        DataCerta = CStr(dia) + "/" + CStr(mes) + "/" + CStr(ano)

        'Return CStr(dia) & "/" & CStr(mes) & "/" & CStr(ano)

        Return DataCerta

    End Function

    Function fTransformaNumero(ByVal wNumero As Double)

        Dim wNumeroFormatado

        wNumeroFormatado = wNumero.ToString("#############0.00")

        wNumeroFormatado = Replace(wNumeroFormatado, ".", ",")

        Return wNumeroFormatado

    End Function

    Function fLerArquivo_old()

        Dim wArquivo As String
        Dim wTexto As StreamReader
        Dim wEmail As String
        Dim wData As String

        wData = fRetornaDataCompleta()

        wArquivo = ConfigurationSettings.AppSettings("Comunicados") & "comunicado.asp"

        wTexto = File.OpenText(wArquivo)
        wEmail = wTexto.ReadToEnd

        wTexto.Close()

        'Replace da Data pela data do dia
        wEmail = Replace(wEmail, "<<DATA>>", wData)

        Return wEmail

    End Function

    Function fRetornaDataCompleta()

        'DeclaraÁ„o das vari·veis
        Dim texto, titulo, diasemana

        'Vari·vel data din‚mica
        diasemana = Weekday(Now)

        Select Case diasemana
            Case 1
                diasemana = "Domingo"
            Case 2
                diasemana = "Segunda-feira"
            Case 3
                diasemana = "TerÁa-feira"
            Case 4
                diasemana = "Quarta-feira"
            Case 5
                diasemana = "Quinta-feira"
            Case 6
                diasemana = "Sexta-feira"
            Case 7
                diasemana = "S·bado"
        End Select

        Dim dia, mes, ano As String

        dia = Date.Now.Day
        mes = Date.Now.Month
        ano = Date.Now.Year

        If Len(dia) = 1 Then
            dia = "0" & dia
        End If

        If Len(mes) = 1 Then
            mes = "0" & mes
        End If

        If Len(ano) = 4 Then
            'substring
            ano = Mid(ano, 1, 4)
        End If

        Return dia & "/" & mes & "/" & ano

    End Function

    Function fVerificaExistencia(ByVal wTabela As String, ByVal wCampo As String, ByVal wDado As String)

        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wResposta As Integer

        wSQL = "Select * from " & wTabela & " where " & wCampo & " = '" & wDado & "'"

        Try
            dr = fRetornaDataReader(wSQL)

            If dr.Read Then
                wResposta = True
            Else
                wResposta = False
            End If

        Finally
            dr.Close()
            dr = Nothing

        End Try

        Return wResposta

    End Function

    Public Function fRetornaStringSegura(ByVal wString As String)

        wString = Replace(wString, "'", "")

        Return wString

    End Function

    Sub sSetaCombo(ByVal wCombo As DropDownList, ByVal wValor As Integer)
        ''Apontar para o item correto na Combo
        With wCombo
            Dim objItemCombo As ListItem
            objItemCombo = .Items.FindByValue(wValor)
            If Not IsNothing(objItemCombo) Then
                .SelectedIndex = .Items.IndexOf(objItemCombo)
            End If
        End With
    End Sub

    Sub sSetaCombo(ByVal wCombo As DropDownList, ByVal wValor As String)
        ''Apontar para o item correto na Combo
        With wCombo
            Dim objItemCombo As ListItem
            objItemCombo = .Items.FindByValue(wValor)
            If Not IsNothing(objItemCombo) Then
                .SelectedIndex = .Items.IndexOf(objItemCombo)
            End If
        End With
    End Sub

    Sub sSetaComboStr(ByVal wCombo As DropDownList, ByVal wValor As String)
        ''Apontar para o item correto na Combo
        With wCombo
            Dim objItemCombo As ListItem
            objItemCombo = .Items.FindByText(wValor)
            If Not IsNothing(objItemCombo) Then
                .SelectedIndex = .Items.IndexOf(objItemCombo)
            End If
        End With
    End Sub

    '----------------------------------------------------------------------------------------------
    ' FUNCOES DE SUPORTE E CONVERS√O
    '----------------------------------------------------------------------------------------------
    ' DateToBaan - Converte uma data no formato brasileiro (dd/mm/aaaa) para o formato Baan (d)
    '----------------------------------------------------------------------------------------------
    Function DateToBaan(ByVal OriginalDate As Date)

        DateToBaan = DateDiff("d", "01/01/0100", OriginalDate) + 36160

    End Function

    '----------------------------------------------------------------------------------------------
    ' BaanToOracle - Converte um nome de tabela do formato Baan para o formato Oracle
    '----------------------------------------------------------------------------------------------
    Function BaanToOracle(ByVal BaanName As String, ByVal wCompanyNumber As String)

        BaanToOracle = "baandb.t" & BaanName & wCompanyNumber
        'BaanToOracle = "t" &BaanName & Application("CompanyNumber")

    End Function

    '*******************************************************************************
    '* FunÁıes convers„o Baan para Database Baan
    '*******************************************************************************

    '----------------------------------------------------------------------------------------------
    ' DBTN - DataBase Table Name - recebe o nome da tabela no baan e retorna o nome da tabela no
    ' banco de dados
    '----------------------------------------------------------------------------------------------
    Function DBTN(ByVal BaanTableName As String, ByVal wAmbiente As String, ByVal wCompany As String)

        Select Case wAmbiente
            Case "ORACLE"
                DBTN = DBTN_OracleBaan(BaanTableName, wCompany)
            Case "SQL"
                DBTN = DBTN_Access(BaanTableName, wCompany)
            Case "ACCESS"
                DBTN = DBTN_Access(BaanTableName, wCompany)
            Case Else
                DBTN = BaanTableName
        End Select
    End Function

    Function DBTN_OracleBaan(ByVal BaanTableName As String, ByVal wCompany As String)
        Select Case Len(BaanTableName)
            Case 8
                DBTN_OracleBaan = "baandb.t" & BaanTableName & wCompany
            Case 9
                DBTN_OracleBaan = "baandb." & BaanTableName & wCompany
            Case Else
                DBTN_OracleBaan = BaanTableName
        End Select
    End Function

    Function DBTN_Access(ByVal BaanTableName As String, ByVal wCompany As String)
        Select Case Len(BaanTableName)
            Case 8
                DBTN_Access = "t" & BaanTableName
            Case 9
                DBTN_Access = "" & BaanTableName
            Case Else
                DBTN_Access = BaanTableName
        End Select
    End Function

    '----------------------------------------------------------------------------------------------
    ' DBTNC - DataBase Table Name w/ Company - recebe o nome e companhia da tabela no baan
    ' e retorna o nome da tabela no banco de dados
    '----------------------------------------------------------------------------------------------
    Function DBTNC(ByVal BaanTableName As String, ByVal Company As String, ByVal wAmbiente As String)
        Select Case wAmbiente
            Case "ORACLE"
                DBTNC = DBTNC_OracleBaan(BaanTableName, Company)
            Case "SQL"
                DBTNC = DBTNC_Access(BaanTableName, Company)
            Case "ACCESS"
                DBTNC = DBTNC_Access(BaanTableName, Company)
            Case Else
                DBTNC = BaanTableName
        End Select
    End Function

    Function DBTNC_OracleBaan(ByVal BaanTableName As String, ByVal Company As String)
        Dim strCompany As String

        strCompany = Right("000" & Trim(CStr(Company)), 3)

        Select Case Len(BaanTableName)
            Case 8
                DBTNC_OracleBaan = "baandb.t" & BaanTableName & strCompany
            Case 9
                DBTNC_OracleBaan = "baandb." & BaanTableName & strCompany
            Case Else
                DBTNC_OracleBaan = BaanTableName
        End Select
    End Function

    Function DBTNC_Access(ByVal BaanTableName, ByVal Company)

        Dim strCompany As String

        strCompany = Right("000" & Trim(CStr(Company)), 3)
        Select Case Len(BaanTableName)
            Case 8
                DBTNC_Access = "baan_t" & BaanTableName & strCompany
            Case 9
                DBTNC_Access = "baan_" & BaanTableName & strCompany
            Case Else
                DBTNC_Access = BaanTableName
        End Select
    End Function

    '----------------------------------------------------------------------------------------------
    ' DBFN - DataBase Field Name - recebe o nome do campo no baan e retorna o nome do campo no
    ' banco de dados.
    '----------------------------------------------------------------------------------------------
    Function DBFN(ByVal BaanFieldName As String, ByVal wAmbiente As String, ByVal wCompany As String)
        Select Case wAmbiente
            Case "ORACLE"
                DBFN = DBFN_OracleBaan(BaanFieldName, wAmbiente, wCompany)
            Case "SQL"
                DBFN = DBFN_Access(BaanFieldName, wAmbiente, wCompany)
            Case "ACCESS"
                DBFN = DBFN_Access(BaanFieldName, wAmbiente, wCompany)
            Case Else
                DBFN = BaanFieldName
        End Select
    End Function

    Function DBFN_OracleBaan(ByVal BaanFieldName As String, ByVal wAmbiente As String, ByVal wCompany As String)
        Dim DotPosition As Integer
        Dim TableName As String
        Dim FieldName As String

        BaanFieldName = CStr(BaanFieldName)

        If Len(BaanFieldName) < 9 Then
            DBFN_OracleBaan = "T$" & Replace(BaanFieldName, ".", "$")
        Else
            DotPosition = InStr(BaanFieldName, ".")
            If DotPosition > 0 Then
                TableName = Mid(BaanFieldName, 1, DotPosition - 1)
                FieldName = Mid(BaanFieldName, DotPosition + 1, 999)
                DBFN_OracleBaan = DBTN(TableName, wAmbiente, wCompany) & "." & DBFN_OracleBaan(FieldName, wAmbiente, wCompany)
            Else
                DBFN_OracleBaan = ""
            End If
        End If
        DBFN_OracleBaan = Replace(DBFN_OracleBaan, "(", "$")
        DBFN_OracleBaan = Replace(DBFN_OracleBaan, ")", "")
        'DBFN_OracleBaan = DBFN_OracleBaan & " as " & BaanFieldName
    End Function

    Function DBFN_Access(ByVal BaanFieldName As String, ByVal wAmbiente As String, ByVal wCompany As String)
        Dim DotPosition As Integer
        Dim TableName As String
        Dim FieldName As String

        BaanFieldName = CStr(BaanFieldName)

        If Len(BaanFieldName) < 9 Then
            DBFN_Access = "T_" & Replace(BaanFieldName, ".", "_")
        Else
            DotPosition = InStr(BaanFieldName, ".")
            If DotPosition > 0 Then
                TableName = Mid(BaanFieldName, 1, DotPosition - 1)
                FieldName = Mid(BaanFieldName, DotPosition + 1, 999)
                DBFN_Access = DBTN(TableName, wAmbiente, wCompany) & "." & DBFN_Access(FieldName, wAmbiente, wCompany)
                'DBFN_Access = DBTN(TableName, wAmbiente, wCompany) & "." & FieldName
            Else
                DBFN_Access = ""
            End If
        End If
        DBFN_Access = Replace(DBFN_Access, "(", "_")
        DBFN_Access = Replace(DBFN_Access, ")", "")
        'DBFN_Access = DBFN_Access & " as " & FieldName
    End Function

    '----------------------------------------------------------------------------------------------
    ' DBDTCMP - DataBase Date Compare - gera a string para comparacao de datas no Banco de Dados
    '----------------------------------------------------------------------------------------------

    Function DBDTCMP(ByVal iField As String, ByVal iOperator As String, ByVal iDate As Object, ByVal wAmbiente As String)
        Select Case wAmbiente
            Case "ORACLE"
                DBDTCMP = DBDTCMP_OracleBaan(iField, iOperator, iDate, wAmbiente)
            Case "SQL"
                DBDTCMP = DBDTCMP_Access(iField, iOperator, iDate)
            Case "ACCESS"
                DBDTCMP = DBDTCMP_Access(iField, iOperator, iDate)
            Case Else
                DBDTCMP = ""
        End Select
    End Function

    Function DBDTCMP_OracleBaan(ByVal iField As String, ByVal iOperator As String, ByVal iDate As Object, ByVal wAmbiente As String)
        Select Case iOperator
            Case "="
                If iDate = 0 Then
                    'No Baan, data igual a zero gera data negativa no Oracle
                    DBDTCMP_OracleBaan = iField & " < TO_DATE('0001-01-01', 'YYYY-MM-DD')"
                Else
                    DBDTCMP_OracleBaan = iField & " = TO_DATE('" _
                         & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) _
                         & "', 'YYYY-MM-DD')"
                End If
            Case Else
                DBDTCMP_OracleBaan = iField & iOperator & "TO_DATE('" _
                     & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) _
                     & "', 'YYYY-MM-DD')"
        End Select
    End Function

    Function DBDTCMP_SQL(ByVal iField As String, ByVal iOperator As String, ByVal iDate As Object)

        If iDate Is DBNull.Value Then
            'Para simular o Baan, usamos datas vazias como 31/12/1899
            iDate = DateSerial(1899, 12, 31)
        End If

        Select Case iOperator
            Case "="
                'DBDTCMP_Access = iField & "= #" & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) & "#"
                DBDTCMP_SQL = iField & "= '" & Year(iDate) & "/" & Month(iDate) & "/" & Day(iDate) & "'"
            Case Else
                'DBDTCMP_Access = iField & iOperator & " #" & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) & "#"
                DBDTCMP_SQL = iField & iOperator & " '" & Year(iDate) & "/" & Month(iDate) & "/" & Day(iDate) & "'"
        End Select
    End Function

    Function DBDTCMP_Access(ByVal iField As String, ByVal iOperator As String, ByVal iDate As Object)

        If iDate Is DBNull.Value Then
            'Para simular o Baan, usamos datas vazias como 31/12/1899
            iDate = DateSerial(1899, 12, 31)
        End If

        Select Case iOperator
            Case "="
                DBDTCMP_Access = iField & "= #" & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) & "#"
                'DBDTCMP_Access = iField & "= '" & Year(iDate) & "/" & Month(iDate) & "/" & Day(iDate) & "'"
            Case Else
                DBDTCMP_Access = iField & iOperator & " #" & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) & "#"
                'DBDTCMP_Access = iField & iOperator & " '" & Year(iDate) & "/" & Month(iDate) & "/" & Day(iDate) & "'"
        End Select
    End Function

    '----------------------------------------------------------------------------------------------
    ' DBDATE - Retorna String para informaÁ„o de data ao banco de dados
    '----------------------------------------------------------------------------------------------
    Function DBDATE(ByVal iDate As Object, ByVal wAmbiente As String)
        Select Case wAmbiente
            Case "ORACLE"
                DBDATE = DBDATE_OracleBaan(iDate)
            Case "SQL"
                DBDATE = DBDATE_SQL(iDate)
            Case "ACCESS"
                DBDATE = DBDATE_ACCESS(iDate)
            Case Else
                DBDATE = ""
        End Select
    End Function

    Function DBDATE_OracleBaan(ByVal iDate As Object)
        DBDATE_OracleBaan = "TO_DATE('" & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) _
             & "', 'YYYY-MM-DD')"
    End Function

    Function DBDATE_SQL(ByVal iDate As Object)
        If Not IsDate(iDate) Then
            If iDate = 0 Then
                'Para simular o Baan, usamos datas vazias como 31/12/1899
                iDate = DateSerial(1899, 12, 31)
            End If
        End If
        'DBDATE_SQL = "#" & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) & "#"
        DBDATE_SQL = "'" & Year(iDate) & "/" & Month(iDate) & "/" & Day(iDate) & "'"
    End Function

    Function DBDATE_ACCESS(ByVal iDate As Object)
        If Not IsDate(iDate) Then
            If iDate = 0 Then
                'Para simular o Baan, usamos datas vazias como 31/12/1899
                iDate = DateSerial(1899, 12, 31)
            End If
        End If
        DBDATE_ACCESS = "#" & Year(iDate) & "-" & Month(iDate) & "-" & Day(iDate) & "#"
        'DBDATE_SQL = "'" & Year(iDate) & "/" & Month(iDate) & "/" & Day(iDate) & "'"
    End Function

    '----------------------------------------------------------------------------------------------
    ' DBFCUPPER - DB Function Upper - Retorna a funcao UPPER para o Banco de Dados
    '----------------------------------------------------------------------------------------------

    Function DBFCUPPER(ByVal iField As String, ByVal wAmbiente As String)
        Select Case wAmbiente
            Case "ORACLE"
                DBFCUPPER = "UPPER('" & iField & "')"
            Case "SQL"
                DBFCUPPER = "UCASE('" & iField & "')"
            Case "ACCESS"
                DBFCUPPER = "UCASE('" & iField & "')"
            Case Else
                DBFCUPPER = ""
        End Select
    End Function

    '----------------------------------------------------------------------------------------------
    ' TimeToLong - Retorna hora, minuto e segundo como Long no formato HHMMSS
    '----------------------------------------------------------------------------------------------
    Function TimeToLong(ByVal iDate)
        TimeToLong = Hour(iDate) * 10000 + Minute(iDate) * 100 + Second(iDate)
    End Function

    '----------------------------------------------------------------------------------------------
    ' MinimumDate - data mÌnima para entrada de cotaÁıes
    '----------------------------------------------------------------------------------------------
    Function MinimumDate()
        MinimumDate = DateAdd(DateInterval.Day, 2, Date.Today)
    End Function

    '----------------------------------------------------------------------------------------------
    ' CleanString - Limpa string para permitir entrada no Banco de dados
    '----------------------------------------------------------------------------------------------
    Function CleanString(ByVal iString)
        CleanString = Replace(iString, "'", "''")
    End Function

    Function fLerArquivo(ByVal wArquivo As String)

        'Dim wTexto As StreamReader
        Dim wEmail As String
        Dim wData As String
        Dim wPagina As String

        wData = fRetornaDataCompleta()

        wArquivo = ConfigurationSettings.AppSettings("Comunicados") & wArquivo

        'Default
        Dim reader As New StreamReader(wArquivo, System.Text.Encoding.Default)
        reader = File.OpenText(wArquivo)
        wEmail = reader.ReadToEnd
        reader.Close()
        wPagina += "Default" & wEmail

        'BigEndianUnicode
        Dim reader1 As New StreamReader(wArquivo, System.Text.Encoding.BigEndianUnicode)
        reader1 = File.OpenText(wArquivo)
        wEmail = reader1.ReadToEnd
        reader1.Close()
        wPagina += "BigEndianUnicode" & wEmail

        'ASCII
        Dim reader2 As New StreamReader(wArquivo, System.Text.Encoding.ASCII)
        reader2 = File.OpenText(wArquivo)
        wEmail = reader2.ReadToEnd
        reader2.Close()
        wPagina += "ASCII" & wEmail

        'Unicode
        Dim reader3 As New StreamReader(wArquivo, System.Text.Encoding.Unicode)
        reader3 = File.OpenText(wArquivo)
        wEmail = reader3.ReadToEnd
        reader3.Close()
        wPagina += "Unicode" & wEmail

        'UTF7
        Dim reader4 As New StreamReader(wArquivo, System.Text.Encoding.UTF7)
        reader4 = File.OpenText(wArquivo)
        wEmail = reader4.ReadToEnd
        reader4.Close()
        wPagina += "UTF7" & wEmail

        'UTF8
        Dim reader5 As New StreamReader(wArquivo, System.Text.Encoding.UTF8)
        reader5 = File.OpenText(wArquivo)
        wEmail = reader5.ReadToEnd
        reader5.Close()
        wPagina += "UTF8" & wEmail

        'Replace da Data pela data do dia
        wEmail = Replace(wEmail, "<<DATA>>", wData)

        Return wPagina

    End Function

    Sub sEnviaEmail_old(ByVal tEmailPara As String, ByVal tEmailDe As String, ByVal tEmailCC As String, ByVal tEmailCCO As String, ByVal wTitulo As String, ByVal wCorpo As String, ByVal wArquivo As String)

        Dim objectoEmail As New MailMessage
        Dim wEmail As String

        'wEmail = fLerArquivo(wArquivo)
        wEmail = Replace(wCorpo, "<<CORPO>>", wCorpo)

        objectoEmail.To = tEmailPara
        objectoEmail.From = tEmailDe
        objectoEmail.Cc = tEmailCC
        objectoEmail.Bcc = tEmailCCO
        'tb pode ser MailFormat.Html em vez de MailFormat.Text
        objectoEmail.BodyFormat = MailFormat.Html
        'outras opÁıes s„o High, e Low
        objectoEmail.Priority = MailPriority.Normal
        objectoEmail.Subject = wTitulo
        'objectoEmail.Body = "Viva," & vbCrLf & vbCrLf & "Este È um exemplo de envio de e-mail"
        objectoEmail.Body = wEmail

        SmtpMail.SmtpServer = "cerebro"

        SmtpMail.Send(objectoEmail)

    End Sub

    Function TirarAcento(ByVal Palavra)

        Dim CAcento As String = "‡·‚„‰ËÈÍÎÏÌÓÔÚÛÙıˆ˘˙˚¸¿¡¬√ƒ»… ÀÃÕŒ“”‘’÷Ÿ⁄€‹Á«Ò—"
        Dim SAcento As String = "aaaaaeeeeiiiiooooouuuuAAAAAEEEEIIIOOOOOUUUUcCnN"
        Dim Texto As String = ""
        Dim Letra As String
        Dim Pos_Acento As String
        Dim x As Integer

        If Palavra <> "" Then
            For x = 1 To Len(Palavra)
                Letra = Mid(Palavra, x, 1)
                Pos_Acento = InStr(CAcento, Letra)
                If Pos_Acento > 0 Then Letra = Mid(SAcento, Pos_Acento, 1)
                Texto = Texto & Letra
            Next
            TirarAcento = Texto
        End If
    End Function

    Function TrocarAcento(ByVal Palavra)

        Dim CAcento As String = "‡·‚„‰ËÈÍÎÏÌÓÔÚÛÙıˆ˘˙˚¸¿¡¬√ƒ»… ÀÃÕŒ“”‘’÷Ÿ⁄€‹Á«Ò—"
        Dim SAcento As String = "aaaaaeeeeiiiiooooouuuuAAAAAEEEEIIIOOOOOUUUUcCnN"
        Dim Texto As String = ""
        Dim Letra As String
        Dim Pos_Acento As String
        Dim x As Integer

        CAcento = "‡·‚„‰ËÈÍÎÏÌÓÔÚÛÙıˆ˘˙˚¸¿¡¬√ƒ»… ÀÃÕŒ“”‘’÷Ÿ⁄€‹Á«Ò—"
        Texto = ""
        If Palavra <> "" Then
            For x = 1 To Len(Palavra)
                Letra = Mid(Palavra, x, 1)
                Pos_Acento = InStr(CAcento, Letra)
                If Pos_Acento > 0 Then Letra = "_"
                Texto = Texto & Letra
            Next
            TrocarAcento = Texto
        End If
    End Function

    Public Function fCarregaCliente_old(ByVal wCodigoCliente As String) As wCliente

        Dim wSQL As String
        Dim wCliente As New wCliente
        Dim dr As SqlDataReader

        wSQL = "Select * from tbClientes where cCliente = " & wCodigoCliente

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then

            With wCliente

                .Codigo = dr("cCliente")
                .Grupo = dr("cGrupo")
                .nome = dr("tCliente")
                .nomefantasia = dr("tNomeFantasia")
                .endereco = dr("tEndereco")
                .bairro = dr("tBairro")
                .cidade = dr("tCidade")
                .estado = dr("tEstado")
                .CEP = dr("tCEP")
                .telefone = dr("tTelefone")
                .emailadm = dr("tEmailAdm")
                .emailcobranca = dr("tEmailCobranca")
                .CNPJCPF = dr("tCNPJCPF")
                .INSCRESTADUAL = dr("tInscricaoEstadual")
                .INSCRMUNICIPAL = dr("tInscricaoMunicipal")
                .DataAlteracao = dr("dAlteracao")
                .Status = dr("cStatus")

            End With

        End If

        dr.Close()
        dr = Nothing

        Return wCliente

    End Function

    Function fFormataCNPJ(ByVal wCNPJ As String)

        Dim wTamanho As Integer
        Dim wLetra As String
        Dim wContador, wContador2 As Integer
        Dim wNovoCNPJ As String

        If wCNPJ Is Nothing Then

            wNovoCNPJ = "99.999.999/0001-99"

        Else
            wTamanho = wCNPJ.Length
            wContador2 = 0

            For wContador = wTamanho To 1 Step -1

                wLetra = Mid(wCNPJ, wContador, 1)
                wContador2 += 1

                If wContador2 = 3 Then
                    wLetra = "." & wLetra
                    wContador2 = 0
                End If

                wNovoCNPJ = wNovoCNPJ & wLetra

            Next

        End If

        Return wNovoCNPJ

    End Function

    Function fRetornaUltimoPerfil()

        Dim wSQL As String
        Dim wCodigoPerfil As String
        Dim dr As SqlDataReader

        wSQL = "Select Max(cPerfil) as cPerfil from tbPerfis "

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then
            If Not dr("cPerfil") Is DBNull.Value Then
                wCodigoPerfil = dr("cPerfil")
            Else
                wCodigoPerfil = ""
            End If
        Else
            wCodigoPerfil = ""

        End If

        dr.Close()
        dr = Nothing

        Return wCodigoPerfil

    End Function


    Function fRetornaUltimaRef()

        Dim wSQL As String
        Dim wRef As String
        Dim dr As SqlDataReader

        wSQL = "Select Max(t_ref) as REF from tbPedidosCotacoes "

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then
            If Not dr("ref") Is DBNull.Value Then
                wRef = dr("ref")
            Else
                wRef = ""
            End If
        Else
            wRef = ""
        End If

        dr.Close()
        dr = Nothing

        Return wRef

    End Function

    Function fRetornaUltimoMARC() As Integer

        Dim wSQL As String
        Dim wRef As String
        Dim dr As SqlDataReader

        wSQL = "Select Max(cLeader) as cLeader from tbLeaders "

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then
            If Not dr("cLeader") Is DBNull.Value Then
                wRef = dr("cLeader")
            Else
                wRef = 0
            End If
        Else
            wRef = 0
        End If

        dr.Close()
        dr = Nothing

        Return wRef

    End Function

    Function fRetornaUltimaImportacao()

        Dim wSQL As String
        Dim wCodigoMaterial As String
        Dim dr As SqlDataReader

        wSQL = "Select Max(cMaterial) as cMaterial from tbMateriais"

        dr = fRetornaDataReader(wSQL)

        If dr.Read Then
            If Not dr("cMaterial") Is DBNull.Value Then
                wCodigoMaterial = dr("cMaterial")
            Else
                wCodigoMaterial = "Novo"
            End If
        Else
            wCodigoMaterial = "Novo"
        End If

        dr.Close()
        dr = Nothing

        Return wCodigoMaterial

    End Function


    Function fRetornaOndeEsta(ByVal wCodigoItemMenu As String) As String

        Dim wSQL As String
        Dim func As New Funcoes
        Dim dr As SqlDataReader
        Dim wOndeEsta As String = String.Empty
        Dim wOpcao As String

        If wCodigoItemMenu = "" Then
            wOndeEsta = ""
        Else
            wSQL = "Select * from vwMenus where cItemMenu = " & wCodigoItemMenu

            dr = func.fRetornaDataReader(wSQL)

            If dr.Read Then

                wOpcao = UCase(dr("tItemMenu"))

                If InStr(wOpcao, "HOME") <> 0 Then 'J· existe uma opÁ„o HOME
                    wOndeEsta = "VocÍ est· em <a href='lmPesquisarAcervo.aspx'>HOME</a>"
                Else
                    wOndeEsta = "VocÍ est· em <a href='lmPesquisarAcervo.aspx'>HOME</a> : <a href='" & dr("tPagina") & "'>" & UCase(dr("tMenu")) & " : " & UCase(dr("tItemMenu")) & "</a>"
                End If

                wOndeEsta = "VocÍ est· em " & UCase(dr("tMenu")) & " : " & UCase(dr("tItemMenu")) & "</a>"

            End If

            dr.Close()
            dr = Nothing

        End If

        Return wOndeEsta

    End Function

    Function fRetornaCodigoPagina(ByVal wPagina As String) As String

        Dim wSQL As String
        Dim func As New Funcoes
        Dim dr As SqlDataReader

        wSQL = "Select * from tbItensMenu where tPagina = '" & wPagina & "'"

        dr = func.fRetornaDataReader(wSQL)

        If dr.Read Then
            Return dr("cItemMenu")
        End If

        dr.Close()
        dr = Nothing

    End Function

    Function fGeraSalt()

        Dim rng As New RNGCryptoServiceProvider
        Dim buff() As Byte = New Byte(16) {}

        rng.GetBytes(buff)
        Return Convert.ToBase64String(buff)

    End Function

    Function fGeraSenha(ByVal wSenha As String, ByVal wSalt As String)

        Return FormsAuthentication.HashPasswordForStoringInConfigFile(wSenha & wSalt, "SHA1")

        'lblMD5.Text = "MD5: " & _
        'FormsAuthentication.HashPasswordForStoringInConfigFile(txtSenha.Text & lblRandom.Text, "MD5")

    End Function

    Public Function fGravarSumario(ByVal wAcao As String, ByVal wCodigoLeader As String, ByVal wSumario As String)

        Dim wSQL As String
        Dim func As New Funcoes
        Dim dr As SqlDataReader
        Dim wResposta As String

        wSumario = func.fEliminaApostrofo(wSumario)

        Try
            'Gravamos o Sum·rio
            Select Case wAcao

                Case "A" 'Alterar

                    wSQL = "Update tbLeaders set tSumario = '" & Trim(wSumario) & "'" & _
                                " where cLeader = " & wCodigoLeader

                    wResposta = func.fExecutaSQL(wSQL, "SQL", "Sucesso", "Erro")


                Case "I" 'Incluir

                    wSQL = "SELECT Max([tbObjetos].[cObjeto]) AS cObjeto FROM tbObjetos;"

                    dr = func.fRetornaDataReader(wSQL)

                    If dr.Read() Then

                        wCodigoLeader = dr("cObjeto")

                    End If

                    dr.Close()
                    dr = Nothing

                    wSQL = "Update tbLeaders set tSumario = '" & Trim(wSumario) & "'" & _
                            " where cObjeto = " & wCodigoLeader

                    wResposta = func.fExecutaSQL(wSQL, "SQL", "Sucesso", "Erro")

            End Select

        Catch ex As Exception
            'Se der algum erro, exibimos a mensagem 
            wResposta = "H· erros!. " & ex.Message

        End Try

        Return wResposta

    End Function


    Sub sCarregaImagem(ByVal wCodigoLeader As String, ByVal imgFoto As Image, ByVal wURL As String)

        Dim func As New Funcoes
        Dim wSQL As String
        Dim dr As SqlDataReader

        wSQL = "Select * from tbLeaders where cLeader = " & wCodigoLeader

        dr = func.fRetornaDataReader(wSQL)

        If dr.Read Then

            If dr("tFoto") Is DBNull.Value Then

                'Caso o registro n„o tenha imagem uma foto padr„o È colocada
                imgFoto.ImageUrl = "http://" & wURL & ConfigurationSettings.AppSettings("URLFotos") & "padrao.gif"
                'imgFoto.Width = Unit.Pixel(130)

            Else

                'Caso o registro tenha imagem a sua foto È colocada
                imgFoto.ImageUrl = "http://" & wURL & ConfigurationSettings.AppSettings("URLFotos") & dr("tFoto")
                imgFoto.Width = Unit.Pixel(130)

            End If

        End If

        dr.Close()
        dr = Nothing

    End Sub

    Function fCarregaImagem(ByVal wCodigoLeader As String, ByVal wURL As String) As String

        Dim func As New Funcoes
        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wImagem As String

        wSQL = "Select * from tbLeaders where cLeader = " & wCodigoLeader

        dr = func.fRetornaDataReader(wSQL)

        If dr.Read Then

            If dr("tFoto") Is DBNull.Value Then

                'Caso o registro n„o tenha imagem uma foto padr„o È colocada
                wImagem = "http://" & wURL & ConfigurationSettings.AppSettings("URLFotos") & "padrao.gif"
                'imgFoto.Width = Unit.Pixel(130)

            Else

                'Caso o registro tenha imagem a sua foto È colocada
                wImagem = "http://" & wURL & ConfigurationSettings.AppSettings("URLFotos") & dr("tFoto")

            End If

        End If

        dr.Close()
        dr = Nothing

        Return wImagem

    End Function

    Function fCarregaSumario(ByVal wCodigoLeader As String)

        Dim func As New Funcoes
        Dim wSQL As String
        Dim dr As SqlDataReader

        wSQL = "Select * from tbLeaders where cLeader = " & wCodigoLeader

        dr = func.fRetornaDataReader(wSQL)

        Try

            If dr.Read Then

                If dr("tSumario") Is DBNull.Value Then
                    Return ""
                Else
                    Return dr("tSumario")
                End If

            Else

                Return ""

            End If

        Finally

            dr.Close()
            dr = Nothing

        End Try

    End Function

    Function fConfiguraTextArea(ByVal wTexto As String)

        wTexto = Replace(wTexto, Chr(13), "<br>")

        Return wTexto

    End Function

    Function fMarcaTexto(ByVal wTexto As String, ByVal wPalavras As String)

        Dim wArray(100) As String
        Dim wContador As Integer

        wArray = Split(wPalavras, " ")

        For wContador = 0 To wArray.GetUpperBound(0)

            If wArray(wContador) Is Nothing Then
                Exit For
            End If

            wTexto = Replace(wTexto.ToUpper, wArray(wContador), "<span style='BACKGROUND-COLOR: #ffff00'>" & wArray(wContador) & "</span>")

        Next

        'Return Replace(wTexto.ToUpper, UCase(Session("wSumario")), "<span style='BACKGROUND-COLOR: #ffff00'>" & UCase(Session("wSumario")) & "</span>")

        Return wTexto

    End Function

    Function fRetornaSQLparaSumario(ByVal wPalavras As String)

        Dim wArray(100) As String
        Dim wContador As Integer
        Dim wTexto As String

        wArray = Split(wPalavras, " ")

        wTexto = " and ( "

        For wContador = 0 To wArray.GetUpperBound(0)

            If wContador = 0 Then
                wTexto += " tSumario like '%" & fPreparaPalavra(wArray(wContador).Trim) & "%' "
            Else
                wTexto += " and tSumario like '%" & fPreparaPalavra(wArray(wContador).Trim) & "%' "
            End If


        Next

        'wTexto = Mid(wTexto, 5, Len(wTexto) - 5)
        wTexto += " )"
        'Return Replace(wTexto.ToUpper, UCase(Session("wSumario")), "<span style='BACKGROUND-COLOR: #ffff00'>" & UCase(Session("wSumario")) & "</span>")

        Return wTexto

    End Function

    Sub sCarregaDias(ByVal wCombo As DropDownList)

        Dim i As Integer

        With wCombo

            For i = 1 To 31
                .Items.Add(New ListItem(i, i))
            Next

        End With

    End Sub

    Sub sCarregaMeses(ByVal wCombo As DropDownList)

        Dim i As Integer

        With wCombo

            For i = 1 To 12
                .Items.Add(New ListItem(fRetornaMes(i), i))
            Next

        End With

    End Sub
    Function fRetornaMes(ByVal wMes As Integer) As String
        'Melhoria no thread de processamento
        'CorreÁ„o~de crÌtica: 06/05/09 - by Marcos R. Caso
        If wMes < 7 Then
            If wMes < 4 Then
                If wMes = 1 Then
                    Return "Janeiro"
                ElseIf wMes = 2 Then
                    Return "Fevereiro"
                Else
                    Return "MarÁo"
                End If
            Else
                If wMes = 4 Then
                    Return "Abril"
                ElseIf wMes = 5 Then
                    Return "Maio"
                Else
                    Return "Junho"
                End If
            End If
        Else
            If wMes < 10 Then
                If wMes = 7 Then
                    Return "Julho"
                ElseIf wMes = 8 Then
                    Return "Agosto"
                Else
                    Return "Setembro"
                End If
            Else
                If wMes = 10 Then
                    Return "Outubro"
                ElseIf wMes = 11 Then
                    Return "Novembro"
                Else
                    Return "Dezembro"
                End If
            End If
        End If
    End Function

    Sub sCarregaCombo(ByVal wSQL As String, ByRef wCombo As DropDownList, ByVal wCampoData As String, ByVal wCampoValor As String, ByVal wTodos As String)

        Dim func As New Funcoes
        Dim dr As SqlDataReader

        wCombo.Items.Clear()

        dr = func.fRetornaDataReader(wSQL)

        Try
            With wCombo

                .Items.Add(New ListItem(wTodos, "0"))

                Do While dr.Read()
                    .Items.Add(New ListItem(dr(wCampoData), dr(wCampoValor)))
                Loop

            End With

        Finally
            dr.Close()
            dr = Nothing

        End Try
    End Sub

    Sub sCarregaCombo(ByVal wSQL As String, ByRef wCombo As DropDownList, ByVal wCampoData As String, ByVal wCampoValor As String)

        Dim func As New Funcoes
        Dim dr As SqlDataReader

        dr = func.fRetornaDataReader(wSQL)

        With wCombo
            .DataValueField = wCampoValor.Trim()
            .DataTextField = wCampoData
            .DataSource = dr
            .DataBind()
        End With

        dr.Close()
        dr = Nothing

    End Sub

    Sub sCarregaCombo(ByVal ds As DataSet, ByRef wCombo As DropDownList, ByVal wCampoData As String, ByVal wCampoValor As String)

        Dim func As New Funcoes

        With wCombo
            .DataValueField = wCampoValor.Trim()
            .DataTextField = wCampoData
            .DataSource = ds
            .DataBind()
        End With

    End Sub

    Sub sCarregaCombo(ByVal ds As DataSet, ByRef wCombo As DropDownList, ByVal wCampoData As String, ByVal wCampoValor As String, ByVal wTodos As String)

        Dim func As New Funcoes
        wCombo.Items.Clear()

        Try
            With wCombo

                .Items.Add(New ListItem(wTodos, "0"))

                For wContador As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    .Items.Add(New ListItem(ds.Tables(0).Rows(wContador).Item(wCampoData), ds.Tables(0).Rows(wContador).Item(wCampoValor)))
                Next

            End With

        Finally

        End Try

    End Sub

    Function fRetornaStatusLivro(ByVal wCodigoStatus As Integer) As String
        If wCodigoStatus = 0 Then
            Return "DISPONÕVEL"
        Else
            If wCodigoStatus = 1 Then
                Return "EMPRESTADO"
            End If
        End If
    End Function


    Function fRetornaUsuarioEmprestimo(ByVal wCodigoTombo) As String

        Dim func As New Funcoes
        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wResposta As String = String.Empty

        wSQL = "select * " & _
                    " from tbEmprestimos, tbUsuarios " & _
                    " where (tbEmprestimos.cUsuario = tbUsuarios.cUsuario) and cTombo = " & wCodigoTombo & " and dDevolucao is null "

        dr = func.fRetornaDataReader(wSQL)

        Do While dr.Read

            wResposta = " para Usu·rio(a) <font color='Red'>" & CType(dr("tNome"), String) & "</font> com previs„o de devoluÁ„o para <font color='Red'>" & CType(dr("dDevolucaoPrevista"), Date).ToShortDateString & "</font>"

        Loop

        dr.Close()
        dr = Nothing

        Return wResposta

    End Function

    Function fEliminaApostrofo(ByVal wTexto As String)

        wTexto = Replace(wTexto, "'", "¥")
        Return wTexto

    End Function

    Function fRetornaApostrofo(ByVal wTexto As String)

        wTexto = Replace(wTexto, "¥", "'")
        Return wTexto

    End Function

    Function fApostrofoParaComandosSQL(ByVal wTexto As String)

        'wTexto = Replace(wTexto, ", ''", "'")
        'wTexto = Replace(wTexto, "''", "'")
        wTexto = Replace(wTexto, "'", "''")
        Return wTexto

    End Function

    Function fRetornaTipoMaterial(ByVal wCodigoLeader As String)

        Dim wSQL As String
        Dim func As New Funcoes
        Dim dr As SqlDataReader

        wSQL = "select * from tbleaders, tbTiposMaterial where (tbleaders.cTipoMaterial = tbTiposMaterial.cTipoMaterial) and cLeader = " & wCodigoLeader

        dr = func.fRetornaDataReader(wSQL)

        If dr.Read Then

            Return dr("tTipoMaterial")

        Else

            Return "Sem Material Definido"

        End If

        dr.Close()
        dr = Nothing

    End Function

    Function fRetornaEmailsGrupo(ByVal wCodigoGrupo As String)

        Dim wSQL As String
        Dim dr As SqlDataReader
        Dim wEmails As String = String.Empty

        wSQL = "Select * from vwUsuarios where cGrupo = " & wCodigoGrupo & " and lNovasAquisicoes = 1 order by tEmail"

        dr = fRetornaDataReader(wSQL)

        Do While dr.Read
            wEmails += dr("tEmail") & "; "
        Loop

        dr.Close()
        dr = Nothing

        Return wEmails

    End Function

    Function fPreparaPalavra(ByVal wString As String)

        Dim wPalavra As String

        wString = fTiraAcentos(wString)

        wPalavra = Replace(wString, "a", "[a,·,‡,„,‚,‰]")
        wPalavra = Replace(wPalavra, "e", "[e,È,Ë,Í,Î]")
        wPalavra = Replace(wPalavra, "i", "[i,Ì,Ï,Ó,Ô]")
        wPalavra = Replace(wPalavra, "o", "[o,Û,Ú,ı,Ù,ˆ]")
        wPalavra = Replace(wPalavra, "u", "[u,˙,˘,˚,¸]")
        wPalavra = Replace(wPalavra, "c", "[c,Á]")
        wPalavra = wPalavra

        Return wPalavra

    End Function

    Function fTiraAcentos(ByVal strTexto)

        Dim com_acentos, sem_acentos, strResultado As String
        Dim i As Integer

        com_acentos = "¡Õ”⁄…ƒœ÷‹À¿Ã“Ÿ»√’¬Œ‘€ ·ÌÛ˙È‰Ôˆ¸Î‡ÏÚ˘Ë„ı‚ÓÙ˚Í-«Á"
        sem_acentos = "AIOUEAIOUEAIOUEAOAIOUEaioueaioueaioueaoaioue-Cc"

        'com_acentos = "¡Õ”⁄…¿Ã“Ÿ»¬Œ‘€ ·ÌÛ˙È‡ÏÚ˘Ë‚ÓÙ˚Í«Á"""
        'sem_acentos = "AIOUEAIOUEAIOUEaioueaioueaioueCc''"

        i = 0
        strResultado = strTexto

        While i < Len(com_acentos)
            i = i + 1
            strResultado = Replace(strResultado, Mid(com_acentos, i, 1), Mid(sem_acentos, i, 1))
        End While

        Return strResultado

    End Function

    Sub sConfiguraPermissoes(ByVal wCodigoPerfil As String, ByVal wCodigoMenu As String, ByVal cmdFiltrar As Button)

        'Dim funcUser As New clsUsuarios
        'Dim wPermissao As New clsUsuarios.wUsuarioPermissao

        'wPermissao = funcUser.fCarregarUsuarioPermissao(wCodigoPerfil, wCodigoMenu)

        'With wPermissao

        '    If .lConsultar = True Or .lExcluir = True Then
        '        cmdFiltrar.Visible = True
        '    Else
        '        cmdFiltrar.Visible = False
        '    End If

        '    If .lIncluir = True Then
        '        cmdNovo.Visible = True
        '    Else
        '        cmdNovo.Visible = False
        '    End If

        '    If .lExcluir = True And lblCodigo.Text <> "0" Then
        '        cmdExcluir.Visible = True
        '    Else
        '        cmdExcluir.Visible = False
        '    End If

        '    If .lAlterar = True Then

        '        If lblCodigo.Text <> "0" Then
        '            cmdGravar.Visible = True
        '        Else
        '            cmdGravar.Visible = False
        '        End If

        '    End If

        '    If .lIncluir = True Then

        '        If lblCodigo.Text = "0" Then
        '            cmdGravar.Visible = True
        '        Else
        '            cmdGravar.Visible = False
        '        End If

        '    Else
        '        If Not .lAlterar = True Then
        '            cmdGravar.Visible = False
        '        End If

        '    End If

        'End With

    End Sub

    Function fRetornaAnoGraficos() As Integer

        Dim wAno As Integer

        If Date.Today.Month = 1 Then
            wAno = Date.Today.Year - 1
        Else
            wAno = Date.Today.Year
        End If

        Return wAno

    End Function

    Public Function fValidaCPF(ByVal CPF As String) As Boolean
        Dim i, a, n1, n2 As Integer

        CPF = CPF.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "")
        CPF = CPF.Trim

        If CPF = "" OrElse _
          CPF.Trim.Length <> 11 OrElse _
          CPF = "11111111111" OrElse _
          CPF = "22222222222" OrElse _
          CPF = "33333333333" OrElse _
          CPF = "44444444444" OrElse _
          CPF = "55555555555" OrElse _
          CPF = "66666666666" OrElse _
          CPF = "77777777777" OrElse _
          CPF = "88888888888" OrElse _
          CPF = "99999999999" Then
            Return False
        End If

        For a = 0 To 1
            n1 = 0
            For i = 1 To 9 + a
                n1 = n1 + Val(Mid(CPF, i, 1)) * (11 + a - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0
            If n2 <> Val(Mid(CPF, 10 + a, 1)) Then
                Return False
            End If
        Next
        Return True

    End Function

    Function fRetiraPontuacaoCPF(ByVal CPF As String)
        Dim wTemp As String = CPF
        If CPF.Substring(3, 1) = "." Then
            CPF = wTemp.Substring(0, 3)
            CPF &= wTemp.Substring(4, 3)
            CPF &= wTemp.Substring(8, 3)
            Return CPF
        Else
            Return CPF
        End If
    End Function

    Function fRetiraPontuacaoRG(ByVal RG As String)
        If RG.Substring(2, 1) = "." Then
            Dim RGTemp As String
            RGTemp = RG.Substring(0, 2)
            RGTemp &= RG.Substring(3, 3)
            RGTemp &= RG.Substring(7, 3)
            RGTemp &= RG.Substring(11, 1)
            Return RGTemp
        Else
            Return RG
        End If
    End Function

    Function fGeraCabecalhoTabela()
        Dim wHTML As String = ""
        wHTML &= "<table border='0'>"
        wHTML &= "<tr>"
        wHTML &= "<th> CPF </th>"
        wHTML &= "<th> Nome </th>"
        wHTML &= "<th> Telefone </th>"
        wHTML &= "<th> Erro </th>"
        wHTML &= "</tr>"

        Return wHTML

    End Function

    Function fGeraConteudoTabela(ByVal CPF As String, ByVal Nome As String, ByVal Telefone As String, ByVal Erro As String)
        Dim wHTML As String = ""
        wHTML &= "<tr>"
        wHTML &= "<td align='center'> " & CPF & "</td>"
        wHTML &= "<td align='center'> " & Nome & "</td>"
        wHTML &= "<td align='center'> " & Telefone & "</td>"
        wHTML &= "<td align='center'> " & Erro & "</td>"
        wHTML &= "</tr>"

        Return wHTML

    End Function

    Function fGeraRodapeTabela()
        Dim wHTML As String = "</table>"
        Return wHTML
    End Function


    Function fCarregarHTMLDetalhePesquisa(ByVal wCaminho As String, ByVal wKey As String) As String

        Dim wHTML As String = File.ReadAllText(wCaminho & "\" & ConfigurationManager.AppSettings(wKey))
        Return wHTML

    End Function

    Function fRetornaEnderecoPainelEditor(ByVal wServer As String, ByVal wTexto As String) As String

        If wServer.ToUpper = "LOCALHOST" Then
            wTexto = Replace(wTexto, "---painel---", "LOCALHOST/CASH_PAINEL")
            wTexto = Replace(wTexto, "---PAINEL---", "LOCALHOST/CASH_PAINEL")
        Else
            wTexto = Replace(wTexto, "---painel---", "WWW.WEBDESENV.COM.BR")
            wTexto = Replace(wTexto, "---PAINEL---", "WWW.WEBDESENV.COM.BR")
        End If

        Return wTexto

    End Function
End Class

