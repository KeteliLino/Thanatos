Imports System.Drawing
Imports System.ComponentModel
Imports MaterialSkin
Imports MaterialSkin.Controls
Imports System.Threading
Imports Guna.UI.Animation



Public Class frm_administrador
    Dim status, setor, tipoSala, id_sala, id_cremacao, id_velorio, StatusFalecido, id_falecido, id_jazigo, id_servico As String
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
        carregar_dados_funcionario(Me.dgv_funcionarios)
        carregar_dados_sala(Me.dgv_sala)
        carregar_dados_cremacao(Me.dgv_cremacao)
        carregar_dados_velorio(Me.dgv_velorio)
        carregar_dados_falecido(Me.dgv_falecido)
        carregar_dados_jazigo(Me.dgv_jazigo)
        carregar_dados_servico(Me.dgv_servico)
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
            If txt_login.Text = "" Or
               txt_senha.Text = "" Or
               txt_nomeFuncionario.Text = "" Or
               txt_cep.Text = "" Then
                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If
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
            limpar_cadastro_funcionarios()
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub frm_administrador_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()

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
            If txt_idSala.Text <> "" Then
                MsgBox("O campo ID não pode ser preenchido manualmente!", MsgBoxStyle.Exclamation, "Atenção")
                txt_idServico.Clear()
                Exit Sub
            End If

            If txt_descricaoSala.Text = "" Or
               cmb_tipoSala.Text = "" Or
               tipoSala = "" Then
                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

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
            limpar_cadastro_salas()
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_incluirCremacoes_Click(sender As Object, e As EventArgs) Handles btn_incluirCremacoes.Click
        Try
            If txt_idCremacao.Text <> "" Then
                MsgBox("O campo ID não pode ser preenchido manualmente!", MsgBoxStyle.Exclamation, "Atenção")
                txt_idServico.Clear()
                Exit Sub
            End If

            If txt_horaCremacao.Text = "" Or
               txt_dataCremacao.Text = "" Or
               txt_idSalaCremacao.Text = "" Or
               txt_idFalecidoCremacao.Text = "" Then
                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

            Dim dataCerta As String = Format(CDate(txt_dataCremacao.Text), "yyyy-MM-dd")
            query = $"SELECT * FROM tb_cremacoes WHERE idSala = '{txt_idSalaCremacao.Text}' AND dataCremacao = '{dataCerta}' AND horaCremacao = '{txt_horaCremacao.Text}'"
            rs = db.Execute(query)
            If rs.EOF = False Then
                MsgBox("Este horário já está reservado para esta sala!", MsgBoxStyle.Critical, "AVISO")
                Exit Sub
            End If

            If txt_idCremacao.Text = "" Then
                query = $"insert into tb_cremacoes 
                     (horaCremacao, dataCremacao, idSala, idFalecido)
                     values ('{txt_horaCremacao.Text}', 
                             '{dataCerta}', 
                             '{txt_idSalaCremacao.Text}', 
                             '{txt_idFalecidoCremacao.Text}')"
                db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information)
            Else
                query = $"update tb_cremacoes set
                        horaCremacao='{txt_horaCremacao.Text}',
                        dataCremacao='{dataCerta}',
                        idSala='{txt_idSalaCremacao.Text}',
                        idFalecido='{txt_idFalecidoCremacao.Text}'
                     where idCremacao='{txt_idCremacao.Text}'"

                db.Execute(query)
                MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information)
            End If

            limpar_cadastro_cremacao()
            carregar_dados_cremacao(Me.dgv_cremacao)

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_incluirVelorios_Click(sender As Object, e As EventArgs) Handles btn_incluirVelorios.Click
        Try
            If txt_idVelorio.Text <> "" Then
                MsgBox("O campo ID não pode ser preenchido manualmente!", MsgBoxStyle.Exclamation, "Atenção")
                txt_idServico.Clear()
                Exit Sub
            End If

            If txt_horaVelorio.Text = "" Or
               txt_dataVelorio.Text = "" Or
               txt_idSalaVelorio.Text = "" Or
               txt_idFalecidoVelorio.Text = "" Then
                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

            Dim dataCertaVelorio As String = Format(CDate(txt_dataVelorio.Text), "yyyy-MM-dd")

            query = $"SELECT * FROM tb_velorios WHERE idSala = '{txt_idSalaVelorio.Text}' AND dataVelorio = '{dataCertaVelorio}' AND horaVelorio = '{txt_horaVelorio.Text}'"
            rs = db.Execute(query)
            If rs.EOF = False Then
                MsgBox("ERRO: Esta sala já está reservada neste horário!", MsgBoxStyle.Critical, "Horário Indisponível")
                Exit Sub
            End If

            If txt_idVelorio.Text = "" Then
                query = $"insert into tb_velorios 
                     (horaVelorio, dataVelorio, idSala, idFalecido)
                     values ('{txt_horaVelorio.Text}', 
                             '{dataCertaVelorio}', 
                             '{txt_idSalaVelorio.Text}', 
                             '{txt_idFalecidoVelorio.Text}')"
                db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information)
            Else
                query = $"update tb_velorios set
                        horaVelorio='{txt_horaVelorio.Text}',
                        dataVelorio='{dataCertaVelorio}',
                        idSala='{txt_idSalaVelorio.Text}',
                        idFalecido='{txt_idFalecidoVelorio.Text}'
                     where idVelorio='{txt_idVelorio.Text}'"
                db.Execute(query)
                MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information)
            End If
            limpar_cadastro_velorio()
            carregar_dados_velorio(Me.dgv_velorio)
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btn_incluirFalecidos_Click(sender As Object, e As EventArgs) Handles btn_incluirFalecidos.Click
        Try
            If txt_idFalecido.Text <> "" Then
                MsgBox("O campo ID não pode ser preenchido manualmente!", MsgBoxStyle.Exclamation, "Atenção")
                txt_idServico.Clear()
                Exit Sub
            End If

            If txt_nomeFalecido.Text = "" Or
               cmb_statusFalecido.Text = "" Or
               StatusFalecido = "" Then
                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

            query = $"select * from tb_falecidos where idFalecido='{txt_idFalecido.Text}'"
            rs = db.Execute(query)
            If rs.EOF = True Then
                query = $"insert into tb_falecidos (nomeFalecido, idStatus) values (
                        '{txt_nomeFalecido.Text}', '{StatusFalecido}');"
                rs = db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                limpar_cadastro_falecido()
                carregar_dados_falecido(Me.dgv_falecido)
            Else
                If resp = MsgBoxResult.Yes Then
                    query = $"update tb_falecidos set nomeFalecido='{txt_nomeFalecido.Text}', idStatus='{StatusFalecido}' where idFalecido='{txt_idFalecido.Text}'"
                    rs = db.Execute(query)
                    MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_cadastro_falecido()
                    carregar_dados_falecido(Me.dgv_falecido)
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_incluirJazigo_Click(sender As Object, e As EventArgs) Handles btn_incluirJazigo.Click
        Try
            If txt_idJazigo.Text <> "" Then
                MsgBox("O campo ID não pode ser preenchido manualmente!", MsgBoxStyle.Exclamation, "Atenção")
                txt_idServico.Clear()
                Exit Sub
            End If

            If txt_quadrante.Text = "" Or
               txt_fileira.Text = "" Or
               txt_idFalecidoJazigo.Text = "" Or
               txt_coluna.Text = "" Then
                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

            query = $"select * from tb_jazigos where idJazigo='{txt_idJazigo.Text}'"
            rs = db.Execute(query)
            If rs.EOF = True Then
                query = $"insert into tb_jazigos (quadranteJazigo,linhaJazigo,colunaJazigo,idFalecido) values (
                        '{txt_quadrante.Text}', '{txt_fileira.Text}', '{txt_coluna.Text}','{txt_idFalecidoJazigo.Text}');"
                rs = db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                limpar_cadastro_jazigo()
                carregar_dados_jazigo(Me.dgv_jazigo)
            Else
                If resp = MsgBoxResult.Yes Then
                    query = $"update tb_jazigos set quadranteJazigo='{txt_quadrante.Text}', linhaJazigo='{txt_fileira.Text}', 
                                colunaJazigo='{txt_coluna.Text}', idFalecido='{txt_idFalecidoJazigo.Text}' where idJazigo='{id_jazigo}'"
                    rs = db.Execute(query)
                    MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_cadastro_jazigo()
                    carregar_dados_jazigo(Me.dgv_jazigo)
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_incluirServicos_Click(sender As Object, e As EventArgs) Handles btn_incluirServicos.Click
        Try
            If txt_idServico.Text <> "" Then
                MsgBox("O campo ID não pode ser preenchido manualmente!", MsgBoxStyle.Exclamation, "Atenção")
                txt_idServico.Clear()
                Exit Sub
            End If

            If txt_descricaoServicos.Text = "" Or txt_preco.Text = "" Then
                MsgBox("Todos os campos devem ser preenchidos!", MsgBoxStyle.Exclamation, "Atenção")
                Exit Sub
            End If

            query = $"select * from tb_servicos where idServico='{txt_idServico.Text}'"
            rs = db.Execute(query)
            If rs.EOF = True Then
                query = $"insert into tb_servicos (descricaoServico,valorServico) values (
                        '{txt_descricaoServicos.Text}', '{txt_preco.Text}');"
                rs = db.Execute(query)
                MsgBox("Dados Gravados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                limpar_cadastro_servico()
                carregar_dados_servico(Me.dgv_servico)
            Else
                If resp = MsgBoxResult.Yes Then
                    query = $"update tb_servicos set descricaoServico='{txt_descricaoServicos.Text}', valorServico='{txt_preco.Text}' where idServico='{id_servico}'"
                    rs = db.Execute(query)
                    MsgBox("Dados Alterados com Sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    limpar_cadastro_servico()
                    carregar_dados_servico(Me.dgv_servico)
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub cmb_statusFalecido_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_statusFalecido.SelectedValueChanged
        If cmb_statusFalecido.Text = "Sepultado" Then
            StatusFalecido = "6"
        ElseIf cmb_tipoSala.Text = "Cremado" Then
            tipoSala = "7"
        End If
    End Sub

    Private Sub btn_pesquisarFuncionario_Click(sender As Object, e As EventArgs) Handles btn_pesquisarFuncionario.Click
        If cmb_pesquisar.Text = "CPF" Then
            query = $"Select tb_funcionarios.cpfFuncionario, tb_funcionarios.loginFuncionario,tb_funcionarios.senhaFuncionario, tb_funcionarios.nomeFuncionario, tb_funcionarios.cepFuncionario, 
                    tb_status.descricaoStatus, tb_setores.descricaoSetor from tb_funcionarios inner join tb_status on tb_funcionarios.idStatus = tb_status.idStatus 
                    inner join tb_setores on tb_funcionarios.idSetor = tb_setores.idSetor where cpfFuncionario ='{txt_cpfFuncionario.Text}'"

        ElseIf cmb_pesquisar.Text = "Nome" Then
            query = $"Select tb_funcionarios.cpfFuncionario, tb_funcionarios.loginFuncionario,tb_funcionarios.senhaFuncionario, tb_funcionarios.nomeFuncionario, tb_funcionarios.cepFuncionario, 
                    tb_status.descricaoStatus, tb_setores.descricaoSetor from tb_funcionarios inner join tb_status on tb_funcionarios.idStatus = tb_status.idStatus 
                    inner join tb_setores on tb_funcionarios.idSetor = tb_setores.idSetor where nomeFuncionario like'%{txt_nomeFuncionario.Text}%'"
        Else
            MsgBox("Selecione um filtro de pesquisa!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        rs = db.Execute(query)
        With dgv_funcionarios
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_pesquisarSalas_Click(sender As Object, e As EventArgs) Handles btn_pesquisarSalas.Click
        If cmb_pesquisar1.Text = "ID" Then
            query = $"Select tb_salas.idSala, tb_salas.descricaoSala, tb_tipos_sala.descricaoTipoSala from tb_salas inner join 
                    tb_tipos_sala on tb_salas.idTipoSala = tb_tipos_sala.idTipoSala where idSala = {txt_idSala.Text}"

        ElseIf cmb_pesquisar1.Text = "Descrição" Then
            query = $"Select tb_salas.idSala, tb_salas.descricaoSala, tb_tipos_sala.descricaoTipoSala from tb_salas inner join 
                    tb_tipos_sala on tb_salas.idTipoSala = tb_tipos_sala.idTipoSala where descricaoSala like '%{txt_descricaoSala.Text}%'"
        Else
            MsgBox("Selecione um filtro de pesquisa!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        rs = db.Execute(query)
        With dgv_sala
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_pesquisarCremacoes_Click(sender As Object, e As EventArgs) Handles btn_pesquisarCremacoes.Click
        If cmb_pesquisar2.Text = "ID" Then
            query = $"select tb_cremacoes.idCremacao, tb_cremacoes.horaCremacao, tb_cremacoes.dataCremacao,
                 tb_salas.descricaoSala, tb_falecidos.nomeFalecido 
                 from tb_cremacoes 
                 inner join tb_salas on tb_cremacoes.idSala = tb_salas.idSala 
                 inner join tb_falecidos on tb_cremacoes.idFalecido = tb_falecidos.idFalecido where idCremacao = {txt_idCremacao.Text}"
        ElseIf cmb_pesquisar2.Text = "Data" Then
            query = $"select tb_cremacoes.idCremacao, tb_cremacoes.horaCremacao, tb_cremacoes.dataCremacao,
                 tb_salas.descricaoSala, tb_falecidos.nomeFalecido 
                 from tb_cremacoes 
                 inner join tb_salas on tb_cremacoes.idSala = tb_salas.idSala 
                 inner join tb_falecidos on tb_cremacoes.idFalecido = tb_falecidos.idFalecido where dataCremacao = STR_TO_DATE( '{txt_dataCremacao.Text}', '%d/%m/%Y' )"
        Else
            MsgBox("Selecione um filtro de pesquisa!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        rs = db.Execute(query)
        With dgv_cremacao
            .Rows.Clear()
            Do While rs.EOF = False
                Dim hora As String = rs.Fields("horaCremacao").Value.ToString()
                If DateTime.TryParse(hora, Nothing) Then
                    hora = DateTime.Parse(hora).ToString("HH:mm")
                End If
                Dim data As String = ""
                If Not IsDBNull(rs.Fields("dataCremacao").Value) AndAlso rs.Fields("dataCremacao").Value.ToString <> "" Then
                    Try
                        data = Format(CDate(rs.Fields("dataCremacao").Value), "dd/MM/yyyy")
                    Catch
                        data = rs.Fields("dataCremacao").Value.ToString()
                    End Try
                End If
                .Rows.Add(
                rs.Fields("idCremacao").Value,
                hora,
                data,
                rs.Fields("descricaoSala").Value,
                rs.Fields("nomeFalecido").Value,
                Nothing,
                Nothing
            )
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_pesquisarVelorios_Click(sender As Object, e As EventArgs) Handles btn_pesquisarVelorios.Click
        If cmb_pesquisar3.Text = "ID" Then
            query = $"select 
                    tb_velorios.idVelorio, 
                    tb_velorios.horaVelorio, 
                    tb_velorios.dataVelorio,
                    tb_salas.descricaoSala, 
                    tb_falecidos.nomeFalecido 
                 from tb_velorios 
                 inner join tb_salas 
                    on tb_velorios.idSala = tb_salas.idSala 
                 inner join tb_falecidos 
                    on tb_velorios.idFalecido = tb_falecidos.idFalecido where idVelorio = {txt_idVelorio.Text}"
        ElseIf cmb_pesquisar3.Text = "Data" Then
            query = $"select 
                    tb_velorios.idVelorio, 
                    tb_velorios.horaVelorio, 
                    tb_velorios.dataVelorio,
                    tb_salas.descricaoSala, 
                    tb_falecidos.nomeFalecido 
                 from tb_velorios 
                 inner join tb_salas 
                    on tb_velorios.idSala = tb_salas.idSala 
                 inner join tb_falecidos 
                    on tb_velorios.idFalecido = tb_falecidos.idFalecido where dataVelorio = STR_TO_DATE( '{txt_dataVelorio.Text}', '%d/%m/%Y' )"
        Else
            MsgBox("Selecione um filtro de pesquisa!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        rs = db.Execute(query)
        With dgv_velorio
            .Rows.Clear()
            Do While rs.EOF = False
                Dim hora As String = rs.Fields("horaVelorio").Value.ToString()
                If DateTime.TryParse(hora, Nothing) Then
                    hora = DateTime.Parse(hora).ToString("HH:mm")
                End If
                Dim data As String = ""
                If Not IsDBNull(rs.Fields("dataVelorio").Value) AndAlso rs.Fields("dataVelorio").Value.ToString <> "" Then
                    Try
                        data = Format(CDate(rs.Fields("dataVelorio").Value), "dd/MM/yyyy")
                    Catch
                        data = rs.Fields("dataVelorio").Value.ToString()
                    End Try
                End If
                .Rows.Add(
                rs.Fields("idVelorio").Value,
                hora,
                data,
                rs.Fields("descricaoSala").Value,
                rs.Fields("nomeFalecido").Value,
                Nothing,
                Nothing
            )
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_pesquisarFalecidos_Click(sender As Object, e As EventArgs) Handles btn_pesquisarFalecidos.Click
        If cmb_pesquisar4.Text = "ID" Then
            query = $"select tb_falecidos.idFalecido, tb_falecidos.nomeFalecido, tb_status.descricaoStatus from tb_falecidos inner join
                    tb_status on tb_falecidos.idStatus = tb_status.idStatus where idFalecido = {txt_idFalecido.Text}"
        ElseIf cmb_pesquisar4.Text = "Nome" Then
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

    Private Sub btn_pesquisarJazigo_Click(sender As Object, e As EventArgs) Handles btn_pesquisarJazigo.Click
        If cmb_pesquisar5.Text = "ID" Then
            query = $"SELECT tb_jazigos.idJazigo, tb_jazigos.quadranteJazigo, tb_jazigos.linhaJazigo, tb_jazigos.colunaJazigo, tb_falecidos.nomeFalecido 
                    FROM tb_jazigos LEFT JOIN tb_falecidos ON tb_jazigos.idFalecido = tb_falecidos.idFalecido where idJazigo = {txt_idJazigo.Text}"
        ElseIf cmb_pesquisar5.Text = "ID do Falecido" Then
            query = $"SELECT tb_jazigos.idJazigo, tb_jazigos.quadranteJazigo, tb_jazigos.linhaJazigo, tb_jazigos.colunaJazigo, tb_falecidos.nomeFalecido 
                    FROM tb_jazigos LEFT JOIN tb_falecidos ON tb_jazigos.idFalecido = tb_falecidos.idFalecido where tb_jazigos.idFalecido= {txt_idFalecidoJazigo.Text}"
        Else
            MsgBox("Selecione um filtro de pesquisa!", MsgBoxStyle.Exclamation + vbOKOnly, "Atenção")
            Exit Sub
        End If
        rs = db.Execute(query)
        With dgv_jazigo
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub btn_pesquisarServicos_Click(sender As Object, e As EventArgs) Handles btn_pesquisarServicos.Click
        If cmb_pesquisar6.Text = "ID" Then
            query = $"select * from tb_servicos where idServico = {txt_idServico.Text}"
        ElseIf cmb_pesquisar6.Text = "Descrição" Then
            query = $"select * from tb_servicos where descricaoServico like '%{txt_descricaoServicos.Text}%'"
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
                        limpar_cadastro_funcionarios()
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
                        limpar_cadastro_salas()
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
                        limpar_cadastro_cremacao()
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

    Private Sub dgv_velorio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_velorio.CellContentClick
        With dgv_velorio
            If .CurrentRow.Cells(5).Selected = True Then
                id_velorio = .CurrentRow.Cells(0).Value
                query = $"select * from tb_velorios where idVelorio='{id_velorio}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja excluir o velório com ID: " & id_velorio & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        query = $"Delete from tb_velorios where idVelorio='{id_velorio}'"
                        rs = db.Execute(query)
                        MsgBox("Dados deletados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        limpar_cadastro_velorio()
                        carregar_dados_velorio(Me.dgv_velorio)
                    End If
                End If
            ElseIf .CurrentRow.Cells(6).Selected = True Then
                id_velorio = .CurrentRow.Cells(0).Value
                query = $"select * from tb_velorios where idVelorio='{id_velorio}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    txt_idVelorio.Text = rs.Fields(0).Value
                    txt_horaVelorio.Text = rs.Fields(1).Value
                    txt_dataVelorio.Text = rs.Fields(2).Value
                    txt_idSalaVelorio.Text = rs.Fields(3).Value
                    txt_idFalecidoVelorio.Text = rs.Fields(4).Value

                    resp = MsgBox("Deseja alterar os dados do ID: " & id_velorio & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub dgv_falecido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_falecido.CellContentClick
        With dgv_falecido
            If .CurrentRow.Cells(3).Selected = True Then
                id_falecido = .CurrentRow.Cells(0).Value
                query = $"select * from tb_falecidos where idFalecido='{id_falecido}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja excluir o falecido com ID: " & id_falecido & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        query = $"Delete from tb_falecidos where idFalecido='{id_falecido}'"
                        rs = db.Execute(query)
                        MsgBox("Dados deletados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        limpar_cadastro_falecido()
                        carregar_dados_falecido(Me.dgv_falecido)
                    End If
                End If
            ElseIf .CurrentRow.Cells(4).Selected = True Then
                id_falecido = .CurrentRow.Cells(0).Value
                query = $"select * from tb_falecidos where idFalecido='{id_falecido}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    txt_idFalecido.Text = rs.Fields(0).Value
                    txt_nomeFalecido.Text = rs.Fields(1).Value
                    StatusFalecido = rs.Fields(2).Value

                    resp = MsgBox("Deseja alterar os dados do ID: " & id_falecido & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub dgv_jazigo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_jazigo.CellContentClick
        With dgv_jazigo
            If .CurrentRow.Cells(5).Selected = True Then
                id_jazigo = .CurrentRow.Cells(0).Value
                query = $"select * from tb_jazigos where idJazigo='{id_jazigo}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja excluir o jazigo com ID: " & id_jazigo & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        query = $"Delete from tb_jazigos where idJazigo='{id_jazigo}'"
                        rs = db.Execute(query)
                        MsgBox("Dados deletados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        limpar_cadastro_jazigo()
                        carregar_dados_jazigo(Me.dgv_jazigo)
                    End If
                End If
            ElseIf .CurrentRow.Cells(6).Selected = True Then
                id_jazigo = .CurrentRow.Cells(0).Value
                query = $"select * from tb_jazigos where idJazigo='{id_jazigo}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    txt_idJazigo.Text = rs.Fields(0).Value
                    txt_quadrante.Text = rs.Fields(1).Value
                    txt_fileira.Text = rs.Fields(2).Value
                    txt_coluna.Text = rs.Fields(3).Value
                    txt_idFalecidoJazigo.Text = rs.Fields(4).Value

                    resp = MsgBox("Deseja alterar os dados do ID: " & id_jazigo & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Sub dgv_servico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_servico.CellContentClick
        With dgv_servico
            If .CurrentRow.Cells(3).Selected = True Then
                id_servico = .CurrentRow.Cells(0).Value
                query = $"select * from tb_servicos where idServico='{id_servico}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja excluir o servico com ID: " & id_servico & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        query = $"Delete from tb_servicos where idServico='{id_servico}'"
                        rs = db.Execute(query)
                        MsgBox("Dados deletados com Sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        limpar_cadastro_servico()
                        carregar_dados_servico(Me.dgv_servico)
                    End If
                End If
            ElseIf .CurrentRow.Cells(4).Selected = True Then
                id_servico = .CurrentRow.Cells(0).Value
                query = $"select * from tb_servicos where idServico='{id_servico}'"
                rs = db.Execute(query)
                If rs.EOF = False Then
                    txt_idServico.Text = rs.Fields(0).Value
                    txt_descricaoServicos.Text = rs.Fields(1).Value
                    txt_preco.Text = rs.Fields(2).Value

                    resp = MsgBox("Deseja alterar os dados do ID: " & id_servico & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                End If
            Else
                Exit Sub
            End If
        End With
    End Sub

    Private Async Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            Dim dados = Await CEP.BuscarCEP(txt_cep.Text)

            txt_logradouro.Text = dados.logradouro
            txt_bairro.Text = dados.bairro
            txt_cidade.Text = dados.localidade

        Catch ex As Exception
            MsgBox("Erro ao buscar CEP", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class

