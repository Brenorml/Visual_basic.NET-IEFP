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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBolo = New System.Windows.Forms.Button()
        Me.btnPao = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnCoxinha = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(270, 332)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnBolo)
        Me.TabPage1.Controls.Add(Me.btnPao)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(262, 306)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pastelaria"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnBolo
        '
        Me.btnBolo.BackgroundImage = Global.CafeQuente.My.Resources.Resources.bolo
        Me.btnBolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBolo.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnBolo.Location = New System.Drawing.Point(20, 140)
        Me.btnBolo.Name = "btnBolo"
        Me.btnBolo.Size = New System.Drawing.Size(115, 115)
        Me.btnBolo.TabIndex = 1
        Me.btnBolo.Text = "Bolo"
        Me.btnBolo.UseVisualStyleBackColor = True
        '
        'btnPao
        '
        Me.btnPao.BackgroundImage = Global.CafeQuente.My.Resources.Resources.pao
        Me.btnPao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPao.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnPao.Location = New System.Drawing.Point(20, 19)
        Me.btnPao.Name = "btnPao"
        Me.btnPao.Size = New System.Drawing.Size(115, 115)
        Me.btnPao.TabIndex = 0
        Me.btnPao.Text = "Pão"
        Me.btnPao.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnCoxinha)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(262, 306)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salgados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnCoxinha
        '
        Me.btnCoxinha.BackgroundImage = Global.CafeQuente.My.Resources.Resources.salgadinho_de_festa_betim
        Me.btnCoxinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCoxinha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoxinha.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnCoxinha.Location = New System.Drawing.Point(18, 20)
        Me.btnCoxinha.Name = "btnCoxinha"
        Me.btnCoxinha.Size = New System.Drawing.Size(115, 115)
        Me.btnCoxinha.TabIndex = 1
        Me.btnCoxinha.Text = "Coxinha"
        Me.btnCoxinha.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(262, 306)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bebidas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(288, 52)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.Size = New System.Drawing.Size(269, 310)
        Me.dgvProdutos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(423, 377)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(134, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Pagamento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Café Quente"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPao As Button
    Friend WithEvents btnBolo As Button
    Friend WithEvents btnCoxinha As Button
End Class
