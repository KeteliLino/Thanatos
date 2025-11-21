Imports LiveCharts.Definitions.Series
Imports LiveCharts.WinForms
Imports ns1

Module banco_dados
    Public query, resp, aux_cpf, qtdeVelorio, proxVelorio, restVelorio, qtdeCremacao, proxCremacao, restCremacao, qtdeAbertoOrcamento, finalizadoMesOrcamento, canceladoMesOrcamento As String
    Public db As ADODB.Connection 'Variavel do bancoq
    Public rs As ADODB.Recordset 'Variavel das tabelas
    Public datas() As Date
    Public valores() As Double
    Public dados_grafico As New List(Of KeyValuePair(Of Date, Double))
    Dim cont = 0

    Sub conecta_banco_mysql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("DRIVER={MySQL ODBC 3.51 Driver};SERVER=localhost;DATABASE=bd_thanatos;UID=root;PWD=usbw;port=6060;option3;")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Public Sub carregar_dados_funcionario(dgv As BunifuCustomDataGrid)
        Try
            query = $"Select tb_funcionarios.cpfFuncionario, tb_funcionarios.loginFuncionario,tb_funcionarios.senhaFuncionario, tb_funcionarios.nomeFuncionario, tb_funcionarios.cepFuncionario, 
                    tb_status.descricaoStatus, tb_setores.descricaoSetor from tb_funcionarios inner join tb_status on tb_funcionarios.idStatus = tb_status.idStatus 
                    inner join tb_setores on tb_funcionarios.idSetor = tb_setores.idSetor"
            rs = db.Execute(query)
            With dgv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub carregar_dados_sala(dgv As BunifuCustomDataGrid)
        Try
            query = $"Select tb_salas.idSala, tb_salas.descricaoSala, tb_tipos_sala.descricaoTipoSala from tb_salas inner join tb_tipos_sala on tb_salas.idTipoSala = tb_tipos_sala.idTipoSala "
            rs = db.Execute(query)
            With dgv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub carregar_dados_cremacao(dgv As BunifuCustomDataGrid)
        Try
            query = $"select tb_cremacoes.idCremacao, tb_cremacoes.horaCremacao, tb_cremacoes.dataCremacao,
                 tb_salas.descricaoSala, tb_falecidos.nomeFalecido 
                 from tb_cremacoes 
                 inner join tb_salas on tb_cremacoes.idSala = tb_salas.idSala 
                 inner join tb_falecidos on tb_cremacoes.idFalecido = tb_falecidos.idFalecido"
            rs = db.Execute(query)
            With dgv
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
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub carregar_dados_velorio(dgv As BunifuCustomDataGrid)
        Try
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
                    on tb_velorios.idFalecido = tb_falecidos.idFalecido"

            rs = db.Execute(query)

            With dgv
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
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub carregar_dados_falecido(dgv As BunifuCustomDataGrid)
        Try
            query = $"select tb_falecidos.idFalecido, tb_falecidos.nomeFalecido, tb_status.descricaoStatus from tb_falecidos inner join
                    tb_status on tb_falecidos.idStatus = tb_status.idStatus"
            rs = db.Execute(query)
            With dgv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub carregar_dados_jazigo(dgv As BunifuCustomDataGrid)
        Try
            query = $"SELECT tb_jazigos.idJazigo, tb_jazigos.quadranteJazigo, tb_jazigos.linhaJazigo, tb_jazigos.colunaJazigo, tb_falecidos.nomeFalecido 
                    FROM tb_jazigos LEFT JOIN tb_falecidos ON tb_jazigos.idFalecido = tb_falecidos.idFalecido;
