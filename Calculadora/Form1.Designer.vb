<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoma
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
        Me.txtOper1 = New System.Windows.Forms.TextBox()
        Me.txtOper2 = New System.Windows.Forms.TextBox()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblSinal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOper1
        '
        Me.txtOper1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper1.Location = New System.Drawing.Point(12, 35)
        Me.txtOper1.Name = "txtOper1"
        Me.txtOper1.Size = New System.Drawing.Size(100, 26)
        Me.txtOper1.TabIndex = 0
        '
        'txtOper2
        '
        Me.txtOper2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper2.Location = New System.Drawing.Point(187, 35)
        Me.txtOper2.Name = "txtOper2"
        Me.txtOper2.Size = New System.Drawing.Size(100, 26)
        Me.txtOper2.TabIndex = 1
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(99, 92)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(96, 34)
        Me.btnIgual.TabIndex = 4
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(199, 211)
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
        Me.lblResultado.Location = New System.Drawing.Point(95, 157)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(100, 23)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSinal
        '
        Me.lblSinal.AutoSize = True
        Me.lblSinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinal.Location = New System.Drawing.Point(136, 35)
        Me.lblSinal.Name = "lblSinal"
        Me.lblSinal.Size = New System.Drawing.Size(28, 29)
        Me.lblSinal.TabIndex = 7
        Me.lblSinal.Text = "+"
        '
        'frmSoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 275)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSinal)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnIgual)
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
    Friend WithEvents btnIgual As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents lblSinal As Label
End Class
