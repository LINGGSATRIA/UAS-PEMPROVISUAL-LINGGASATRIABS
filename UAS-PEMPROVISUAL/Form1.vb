Public Class Form1

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        ' Buka dialog open file dan baca isi file'
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "File Teks (*.docx)|*.docx"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim path As String = openFileDialog.FileName
            Dim lines As String() = System.IO.File.ReadAllLines(path)
            Dim characterCount As Integer = 0
            Dim wordCount As Integer = 0

            ' Hitung karakter, kata, dan baris'
            For Each line In lines
                characterCount += line.Length
                Dim words As String() = line.Split(" ")
                wordCount += words.Length
            Next

            ' Tampilkan hasil perhitungan'
            lblCharactercount.Text = ":" & characterCount
            lblWordCount.Text = ":" & wordCount
            lblLineCount.Text = ":" & lines.Length
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Membersihkan kontrol'
        lblCharacterCount.Text = String.Empty
        lblWordCount.Text = String.Empty
        lblLineCount.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Keluar dari aplikasi'
        Me.Close()
    End Sub
End Class