"
            rs = db.Execute(query)
            With dgv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub carregar_dados_servico(dgv As BunifuCustomDataGrid)
        Try
            query = $"select * from tb_servicos"
            rs = db.Execute(query)
            With dgv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Public Sub carregar_dados_orcamento(dgv As BunifuCustomDataGrid)
        Try
            query = $"SELECT 
            tb_orcamentos.idOrcamento,
            tb_orcamentos.descricaoOrcamento,
            tb_orcamentos.valorOrcamento,
            tb_orcamentos.dataOrcamento, 
            tb_falecidos.nomeFalecido,
            tb_status.descricaoStatus 
        FROM tb_orcamentos
        INNER JOIN tb_falecidos 
            ON tb_orcamentos.idFalecido = tb_falecidos.idFalecido
        INNER JOIN tb_status 
            ON tb_orcamentos.idStatus = tb_status.idStatus"

            rs = db.Execute(query)
            With dgv
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
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Sub coletar_dados_home(tabela As String)
        If tabela = "Velórios" Then
            query = $"SELECT COUNT(*) FROM tb_velorios WHERE dataVelorio = CURDATE();"
            rs = db.Execute(query)
            qtdeVelorio = rs.Fields(0).Value.ToString()
            query = $"SELECT DATE_FORMAT(horaVelorio, '%H:%i') FROM tb_velorios
                    WHERE dataVelorio = CURDATE() ORDER BY horaVelorio ASC LIMIT 1;"
            rs = db.Execute(query)
            proxVelorio = rs.Fields(0).Value.ToString()
            query = $"SELECT COUNT(*) AS veloriosRestantes FROM tb_velorios 
                    WHERE dataVelorio = CURDATE() AND horaVelorio > CURTIME();"
            rs = db.Execute(query)
            restVelorio = rs.Fields(0).Value.ToString()

            query = "SELECT DATE_FORMAT(dataVelorio, '%d/%m/%Y') AS dataFormatada, COUNT(*) AS qtde FROM tb_velorios 
                    WHERE dataVelorio BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 10 DAY) GROUP BY dataVelorio ORDER BY dataVelorio;"
            rs = db.Execute(query)


            dados_grafico.Clear()

            Do While Not rs.EOF
                Dim d As Date = rs.Fields(0).Value
                Dim v As Double = rs.Fields(1).Value

                dados_grafico.Add(New KeyValuePair(Of Date, Double)(d, v))

                rs.MoveNext()
            Loop

        ElseIf tabela = "Cremações" Then
            query = $"SELECT COUNT(*) FROM tb_cremacoes WHERE dataCremacao = CURDATE();"
            rs = db.Execute(query)
            qtdeCremacao = rs.Fields(0).Value.ToString()
            query = $"SELECT DATE_FORMAT(horaCremacao, '%H:%i') FROM tb_cremacoes WHERE dataCremacao = CURDATE() 
                    ORDER BY horaCremacao ASC LIMIT 1;"
            rs = db.Execute(query)
            proxCremacao = rs.Fields(0).Value.ToString()
            query = $"SELECT COUNT(*) FROM tb_cremacoes WHERE dataCremacao = CURDATE() 
                     AND horaCremacao > CURTIME();"
            rs = db.Execute(query)
            restCremacao = rs.Fields(0).Value.ToString()

            query = "SELECT DATE_FORMAT(dataCremacao, '%d/%m/%Y') AS dataFormatada, COUNT(*) AS qtde FROM tb_cremacoes 
                        WHERE dataCremacao BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 10 DAY) GROUP BY dataCremacao ORDER BY dataCremacao;"
            rs = db.Execute(query)

            dados_grafico.Clear()

            Do While Not rs.EOF
                Dim d As Date = rs.Fields(0).Value
                Dim v As Double = rs.Fields(1).Value

                dados_grafico.Add(New KeyValuePair(Of Date, Double)(d, v))

                rs.MoveNext()
            Loop

        ElseIf tabela = "Orçamentos" Then
            query = $"Select COUNT(*)From tb_orcamentos Where idStatus = 3;"
            rs = db.Execute(query)
            qtdeAbertoOrcamento = rs.Fields(0).Value.ToString()
            query = $"SELECT COUNT(*) FROM tb_orcamentos WHERE idStatus = 5 AND MONTH(dataOrcamento) = MONTH(CURDATE()) AND YEAR(dataOrcamento) = YEAR(CURDATE());"
            rs = db.Execute(query)
            finalizadoMesOrcamento = rs.Fields(0).Value.ToString()
            query = $"SELECT COUNT(*) FROM tb_orcamentos WHERE idStatus = 4 AND MONTH(dataOrcamento) = MONTH(CURDATE()) AND YEAR(dataOrcamento) = YEAR(CURDATE());"
            rs = db.Execute(query)
            canceladoMesOrcamento = rs.Fields(0).Value.ToString()

            query = "SELECT DATE_FORMAT(dataOrcamento, '%d/%m/%Y') AS dataFormatada, SUM(valorOrcamento) AS soma FROM tb_orcamentos 
                    WHERE idStatus = 5 AND dataOrcamento BETWEEN DATE_SUB(CURDATE(), INTERVAL 10 DAY) AND CURDATE() GROUP BY dataOrcamento ORDER BY dataOrcamento;"
            rs = db.Execute(query)

            dados_grafico.Clear()

            Do While Not rs.EOF
                Dim d As Date = rs.Fields(0).Value
                Dim v As Double = rs.Fields(1).Value

                dados_grafico.Add(New KeyValuePair(Of Date, Double)(d, v))

                rs.MoveNext()
            Loop
        Else

        End If
    End Sub

    Sub limpar_cadastro_funcionarios()
        Try
            With frm_administrador
                .txt_cpfFuncionario.Clear()
                .txt_nomeFuncionario.Clear()
                .txt_login.Clear()
                .txt_senha.Clear()
                .cmb_status.SelectedIndex = -1
                .cmb_setor.SelectedIndex = -1
                .txt_cep.Clear()
                .txt_logradouro.Clear()
                .txt_bairro.Clear()
                .txt_cidade.Clear()
                .txt_cpfFuncionario.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_cadastro_salas()
        Try
            With frm_administrador
                .txt_idSala.Clear()
                .txt_descricaoSala.Clear()
                .cmb_tipoSala.SelectedIndex = -1
                .txt_descricaoSala.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_cadastro_cremacao()
        Try
            With frm_administrador
                .txt_idCremacao.Clear()
                .txt_horaCremacao.Clear()
                .txt_dataCremacao.Clear()
                .txt_idSalaCremacao.Clear()
                .txt_idFalecido.Clear()
                .txt_horaCremacao.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_cadastro_velorio()
        Try
            With frm_administrador
                .txt_idVelorio.Clear()
                .txt_horaVelorio.Clear()
                .txt_dataVelorio.Clear()
                .txt_idSalaVelorio.Clear()
                .txt_idFalecidoVelorio.Clear()
                .txt_horaVelorio.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_cadastro_falecido()
        Try
            With frm_administrador
                .txt_idFalecido.Clear()
                .txt_nomeFalecido.Clear()
                .cmb_statusFalecido.SelectedIndex = -1
                .txt_nomeFalecido.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_cadastro_jazigo()
        Try
            With frm_administrador
                .txt_idJazigo.Clear()
                .txt_quadrante.Clear()
                .txt_fileira.Clear()
                .txt_coluna.Clear()
                .txt_idFalecidoJazigo.Clear()
                .txt_quadrante.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_cadastro_servico()
        Try
            With frm_administrador
                .txt_idServico.Clear()
                .txt_descricaoServicos.Clear()
                .txt_preco.Clear()
                .txt_descricaoServicos.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Sub limpar_cadastro_orcamento()
        Try
            With frm_financeiro
                .txt_idOrcamento.Clear()
                .txt_descricaoOrcamento.Clear()
                .txt_data.Clear()
                .txt_valor.Clear()
                .txt_idfalecido.Clear()
                .cmb_status.SelectedIndex = -1
                .txt_descricaoOrcamento.Focus()
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Module

