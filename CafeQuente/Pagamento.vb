Public Class Pagamento
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Close()
    End Sub


    Private Sub btPagar_Click(sender As Object, e As EventArgs) Handles btPagar.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(tbNome.Text, New Font("arial", 14, FontStyle.Regular), Brushes.Black, 80, 80)
        e.Graphics.DrawString(tbNif.Text, New Font("arial", 14, FontStyle.Regular), Brushes.Black, 80, 80)
        e.Graphics.DrawString(dgvProdutos.Tag, New Font("arial", 12, FontStyle.Regular), Brushes.Black, 80, 80)
        e.Graphics.DrawString(tbTotal.Text, New Font("arial", 14, FontStyle.Regular), Brushes.Black, 80, 80)
    End Sub
End Class