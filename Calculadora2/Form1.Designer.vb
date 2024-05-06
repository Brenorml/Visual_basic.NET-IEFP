<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSoma
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtOper1 = New System.Windows.Forms.TextBox()
        Me.txtOper2 = New System.Windows.Forms.TextBox()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.Label()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnSubtrair = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOper1
        '
        Me.txtOper1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper1.Location = New System.Drawing.Point(22, 36)
        Me.txtOper1.Name = "txtOper1"
        Me.txtOper1.Size = New System.Drawing.Size(126, 29)
        Me.txtOper1.TabIndex = 0
        '
        'txtOper2
        '
        Me.txtOper2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper2.Location = New System.Drawing.Point(22, 99)
        Me.txtOper2.Name = "txtOper2"
        Me.txtOper2.Size = New System.Drawing.Size(126, 29)
        Me.txtOper2.TabIndex = 1
        '
        'btnSomar
        '
        Me.btnSomar.AutoSize = True
        Me.btnSomar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSomar.Location = New System.Drawing.Point(177, 36)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(55, 34)
        Me.btnSomar.TabIndex = 4
        Me.btnSomar.Text = "+"
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(228, 246)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 33)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblResultado.Location = New System.Drawing.Point(163, 186)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(140, 23)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(53, 186)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(86, 20)
        Me.resultado.TabIndex = 7
        Me.resultado.Text = "Resultado:"
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.AutoSize = True
        Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(248, 36)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(55, 34)
        Me.btnMultiplicar.TabIndex = 8
        Me.btnMultiplicar.Text = "x"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnSubtrair
        '
        Me.btnSubtrair.AutoSize = True
        Me.btnSubtrair.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtrair.Location = New System.Drawing.Point(177, 97)
        Me.btnSubtrair.Name = "btnSubtrair"
        Me.btnSubtrair.Size = New System.Drawing.Size(55, 34)
        Me.btnSubtrair.TabIndex = 9
        Me.btnSubtrair.Text = "-"
        Me.btnSubtrair.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.AutoSize = True
        Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(248, 97)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(55, 34)
        Me.btnDividir.TabIndex = 10
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'frmSoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 306)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnSubtrair)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnSomar)
        Me.Controls.Add(Me.txtOper2)
        Me.Controls.Add(Me.txtOper1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSoma"
        Me.Text = "Soma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOper1 As TextBox
    Friend WithEvents txtOper2 As TextBox
    Friend WithEvents btnSomar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents resultado As Label
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnSubtrair As Button
    Friend WithEvents btnDividir As Button
End Class
