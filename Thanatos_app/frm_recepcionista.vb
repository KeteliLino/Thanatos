Imports System.Drawing
Imports MaterialSkin
Imports MaterialSkin.Controls
Public Class frm_recepcionista
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

    Private Sub frm_recepcionista_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_dataCremacao.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txt_dataVelorio.Text = DateTime.Now.ToString("dd/MM/yyyy")
        If PictureBox5 IsNot Nothing Then
            PictureBox5.BackColor = ColorTranslator.FromHtml("#802790") ' ajuste o HEX aqui
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox5.BorderStyle = BorderStyle.None
        End If
        carregar_dados_cremacao(Me.dgv_cremacao)
        carregar_dados_velorio(Me.dgv_velorio)
        carregar_dados_falecido(Me.dgv_falecido)
        carregar_dados_jazigo(Me.dgv_jazigo)
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

    Private Sub frm_recepcionista_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_mysql()

    End Sub

    Private Sub btn_pesquisar_Click(sender As Object, e As EventArgs) Handles btn_pesquisar.Click
        If cmb_pesquisar.Text = "ID" Then
            query = $"select tb_cremacoes.idCremacao, tb_cremacoes.horaCremacao, tb_cremacoes.dataCremacao,
                 tb_salas.descricaoSala, tb_falecidos.nomeFalecido 
                 from tb_cremacoes 
                 inner join tb_salas on tb_cremacoes.idSala = tb_salas.idSala 
                 inner join tb_falecidos on tb_cremacoes.idFalecido = tb_falecidos.idFalecido where idCremacao = {txt_idCremacao.Text}"
        ElseIf cmb_pesquisar.Text = "Data" Then
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

    Private Sub btn_pesquisar1_Click(sender As Object, e As EventArgs) Handles btn_pesquisar1.Click
        If cmb_pesquisar1.Text = "ID" Then
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

        ElseIf cmb_pesquisar1.Text = "Data" Then
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

    Private Sub btn_pesquisar2_Click(sender As Object, e As EventArgs) Handles btn_pesquisar2.Click
        If cmb_pesquisar2.Text = "ID" Then
            query = $"select tb_falecidos.idFalecido, tb_falecidos.nomeFalecido, tb_status.descricaoStatus from tb_falecidos inner join
                    tb_status on tb_falecidos.idStatus = tb_status.idStatus where idFalecido = {txt_idFalecido.Text}"

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

    Private Sub btn_pesquisar3_Click(sender As Object, e As EventArgs) Handles btn_pesquisar3.Click
        If cmb_pesquisar3.Text = "ID" Then
            query = $"SELECT tb_jazigos.idJazigo, tb_jazigos.quadranteJazigo, tb_jazigos.linhaJazigo, tb_jazigos.colunaJazigo, tb_falecidos.nomeFalecido 
                    FROM tb_jazigos LEFT JOIN tb_falecidos ON tb_jazigos.idFalecido = tb_falecidos.idFalecido where idJazigo = {txt_idJazigo.Text}"

        ElseIf cmb_pesquisar3.Text = "ID do Falecido" Then
            query = $"SELECT tb_jazigos.idJazigo, tb_jazigos.quadranteJazigo, tb_jazigos.linhaJazigo, tb_jazigos.colunaJazigo, tb_falecidos.nomeFalecido 
                    FROM tb_jazigos LEFT JOIN tb_falecidos ON tb_jazigos.idFalecido = tb_falecidos.idFalecido where tb_jazigos.idFalecido= {txt_idFalecido1.Text}"
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
End Class