Imports System.Drawing
Imports System.ComponentModel
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports System.Threading

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

        End If
    End Sub

    Private Sub frm_administrador_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_dataCremacao.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txt_dataVelorio.Text = DateTime.Now.ToString("dd/MM/yyyy")
        If PictureBox3 IsNot Nothing Then
            PictureBox3.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox3.BorderStyle = BorderStyle.None
        End If
    End Sub
    Private Sub Voltar()
        frm_home.Show()
        Me.Hide()
    End Sub
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Voltar()
    End Sub

    Private Sub btn_voltar1_Click(sender As Object, e As EventArgs) Handles btn_voltar1.Click
        Voltar()
    End Sub

    Private Sub btn_voltar2_Click(sender As Object, e As EventArgs) Handles btn_voltar2.Click
        Voltar()
    End Sub

    Private Sub btn_voltar3_Click(sender As Object, e As EventArgs) Handles btn_voltar3.Click
        Voltar()
    End Sub

    Private Sub btn_voltar4_Click(sender As Object, e As EventArgs) Handles btn_voltar4.Click
        Voltar()
    End Sub

    Private Sub btn_voltar5_Click(sender As Object, e As EventArgs) Handles btn_voltar5.Click
        Voltar()
    End Sub

    Private Sub btn_voltar6_Click(sender As Object, e As EventArgs) Handles btn_voltar6.Click
        Voltar()
    End Sub

    Private Sub frm_administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class