Imports System.IO
Public Class Tela
    Private Sub CleanButton_Click(sender As Object, e As EventArgs) Handles CleanButton.Click
        Directory.Delete("C:\Program Files (x86)\Steam\steamapps\workshop\content\304930", True)
        MessageBox.Show("Todos os seus mods foram excluídos com sucesso!")
    End Sub

    Private Sub DiscordButton_Click(sender As Object, e As EventArgs) Handles DiscordButton.Click
        Dim url As String = "https://discord.gg/Udvstpr"
        Process.Start(url)
    End Sub
End Class