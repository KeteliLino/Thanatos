Imports System.Drawing
Imports MaterialSkin
Imports MaterialSkin.Controls
Public Class frm_recepcionista
    Private ReadOnly materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

    Public Sub New()
        InitializeComponent()

        ' Registra o form no MaterialSkinManager
        materialSkinManager.AddFormToManage(Me)

        ' Tema: LIGHT ou DARK
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK

        ' Exemplo: usando hex diretamente via ColorTranslator.FromHtml
        materialSkinManager.ColorScheme = New ColorScheme(
            ColorTranslator.FromHtml("#802790"), ' Primary
            ColorTranslator.FromHtml("#802790"), ' Dark Primary
            ColorTranslator.FromHtml("#802790"), ' Light Primary
            ColorTranslator.FromHtml("#802790"), ' Accent
            TextShade.WHITE)
    End Sub

    Private Sub frm_recepcionista_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If PictureBox5 IsNot Nothing Then
            PictureBox5.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox5.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        frm_home.Show()
        Me.Hide()
    End Sub

    Private Sub btn_financeiro_Click(sender As Object, e As EventArgs) Handles btn_financeiro.Click
        frm_financeiro.Show()
        Me.Hide()
    End Sub

    Private Sub btn_administracao_Click(sender As Object, e As EventArgs) Handles btn_administracao.Click
        frm_administrador.Show()
        Me.Hide()
    End Sub


End Class