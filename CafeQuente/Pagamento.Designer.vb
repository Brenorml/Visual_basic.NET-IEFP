<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagamento
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
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCheque = New System.Windows.Forms.RadioButton()
        Me.rbMbway = New System.Windows.Forms.RadioButton()
        Me.rbMultibanco = New System.Windows.Forms.RadioButton()
        Me.rbDinheiro = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbNome = New System.Windows.Forms.TextBox()
        Me.tbNif = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btPagar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(251, 32)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.Size = New System.Drawing.Size(307, 319)
        Me.dgvProdutos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCheque)
        Me.GroupBox1.Controls.Add(Me.rbMbway)
        Me.GroupBox1.Controls.Add(Me.rbMultibanco)
        Me.GroupBox1.Controls.Add(Me.rbDinheiro)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 177)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de Pagamento"
        '
        'rbCheque
        '
        Me.rbCheque.AutoSize = True
        Me.rbCheque.Location = New System.Drawing.Point(21, 137)
        Me.rbCheque.Name = "rbCheque"
        Me.rbCheque.Size = New System.Drawing.Size(62, 17)
        Me.rbCheque.TabIndex = 3
        Me.rbCheque.TabStop = True
        Me.rbCheque.Text = "Cheque"
        Me.rbCheque.UseVisualStyleBackColor = True
        '
        'rbMbway
        '
        Me.rbMbway.AutoSize = True
        Me.rbMbway.Location = New System.Drawing.Point(20, 100)
        Me.rbMbway.Name = "rbMbway"
        Me.rbMbway.Size = New System.Drawing.Size(63, 17)
        Me.rbMbway.TabIndex = 2
        Me.rbMbway.TabStop = True
        Me.rbMbway.Text = "MBWay"
        Me.rbMbway.UseVisualStyleBackColor = True
        '
        'rbMultibanco
        '
        Me.rbMultibanco.AutoSize = True
        Me.rbMultibanco.Location = New System.Drawing.Point(21, 64)
        Me.rbMultibanco.Name = "rbMultibanco"
        Me.rbMultibanco.Size = New System.Drawing.Size(41, 17)
        Me.rbMultibanco.TabIndex = 1
        Me.rbMultibanco.TabStop = True
        Me.rbMultibanco.Text = "MB"
        Me.rbMultibanco.UseVisualStyleBackColor = True
        '
        'rbDinheiro
        '
        Me.rbDinheiro.AutoSize = True
        Me.rbDinheiro.Location = New System.Drawing.Point(21, 30)
        Me.rbDinheiro.Name = "rbDinheiro"
        Me.rbDinheiro.Size = New System.Drawing.Size(64, 17)
        Me.rbDinheiro.TabIndex = 0
        Me.rbDinheiro.TabStop = True
        Me.rbDinheiro.Text = "Dinheiro"
        Me.rbDinheiro.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbNome)
        Me.GroupBox2.Controls.Add(Me.tbNif)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 136)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados do Cliente"
        '
        'tbNome
        '
        Me.tbNome.Location = New System.Drawing.Point(9, 100)
        Me.tbNome.Name = "tbNome"
        Me.tbNome.Size = New System.Drawing.Size(189, 20)
        Me.tbNome.TabIndex = 3
        '
        'tbNif
        '
        Me.tbNif.Location = New System.Drawing.Point(9, 49)
        Me.tbNif.Name = "tbNif"
        Me.tbNif.Size = New System.Drawing.Size(189, 20)
        Me.tbNif.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIF:"
        '
        'btPagar
        '
        Me.btPagar.Location = New System.Drawing.Point(431, 400)
        Me.btPagar.Name = "btPagar"
        Me.btPagar.Size = New System.Drawing.Size(127, 38)
        Me.btPagar.TabIndex = 5
        Me.btPagar.Text = "Pagar"
        Me.btPagar.UseVisualStyleBackColor = True
        '
        'btCancelar
        '
        Me.btCancelar.Location = New System.Drawing.Point(251, 400)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(127, 38)
        Me.btCancelar.TabIndex = 6
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 369)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total:"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(450, 362)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(108, 20)
        Me.tbTotal.TabIndex = 4
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrintDocument1
        '
        '
        'Pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 450)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btPagar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Name = "Pagamento"
        Me.Text = "Pagamento"
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCheque As RadioButton
    Friend WithEvents rbMbway As RadioButton
    Friend WithEvents rbMultibanco As RadioButton
    Friend WithEvents rbDinheiro As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNome As TextBox
    Friend WithEvents tbNif As TextBox
    Friend WithEvents btPagar As Button
    Friend WithEvents btCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
