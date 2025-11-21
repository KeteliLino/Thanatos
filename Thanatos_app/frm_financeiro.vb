Imports System.Drawing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class frm_financeiro
    Private ReadOnly materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance
    Dim status, id_orcamento As String

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
        txt_data.Text = DateTime.Now.ToString("dd/MM/yyyy")
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

    Private Sub txt_data_Click(sender As Object, e As EventArgs) Handles txt_data.Click

    End Sub

    Private Sub MaterialLabel8_Click(sender As Object, e As EventArgs) Handles MaterialLabel8.Click

    End Sub

    Private Sub frm_financeiro_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()
        carregar_dados_orcamento(Me.dgv_orcamento)
        carregar_dados_servico(Me.dgv_servico)
        carregar_dados_falecido(Me.dgv_falecido)
    End Sub

    Private Sub btn_incluir_Click(sender As Object, e As EventArgs) Handles btn_incluir.Click
        Try
            Dim dataCertaOrcamento As String = Format(CDate(txt_data.Text), "yyyy-MM-dd")
            If txt_idOrcamento.Text = "" Then
                query = $"insert into tb_orcamentos 
                     (descricaoOrcamento, valorOrcamento, dataOrcamento, idFalecido, idStatus)
                     values ('{txt_descricaoOrcamento.Text}', 
                             '{txt_valor.Text}', 
                             '{dataCertaOrcamento}',
                             '{txt_idfalecido.Text}',
                             '{status}')"
                db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information)
            Else
                query = $"UPDATE tb_orcamentos SET
                        descricaoOrcamento='{txt_descricaoOrcamento.Text}',
                        valorOrcamento='{txt_valor.Text}',
                        dataOrcamento='{dataCertaOrcamento}',
                        idFalecido='{txt_idfalecido.Text}',
                        idStatus='{status}'
                     WHERE idOrcamento='{txt_idOrcamento.Text}'"
                db.Execute(query)
                MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information)
            End If
            limpar_cadastro_orcamento()
            carregar_dados_orcamento(Me.dgv_orcamento)
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmb_status_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_status.SelectedValueChanged
        If cmb_status.Text = "Aberto" Then
            status = "3"
        ElseIf cmb_status.Text = "Finalizado" Then
            status = "5"
        ElseIf cmb_status.Text = "Cancelado" Then
            status = "4"
        End If
    End Sub

    Private Sub cmb_setor_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_incluirFuncionario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_voltar3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_tipoSala_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_incluirSalas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_incluirCremacoes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_incluirVelorios_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_voltar6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_statusFalecido_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_incluirFalecidos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_incluirJazigo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_voltar5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_incluirServicos_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_voltar4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_orcamento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_orcamento.CellContentClick
        With dgv_orcamento
            If .CurrentRow.Cells(6).Selected = True Then
                id_orcamento = .CurrentRow.Cells(0).Value
                query = $"select * from tb_orcamentos where idOrcamento='{id_orcamento}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja excluir o orçamento com ID: " & id_orcamento & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        query = $"Delete from tb_orcamentos where idOrcamento='{id_orcamento}'"
                        rs = db.Execute(query)
                        MsgBox("Dados deletados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        limpar_cadastro_orcamento()
                        carregar_dados_orcamento(Me.dgv_orcamento)
                    End If
                End If
            ElseIf .CurrentRow.Cells(7).Selected = True Then
                id_orcamento = .CurrentRow.Cells(0).Value
                query = $"select * from tb_orcamentos where idOrcamento='{id_orcamento}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    txt_idOrcamento.Text = rs.Fields(0).Value
                    txt_descricaoOrcamento.Text = rs.Fields(1).Value
                    txt_valor.Text = rs.Fields(2).Value
                    txt_data.Text = rs.Fields(3).Value
                    txt_idfalecido.Text = rs.Fields(4).Value
                    status = rs.Fields(5).Value
                    cmb_status.Text = rs.Fields(5).Value

                    resp = MsgBox("Deseja alterar os dados do ID: " & id_orcamento & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub
End Class
