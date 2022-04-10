<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnSelectPicture = New System.Windows.Forms.Button()
        Me.ofPictureFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.pictureBoxViewer = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBoxViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Location = New System.Drawing.Point(583, 518)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(136, 29)
        Me.btnSelectPicture.TabIndex = 0
        Me.btnSelectPicture.Text = "Browse Picture"
        Me.btnSelectPicture.UseVisualStyleBackColor = True
        '
        'ofPictureFileDialog
        '
        Me.ofPictureFileDialog.Filter = "JPEG Files|*.JPG"
        Me.ofPictureFileDialog.Title = "Browse Picture"
        '
        'pictureBoxViewer
        '
        Me.pictureBoxViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBoxViewer.Location = New System.Drawing.Point(12, 12)
        Me.pictureBoxViewer.Name = "pictureBoxViewer"
        Me.pictureBoxViewer.Size = New System.Drawing.Size(707, 500)
        Me.pictureBoxViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxViewer.TabIndex = 1
        Me.pictureBoxViewer.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(731, 559)
        Me.Controls.Add(Me.pictureBoxViewer)
        Me.Controls.Add(Me.btnSelectPicture)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBoxViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelectPicture As Button
    Friend WithEvents ofPictureFileDialog As OpenFileDialog
    Friend WithEvents pictureBoxViewer As PictureBox
End Class
