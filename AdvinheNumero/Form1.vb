Public Class Form1

    Private numeroAleatorio As Integer
    Private limiteInferior As Integer
    Private limiteSuperior As Integer
    Private numApostas As Integer = 0

    Private Sub radEntre1e100_CheckedChanged(sender As Object, e As EventArgs) Handles radEntre1e100.CheckedChanged
        'Inibir controlos soe e desce numéricos
        Me.nudInferior.Enabled = False
        Me.nudSuperior.Enabled = False
    End Sub

    Private Sub radEntre_CheckedChanged(sender As Object, e As EventArgs) Handles radEntre.CheckedChanged
        'Habilitar os controlos sobe e desce numéricos
        Me.nudInferior.Enabled = True
        Me.nudSuperior.Enabled = True
    End Sub

    Private Sub chkLimitar_CheckedChanged(sender As Object, e As EventArgs) Handles chkLimitar.CheckedChanged
        'Inibir/habilitar sobe e desce numérico
        If Me.chkLimitar.Checked = True Then
            Me.nudLimitar.Enabled = True
        Else
            Me.nudLimitar.Enabled = False
        End If
    End Sub

    Private Sub botIniciar_Click(sender As Object, e As EventArgs) Handles botIniciar.Click
        'Habilitar/inibir controlos
        Me.gbLimites.Enabled = False
        Me.gbTentativas.Enabled = False
        Me.txtAposta.Enabled = True
        Me.botTestarAposta.Enabled = True
        Me.botIniciar.Enabled = False

        'limpar a listBox
        Me.lbNApostado.Items.Clear()

        'Inicia os limites da aposta
        If Me.radEntre1e100.Checked Then
            limiteInferior = 1
            limiteSuperior = 100
        Else
            limiteInferior = CInt(Me.nudInferior.Value)
            limiteSuperior = CInt(Me.nudSuperior.Value)
        End If

        'Gerar número entre intLimiteInferior (inclusivo) e intLimiteSuperior + 1 (exclusivo)
        Dim rnd As New Random

        'RESOLVER PROBLEMA DE ERRO QUANDO VALOR INFERIOR É MAIOR QUE VALOR SUPERIOR
        If limiteInferior > limiteSuperior Then
            MessageBox.Show("O valor inferior não pode ser maior que o superior.", "Insira um valor válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.gbLimites.Enabled = True
            Me.gbTentativas.Enabled = True
            Me.txtAposta.Enabled = False
            Me.botTestarAposta.Enabled = False
            Me.botIniciar.Enabled = True
        Else
            numeroAleatorio = rnd.Next(limiteInferior, limiteSuperior + 1)

        End If
        'RESOLVER PROBLEMA DE ERRO QUANDO VALOR INFERIOR É MAIOR QUE VALOR SUPERIOR


        If Me.chkDica.Checked = True Then
            Me.ToolTip1.SetToolTip(Me.botTestarAposta, limiteInferior.ToString & "-" & limiteSuperior.ToString)
        End If

        numApostas = 0
        Me.txtAposta.Text = ""
        Me.txtAposta.Focus()
    End Sub

    Private Sub botTestarAposta_Click(sender As Object, e As EventArgs) Handles botTestarAposta.Click
        'Validar a aposta. Se o valor não for numérico então apresentar erro e terminar subrotina.
        If Not IsNumeric(Me.txtAposta.Text) Then
            MessageBox.Show("Por favor instroduza um valor numérico!", "Aposta não numérica", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim aposta As Integer = Integer.Parse(Me.txtAposta.Text)

        'Incrementar as apostas
        numApostas += 1

        'Comparar o número gerado com a aposta do utilizador
        Select Case numeroAleatorio
            Case Is < aposta
                'Aposta demasiado alta
                limiteSuperior = aposta - 1
                Me.lbNApostado.Items.Insert(0, "< " & aposta.ToString & ControlChars.Tab & "Aposta " & numApostas.ToString)

            Case Is > aposta
                'Aposta demasiado baixa
                limiteInferior = aposta + 1
                Me.lbNApostado.Items.Insert(0, "> " & aposta.ToString & ControlChars.Tab & "Aposta " & numApostas.ToString)

            Case Else
                'finalização com acerto
                Me.lbNApostado.Items.Insert(0, aposta.ToString & ControlChars.Tab & "Parabéns!")
                MessageBox.Show("Parabéns! Acertou no número adivinhado. " & "Necessitou de " & numApostas.ToString & " aposta(s).")
                'Habilitar/inibir controlos
                Me.gbLimites.Enabled = True
                Me.gbTentativas.Enabled = True
                Me.txtAposta.Enabled = False
                Me.botTestarAposta.Enabled = False
                Me.botIniciar.Enabled = True
                Me.botIniciar.Focus()
        End Select

        'Actualizar a dica, caso utilizada
        If Me.chkDica.Checked = True Then
            Me.ToolTip1.SetToolTip(Me.botTestarAposta, limiteInferior.ToString & "-" & limiteSuperior.ToString)
        End If

        'Número de apostas máximas atingido.
        If Me.chkLimitar.Checked = True AndAlso numeroAleatorio <> aposta AndAlso numApostas = Me.nudLimitar.Value Then
            'Inserir no início da lista
            Me.lbNApostado.Items.Insert(0, "Fim!")
            MessageBox.Show("Atingiu o número de apostas máximas!", "Perdeu!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Habilitar/Inibir Controlos
            Me.gbLimites.Enabled = True
            Me.gbTentativas.Enabled = True
            Me.txtAposta.Enabled = False
            Me.botTestarAposta.Enabled = False
            Me.botIniciar.Enabled = True
        End If
    End Sub
End Class
