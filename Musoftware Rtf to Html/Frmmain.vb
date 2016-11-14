Imports Itenso.Sys.Application
Imports Itenso.Rtf
Imports Itenso.Rtf.Support
Imports Itenso.Rtf.Parser
Imports Itenso.Rtf.Interpreter
Imports Itenso.Rtf.Converter.Image
Imports Itenso.Rtf.Converter.Html

Public Class Frmmain

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.Load

    End Sub

    Private Sub Frmmain_Load(sender As Object, e As EventArgs) Handles Me.Load
        RichTextBoxJmb1.RichTextBox.Text = ""
        AddHandler RichTextBoxJmb1.RichTextBox.TextChanged, AddressOf textchangeds

    End Sub
    Sub textchangeds()
        FastColoredTextBox1.Text = RTFTOHTMLL(RichTextBoxJmb1.RichTextBox.Rtf)
    End Sub

    Function RTFTOHTMLL(rtfText As String) As String
        Dim rtfDocument As IRtfDocument = RtfInterpreterTool.BuildDoc(rtfText)

        Dim settings As RtfHtmlConvertSettings = New RtfHtmlConvertSettings()
        settings.ConvertScope = RtfHtmlConvertScope.Content

        Dim htmlConverter As RtfHtmlConverter = New RtfHtmlConverter(rtfDocument, settings)
        Return htmlConverter.Convert()

    End Function


    Private Sub RichTextBoxJmb1_Load(sender As Object, e As EventArgs) Handles RichTextBoxJmb1.Load

    End Sub
End Class
