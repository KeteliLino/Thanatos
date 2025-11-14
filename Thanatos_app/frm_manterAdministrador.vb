Imports System.Drawing
Imports System.ComponentModel
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class frm_manterAdministrador
    Private ReadOnly materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

    Public Sub New()
        InitializeComponent()

        ' Evita executar quando o Visual Studio está no Designer
        If LicenseManager.UsageMode = LicenseUsageMode.Runtime Then
            ' Registra o form no MaterialSkinManager
            materialSkinManager.AddFormToManage(Me)

            ' Tema: LIGHT ou DARK
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK

            ' Color scheme (use HEX convertendo para Color)
            materialSkinManager.ColorScheme = New ColorScheme(
                ColorTranslator.FromHtml("#802790"), ' Primary
                ColorTranslator.FromHtml("#802790"), ' Dark Primary
                ColorTranslator.FromHtml("#FFFFFF"), ' Light Primary
                ColorTranslator.FromHtml("#802790"), ' Accent
                TextShade.WHITE)
        End If
    End Sub

    Private Sub frm_manterAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' lógica do form...
    End Sub
End Class