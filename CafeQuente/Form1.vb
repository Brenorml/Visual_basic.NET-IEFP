Public Class Form1
    Private Sub btnPao_Click(sender As Object, e As EventArgs) Handles btnPao.Click
        TextBox1.Text = Format(CDbl(TextBox1.Text) + CDbl(btnPao.Tag), "0.00")
        InserirLinha(btnPao.Text, Format(CDbl(btnPao.Tag), "0.00"))
    End Sub

    Private Sub InicializaGrid()
        With dgvProdutos
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .MultiSelect = False
            .ReadOnly = True
            .Columns.Add("Produto", "Produto") 'col = 0
            .Columns.Add("Preco", "Preço €") 'col = 1
            .Columns("Preco").ValueType = GetType(Double)
            .Font = New Font("Tahome", 8.25)
            .Columns(0).Width = 150
            .Columns(1).Width = 50
            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializaGrid()
        btnPao.Tag = 0.6
        btnBolo.Tag = 1.5
        btnCoxinha.Tag = 1.0
        TextBox1.Text = Format(0.0, "0.00")
    End Sub

    Sub InserirLinha(ByVal produto As String, ByVal preco As String)
        dgvProdutos.Rows.Add(produto, preco)
    End Sub

    Private Sub btnPao_MouseHover(sender As Object, e As EventArgs) Handles btnPao.MouseHover, btnBolo.MouseHover, btnCoxinha.MouseHover
        'btnPao.BackgroundImage = My.Resources.preto
        Dim btn As System.Windows.Forms.Button

        btn = CType(sender, Button)
        btn.BackgroundImage = My.Resources.preto
    End Sub

    Private Sub btnPao_MouseLeave(sender As Object, e As EventArgs) Handles btnPao.MouseLeave
        btnPao.BackgroundImage = My.Resources.pao
    End Sub

    Private Sub btnBolo_Click(sender As Object, e As EventArgs) Handles btnBolo.Click
        TextBox1.Text = Format(CDbl(TextBox1.Text) + CDbl(btnBolo.Tag), "0.00")
        InserirLinha(btnBolo.Text, Format(CDbl(btnBolo.Tag), "0.00"))
    End Sub

    Private Sub btnBolo_MouseLeave(sender As Object, e As EventArgs) Handles btnBolo.MouseLeave
        btnBolo.BackgroundImage = My.Resources.bolo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formPagamento As New Pagamento

        formPagamento.dgvProdutos.Columns.Add("Produto", "Produto")
        formPagamento.dgvProdutos.Columns.Add("Preco", "Preço €")

        For Each row As DataGridViewRow In dgvProdutos.Rows
            formPagamento.dgvProdutos.Rows.Add(row.Cells(0).Value, row.Cells(1).Value)
        Next
        formPagamento.tbTotal.Text = TextBox1.Text

        formPagamento.ShowDialog()
    End Sub

    Private Sub btnCoxinha_Click(sender As Object, e As EventArgs) Handles btnCoxinha.Click
        TextBox1.Text = Format(CDbl(TextBox1.Text) + CDbl(btnCoxinha.Tag), "0.00")
        InserirLinha(btnCoxinha.Text, Format(CDbl(btnCoxinha.Tag), "0.00"))
    End Sub

    Private Sub btnCoxinha_MouseLeave(sender As Object, e As EventArgs) Handles btnCoxinha.MouseLeave
        btnCoxinha.BackgroundImage = My.Resources.salgadinho_de_festa_betim
    End Sub
End Class
