Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Code généré par le Concepteur Windows Form "

    Public Sub New()
        MyBase.New()

        'Cet appel est requis par le Concepteur Windows Form.
        InitializeComponent()

        'Ajoutez une initialisation quelconque après l'appel InitializeComponent()

    End Sub

    'La méthode substituée Dispose du formulaire pour nettoyer la liste des composants.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requis par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée en utilisant le Concepteur Windows Form.  
    'Ne la modifiez pas en utilisant l'éditeur de code.
    Friend WithEvents RichTextBoxJmb1 As RichTextBoxJmb.RichTextBoxJmb
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RichTextBoxJmb1 = New RichTextBoxJmb.RichTextBoxJmb
        Me.SuspendLayout()
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
        Me.RichTextBoxJmb1.Size = New System.Drawing.Size(742, 426)
        Me.RichTextBoxJmb1.StampAction = RichTextBoxJmb.RichTextBoxJmb.StampActions.Editepar
        Me.RichTextBoxJmb1.StampColor = System.Drawing.Color.Blue
        Me.RichTextBoxJmb1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(742, 426)
        Me.Controls.Add(Me.RichTextBoxJmb1)
        Me.Name = "Form1"
        Me.Text = "Test de RichTextBoxJMB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            RichTextBoxJmb1.RichTextBox.LoadFile(Application.StartupPath & "\RichTextBoxJMB.rtf")
        Catch err As Exception
            MsgBox("Ouverture de " & Application.StartupPath & "\RichTextBoxJMB.rtf impossible.")
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs)

    End Sub
End Class
