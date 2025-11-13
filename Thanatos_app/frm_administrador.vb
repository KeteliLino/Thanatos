Imports System.Drawing
Imports MaterialSkin
Imports MaterialSkin.Controls
Public Class frm_administrador
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

    Private Sub frm_administrador_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' editando picture box
        If PictureBox1 IsNot Nothing Then
            PictureBox1.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.BorderStyle = BorderStyle.None
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

    Private Sub btn_recepcao_Click(sender As Object, e As EventArgs) Handles btn_recepcao.Click
        frm_recepcionista.Show()
        Me.Hide()
    End Sub
End Class