Imports System.Net.Mail

Public Class frmTesteEnvioEmail

    Private Sub btnEnviarEmail_Click(sender As Object, e As EventArgs) Handles btnEnviarEmail.Click
        Dim strSmtpServidorSaida As String
        Dim strPortaServidorSaida As String
        Dim strSenhaRemetente As String
        Dim strEmailUsuarioRemetente As String

        strSmtpServidorSaida = cboSmtpServidorSaidaEmail.Text.Trim

        strPortaServidorSaida = txtPortaSaidaEmail.Text.Trim

        strEmailUsuarioRemetente = txtEmailUsuarioRemetente.Text.Trim

        strSenhaRemetente = txtSenhaUsuarioRemetente.Text.Trim


        Dim objSmtp As New System.Net.Mail.SmtpClient(strSmtpServidorSaida, strPortaServidorSaida)

        'Dim objSmtp As New System.Net.Mail.SmtpClient("email-ssl.com.br", 587)

        'Dim objSmtp As New System.Net.Mail.SmtpClient("outlook.office365.com", 587)
        'Dim objSmtp As New System.Net.Mail.SmtpClient("smtp.office365.com", 587)

        Dim objMail As New System.Net.Mail.MailMessage()
        'Dim objAnexo As System.Net.Mail.Attachment

        Dim objCred As New Net.NetworkCredential(strEmailUsuarioRemetente, strSenhaRemetente)

        'Dim objCred As New Net.NetworkCredential("dario@gir.srv.br", "*q8n6kked*")
        'Dim objCred As New Net.NetworkCredential("suprimentos@bcs-ci.com.br", "bcs2021.")
        Dim strMensagem As String
        Dim strSubject, strEmail As String

        Try

            'DEUS è poderoso

            Cursor.Current = Cursors.WaitCursor

            strSubject = "Título Email"
            strMensagem = "Corpo Email"
            strEmail = txtEmailPara.Text.Trim
            'strEmail = "dario@gir.srv.br"
            'strEmail = "suprimentos@bcs-ci.com.br"


            objMail.To.Add(New MailAddress(strEmail))
            objMail.IsBodyHtml = False
            objMail.BodyEncoding = System.Text.Encoding.UTF8
            objMail.Body = strMensagem
            objMail.Subject = strSubject
            'objAnexo = New System.Net.Mail.Attachment(strCaminho)
            'objMail.Attachments.Add(objAnexo)

            objMail.From = New MailAddress(strEmailUsuarioRemetente, strEmailUsuarioRemetente)

            'objMail.From = New MailAddress("dario@gir.srv.br", "Dario")
            'objMail.From = New MailAddress("suprimentos@bcs-ci.com.br", "suprimentos@bcs-ci.com.br")

            objSmtp.DeliveryMethod = SmtpDeliveryMethod.Network
            objSmtp.Credentials = objCred


            objSmtp.EnableSsl = True

            objSmtp.TargetName = Nothing

            If chkInformaTargetName.Checked Then
                'objSmtp.TargetName = "STARTTLS/outlook.office365.com"
                'objSmtp.TargetName = "STARTTLS/smtp.office365.com"
                objSmtp.TargetName = cboTargetName.Text.Trim
            End If

            objSmtp.Send(objMail)
            MsgBox("Envio executado com sucesso!!", MsgBoxStyle.Information, "Sucesso")


            'Try
            '    objSmtp.Send(objMail)
            '    MsgBox("Envio executado com sucesso.", MsgBoxStyle.Information, "Sucesso")
            'Catch ex As Exception
            '    If IsNothing(ex.InnerException) Then
            '        MsgBox(ex.Message & vbLf & MsgBoxStyle.Critical, "Erro")
            '    Else
            '        MsgBox(ex.Message & vbLf & ex.InnerException.Message, MsgBoxStyle.Critical, "Erro")
            '    End If
            'Finally
            '    objSmtp.Dispose()
            '    'objAnexo.Dispose()
            '    objMail.Dispose()
            'End Try
        Catch ex As System.Net.Mail.SmtpException
            If IsNothing(ex.InnerException) Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
            Else
                MsgBox(ex.Message & vbLf & ex.InnerException.Message, MsgBoxStyle.Critical, "Erro")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
            'MsgError(ex, True)
        Finally
            Cursor.Current = Cursors.Default
            'objAnexo = Nothing
            objMail.Dispose()
            objSmtp.Dispose()

            objMail = Nothing
            objSmtp = Nothing
            objCred = Nothing
            'objAnexo = Nothing
        End Try

    End Sub

    Private Sub chkInformaTargetName_CheckedChanged(sender As Object, e As EventArgs) Handles chkInformaTargetName.CheckedChanged
        If chkInformaTargetName.Checked Then
            cboTargetName.Enabled = True
        Else
            cboTargetName.Enabled = False
        End If
    End Sub

    Private Sub frmTesteEnvioEmail_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboSmtpServidorSaidaEmail.SelectedIndex = -1
        cboSmtpServidorSaidaEmail.Text = "smtp.office365.com"

        txtPortaSaidaEmail.Text = "587"

        txtEmailUsuarioRemetente.Text = "suprimentos@bcs-ci.com.br"

        txtSenhaUsuarioRemetente.Text = "bcs2021."

        txtEmailPara.Text = "dario@gir.srv.br"

        chkInformaTargetName.Enabled = True
        cboTargetName.SelectedIndex = -1
        cboTargetName.Enabled = False

    End Sub
End Class
