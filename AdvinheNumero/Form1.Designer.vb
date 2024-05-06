<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.gbLimites = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkDica = New System.Windows.Forms.CheckBox()
        Me.nudSuperior = New System.Windows.Forms.NumericUpDown()
        Me.nudInferior = New System.Windows.Forms.NumericUpDown()
        Me.radEntre = New System.Windows.Forms.RadioButton()
        Me.radEntre1e100 = New System.Windows.Forms.RadioButton()
        Me.gbTentativas = New System.Windows.Forms.GroupBox()
        Me.nudLimitar = New System.Windows.Forms.NumericUpDown()
        Me.chkLimitar = New System.Windows.Forms.CheckBox()
        Me.botIniciar = New System.Windows.Forms.Button()
        Me.botTestarAposta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAposta = New System.Windows.Forms.TextBox()
        Me.lbNApostado = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbLimites.SuspendLayout()
        CType(Me.nudSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInferior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTentativas.SuspendLayout()
        CType(Me.nudLimitar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbLimites
        '
        Me.gbLimites.Controls.Add(Me.Label1)
        Me.gbLimites.Controls.Add(Me.chkDica)
        Me.gbLimites.Controls.Add(Me.nudSuperior)
        Me.gbLimites.Controls.Add(Me.nudInferior)
        Me.gbLimites.Controls.Add(Me.radEntre)
        Me.gbLimites.Controls.Add(Me.radEntre1e100)
        Me.gbLimites.Location = New System.Drawing.Point(13, 13)
        Me.gbLimites.Name = "gbLimites"
        Me.gbLimites.Size = New System.Drawing.Size(169, 137)
        Me.gbLimites.TabIndex = 0
        Me.gbLimites.TabStop = False
        Me.gbLimites.Text = "Limites"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "e"
        '
        'chkDica
        '
        Me.chkDica.AutoSize = True
        Me.chkDica.Location = New System.Drawing.Point(17, 114)
        Me.chkDica.Name = "chkDica"
        Me.chkDica.Size = New System.Drawing.Size(86, 17)
        Me.chkDica.TabIndex = 4
        Me.chkDica.Text = "Mostrar Dica"
        Me.ToolTip1.SetToolTip(Me.chkDica, "Visualiza os limites do resultado")
        Me.chkDica.UseVisualStyleBackColor = True
        '
        'nudSuperior
        '
        Me.nudSuperior.Enabled = False
        Me.nudSuperior.Location = New System.Drawing.Point(109, 73)
        Me.nudSuperior.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudSuperior.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSuperior.Name = "nudSuperior"
        Me.nudSuperior.Size = New System.Drawing.Size(50, 20)
        Me.nudSuperior.TabIndex = 3
        Me.nudSuperior.Value = New Decimal(New Integer() {999, 0, 0, 0})
        '
        'nudInferior
        '
        Me.nudInferior.Enabled = False
        Me.nudInferior.Location = New System.Drawing.Point(34, 73)
        Me.nudInferior.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudInferior.Name = "nudInferior"
        Me.nudInferior.Size = New System.Drawing.Size(50, 20)
        Me.nudInferior.TabIndex = 2
        '
        'radEntre
        '
        Me.radEntre.AutoSize = True
        Me.radEntre.Location = New System.Drawing.Point(17, 43)
        Me.radEntre.Name = "radEntre"
        Me.radEntre.Size = New System.Drawing.Size(50, 17)
        Me.radEntre.TabIndex = 1
        Me.radEntre.Text = "Entre"
        Me.radEntre.UseVisualStyleBackColor = True
        '
        'radEntre1e100
        '
        Me.radEntre1e100.AutoSize = True
        Me.radEntre1e100.Checked = True
        Me.radEntre1e100.Location = New System.Drawing.Point(17, 20)
        Me.radEntre1e100.Name = "radEntre1e100"
        Me.radEntre1e100.Size = New System.Drawing.Size(89, 17)
        Me.radEntre1e100.TabIndex = 0
        Me.radEntre1e100.TabStop = True
        Me.radEntre1e100.Text = "Entre 1 e 100"
        Me.radEntre1e100.UseVisualStyleBackColor = True
        '
        'gbTentativas
        '
        Me.gbTentativas.Controls.Add(Me.nudLimitar)
        Me.gbTentativas.Controls.Add(Me.chkLimitar)
        Me.gbTentativas.Location = New System.Drawing.Point(13, 156)
        Me.gbTentativas.Name = "gbTentativas"
        Me.gbTentativas.Size = New System.Drawing.Size(169, 88)
        Me.gbTentativas.TabIndex = 1
        Me.gbTentativas.TabStop = False
        Me.gbTentativas.Text = "Tentativas"
        '
        'nudLimitar
        '
        Me.nudLimitar.Enabled = False
        Me.nudLimitar.Location = New System.Drawing.Point(34, 52)
        Me.nudLimitar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLimitar.Name = "nudLimitar"
        Me.nudLimitar.Size = New System.Drawing.Size(50, 20)
        Me.nudLimitar.TabIndex = 1
        Me.nudLimitar.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'chkLimitar
        '
        Me.chkLimitar.AutoSize = True
        Me.chkLimitar.Location = New System.Drawing.Point(17, 29)
        Me.chkLimitar.Name = "chkLimitar"
        Me.chkLimitar.Size = New System.Drawing.Size(56, 17)
        Me.chkLimitar.TabIndex = 0
        Me.chkLimitar.Text = "Limitar"
        Me.ToolTip1.SetToolTip(Me.chkLimitar, "Permite definir o número máximo de tentativas")
        Me.chkLimitar.UseVisualStyleBackColor = True
        '
        'botIniciar
        '
        Me.botIniciar.Location = New System.Drawing.Point(220, 13)
        Me.botIniciar.Name = "botIniciar"
        Me.botIniciar.Size = New System.Drawing.Size(102, 23)
        Me.botIniciar.TabIndex = 2
        Me.botIniciar.Text = "Iniciar"
        Me.ToolTip1.SetToolTip(Me.botIniciar, "Clique para iniciar o jogo")
        Me.botIniciar.UseVisualStyleBackColor = True
        '
        'botTestarAposta
        '
        Me.botTestarAposta.Location = New System.Drawing.Point(220, 81)
        Me.botTestarAposta.Name = "botTestarAposta"
        Me.botTestarAposta.Size = New System.Drawing.Size(102, 23)
        Me.botTestarAposta.TabIndex = 3
        Me.botTestarAposta.Text = "Testar Aposta"
        Me.botTestarAposta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Aposta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Números Apostados:"
        '
        'txtAposta
        '
        Me.txtAposta.Enabled = False
        Me.txtAposta.Location = New System.Drawing.Point(272, 49)
        Me.txtAposta.Name = "txtAposta"
        Me.txtAposta.Size = New System.Drawing.Size(50, 20)
        Me.txtAposta.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtAposta, "Introduza o seu palpite")
        '
        'lbNApostado
        '
        Me.lbNApostado.Enabled = False
        Me.lbNApostado.FormattingEnabled = True
        Me.lbNApostado.Location = New System.Drawing.Point(191, 136)
        Me.lbNApostado.Name = "lbNApostado"
        Me.lbNApostado.Size = New System.Drawing.Size(131, 108)
        Me.lbNApostado.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 261)
        Me.Controls.Add(Me.gbTentativas)
        Me.Controls.Add(Me.lbNApostado)
        Me.Controls.Add(Me.txtAposta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.botTestarAposta)
        Me.Controls.Add(Me.botIniciar)
        Me.Controls.Add(Me.gbLimites)
        Me.Name = "Form1"
        Me.Text = "Advinhe o Número!"
        Me.gbLimites.ResumeLayout(False)
        Me.gbLimites.PerformLayout()
        CType(Me.nudSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInferior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTentativas.ResumeLayout(False)
        Me.gbTentativas.PerformLayout()
        CType(Me.nudLimitar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbLimites As GroupBox
    Friend WithEvents gbTentativas As GroupBox
    Friend WithEvents chkDica As CheckBox
    Friend WithEvents nudInferior As NumericUpDown
    Friend WithEvents radEntre As RadioButton
    Friend WithEvents radEntre1e100 As RadioButton
    Friend WithEvents nudSuperior As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudLimitar As NumericUpDown
    Friend WithEvents chkLimitar As CheckBox
    Friend WithEvents botIniciar As Button
    Friend WithEvents botTestarAposta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAposta As TextBox
    Friend WithEvents lbNApostado As ListBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
