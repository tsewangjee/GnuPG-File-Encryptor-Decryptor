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
        Me.RemoveDoubleQuotes = New System.Windows.Forms.Button()
        Me.Encrypt = New System.Windows.Forms.Button()
        Me.Decrypt = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RemoveDoubleQuotes
        '
        Me.RemoveDoubleQuotes.Location = New System.Drawing.Point(82, 6)
        Me.RemoveDoubleQuotes.Name = "RemoveDoubleQuotes"
        Me.RemoveDoubleQuotes.Size = New System.Drawing.Size(194, 30)
        Me.RemoveDoubleQuotes.TabIndex = 0
        Me.RemoveDoubleQuotes.Text = "Remove Double Quotes"
        Me.RemoveDoubleQuotes.UseVisualStyleBackColor = True
        Me.RemoveDoubleQuotes.Visible = False
        '
        'Encrypt
        '
        Me.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Encrypt.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Encrypt.Location = New System.Drawing.Point(40, 155)
        Me.Encrypt.Name = "Encrypt"
        Me.Encrypt.Size = New System.Drawing.Size(95, 35)
        Me.Encrypt.TabIndex = 1
        Me.Encrypt.Text = "Encrypt"
        Me.Encrypt.UseVisualStyleBackColor = True
        '
        'Decrypt
        '
        Me.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Decrypt.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Decrypt.Location = New System.Drawing.Point(169, 155)
        Me.Decrypt.Name = "Decrypt"
        Me.Decrypt.Size = New System.Drawing.Size(95, 35)
        Me.Decrypt.TabIndex = 2
        Me.Decrypt.Text = "Decrypt"
        Me.Decrypt.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Exit_Button
        '
        Me.Exit_Button.Location = New System.Drawing.Point(128, 264)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(52, 35)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(17, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "GPG Encryption/Decryption Application"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.Decrypt)
        Me.Controls.Add(Me.Encrypt)
        Me.Controls.Add(Me.RemoveDoubleQuotes)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "ESRFileEncryptor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RemoveDoubleQuotes As System.Windows.Forms.Button
    Friend WithEvents Encrypt As System.Windows.Forms.Button
    Friend WithEvents Decrypt As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Exit_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
