<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmain))
        Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBoxJmb1 = New Musoftware_Rtf_to_Html.RichTextBoxJmb()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FastColoredTextBox1
        '
        Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.FastColoredTextBox1.BackBrush = Nothing
        Me.FastColoredTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        Me.FastColoredTextBox1.Location = New System.Drawing.Point(2, 2)
        Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
        Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox1.Size = New System.Drawing.Size(674, 228)
        Me.FastColoredTextBox1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FastColoredTextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(678, 232)
        Me.Panel1.TabIndex = 2
        '
        'RichTextBoxJmb1
        '
        Me.RichTextBoxJmb1.DetectURLs = True
        Me.RichTextBoxJmb1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxJmb1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxJmb1.Name = "RichTextBoxJmb1"
        Me.RichTextBoxJmb1.ShowBold = True
        Me.RichTextBoxJmb1.ShowCenterJustify = True
        Me.RichTextBoxJmb1.ShowColors = True
        Me.RichTextBoxJmb1.ShowFont = True
        Me.RichTextBoxJmb1.ShowFontSize = True
        Me.RichTextBoxJmb1.ShowItalic = True
        Me.RichTextBoxJmb1.ShowLeftJustify = True
        Me.RichTextBoxJmb1.Shownormal = True
        Me.RichTextBoxJmb1.ShowOpen = True
        Me.RichTextBoxJmb1.ShowPreview = True
        Me.RichTextBoxJmb1.ShowPrint = True
        Me.RichTextBoxJmb1.ShowQuit = True
        Me.RichTextBoxJmb1.ShowRedo = True
        Me.RichTextBoxJmb1.ShowRightJustify = True
        Me.RichTextBoxJmb1.ShowSave = True
        Me.RichTextBoxJmb1.ShowStamp = True
        Me.RichTextBoxJmb1.ShowStrikeout = True
        Me.RichTextBoxJmb1.ShowUnderline = True
        Me.RichTextBoxJmb1.ShowUndo = True
        Me.RichTextBoxJmb1.Size = New System.Drawing.Size(678, 226)
        Me.RichTextBoxJmb1.StampAction = Musoftware_Rtf_to_Html.RichTextBoxJmb.StampActions.Editepar
        Me.RichTextBoxJmb1.StampColor = System.Drawing.Color.Blue
        Me.RichTextBoxJmb1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RichTextBoxJmb1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(678, 462)
        Me.SplitContainer1.SplitterDistance = 226
        Me.SplitContainer1.TabIndex = 3
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 462)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musoftware Rtf to Html"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBoxJmb1 As Musoftware_Rtf_to_Html.RichTextBoxJmb
    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
