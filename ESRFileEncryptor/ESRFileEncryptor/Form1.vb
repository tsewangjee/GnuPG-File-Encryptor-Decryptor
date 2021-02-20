Imports System.IO
Imports Starksoft.Cryptography.OpenPGP  'After referencing Starksoft.Cryptography.OpenPGP.DLL
Imports System.Configuration

Public Class Form1

#Region "member variables"

    Private gpg As GnuPG = New GnuPG()
    Dim fileName As String = "gpg.exe"
    Private appPath As String = Path.Combine(Environment.CurrentDirectory, fileName) 'The path where gpg.exe is located
    Private KeyName As String = ConfigurationManager.AppSettings.Get("PublicKey_Name")
    Private passPhrase As String = ConfigurationManager.AppSettings.Get("SecretKeyName_PassPhrase")

#End Region

#Region "button events"
    'This button event will remove the double quotes in the DAT file, or any text file.
    Private Sub Remove_Double_Quotes(sender As System.Object, e As System.EventArgs) Handles RemoveDoubleQuotes.Click
        Try
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()

            If result = DialogResult.OK Then
                Dim FileLocation As String = OpenFileDialog1.FileName
                Dim FileData As String = File.ReadAllText(FileLocation)

                Dim NewFileData As String = FileData.Replace("""", "")
                Dim fs As FileStream = File.Create(FileLocation) 'overwrite the existing the file
                fs.Close()

                Dim objWriter As New System.IO.StreamWriter(FileLocation)
                objWriter.Write(NewFileData)
                objWriter.Close()

                MessageBox.Show("Please check your file, (Double Quotes removed).")
            Else
                MessageBox.Show("Please choose your .dat file")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Try
        End Try
    End Sub

    'Here we handle the encryption of the DAT file
    Private Sub Encrypt_file(sender As System.Object, e As System.EventArgs) Handles Encrypt.Click
        Try
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()

            If result = DialogResult.OK Then
                Dim SourceFileLocation As String = OpenFileDialog1.FileName

                EncryptFile(KeyName, SourceFileLocation, SourceFileLocation + ".asc")
                MessageBox.Show("File Encrypted Successfully with type (.asc) created with the same filename, in the same directory as source file.")
            Else
                MessageBox.Show("Please choose a file to encrypt")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Try
        End Try
    End Sub

    'Here we handle the decryption of the encrypted DAT file
    Private Sub Decrypt_file(sender As System.Object, e As System.EventArgs) Handles Decrypt.Click
        Try
            Dim result As DialogResult = OpenFileDialog1.ShowDialog()

            If result = DialogResult.OK Then
                Dim EncryptedFileLocation As String = OpenFileDialog1.FileName
                Dim directoryPath As String = Path.GetDirectoryName(EncryptedFileLocation)
                Dim filename = Path.GetFileNameWithoutExtension(System.IO.Path.GetFileName(OpenFileDialog1.FileName))

                DecryptFile(EncryptedFileLocation, directoryPath + "\Decrypted_" + filename)
                MessageBox.Show("File Decrypted Successfully, starting with (Decrypted_) followed by the same filename, in the same directory as Encrypted file.")
            Else
                MessageBox.Show("Please choose an encrypted file")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Try
        End Try
    End Sub

    Private Sub Exit_Button_Click(sender As System.Object, e As System.EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
#End Region

#Region "functions"
    Public Function EncryptFile(ByVal keyUserId As String, ByVal sourceFile As String, ByVal encryptedFile As String)
        If String.IsNullOrEmpty(keyUserId) Then Throw New ArgumentException("Public key name is either empty or null", "keyUserId")
        If String.IsNullOrEmpty(sourceFile) Then Throw New ArgumentException("sourceFile parameter is either empty or null", "sourceFile")
        If String.IsNullOrEmpty(encryptedFile) Then Throw New ArgumentException("encryptedFile parameter is either empty or null", "encryptedFile")

        Using sourceFileStream As Stream = New FileStream(sourceFile, FileMode.Open)
            Using encryptedFileStream As Stream = New FileStream(encryptedFile, FileMode.Create)
                gpg.BinaryPath = Path.GetDirectoryName(appPath)
                gpg.Recipient = keyUserId
                gpg.Encrypt(sourceFileStream, encryptedFileStream)
            End Using
        End Using
        Return 0
    End Function

    Public Function DecryptFile(ByVal encryptedSourceFile As String, ByVal decryptedFile As String)
        If String.IsNullOrEmpty(encryptedSourceFile) Then Throw New ArgumentException("encryptedSourceFile parameter is either empty or null", "encryptedSourceFile")
        If String.IsNullOrEmpty(decryptedFile) Then Throw New ArgumentException("decryptedFile parameter is either empty or null", "decryptedFile")

        Using encryptedSourceFileStream As FileStream = New FileStream(encryptedSourceFile, FileMode.Open)
            encryptedSourceFileStream.Position = 0

            Using decryptedFileStream As FileStream = New FileStream(decryptedFile, FileMode.Create)
                gpg.BinaryPath = Path.GetDirectoryName(appPath)
                gpg.Passphrase = passPhrase  'The security passphrase you created while creating the keys.
                gpg.Decrypt(encryptedSourceFileStream, decryptedFileStream)
            End Using
        End Using
        Return 0
    End Function
#End Region

End Class
