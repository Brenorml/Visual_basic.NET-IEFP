Imports System.IO
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Sinaliza que o texto fpo alterado.
        'A propriedade Tag pode conter qualquer tipo de dados.
        TextBox1.Tag = "Alterado"
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        'Verifica se o texto foi alterado.
        If TextBox1.Tag IsNot Nothing Then
            Dim res As DialogResult
            res = MessageBox.Show("O documento foi alterado. Deseja continuar?", "Editor de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If res <> Windows.Forms.DialogResult.Yes Then
                Return
            End If
        End If
        'Limpa o editor e a indicação de alterado.
        Me.TextBox1.Text = String.Empty
        Me.TextBox1.Tag = Nothing
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Me.OpenFileDialog1.Title = "Abrir..."
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.Filter = "Ficheiros de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        'Seleciona o primeiro filtro (*.txt)
        Me.OpenFileDialog1.FilterIndex = 1
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Lê todo o texto do arquivo para editor
            Me.TextBox1.Text = File.ReadAllText(Me.OpenFileDialog1.FileName)
            Me.TextBox1.Tag = Nothing
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Me.SaveFileDialog1.Title = "Guardar..."
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "Ficheiros de texto (*.txt)|*.txt"
        Me.SaveFileDialog1.DefaultExt = "txt"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Salva todo texto do editor no ficheiro
            File.WriteAllText(Me.SaveFileDialog1.FileName, Me.TextBox1.Text)
        End If
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        'Verificação de alteração de texto
        If TextBox1.Tag IsNot Nothing Then
            Dim res As DialogResult
            res = MessageBox.Show("O documento foi alterado.Deseja continuar?", "Editor de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If res <> Windows.Forms.DialogResult.Yes Then
                Return
            End If
        End If
        'finalização do programa
        Application.Exit()
    End Sub

    Private Sub CorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorToolStripMenuItem.Click
        'Seleciona a cor no editor
        Me.ColorDialog1.Color = TextBox1.ForeColor
        If Me.ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TextBox1.ForeColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub TipoDeLetraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeLetraToolStripMenuItem.Click
        'Alterar a cor
        Me.FontDialog1.ShowColor = True
        'Selecionar a cor usada no editor
        Me.FontDialog1.Color = TextBox1.ForeColor
        'Alterar cor apos pressionar OK
        If Me.FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.TextBox1.Font = Me.FontDialog1.Font
            Me.TextBox1.ForeColor = Me.FontDialog1.Color
        End If
    End Sub
End Class
