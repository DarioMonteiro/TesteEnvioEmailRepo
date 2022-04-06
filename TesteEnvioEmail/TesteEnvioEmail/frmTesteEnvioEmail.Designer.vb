<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTesteEnvioEmail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEnviarEmail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSmtpServidorSaidaEmail = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPortaSaidaEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmailUsuarioRemetente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSenhaUsuarioRemetente = New System.Windows.Forms.TextBox()
        Me.chkInformaTargetName = New System.Windows.Forms.CheckBox()
        Me.lblTargetName = New System.Windows.Forms.Label()
        Me.cboTargetName = New System.Windows.Forms.ComboBox()
        Me.txtEmailPara = New System.Windows.Forms.TextBox()
        Me.labPara = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Location = New System.Drawing.Point(201, 225)
        Me.btnEnviarEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(97, 19)
        Me.btnEnviarEmail.TabIndex = 0
        Me.btnEnviarEmail.Text = "Enviar Email"
        Me.btnEnviarEmail.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SMTP SERVIDOR SAIDA:"
        '
        'cboSmtpServidorSaidaEmail
        '
        Me.cboSmtpServidorSaidaEmail.FormattingEnabled = True
        Me.cboSmtpServidorSaidaEmail.Items.AddRange(New Object() {"email-ssl.com.br", "outlook.office365.com", "smtp.office365.com"})
        Me.cboSmtpServidorSaidaEmail.Location = New System.Drawing.Point(194, 32)
        Me.cboSmtpServidorSaidaEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSmtpServidorSaidaEmail.Name = "cboSmtpServidorSaidaEmail"
        Me.cboSmtpServidorSaidaEmail.Size = New System.Drawing.Size(270, 21)
        Me.cboSmtpServidorSaidaEmail.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PORTA:"
        '
        'txtPortaSaidaEmail
        '
        Me.txtPortaSaidaEmail.Location = New System.Drawing.Point(194, 60)
        Me.txtPortaSaidaEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPortaSaidaEmail.MaxLength = 4
        Me.txtPortaSaidaEmail.Name = "txtPortaSaidaEmail"
        Me.txtPortaSaidaEmail.Size = New System.Drawing.Size(97, 20)
        Me.txtPortaSaidaEmail.TabIndex = 4
        Me.txtPortaSaidaEmail.Text = "587"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "EMAIL USUARIO REMETENTE:"
        '
        'txtEmailUsuarioRemetente
        '
        Me.txtEmailUsuarioRemetente.Location = New System.Drawing.Point(194, 90)
        Me.txtEmailUsuarioRemetente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailUsuarioRemetente.MaxLength = 150
        Me.txtEmailUsuarioRemetente.Name = "txtEmailUsuarioRemetente"
        Me.txtEmailUsuarioRemetente.Size = New System.Drawing.Size(364, 20)
        Me.txtEmailUsuarioRemetente.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SENHA USUARIO REMETENTE:"
        '
        'txtSenhaUsuarioRemetente
        '
        Me.txtSenhaUsuarioRemetente.Location = New System.Drawing.Point(195, 119)
        Me.txtSenhaUsuarioRemetente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSenhaUsuarioRemetente.MaxLength = 20
        Me.txtSenhaUsuarioRemetente.Name = "txtSenhaUsuarioRemetente"
        Me.txtSenhaUsuarioRemetente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaUsuarioRemetente.Size = New System.Drawing.Size(364, 20)
        Me.txtSenhaUsuarioRemetente.TabIndex = 8
        '
        'chkInformaTargetName
        '
        Me.chkInformaTargetName.AutoSize = True
        Me.chkInformaTargetName.Location = New System.Drawing.Point(27, 184)
        Me.chkInformaTargetName.Margin = New System.Windows.Forms.Padding(2)
        Me.chkInformaTargetName.Name = "chkInformaTargetName"
        Me.chkInformaTargetName.Size = New System.Drawing.Size(156, 17)
        Me.chkInformaTargetName.TabIndex = 9
        Me.chkInformaTargetName.Text = "INFORMA TARGET NAME"
        Me.chkInformaTargetName.UseVisualStyleBackColor = True
        '
        'lblTargetName
        '
        Me.lblTargetName.AutoSize = True
        Me.lblTargetName.Location = New System.Drawing.Point(184, 185)
        Me.lblTargetName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTargetName.Name = "lblTargetName"
        Me.lblTargetName.Size = New System.Drawing.Size(88, 13)
        Me.lblTargetName.TabIndex = 10
        Me.lblTargetName.Text = "TARGET NAME:"
        '
        'cboTargetName
        '
        Me.cboTargetName.Enabled = False
        Me.cboTargetName.FormattingEnabled = True
        Me.cboTargetName.Items.AddRange(New Object() {"STARTTLS/smtp.office365.com", "STARTTLS/outlook.office365.com"})
        Me.cboTargetName.Location = New System.Drawing.Point(273, 183)
        Me.cboTargetName.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTargetName.Name = "cboTargetName"
        Me.cboTargetName.Size = New System.Drawing.Size(277, 21)
        Me.cboTargetName.TabIndex = 11
        '
        'txtEmailPara
        '
        Me.txtEmailPara.Location = New System.Drawing.Point(194, 148)
        Me.txtEmailPara.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmailPara.MaxLength = 150
        Me.txtEmailPara.Name = "txtEmailPara"
        Me.txtEmailPara.Size = New System.Drawing.Size(364, 20)
        Me.txtEmailPara.TabIndex = 13
        '
        'labPara
        '
        Me.labPara.AutoSize = True
        Me.labPara.Location = New System.Drawing.Point(25, 151)
        Me.labPara.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labPara.Name = "labPara"
        Me.labPara.Size = New System.Drawing.Size(74, 13)
        Me.labPara.TabIndex = 12
        Me.labPara.Text = "EMAIL PARA:"
        '
        'frmTesteEnvioEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 266)
        Me.Controls.Add(Me.txtEmailPara)
        Me.Controls.Add(Me.labPara)
        Me.Controls.Add(Me.cboTargetName)
        Me.Controls.Add(Me.lblTargetName)
        Me.Controls.Add(Me.chkInformaTargetName)
        Me.Controls.Add(Me.txtSenhaUsuarioRemetente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmailUsuarioRemetente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPortaSaidaEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboSmtpServidorSaidaEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviarEmail)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTesteEnvioEmail"
        Me.Text = "Teste envio de email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnviarEmail As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSmtpServidorSaidaEmail As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPortaSaidaEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEmailUsuarioRemetente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSenhaUsuarioRemetente As System.Windows.Forms.TextBox
    Friend WithEvents chkInformaTargetName As System.Windows.Forms.CheckBox
    Friend WithEvents lblTargetName As System.Windows.Forms.Label
    Friend WithEvents cboTargetName As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmailPara As System.Windows.Forms.TextBox
    Friend WithEvents labPara As System.Windows.Forms.Label

End Class
