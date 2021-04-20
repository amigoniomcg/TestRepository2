<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailsForm
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
        Me.closeButton = New System.Windows.Forms.Button()
        Me.contentTextBox = New System.Windows.Forms.TextBox()
        Me.copyToClipboardButton = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'closeButton
        '
        Me.closeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.closeButton.Location = New System.Drawing.Point(217, 277)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 2
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = true
        '
        'contentTextBox
        '
        Me.contentTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.contentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.contentTextBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.contentTextBox.Location = New System.Drawing.Point(12, 12)
        Me.contentTextBox.Multiline = true
        Me.contentTextBox.Name = "contentTextBox"
        Me.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.contentTextBox.Size = New System.Drawing.Size(280, 259)
        Me.contentTextBox.TabIndex = 3
        Me.contentTextBox.WordWrap = false
        '
        'copyToClipboardButton
        '
        Me.copyToClipboardButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.copyToClipboardButton.Location = New System.Drawing.Point(30, 257)
        Me.copyToClipboardButton.Name = "copyToClipboardButton"
        Me.copyToClipboardButton.Size = New System.Drawing.Size(75, 23)
        Me.copyToClipboardButton.TabIndex = 4
        Me.copyToClipboardButton.Text = "Copy"
        Me.copyToClipboardButton.UseVisualStyleBackColor = true
        '
        'DetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 312)
        Me.Controls.Add(Me.copyToClipboardButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.contentTextBox)
        Me.Name = "DetailsForm"
        Me.Text = "Details"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents closeButton As System.Windows.Forms.Button
    Public WithEvents contentTextBox As System.Windows.Forms.TextBox
    Private WithEvents copyToClipboardButton As Button
End Class