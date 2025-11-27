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
        carregar_dados_orcamento(Me.dgv_orcamento)
        carregar_dados_servico(Me.dgv_servico)
        carregar_dados_falecido(Me.dgv_falecido)
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


    Private Sub frm_financeiro_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()
    End Sub

    Private Sub btn_incluir_Click(sender As Object, e As EventArgs) Handles btn_incluir.Click
        Try
            If txt_idOrcamento.Text <> "" Then
                MsgBox("O campo ID não pode ser preenchido manualmente!", MsgBoxStyle.Exclamation, "Atenção")
                txt_idServico.Clear()
                Exit Sub
            End If

            If txt_descricaoOrcamento.Text = "" Or
               txt_data.Text = "" Or
               txt_valor.Text = "" Or
               txt_idfalecido.Text Or
               cmb_status.Text = "" Or
               status = "" Then
                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

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
    Private Sub btn_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_pesquisar.Click
        If cmb_pesquisar.Text = "ID" Then
            query = $"SELECT tb_orcamentos.idOrcamento, tb_orcamentos.descricaoOrcamento, tb_orcamentos.valorOrcamento, tb_orcamentos.dataOrcamento, tb_falecidos.nomeFalecido, tb_status.descricaoStatus
                    FROM tb_orcamentos
                    INNER JOIN tb_falecidos ON tb_orcamentos.idFalecido = tb_falecidos.idFalecido
                    INNER JOIN tb_status ON tb_orcamentos.idStatus = tb_status.idStatus
                    WHERE idOrcamento ={txt_idOrcamento.Text}"

        ElseIf cmb_pesquisar.Text = "Data" Then
            query = $"SELECT tb_orcamentos.idOrcamento, tb_orcamentos.descricaoOrcamento, tb_orcamentos.valorOrcamento, tb_orcamentos.dataOrcamento, tb_falecidos.nomeFalecido, tb_status.descricaoStatus
                    FROM tb_orcamentos
                    INNER JOIN tb_falecidos ON tb_orcamentos.idFalecido = tb_falecidos.idFalecido
                    INNER JOIN tb_status ON tb_orcamentos.idStatus = tb_status.idStatus
                    WHERE dataOrcamento = STR_TO_DATE( '{txt_data.Text}', '%d/%m/%Y' )"

        Else
            MsgBox("Selecione um filtro de pesquisa!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        rs = db.Execute(query)
        With dgv_orcamento
            .Rows.Clear()
            Do While rs.EOF = False
                Dim data As String = ""
                If Not IsDBNull(rs.Fields("dataOrcamento").Value) AndAlso rs.Fields("dataOrcamento").Value.ToString <> "" Then
                    Try
                        data = Format(CDate(rs.Fields("dataOrcamento").Value), "dd/MM/yyyy")
                    Catch
                        data = rs.Fields("dataOrcamento").Value.ToString()
                    End Try
                End If
                .Rows.Add(
                rs.Fields("idOrcamento").Value,
                rs.Fields("descricaoOrcamento").Value,
                rs.Fields("valorOrcamento").Value,
                data,
                rs.Fields("nomeFalecido").Value,
                rs.Fields("descricaoStatus").Value,
                Nothing,
                Nothing
            )
                rs.MoveNext()
            Loop
        End With

    End Sub

    Private Sub btn_pesquisar1_Click(sender As Object, e As EventArgs) Handles btn_pesquisar1.Click
        If cmb_pesquisar1.Text = "ID" Then
            query = $"select * from tb_servicos where idServico = {txt_idServico.Text}"

        ElseIf cmb_pesquisar1.Text = "Descrição" Then
            query = $"select * from tb_servicos where descricaoServico like '%{txt_descServico.Text}%'"

        Else
            MsgBox("Selecione um filtro de pesquisa!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        rs = db.Execute(query)
        With dgv_servico
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_pesquisar2_Click(sender As Object, e As EventArgs) Handles btn_pesquisar2.Click
        If cmb_pesquisar2.Text = "ID" Then
            query = $"select tb_falecidos.idFalecido, tb_falecidos.nomeFalecido, tb_status.descricaoStatus from tb_falecidos inner join
                    tb_status on tb_falecidos.idStatus = tb_status.idStatus where idFalecido = {txt_idFalecido1.Text}"

        ElseIf cmb_pesquisar2.Text = "Nome" Then
            query = $"select tb_falecidos.idFalecido, tb_falecidos.nomeFalecido, tb_status.descricaoStatus from tb_falecidos inner join
                    tb_status on tb_falecidos.idStatus = tb_status.idStatus where nomeFalecido like '%{txt_nomeFalecido.Text}%'"
        Else
            MsgBox("Selecione um filtro de pesquisa!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        rs = db.Execute(query)
        With dgv_falecido
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
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
