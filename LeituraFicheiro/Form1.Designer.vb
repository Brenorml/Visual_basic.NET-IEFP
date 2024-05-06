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
        Me.CmdAbrir = New System.Windows.Forms.Button()
        Me.TxtFicheiro = New System.Windows.Forms.TextBox()
        Me.cdDialogoAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'CmdAbrir
        '
        Me.CmdAbrir.Location = New System.Drawing.Point(183, 242)
        Me.CmdAbrir.Name = "CmdAbrir"
        Me.CmdAbrir.Size = New System.Drawing.Size(140, 26)
        Me.CmdAbrir.TabIndex = 0
        Me.CmdAbrir.Text = "Abrir"
        Me.CmdAbrir.UseVisualStyleBackColor = True
        '
        'TxtFicheiro
        '
        Me.TxtFicheiro.Location = New System.Drawing.Point(12, 12)
        Me.TxtFicheiro.Multiline = True
        Me.TxtFicheiro.Name = "TxtFicheiro"
        Me.TxtFicheiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtFicheiro.Size = New System.Drawing.Size(482, 224)
        Me.TxtFicheiro.TabIndex = 1
        '
        'cdDialogoAbrir
        '
        Me.cdDialogoAbrir.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 276)
        Me.Controls.Add(Me.TxtFicheiro)
        Me.Controls.Add(Me.CmdAbrir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdAbrir As Button
    Friend WithEvents TxtFicheiro As TextBox
    Friend WithEvents cdDialogoAbrir As OpenFileDialog
End Class
