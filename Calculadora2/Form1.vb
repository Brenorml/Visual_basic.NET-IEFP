Public Class frmSoma
    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        lblResultado.Text = Val(txtOper1.Text) + (Val(txtOper2.Text))
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        lblResultado.Text = Val(txtOper1.Text) * (Val(txtOper2.Text))
    End Sub

    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        lblResultado.Text = Val(txtOper1.Text) - (Val(txtOper2.Text))
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        lblResultado.Text = Val(txtOper1.Text) / (Val(txtOper2.Text))
    End Sub
End Class
