<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manual))
        Me.rtxtManual = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtxtManual
        '
        Me.rtxtManual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxtManual.Location = New System.Drawing.Point(1, 1)
        Me.rtxtManual.Name = "rtxtManual"
        Me.rtxtManual.ReadOnly = True
        Me.rtxtManual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtxtManual.Size = New System.Drawing.Size(536, 657)
        Me.rtxtManual.TabIndex = 0
        Me.rtxtManual.Text = "Open File - "
        '
        'Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 657)
        Me.Controls.Add(Me.rtxtManual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Manual"
        Me.Text = "Manual"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtxtManual As RichTextBox
End Class
