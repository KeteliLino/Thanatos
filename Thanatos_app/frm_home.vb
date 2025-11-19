Imports System.Drawing
Imports System.Globalization
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.Defaults
Imports LiveCharts.WinForms
Imports System.Runtime.Remoting.Messaging

Public Class frm_home
    Dim resp
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

    Private Sub frm_home_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If PictureBox1 IsNot Nothing Then
            PictureBox1.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub frm_home_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()
        lbl_nome.Text = "Bem-vindo, " + frm_login.nomeFuncionario
        If frm_login.idSetor = "1" Then
            With Me
                .btn_administracao.Enabled = True
                .btn_financeiro.Enabled = False
                .btn_recepcao.Enabled = False
            End With
        ElseIf frm_login.idSetor = "2" Then
            With Me
                .btn_administracao.Enabled = False
                .btn_financeiro.Enabled = True
                .btn_recepcao.Enabled = False
            End With
        ElseIf frm_login.idSetor = "3" Then
            With Me
                .btn_administracao.Enabled = False
                .btn_financeiro.Enabled = False
                .btn_recepcao.Enabled = True
            End With
        Else
            With Me
                .btn_administracao.Enabled = True
                .btn_financeiro.Enabled = True
                .btn_recepcao.Enabled = True
            End With
        End If
        ' Inicializa e popula o gráfico (garanta que o controle se chame cartesianChart1 no Designer)
        SetupLineChart()

        ' Exemplo de dados: múltiplos pontos no tempo
        Dim amostra As New List(Of KeyValuePair(Of DateTime, Double)) From {
            New KeyValuePair(Of DateTime, Double)(DateTime.Today.AddDays(-6), 1200.5),
            New KeyValuePair(Of DateTime, Double)(DateTime.Today.AddDays(-5), 1500),
            New KeyValuePair(Of DateTime, Double)(DateTime.Today.AddDays(-4), 1100.75),
            New KeyValuePair(Of DateTime, Double)(DateTime.Today.AddDays(-3), 1750),
            New KeyValuePair(Of DateTime, Double)(DateTime.Today.AddDays(-2), 900),
            New KeyValuePair(Of DateTime, Double)(DateTime.Today.AddDays(-1), 2050.25),
            New KeyValuePair(Of DateTime, Double)(DateTime.Today, 1600)
        }
        PopulateLineChart(amostra)
    End Sub

    ' Configurações iniciais do gráfico
    Private Sub SetupLineChart()
        ' Verifica se o controle existe
        Dim found() As Control = Me.Controls.Find("cartesianChart1", True)
        If found.Length = 0 Then Return
        Dim chart = TryCast(found(0), LiveCharts.WinForms.CartesianChart)
        If chart Is Nothing Then Return

        chart.Series = New LiveCharts.SeriesCollection()

        ' eixo X com formatação de datas
        chart.AxisX.Clear()
        chart.AxisX.Add(New Axis With {
            .LabelFormatter = Function(value) DateTime.FromOADate(value).ToString("dd/MM/yyyy"),
            .Separator = New Separator With {.Step = 1, .IsEnabled = True}
        })

        ' eixo Y com formato monetário pt-BR
        chart.AxisY.Clear()
        chart.AxisY.Add(New Axis With {
            .LabelFormatter = Function(value) value.ToString("N2", CultureInfo.GetCultureInfo("pt-BR"))
        })

        chart.LegendLocation = LegendLocation.None
        chart.DisableAnimations = False
        chart.Hoverable = True
    End Sub

    ' Popula o gráfico com uma única série de linha (muitos pontos no tempo)
    Public Sub PopulateLineChart(dados As List(Of KeyValuePair(Of DateTime, Double)))
        Dim found() As Control = Me.Controls.Find("cartesianChart1", True)
        If found.Length = 0 Then Return
        Dim chart = TryCast(found(0), LiveCharts.WinForms.CartesianChart)
        If chart Is Nothing Then Return

        Dim values As New ChartValues(Of ObservablePoint)
        For Each kv In dados
            ' X = OADate (double), Y = valor
            values.Add(New ObservablePoint(kv.Key.ToOADate(), kv.Value))
        Next

        ' Mantém apenas uma série (substitui se existir)
        Dim series As New LineSeries With {
            .Values = values,
            .PointGeometry = DefaultGeometries.Circle,
            .PointGeometrySize = 6,
            .StrokeThickness = 2,
            .Fill = System.Windows.Media.Brushes.Transparent ' sem preenchimento abaixo da linha
        }

        chart.Series.Clear()
        chart.Series.Add(series)

        ' ajusta limites X para dar folga visual (opcional)
        Dim minX = dados.Min(Function(d) d.Key).ToOADate()
        Dim maxX = dados.Max(Function(d) d.Key).ToOADate()
        Dim padding = (maxX - minX) * 0.05
        If padding = 0 Then padding = 1
        chart.AxisX(0).MinValue = minX - padding
        chart.AxisX(0).MaxValue = maxX + padding

        chart.Refresh()
    End Sub

    Private Sub btn_financeiro_Click(sender As Object, e As EventArgs) Handles btn_financeiro.Click
        frm_financeiro.Show()
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

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        resp = MsgBox("Tem certeza que deseja sair da conta? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
        If resp = MsgBoxResult.Yes Then
            frm_login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        resp = MsgBox("Deseja sair do sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "AVISO")
        If resp = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub cmb_tabelas_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_tabelas.SelectedValueChanged
        coletar_dados_home(cmb_tabelas.Text)
        If cmb_tabelas.Text = "Velórios" Then
            lbl_titulo1.Text = "Qtde de Velórios Hoje"
            lbl_titulo2.Text = "Hora do Próximo Velório"
            lbl_titulo3.Text = "Velórios Restantes Hoje"
            lbl_dado1.Text = qtdeVelorio
            lbl_dado2.Text = proxVelorio
            lbl_dado3.Text = restVelorio

        ElseIf cmb_tabelas.Text = "Cremações" Then
            lbl_titulo1.Text = "Qtde de Cremações Hoje"
            lbl_titulo2.Text = "Hora do Próxima Cremação"
            lbl_titulo3.Text = "Cremações Restantes Hoje"
            lbl_dado1.Text = qtdeCremacao
            lbl_dado2.Text = proxCremacao
            lbl_dado3.Text = restCremacao

        ElseIf cmb_tabelas.Text = "Orçamentos" Then
            lbl_titulo1.Text = "Orçamentos em Aberto"
            lbl_titulo2.Text = "Finalizados no Mês"
            lbl_titulo3.Text = "Cancelados no Mês"
            lbl_dado1.Text = qtdeAbertoOrcamento
            lbl_dado2.Text = finalizadoMesOrcamento
            lbl_dado3.Text = canceladoMesOrcamento
        End If

    End Sub


End Class

