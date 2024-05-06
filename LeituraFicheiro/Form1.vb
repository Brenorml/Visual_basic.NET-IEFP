Imports System.IO

Public Class Form1
    Private Sub CmdAbrir_Click(sender As Object, e As EventArgs) Handles CmdAbrir.Click
        Dim FicheiroStream As FileStream 'Filestream para abrir ficheiros
        Dim StreamLeitura As StreamReader 'Streamreader permite a leitura de streams

        Try 'estrutura para capturar possiveis erros ou exceções
            cdDialogoAbrir.ShowDialog()

            FicheiroStream = New FileStream(cdDialogoAbrir.FileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None) 'abrir ou criar, leitura e sem partilha
            StreamLeitura = New StreamReader(FicheiroStream) 'criar objeto de leitura
            StreamLeitura.BaseStream.Seek(0, SeekOrigin.Begin) 'situar o ponto de ficheiro no primeiro Offset
            TxtFicheiro.Text = StreamLeitura.ReadToEnd 'carregar na textbox o conteudo do ficheiro
        Catch ex As Exception
            MsgBox("Erro: " & Err.Description) 'erros?
            Exit Sub
        End Try
    End Sub
End Class
