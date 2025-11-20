Imports System.Drawing
Imports System.ComponentModel
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports System.Threading

Public Class frm_administrador
    Dim status, setor, tipoSala, id_sala, id_cremacao As String
    Dim cont As Integer
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

    Private Sub btn_incluirFuncionario_Click(sender As Object, e As EventArgs) Handles btn_incluirFuncionario.Click
        Try
            query = $"select * from tb_funcionarios where cpfFuncionario='{txt_cpfFuncionario.Text}'"
            rs = db.Execute(query)
            If rs.EOF = True Then
                query = $"insert into tb_funcionarios (cpfFuncionario,loginFuncionario,senhaFuncionario,nomeFuncionario,cepFuncionario,idStatus,idSetor) values (
                        '{txt_cpfFuncionario.Text}', '{txt_login.Text}', '{txt_senha.Text}','{txt_nomeFuncionario.Text}','{txt_cep.Text}', {status}, {setor});"
                rs = db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                carregar_dados_funcionario(Me.dgv_funcionarios)
            Else
                If resp = MsgBoxResult.Yes Then
                    query = $"update tb_funcionarios set loginFuncionario='{txt_login.Text}', senhaFuncionario='{txt_senha.Text}', 
                                nomeFuncionario='{txt_nomeFuncionario.Text}', cepFuncionario='{txt_cep.Text}', idStatus={status}, idSetor={setor} 
                                where cpfFuncionario='{aux_cpf}'"
                    rs = db.Execute(query)
                    MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    carregar_dados_funcionario(Me.dgv_funcionarios)
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub frm_administrador_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()
        carregar_dados_funcionario(Me.dgv_funcionarios)
        carregar_dados_sala(Me.dgv_sala)
        carregar_dados_cremacao(Me.dgv_cremacao)
        carregar_dados_velorio(Me.dgv_velorio)
        carregar_dados_falecido(Me.dgv_falecido)
        carregar_dados_jazigo(Me.dgv_jazigo)
        carregar_dados_servico(Me.dgv_servico)
    End Sub

    Private Sub cmb_setor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_setor.SelectedValueChanged
        If cmb_setor.Text = "Administração" Then
            setor = "1"
        ElseIf cmb_setor.Text = "Financeiro" Then
            setor = "2"
        ElseIf cmb_setor.Text = "Recepção" Then
            setor = "3"
        End If
    End Sub

    Private Sub cmb_status_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_status.SelectedValueChanged
        If cmb_status.Text = "Ativo" Then
            status = "1"
        ElseIf cmb_status.Text = "Inativo" Then
            status = "2"
        End If
    End Sub


    Private Sub btn_incluirSalas_Click(sender As Object, e As EventArgs) Handles btn_incluirSalas.Click
        Try
            query = $"select * from tb_salas where descricaoSala='{txt_descricaoSala.Text}'"
            rs = db.Execute(query)
            If rs.EOF = True Then
                query = $"insert into tb_salas (descricaoSala,idTipoSala) values (
                        '{txt_descricaoSala.Text}', '{tipoSala}');"
                rs = db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                carregar_dados_sala(Me.dgv_sala)
            Else
                If resp = MsgBoxResult.Yes Then
                    query = $"update tb_salas set descricaoSala='{txt_descricaoSala.Text}', idTipoSala='{tipoSala}' where idSala='{txt_idSala.Text}'"
                    rs = db.Execute(query)
                    MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    carregar_dados_sala(Me.dgv_sala)
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_incluirCremacoes_Click(sender As Object, e As EventArgs) Handles btn_incluirCremacoes.Click
        Try
            Dim dataCerta As String = Format(CDate(txt_dataCremacao.Text), "yyyy-MM-dd")
            If txt_idCremacao.Text = "" Then
                query = $"insert into tb_cremacoes 
                     (horaCremacao, diaCremacao, idSala, idFalecido)
                     values ('{txt_horaCremacao.Text}', 
                             '{dataCerta}', 
                             '{txt_idSalaCremacao.Text}', 
                             '{txt_idFalecidoCremacao.Text}')"
                db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information)
            Else
                query = $"update tb_cremacoes set
                        horaCremacao='{txt_horaCremacao.Text}',
                        diaCremacao='{dataCerta}',
                        idSala='{txt_idSalaCremacao.Text}',
                        idFalecido='{txt_idFalecidoCremacao.Text}'
                     where idCremacao='{txt_idCremacao.Text}'"

                db.Execute(query)
                MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information)
            End If

            carregar_dados_cremacao(Me.dgv_cremacao)

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_incluirVelorios_Click(sender As Object, e As EventArgs) Handles btn_incluirVelorios.Click
        Try
            Dim dataCertaVelorio As String = Format(CDate(txt_dataVelorio.Text), "yyyy-MM-dd")
            If txt_idVelorio.Text = "" Then
                query = $"insert into tb_velorios 
                     (horaVelorio, diaVelorio, idSala, idFalecido)
                     values ('{txt_horaVelorio.Text}', 
                             '{dataCertaVelorio}', 
                             '{txt_idSalaVelorio.Text}', 
                             '{txt_idFalecidoVelorio.Text}')"
                db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information)
            Else
                query = $"update tb_velorios set
                        horaVelorio='{txt_horaVelorio.Text}',
                        diaVelorio='{dataCertaVelorio}',
                        idSala='{txt_idSalaVelorio.Text}',
                        idFalecido='{txt_idFalecidoVelorio.Text}'
                     where idVelorio='{txt_idVelorio.Text}'"
                db.Execute(query)
                MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information)
            End If
            carregar_dados_velorio(Me.dgv_velorio)
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmb_tipoSala_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_tipoSala.SelectedValueChanged
        If cmb_tipoSala.Text = "Velório" Then
            tipoSala = "2"
        ElseIf cmb_tipoSala.Text = "Cremação" Then
            tipoSala = "1"
        End If
    End Sub

    Private Sub dgv_funcionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_funcionarios.CellContentClick
        With dgv_funcionarios
            If .CurrentRow.Cells(7).Selected = True Then
                aux_cpf = .CurrentRow.Cells(0).Value
                query = $"select * from tb_funcionarios where cpfFuncionario='{aux_cpf}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja excluir o cpf: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        query = $"Delete from tb_funcionarios where cpfFuncionario='{aux_cpf}'"
                        rs = db.Execute(query)
                        MsgBox("Dados deletados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        carregar_dados_funcionario(Me.dgv_funcionarios)
                    End If
                End If
            ElseIf .CurrentRow.Cells(8).Selected = True Then
                aux_cpf = .CurrentRow.Cells(0).Value
                query = $"select * from tb_funcionarios where cpfFuncionario='{aux_cpf}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    txt_cpfFuncionario.Text = rs.Fields(0).Value
                    txt_login.Text = rs.Fields(1).Value
                    txt_senha.Text = rs.Fields(2).Value
                    txt_nomeFuncionario.Text = rs.Fields(3).Value
                    txt_cep.Text = rs.Fields(4).Value
                    status = rs.Fields(5).Value
                    setor = rs.Fields(6).Value

                    If setor = "1" Then
                        cmb_setor.Text = "Administração"
                    ElseIf setor = "2" Then
                        cmb_setor.Text = "Financeiro"
                    ElseIf setor = "3" Then
                        cmb_setor.Text = "Recepção"
                    End If

                    resp = MsgBox("Deseja alterar os dados do cpf: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub dgv_sala_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_sala.CellContentClick
        With dgv_sala
            If .CurrentRow.Cells(3).Selected = True Then
                id_sala = .CurrentRow.Cells(0).Value
                query = $"select * from tb_salas where idSala='{id_sala}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja excluir a sala com ID: " & id_sala & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        query = $"Delete from tb_salas where idSala='{id_sala}'"
                        rs = db.Execute(query)
                        MsgBox("Dados deletados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        carregar_dados_sala(Me.dgv_sala)
                    End If
                End If
            ElseIf .CurrentRow.Cells(4).Selected = True Then
                id_sala = .CurrentRow.Cells(0).Value
                query = $"select * from tb_salas where idSala='{id_sala}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    txt_idSala.Text = rs.Fields(0).Value
                    txt_descricaoSala.Text = rs.Fields(1).Value
                    tipoSala = rs.Fields(2).Value

                    resp = MsgBox("Deseja alterar os dados do ID: " & id_sala & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub dgv_cremacao_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cremacao.CellContentClick
        With dgv_cremacao
            If .CurrentRow.Cells(5).Selected = True Then
                id_cremacao = .CurrentRow.Cells(0).Value
                query = $"select * from tb_cremacoes where idCremacao='{id_cremacao}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja excluir a cremacao com ID: " & id_cremacao & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        query = $"Delete from tb_cremacoes where idCremacao='{id_cremacao}'"
                        rs = db.Execute(query)
                        MsgBox("Dados deletados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        carregar_dados_cremacao(Me.dgv_cremacao)
                    End If
                End If
            ElseIf .CurrentRow.Cells(6).Selected = True Then
                id_cremacao = .CurrentRow.Cells(0).Value
                query = $"select * from tb_cremacoes where idCremacao='{id_cremacao}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    txt_idCremacao.Text = rs.Fields(0).Value
                    txt_horaCremacao.Text = rs.Fields(1).Value
                    txt_dataCremacao.Text = rs.Fields(2).Value
                    txt_idSalaCremacao.Text = rs.Fields(3).Value
                    txt_idFalecidoCremacao.Text = rs.Fields(4).Value

                    resp = MsgBox("Deseja alterar os dados do ID: " & id_cremacao & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub
End Class

