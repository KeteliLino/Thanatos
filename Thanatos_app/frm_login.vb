Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class frm_login
    ' Se você preferir instanciar uma vez:
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

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pb As PictureBox = FindFirstPictureBox(Me)
        If pb IsNot Nothing Then
            pb.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            pb.SizeMode = PictureBoxSizeMode.StretchImage
            pb.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Function FindFirstPictureBox(parent As Control) As PictureBox
        For Each c As Control In parent.Controls
            If TypeOf c Is PictureBox Then
                Return DirectCast(c, PictureBox)
            End If
            If c.HasChildren Then
                Dim f = FindFirstPictureBox(c)
                If f IsNot Nothing Then Return f
            End If
        Next
        Return Nothing
    End Function


    ' Resto do código do form...
End Class