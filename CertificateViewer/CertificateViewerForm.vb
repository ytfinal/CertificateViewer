Imports System.Security.Cryptography.X509Certificates

Public Class CertificateViewerForm
    Private x509Cert As X509Certificate2
    Private ReturnBase64CertString As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BroweButton_Click(sender As Object, e As EventArgs) Handles BroweButton.Click
        If CertFileOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            CertPathTextBox.Text = CertFileOpenFileDialog.FileName
        End If
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        ClearCertificateInfo()
        If My.Computer.FileSystem.FileExists(CertPathTextBox.Text) Then
            If CertPathTextBox.Text.EndsWith(".cer") Then
                Try
                    Dim CerFileBytes As Byte() = System.IO.File.ReadAllBytes(CertPathTextBox.Text)
                    CertBase64TextBox.Text = System.Text.Encoding.UTF8.GetString(CerFileBytes, 0, CerFileBytes.Length)
                    x509Cert = New X509Certificate2(CerFileBytes)
                Catch ex As Exception
                    MessageBox.Show("Error Loading Public Key Certficate (.cer)" & vbCrLf & ex.Message)
                End Try
                LoadCertificateInfo()
            ElseIf CertPathTextBox.Text.EndsWith(".pfx") Then
                Try
                    Dim PFXFileBytes As Byte() = System.IO.File.ReadAllBytes(CertPathTextBox.Text)
                    Dim PFXFileInBase64 As String = Convert.ToBase64String(PFXFileBytes)
                    CertBase64TextBox.Text = PFXFileInBase64
                    x509Cert = New X509Certificate2(PFXFileBytes, PFXPasswordTextBox.Text)
                    LoadCertificateInfo()
                Catch ex As Exception
                    MessageBox.Show("Error Loading Private Key Certficate (.pfx)" & ex.Message)
                End Try
            Else
                MessageBox.Show("Unsupported Certificate file format... Please load .cer or .pfx")
            End If
        Else
            MessageBox.Show("File not found!")
        End If
    End Sub

    Private Sub CertPathTextBox_DragEnter(sender As Object, e As DragEventArgs) Handles CertPathTextBox.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub CertPathTextBox_DragDrop(sender As Object, e As DragEventArgs) Handles CertPathTextBox.DragDrop
        Dim FileDropContents As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each FileDropContent As String In FileDropContents
            CertPathTextBox.Text = FileDropContent
        Next
    End Sub

    Private Sub LoadCertificateInfo()
        SubjectTextBox.Text = x509Cert.Subject
        IssuerTextBox.Text = x509Cert.Issuer
        VersionTextBox.Text = x509Cert.Version
        ValidDateTextBox.Text = x509Cert.NotBefore
        ExpiryDateTextBox.Text = x509Cert.NotAfter
        ThumbprintTextBox.Text = x509Cert.Thumbprint
        SerialNumberTextBox.Text = x509Cert.SerialNumber
        FriendlyNameTextBox.Text = x509Cert.PublicKey.Oid.FriendlyName
        PublicKeyFormatTextBox.Text = x509Cert.PublicKey.EncodedKeyValue.Format(True)
        RawDataLengthTextBox.Text = x509Cert.RawData.Length
        CertificateToStringTextBox.Text = x509Cert.ToString(True)
        CertificateToXMLTextBox.Text = x509Cert.PublicKey.Key.ToXmlString(False)
    End Sub

    Private Sub ClearCertificateInfo()
        CertBase64TextBox.Text = ""
        SubjectTextBox.Text = ""
        IssuerTextBox.Text = ""
        VersionTextBox.Text = ""
        ValidDateTextBox.Text = ""
        ExpiryDateTextBox.Text = ""
        ThumbprintTextBox.Text = ""
        SerialNumberTextBox.Text = ""
        FriendlyNameTextBox.Text = ""
        PublicKeyFormatTextBox.Text = ""
        RawDataLengthTextBox.Text = ""
        CertificateToStringTextBox.Text = ""
        CertificateToXMLTextBox.Text = ""
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs)
        ReturnBase64CertString = CertBase64TextBox.Text
        Me.Close()
    End Sub
End Class
