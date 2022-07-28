<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CertificateViewerForm
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
        Me.CertPathGroupBox = New System.Windows.Forms.GroupBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.BroweButton = New System.Windows.Forms.Button()
        Me.CertPathTextBox = New System.Windows.Forms.TextBox()
        Me.CertFileOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.CertBase64GroupBox = New System.Windows.Forms.GroupBox()
        Me.CertBase64TextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.PFXPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.IssuerGroupBox = New System.Windows.Forms.GroupBox()
        Me.IssuerTextBox = New System.Windows.Forms.TextBox()
        Me.VersionGroupBox = New System.Windows.Forms.GroupBox()
        Me.VersionTextBox = New System.Windows.Forms.TextBox()
        Me.ValidDateGroupBox = New System.Windows.Forms.GroupBox()
        Me.ValidDateTextBox = New System.Windows.Forms.TextBox()
        Me.ExpiryDateGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExpiryDateTextBox = New System.Windows.Forms.TextBox()
        Me.ThumbprintGroupBox = New System.Windows.Forms.GroupBox()
        Me.ThumbprintTextBox = New System.Windows.Forms.TextBox()
        Me.SerialNumberGroupBox = New System.Windows.Forms.GroupBox()
        Me.SerialNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FriendlyNameGroupBox = New System.Windows.Forms.GroupBox()
        Me.FriendlyNameTextBox = New System.Windows.Forms.TextBox()
        Me.PublicKeyFormatGroupBox = New System.Windows.Forms.GroupBox()
        Me.PublicKeyFormatTextBox = New System.Windows.Forms.TextBox()
        Me.RawDataLengthGroupBox = New System.Windows.Forms.GroupBox()
        Me.RawDataLengthTextBox = New System.Windows.Forms.TextBox()
        Me.CertificateToStringGroupBox = New System.Windows.Forms.GroupBox()
        Me.CertificateToStringTextBox = New System.Windows.Forms.TextBox()
        Me.CertificateToXMLStringGroupBox = New System.Windows.Forms.GroupBox()
        Me.CertificateToXMLTextBox = New System.Windows.Forms.TextBox()
        Me.CertPathGroupBox.SuspendLayout()
        Me.CertBase64GroupBox.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.IssuerGroupBox.SuspendLayout()
        Me.VersionGroupBox.SuspendLayout()
        Me.ValidDateGroupBox.SuspendLayout()
        Me.ExpiryDateGroupBox.SuspendLayout()
        Me.ThumbprintGroupBox.SuspendLayout()
        Me.SerialNumberGroupBox.SuspendLayout()
        Me.FriendlyNameGroupBox.SuspendLayout()
        Me.PublicKeyFormatGroupBox.SuspendLayout()
        Me.RawDataLengthGroupBox.SuspendLayout()
        Me.CertificateToStringGroupBox.SuspendLayout()
        Me.CertificateToXMLStringGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CertPathGroupBox
        '
        Me.CertPathGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CertPathGroupBox.Controls.Add(Me.LoadButton)
        Me.CertPathGroupBox.Controls.Add(Me.BroweButton)
        Me.CertPathGroupBox.Controls.Add(Me.CertPathTextBox)
        Me.CertPathGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.CertPathGroupBox.Name = "CertPathGroupBox"
        Me.CertPathGroupBox.Size = New System.Drawing.Size(1012, 58)
        Me.CertPathGroupBox.TabIndex = 0
        Me.CertPathGroupBox.TabStop = False
        Me.CertPathGroupBox.Text = "Certificate Path"
        '
        'LoadButton
        '
        Me.LoadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadButton.Location = New System.Drawing.Point(931, 19)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadButton.TabIndex = 2
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'BroweButton
        '
        Me.BroweButton.Location = New System.Drawing.Point(6, 19)
        Me.BroweButton.Name = "BroweButton"
        Me.BroweButton.Size = New System.Drawing.Size(75, 23)
        Me.BroweButton.TabIndex = 1
        Me.BroweButton.Text = "Browse"
        Me.BroweButton.UseVisualStyleBackColor = True
        '
        'CertPathTextBox
        '
        Me.CertPathTextBox.AllowDrop = True
        Me.CertPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CertPathTextBox.Location = New System.Drawing.Point(87, 21)
        Me.CertPathTextBox.Name = "CertPathTextBox"
        Me.CertPathTextBox.Size = New System.Drawing.Size(838, 20)
        Me.CertPathTextBox.TabIndex = 0
        '
        'CertFileOpenFileDialog
        '
        Me.CertFileOpenFileDialog.Filter = "Certificate Files|*.cer; *.pfx|All files (*.*)|*.*"
        '
        'CertBase64GroupBox
        '
        Me.CertBase64GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CertBase64GroupBox.Controls.Add(Me.CertBase64TextBox)
        Me.CertBase64GroupBox.Location = New System.Drawing.Point(12, 76)
        Me.CertBase64GroupBox.Name = "CertBase64GroupBox"
        Me.CertBase64GroupBox.Size = New System.Drawing.Size(318, 793)
        Me.CertBase64GroupBox.TabIndex = 1
        Me.CertBase64GroupBox.TabStop = False
        Me.CertBase64GroupBox.Text = "Base64 String"
        '
        'CertBase64TextBox
        '
        Me.CertBase64TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CertBase64TextBox.Location = New System.Drawing.Point(6, 19)
        Me.CertBase64TextBox.Multiline = True
        Me.CertBase64TextBox.Name = "CertBase64TextBox"
        Me.CertBase64TextBox.ReadOnly = True
        Me.CertBase64TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CertBase64TextBox.Size = New System.Drawing.Size(306, 768)
        Me.CertBase64TextBox.TabIndex = 0
        '
        'GroupBox
        '
        Me.GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox.Controls.Add(Me.SubjectTextBox)
        Me.GroupBox.Location = New System.Drawing.Point(336, 102)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(688, 52)
        Me.GroupBox.TabIndex = 2
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Subject"
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubjectTextBox.Location = New System.Drawing.Point(6, 19)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.ReadOnly = True
        Me.SubjectTextBox.Size = New System.Drawing.Size(676, 20)
        Me.SubjectTextBox.TabIndex = 0
        '
        'PFXPasswordTextBox
        '
        Me.PFXPasswordTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PFXPasswordTextBox.Location = New System.Drawing.Point(663, 76)
        Me.PFXPasswordTextBox.Name = "PFXPasswordTextBox"
        Me.PFXPasswordTextBox.Size = New System.Drawing.Size(361, 20)
        Me.PFXPasswordTextBox.TabIndex = 3
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(557, 79)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(100, 13)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Password (for .pfx): "
        '
        'IssuerGroupBox
        '
        Me.IssuerGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IssuerGroupBox.Controls.Add(Me.IssuerTextBox)
        Me.IssuerGroupBox.Location = New System.Drawing.Point(336, 160)
        Me.IssuerGroupBox.Name = "IssuerGroupBox"
        Me.IssuerGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.IssuerGroupBox.TabIndex = 3
        Me.IssuerGroupBox.TabStop = False
        Me.IssuerGroupBox.Text = "Issuer"
        '
        'IssuerTextBox
        '
        Me.IssuerTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IssuerTextBox.Location = New System.Drawing.Point(6, 19)
        Me.IssuerTextBox.Name = "IssuerTextBox"
        Me.IssuerTextBox.ReadOnly = True
        Me.IssuerTextBox.Size = New System.Drawing.Size(676, 20)
        Me.IssuerTextBox.TabIndex = 0
        '
        'VersionGroupBox
        '
        Me.VersionGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionGroupBox.Controls.Add(Me.VersionTextBox)
        Me.VersionGroupBox.Location = New System.Drawing.Point(336, 218)
        Me.VersionGroupBox.Name = "VersionGroupBox"
        Me.VersionGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.VersionGroupBox.TabIndex = 5
        Me.VersionGroupBox.TabStop = False
        Me.VersionGroupBox.Text = "Version"
        '
        'VersionTextBox
        '
        Me.VersionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionTextBox.Location = New System.Drawing.Point(6, 19)
        Me.VersionTextBox.Name = "VersionTextBox"
        Me.VersionTextBox.ReadOnly = True
        Me.VersionTextBox.Size = New System.Drawing.Size(676, 20)
        Me.VersionTextBox.TabIndex = 0
        '
        'ValidDateGroupBox
        '
        Me.ValidDateGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValidDateGroupBox.Controls.Add(Me.ValidDateTextBox)
        Me.ValidDateGroupBox.Location = New System.Drawing.Point(336, 276)
        Me.ValidDateGroupBox.Name = "ValidDateGroupBox"
        Me.ValidDateGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.ValidDateGroupBox.TabIndex = 6
        Me.ValidDateGroupBox.TabStop = False
        Me.ValidDateGroupBox.Text = "Valid Date"
        '
        'ValidDateTextBox
        '
        Me.ValidDateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValidDateTextBox.Location = New System.Drawing.Point(6, 19)
        Me.ValidDateTextBox.Name = "ValidDateTextBox"
        Me.ValidDateTextBox.ReadOnly = True
        Me.ValidDateTextBox.Size = New System.Drawing.Size(676, 20)
        Me.ValidDateTextBox.TabIndex = 0
        '
        'ExpiryDateGroupBox
        '
        Me.ExpiryDateGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpiryDateGroupBox.Controls.Add(Me.ExpiryDateTextBox)
        Me.ExpiryDateGroupBox.Location = New System.Drawing.Point(336, 334)
        Me.ExpiryDateGroupBox.Name = "ExpiryDateGroupBox"
        Me.ExpiryDateGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.ExpiryDateGroupBox.TabIndex = 7
        Me.ExpiryDateGroupBox.TabStop = False
        Me.ExpiryDateGroupBox.Text = "Expiry Date"
        '
        'ExpiryDateTextBox
        '
        Me.ExpiryDateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpiryDateTextBox.Location = New System.Drawing.Point(6, 19)
        Me.ExpiryDateTextBox.Name = "ExpiryDateTextBox"
        Me.ExpiryDateTextBox.ReadOnly = True
        Me.ExpiryDateTextBox.Size = New System.Drawing.Size(676, 20)
        Me.ExpiryDateTextBox.TabIndex = 0
        '
        'ThumbprintGroupBox
        '
        Me.ThumbprintGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThumbprintGroupBox.Controls.Add(Me.ThumbprintTextBox)
        Me.ThumbprintGroupBox.Location = New System.Drawing.Point(336, 392)
        Me.ThumbprintGroupBox.Name = "ThumbprintGroupBox"
        Me.ThumbprintGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.ThumbprintGroupBox.TabIndex = 8
        Me.ThumbprintGroupBox.TabStop = False
        Me.ThumbprintGroupBox.Text = "Thumbprint"
        '
        'ThumbprintTextBox
        '
        Me.ThumbprintTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ThumbprintTextBox.Location = New System.Drawing.Point(6, 19)
        Me.ThumbprintTextBox.Name = "ThumbprintTextBox"
        Me.ThumbprintTextBox.ReadOnly = True
        Me.ThumbprintTextBox.Size = New System.Drawing.Size(676, 20)
        Me.ThumbprintTextBox.TabIndex = 0
        '
        'SerialNumberGroupBox
        '
        Me.SerialNumberGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SerialNumberGroupBox.Controls.Add(Me.SerialNumberTextBox)
        Me.SerialNumberGroupBox.Location = New System.Drawing.Point(336, 450)
        Me.SerialNumberGroupBox.Name = "SerialNumberGroupBox"
        Me.SerialNumberGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.SerialNumberGroupBox.TabIndex = 9
        Me.SerialNumberGroupBox.TabStop = False
        Me.SerialNumberGroupBox.Text = "Serial Number"
        '
        'SerialNumberTextBox
        '
        Me.SerialNumberTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SerialNumberTextBox.Location = New System.Drawing.Point(6, 19)
        Me.SerialNumberTextBox.Name = "SerialNumberTextBox"
        Me.SerialNumberTextBox.ReadOnly = True
        Me.SerialNumberTextBox.Size = New System.Drawing.Size(676, 20)
        Me.SerialNumberTextBox.TabIndex = 0
        '
        'FriendlyNameGroupBox
        '
        Me.FriendlyNameGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FriendlyNameGroupBox.Controls.Add(Me.FriendlyNameTextBox)
        Me.FriendlyNameGroupBox.Location = New System.Drawing.Point(336, 508)
        Me.FriendlyNameGroupBox.Name = "FriendlyNameGroupBox"
        Me.FriendlyNameGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.FriendlyNameGroupBox.TabIndex = 10
        Me.FriendlyNameGroupBox.TabStop = False
        Me.FriendlyNameGroupBox.Text = "Friendly Name"
        '
        'FriendlyNameTextBox
        '
        Me.FriendlyNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FriendlyNameTextBox.Location = New System.Drawing.Point(6, 19)
        Me.FriendlyNameTextBox.Name = "FriendlyNameTextBox"
        Me.FriendlyNameTextBox.ReadOnly = True
        Me.FriendlyNameTextBox.Size = New System.Drawing.Size(676, 20)
        Me.FriendlyNameTextBox.TabIndex = 0
        '
        'PublicKeyFormatGroupBox
        '
        Me.PublicKeyFormatGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublicKeyFormatGroupBox.Controls.Add(Me.PublicKeyFormatTextBox)
        Me.PublicKeyFormatGroupBox.Location = New System.Drawing.Point(336, 566)
        Me.PublicKeyFormatGroupBox.Name = "PublicKeyFormatGroupBox"
        Me.PublicKeyFormatGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.PublicKeyFormatGroupBox.TabIndex = 11
        Me.PublicKeyFormatGroupBox.TabStop = False
        Me.PublicKeyFormatGroupBox.Text = "Public Key Format"
        '
        'PublicKeyFormatTextBox
        '
        Me.PublicKeyFormatTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublicKeyFormatTextBox.Location = New System.Drawing.Point(6, 19)
        Me.PublicKeyFormatTextBox.Name = "PublicKeyFormatTextBox"
        Me.PublicKeyFormatTextBox.ReadOnly = True
        Me.PublicKeyFormatTextBox.Size = New System.Drawing.Size(676, 20)
        Me.PublicKeyFormatTextBox.TabIndex = 0
        '
        'RawDataLengthGroupBox
        '
        Me.RawDataLengthGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RawDataLengthGroupBox.Controls.Add(Me.RawDataLengthTextBox)
        Me.RawDataLengthGroupBox.Location = New System.Drawing.Point(336, 624)
        Me.RawDataLengthGroupBox.Name = "RawDataLengthGroupBox"
        Me.RawDataLengthGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.RawDataLengthGroupBox.TabIndex = 12
        Me.RawDataLengthGroupBox.TabStop = False
        Me.RawDataLengthGroupBox.Text = "Raw Data Length"
        '
        'RawDataLengthTextBox
        '
        Me.RawDataLengthTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RawDataLengthTextBox.Location = New System.Drawing.Point(6, 19)
        Me.RawDataLengthTextBox.Name = "RawDataLengthTextBox"
        Me.RawDataLengthTextBox.ReadOnly = True
        Me.RawDataLengthTextBox.Size = New System.Drawing.Size(676, 20)
        Me.RawDataLengthTextBox.TabIndex = 0
        '
        'CertificateToStringGroupBox
        '
        Me.CertificateToStringGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CertificateToStringGroupBox.Controls.Add(Me.CertificateToStringTextBox)
        Me.CertificateToStringGroupBox.Location = New System.Drawing.Point(336, 682)
        Me.CertificateToStringGroupBox.Name = "CertificateToStringGroupBox"
        Me.CertificateToStringGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.CertificateToStringGroupBox.TabIndex = 13
        Me.CertificateToStringGroupBox.TabStop = False
        Me.CertificateToStringGroupBox.Text = "Certificate To String"
        '
        'CertificateToStringTextBox
        '
        Me.CertificateToStringTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CertificateToStringTextBox.Location = New System.Drawing.Point(6, 19)
        Me.CertificateToStringTextBox.Name = "CertificateToStringTextBox"
        Me.CertificateToStringTextBox.ReadOnly = True
        Me.CertificateToStringTextBox.Size = New System.Drawing.Size(676, 20)
        Me.CertificateToStringTextBox.TabIndex = 0
        '
        'CertificateToXMLStringGroupBox
        '
        Me.CertificateToXMLStringGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CertificateToXMLStringGroupBox.Controls.Add(Me.CertificateToXMLTextBox)
        Me.CertificateToXMLStringGroupBox.Location = New System.Drawing.Point(336, 740)
        Me.CertificateToXMLStringGroupBox.Name = "CertificateToXMLStringGroupBox"
        Me.CertificateToXMLStringGroupBox.Size = New System.Drawing.Size(688, 52)
        Me.CertificateToXMLStringGroupBox.TabIndex = 14
        Me.CertificateToXMLStringGroupBox.TabStop = False
        Me.CertificateToXMLStringGroupBox.Text = "Certificate To XML String"
        '
        'CertificateToXMLTextBox
        '
        Me.CertificateToXMLTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CertificateToXMLTextBox.Location = New System.Drawing.Point(6, 19)
        Me.CertificateToXMLTextBox.Name = "CertificateToXMLTextBox"
        Me.CertificateToXMLTextBox.ReadOnly = True
        Me.CertificateToXMLTextBox.Size = New System.Drawing.Size(676, 20)
        Me.CertificateToXMLTextBox.TabIndex = 0
        '
        'CertificateViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 881)
        Me.Controls.Add(Me.CertificateToXMLStringGroupBox)
        Me.Controls.Add(Me.CertificateToStringGroupBox)
        Me.Controls.Add(Me.RawDataLengthGroupBox)
        Me.Controls.Add(Me.PublicKeyFormatGroupBox)
        Me.Controls.Add(Me.FriendlyNameGroupBox)
        Me.Controls.Add(Me.SerialNumberGroupBox)
        Me.Controls.Add(Me.ThumbprintGroupBox)
        Me.Controls.Add(Me.ExpiryDateGroupBox)
        Me.Controls.Add(Me.ValidDateGroupBox)
        Me.Controls.Add(Me.VersionGroupBox)
        Me.Controls.Add(Me.IssuerGroupBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.PFXPasswordTextBox)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.CertBase64GroupBox)
        Me.Controls.Add(Me.CertPathGroupBox)
        Me.Name = "CertificateViewerForm"
        Me.Text = "Certificate Viewer"
        Me.CertPathGroupBox.ResumeLayout(False)
        Me.CertPathGroupBox.PerformLayout()
        Me.CertBase64GroupBox.ResumeLayout(False)
        Me.CertBase64GroupBox.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.IssuerGroupBox.ResumeLayout(False)
        Me.IssuerGroupBox.PerformLayout()
        Me.VersionGroupBox.ResumeLayout(False)
        Me.VersionGroupBox.PerformLayout()
        Me.ValidDateGroupBox.ResumeLayout(False)
        Me.ValidDateGroupBox.PerformLayout()
        Me.ExpiryDateGroupBox.ResumeLayout(False)
        Me.ExpiryDateGroupBox.PerformLayout()
        Me.ThumbprintGroupBox.ResumeLayout(False)
        Me.ThumbprintGroupBox.PerformLayout()
        Me.SerialNumberGroupBox.ResumeLayout(False)
        Me.SerialNumberGroupBox.PerformLayout()
        Me.FriendlyNameGroupBox.ResumeLayout(False)
        Me.FriendlyNameGroupBox.PerformLayout()
        Me.PublicKeyFormatGroupBox.ResumeLayout(False)
        Me.PublicKeyFormatGroupBox.PerformLayout()
        Me.RawDataLengthGroupBox.ResumeLayout(False)
        Me.RawDataLengthGroupBox.PerformLayout()
        Me.CertificateToStringGroupBox.ResumeLayout(False)
        Me.CertificateToStringGroupBox.PerformLayout()
        Me.CertificateToXMLStringGroupBox.ResumeLayout(False)
        Me.CertificateToXMLStringGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CertPathGroupBox As GroupBox
    Friend WithEvents BroweButton As Button
    Friend WithEvents CertPathTextBox As TextBox
    Friend WithEvents LoadButton As Button
    Friend WithEvents CertFileOpenFileDialog As OpenFileDialog
    Friend WithEvents CertBase64GroupBox As GroupBox
    Friend WithEvents CertBase64TextBox As TextBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents SubjectTextBox As TextBox
    Friend WithEvents PFXPasswordTextBox As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents IssuerGroupBox As GroupBox
    Friend WithEvents IssuerTextBox As TextBox
    Friend WithEvents VersionGroupBox As GroupBox
    Friend WithEvents VersionTextBox As TextBox
    Friend WithEvents ValidDateGroupBox As GroupBox
    Friend WithEvents ValidDateTextBox As TextBox
    Friend WithEvents ExpiryDateGroupBox As GroupBox
    Friend WithEvents ExpiryDateTextBox As TextBox
    Friend WithEvents ThumbprintGroupBox As GroupBox
    Friend WithEvents ThumbprintTextBox As TextBox
    Friend WithEvents SerialNumberGroupBox As GroupBox
    Friend WithEvents SerialNumberTextBox As TextBox
    Friend WithEvents FriendlyNameGroupBox As GroupBox
    Friend WithEvents FriendlyNameTextBox As TextBox
    Friend WithEvents PublicKeyFormatGroupBox As GroupBox
    Friend WithEvents PublicKeyFormatTextBox As TextBox
    Friend WithEvents RawDataLengthGroupBox As GroupBox
    Friend WithEvents RawDataLengthTextBox As TextBox
    Friend WithEvents CertificateToStringGroupBox As GroupBox
    Friend WithEvents CertificateToStringTextBox As TextBox
    Friend WithEvents CertificateToXMLStringGroupBox As GroupBox
    Friend WithEvents CertificateToXMLTextBox As TextBox
End Class
