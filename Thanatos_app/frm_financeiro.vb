Imports System.Drawing
Imports MaterialSkin
Imports MaterialSkin.Controls
Public Class frm_financeiro
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
            ColorTranslator.FromHtml("#FFFFFF"), ' Light Primary
            ColorTranslator.FromHtml("#802790"), ' Accent
            TextShade.WHITE)
    End Sub
    Private Sub frm_financeiro_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' editando picture box
        If PictureBox3 IsNot Nothing Then
            PictureBox3.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox3.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        frm_home.Show()
        Me.Hide()
    End Sub

    Private Sub btn_recepcao_Click(sender As Object, e As EventArgs) Handles btn_recepcao.Click
        frm_recepcionista.Show()
        Me.Hide()
    End Sub

    Private Sub btn_administracao_Click(sender As Object, e As EventArgs) Handles btn_administracao.Click
        frm_administrador.Show()
        Me.Hide()
    End Sub
End Class