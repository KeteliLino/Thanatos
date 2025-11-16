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

        AddHandler MaterialTabControl1.SelectedIndexChanged, AddressOf TabControl_SelectedIndexChanged
    End Sub
    Private Sub frm_financeiro_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' editando picture box
        If PictureBox3 IsNot Nothing Then
            PictureBox3.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox3.BorderStyle = BorderStyle.None
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

    Private Sub btn_incluir_Click(sender As Object, e As EventArgs) Handles btn_incluir.Click

    End Sub

    Private Sub btn_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_pesquisar.Click

    End Sub
End Class
