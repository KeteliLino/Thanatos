Imports System.Drawing
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports Guna.UI.WinForms

Public Class frm_login
    Private ReadOnly materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance

    ' Paleta / cores
    Private ReadOnly PRIMARY_HEX As String = "#802790"
    Private ReadOnly ENTER_BTN_HEX As String = "#C075CA"
    Private ReadOnly TITLE_FONT_NAME As String = "Segoe UI"
    Private ReadOnly LABEL_FONT_SIZE As Single = 12.0F

    Public Sub New()
        InitializeComponent()
        SetupMaterialSkin()
        AddHandler Me.Resize, AddressOf OnFormResize
    End Sub

    ' -----------------------
    ' Eventos
    ' -----------------------
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPictureBoxStyle()
        CenterShadowPanelAndChildren()
        StyleEnterButton()
    End Sub

    Private Sub OnFormResize(sender As Object, e As EventArgs)
        CenterShadowPanelAndChildren()
    End Sub

    ' -----------------------
    ' Configurações iniciais
    ' -----------------------
    Private Sub SetupMaterialSkin()
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK
        materialSkinManager.ColorScheme = New ColorScheme(
            ColorTranslator.FromHtml(PRIMARY_HEX),
            ColorTranslator.FromHtml(PRIMARY_HEX),
            ColorTranslator.FromHtml(PRIMARY_HEX),
            ColorTranslator.FromHtml(PRIMARY_HEX),
            TextShade.WHITE)
    End Sub

    Private Sub ApplyPictureBoxStyle()
        Dim pb = TryCast(FindControlRecursive(Me, Function(c) TypeOf c Is PictureBox), PictureBox)
        If pb Is Nothing Then Return

        pb.BackColor = ColorTranslator.FromHtml(PRIMARY_HEX)
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.BorderStyle = BorderStyle.None
    End Sub

    ' -----------------------
    ' Centralização e layout
    ' -----------------------
    Private Sub CenterShadowPanelAndChildren()
        ' procura por nome exato primeiro
        Dim panel As Control = FindControlRecursive(Me, Function(c) String.Equals(c.Name, "gunaShadowPanel1", StringComparison.OrdinalIgnoreCase))

        ' se não achar, procura por membros que contenham "guna" e "shadow" no nome
        If panel Is Nothing Then
            panel = FindControlRecursive(Me, Function(c)
                                                 Return Not String.IsNullOrEmpty(c.Name) AndAlso c.Name.ToLower().Contains("guna") AndAlso c.Name.ToLower().Contains("shadow")
                                             End Function)
        End If

        If panel Is Nothing Then Return

        panel.Left = Math.Max(0, (Me.ClientSize.Width - panel.Width) \ 2)
        panel.Top = Math.Max(0, (Me.ClientSize.Height - panel.Height) \ 2)

        CenterChildrenHorizontally(panel)
        RestoreLabelStyles(panel)
    End Sub

    Private Sub CenterChildrenHorizontally(parent As Control)
        For Each c As Control In parent.Controls
            Dim typeName = c.GetType().Name.ToLower()
            If TypeOf c Is Label OrElse typeName.Contains("label") Then Continue For
            If c.Tag IsNot Nothing AndAlso String.Equals(c.Tag.ToString(), "no-center", StringComparison.OrdinalIgnoreCase) Then Continue For

            c.Left = Math.Max(0, (parent.ClientSize.Width - c.Width) \ 2)
        Next
    End Sub

    ' -----------------------
    ' Estilização de labels
    ' -----------------------
    Private Sub RestoreLabelStyles(parent As Control)
        For Each c As Control In parent.Controls
            Dim typeName = c.GetType().Name
            If TypeOf c Is Label OrElse typeName.IndexOf("label", StringComparison.OrdinalIgnoreCase) >= 0 Then
                If c.Tag IsNot Nothing AndAlso String.Equals(c.Tag.ToString(), "preserve", StringComparison.OrdinalIgnoreCase) Then
                    ' manter inalterado
                Else
                    Try
                        c.BackColor = Color.Transparent
                        c.ForeColor = Color.White
                        c.Font = New Font(TITLE_FONT_NAME, LABEL_FONT_SIZE, FontStyle.Regular, GraphicsUnit.Point)
                    Catch
                        ' ignore alterações que falhem
                    End Try
                End If
            End If

            If c.HasChildren Then RestoreLabelStyles(c)
        Next
    End Sub

    ' -----------------------
    ' Botão Entrar (Guna)
    ' -----------------------
    Private Sub StyleEnterButton()
        Dim ctrl = FindControlRecursive(Me, Function(c) String.Equals(c.Name, "btn_entrar", StringComparison.OrdinalIgnoreCase))
        If ctrl Is Nothing Then Return

        Dim targetColor As Color = ColorTranslator.FromHtml(ENTER_BTN_HEX)

        Dim gbtn = TryCast(ctrl, GunaButton)
        If gbtn IsNot Nothing Then
            gbtn.BaseColor = targetColor
            gbtn.BackColor = targetColor
            gbtn.BorderColor = Color.Transparent
            gbtn.OnHoverBaseColor = ControlPaint.Light(targetColor)
            gbtn.OnHoverBorderColor = Color.Transparent
            gbtn.OnHoverForeColor = Color.White
            gbtn.OnPressedColor = ControlPaint.Dark(targetColor)
            gbtn.ForeColor = Color.White
            gbtn.Image = Nothing
            Return
        End If

        If TypeOf ctrl Is Button Then
            Dim b = DirectCast(ctrl, Button)
            b.FlatStyle = FlatStyle.Flat
            b.FlatAppearance.BorderSize = 0
            b.UseVisualStyleBackColor = False
            b.BackColor = targetColor
            b.ForeColor = Color.White
            Return
        End If

        Try
            Dim pBack = ctrl.GetType().GetProperty("BackColor")
            If pBack IsNot Nothing Then pBack.SetValue(ctrl, targetColor, Nothing)
            Dim pFore = ctrl.GetType().GetProperty("ForeColor")
            If pFore IsNot Nothing Then pFore.SetValue(ctrl, Color.White, Nothing)
        Catch
            ' ignore
        End Try
    End Sub

    ' -----------------------
    ' Helper único de busca recursiva
    ' -----------------------
    Private Function FindControlRecursive(parent As Control, predicate As Func(Of Control, Boolean)) As Control
        For Each c As Control In parent.Controls
            If predicate(c) Then Return c
            If c.HasChildren Then
                Dim f = FindControlRecursive(c, predicate)
                If f IsNot Nothing Then Return f
            End If
        Next
        Return Nothing
    End Function

    ' Resto do código do form...
End Class