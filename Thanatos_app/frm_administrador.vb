Imports System.Drawing
Imports System.ComponentModel
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class frm_administrador
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
            ' wire no construtor ou no Load:
            AddHandler MaterialTabControl1.SelectedIndexChanged, AddressOf TabControl_SelectedIndexChanged
        End If
    End Sub



    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim tc = DirectCast(sender, TabControl)
        If tc.SelectedTab IsNot Nothing AndAlso tc.SelectedTab.Name = "tab_voltar" Then
            ' Ação quando a aba "tab_voltar" for selecionada
            frm_home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub frm_administrador_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If PictureBox3 IsNot Nothing Then
            PictureBox3.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox3.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub frm_administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class