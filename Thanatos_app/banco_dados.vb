Imports ns1

Module banco_dados
    Public query, qtdeVelorio, proxVelorio, restVelorio, qtdeCremacao, proxCremacao, restCremacao, qtdeAbertoOrcamento, finalizadoMesOrcamento, canceladoMesOrcamento As String
    Public db As ADODB.Connection 'Variavel do bancoq
    Public rs As ADODB.Recordset 'Variavel das tabelas

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
            query = $"Select tb_funcionarios.cpfFuncionario, tb_funcionarios.loginFuncionario,tb_funcionarios.senhaFuncionario,tb_funcionarios.cepFuncionario, 
                    tb_status.descricaoStatus, tb_setores.descricaoSetor from tb_funcionarios inner join tb_status on tb_funcionarios.idStatus = tb_status.idStatus 
                    inner join tb_setores on tb_funcionarios.idSetor = tb_setores.idSetor"
            rs = db.Execute(query)
            With dgv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
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
            query = $"select tb_cremacoes.idCremacao, tb_cremacoes.horaCremacao, tb_cremacoes.dataCremacao, tb_salas.descricaoSala, tb_falecidos.nomeFalecido from tb_cremacoes inner join
                    tb_salas on tb_cremacoes.idSala = tb_salas.idSala inner join tb_falecidos on tb_cremacoes.idFalecido = tb_falecidos.idFalecido"
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

    Public Sub carregar_dados_velorio(dgv As BunifuCustomDataGrid)
        Try
            query = $"select tb_velorios.idVelorio, tb_velorios.horaVelorio, tb_velorios.dataVelorio, tb_salas.descricaoSala, tb_falecidos.nomeFalecido from tb_velorios inner join
                    tb_salas on tb_velorios.idSala = tb_salas.idSala inner join tb_falecidos on tb_velorios.idFalecido = tb_falecidos.idFalecido"
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
            query = $"SELECT tb_orcamentos.idOrcamento, tb_orcamentos.descricaoOrcamento, tb_orcamentos.valorOrcamento, tb_orcamentos.dataOrcamento, tb_falecidos.nomeFalecido,tb_status.descricaoStatus 
                    FROM tb_orcamentos INNER JOIN tb_falecidos ON tb_orcamentos.idFalecido = tb_falecidos.idFalecido inner join tb_status on tb_orcamentos.idStatus = tb_status.idStatus;"
            rs = db.Execute(query)
            With dgv
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, Nothing, Nothing)
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
        End If
    End Sub
End Module

