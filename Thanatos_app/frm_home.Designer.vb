<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_home
    Inherits MaterialSkin.Controls.MaterialForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_home))
        Me.cmb_tabelas = New MaterialSkin.Controls.MaterialComboBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_sair = New MaterialSkin.Controls.MaterialButton()
        Me.btn_logout = New MaterialSkin.Controls.MaterialButton()
        Me.btn_administracao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_recepcao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_financeiro = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.lbl_nome = New MaterialSkin.Controls.MaterialLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_titulo1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_dado1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_titulo2 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_dado2 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_titulo3 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_dado3 = New MaterialSkin.Controls.MaterialLabel()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_tabelas
        '
        Me.cmb_tabelas.AutoResize = False
        Me.cmb_tabelas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_tabelas.Depth = 0
        Me.cmb_tabelas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmb_tabelas.DropDownHeight = 174
        Me.cmb_tabelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tabelas.DropDownWidth = 121
        Me.cmb_tabelas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmb_tabelas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_tabelas.FormattingEnabled = True
        Me.cmb_tabelas.IntegralHeight = False
        Me.cmb_tabelas.ItemHeight = 43
        Me.cmb_tabelas.Items.AddRange(New Object() {"", "Velórios", "Cremações", "Orçamentos"})
        Me.cmb_tabelas.Location = New System.Drawing.Point(677, 103)
        Me.cmb_tabelas.MaxDropDownItems = 4
        Me.cmb_tabelas.MouseState = MaterialSkin.MouseState.OUT
        Me.cmb_tabelas.Name = "cmb_tabelas"
        Me.cmb_tabelas.Size = New System.Drawing.Size(926, 49)
        Me.cmb_tabelas.StartIndex = 0
        Me.cmb_tabelas.TabIndex = 3
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.btn_sair)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_logout)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_administracao)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_recepcao)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_financeiro)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaShadowPanel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(3, 64)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 6
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 255
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(284, 965)
        Me.GunaShadowPanel1.TabIndex = 6
        '
        'btn_sair
        '
        Me.btn_sair.AutoSize = False
        Me.btn_sair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_sair.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_sair.Depth = 0
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.HighEmphasis = True
        Me.btn_sair.Icon = CType(resources.GetObject("btn_sair.Icon"), System.Drawing.Image)
        Me.btn_sair.Location = New System.Drawing.Point(151, 903)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_sair.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_sair.Size = New System.Drawing.Size(108, 35)
        Me.btn_sair.TabIndex = 9
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_sair.UseAccentColor = False
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.AutoSize = False
        Me.btn_logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_logout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_logout.Depth = 0
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.HighEmphasis = True
        Me.btn_logout.Icon = CType(resources.GetObject("btn_logout.Icon"), System.Drawing.Image)
        Me.btn_logout.Location = New System.Drawing.Point(26, 903)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_logout.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_logout.Size = New System.Drawing.Size(108, 35)
        Me.btn_logout.TabIndex = 8
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_logout.UseAccentColor = False
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_administracao
        '
        Me.btn_administracao.AutoSize = False
        Me.btn_administracao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_administracao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_administracao.Depth = 0
        Me.btn_administracao.ForeColor = System.Drawing.Color.White
        Me.btn_administracao.HighEmphasis = True
        Me.btn_administracao.Icon = CType(resources.GetObject("btn_administracao.Icon"), System.Drawing.Image)
        Me.btn_administracao.Location = New System.Drawing.Point(6, 697)
        Me.btn_administracao.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_administracao.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_administracao.Name = "btn_administracao"
        Me.btn_administracao.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_administracao.Size = New System.Drawing.Size(272, 104)
        Me.btn_administracao.TabIndex = 7
        Me.btn_administracao.Text = "Administração"
        Me.btn_administracao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_administracao.UseAccentColor = False
        Me.btn_administracao.UseVisualStyleBackColor = True
        '
        'btn_recepcao
        '
        Me.btn_recepcao.AutoSize = False
        Me.btn_recepcao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_recepcao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_recepcao.Depth = 0
        Me.btn_recepcao.ForeColor = System.Drawing.Color.White
        Me.btn_recepcao.HighEmphasis = True
        Me.btn_recepcao.Icon = CType(resources.GetObject("btn_recepcao.Icon"), System.Drawing.Image)
        Me.btn_recepcao.Location = New System.Drawing.Point(6, 430)
        Me.btn_recepcao.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_recepcao.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_recepcao.Name = "btn_recepcao"
        Me.btn_recepcao.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_recepcao.Size = New System.Drawing.Size(272, 104)
        Me.btn_recepcao.TabIndex = 6
        Me.btn_recepcao.Text = "Recepção"
        Me.btn_recepcao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_recepcao.UseAccentColor = False
        Me.btn_recepcao.UseVisualStyleBackColor = True
        '
        'btn_financeiro
        '
        Me.btn_financeiro.AutoSize = False
        Me.btn_financeiro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_financeiro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_financeiro.Depth = 0
        Me.btn_financeiro.ForeColor = System.Drawing.Color.White
        Me.btn_financeiro.HighEmphasis = True
        Me.btn_financeiro.Icon = CType(resources.GetObject("btn_financeiro.Icon"), System.Drawing.Image)
        Me.btn_financeiro.Location = New System.Drawing.Point(6, 163)
        Me.btn_financeiro.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_financeiro.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_financeiro.Name = "btn_financeiro"
        Me.btn_financeiro.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_financeiro.Size = New System.Drawing.Size(272, 104)
        Me.btn_financeiro.TabIndex = 4
        Me.btn_financeiro.Text = "Financeiro"
        Me.btn_financeiro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_financeiro.UseAccentColor = False
        Me.btn_financeiro.UseVisualStyleBackColor = True
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.lbl_dado1)
        Me.MaterialCard1.Controls.Add(Me.lbl_titulo1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(677, 342)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(230, 100)
        Me.MaterialCard1.TabIndex = 7
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.lbl_dado2)
        Me.MaterialCard2.Controls.Add(Me.lbl_titulo2)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(1024, 342)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(230, 100)
        Me.MaterialCard2.TabIndex = 8
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.lbl_dado3)
        Me.MaterialCard3.Controls.Add(Me.lbl_titulo3)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(1373, 342)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(230, 100)
        Me.MaterialCard3.TabIndex = 9
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.CartesianChart1)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(677, 498)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(926, 325)
        Me.MaterialCard4.TabIndex = 10
        '
        'CartesianChart1
        '
        Me.CartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CartesianChart1.Location = New System.Drawing.Point(14, 14)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(898, 297)
        Me.CartesianChart1.TabIndex = 0
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Depth = 0
        Me.lbl_nome.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_nome.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.lbl_nome.Location = New System.Drawing.Point(303, 75)
        Me.lbl_nome.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(223, 29)
        Me.lbl_nome.TabIndex = 11
        Me.lbl_nome.Text = "nome do funcionario"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lbl_titulo1
        '
        Me.lbl_titulo1.AutoSize = True
        Me.lbl_titulo1.Depth = 0
        Me.lbl_titulo1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_titulo1.Location = New System.Drawing.Point(8, 8)
        Me.lbl_titulo1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_titulo1.Name = "lbl_titulo1"
        Me.lbl_titulo1.Size = New System.Drawing.Size(13, 19)
        Me.lbl_titulo1.TabIndex = 0
        Me.lbl_titulo1.Text = "..."
        '
        'lbl_dado1
        '
        Me.lbl_dado1.AutoSize = True
        Me.lbl_dado1.Depth = 0
        Me.lbl_dado1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_dado1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.lbl_dado1.Location = New System.Drawing.Point(108, 64)
        Me.lbl_dado1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_dado1.Name = "lbl_dado1"
        Me.lbl_dado1.Size = New System.Drawing.Size(13, 17)
        Me.lbl_dado1.TabIndex = 1
        Me.lbl_dado1.Text = "..."
        '
        'lbl_titulo2
        '
        Me.lbl_titulo2.AutoSize = True
        Me.lbl_titulo2.Depth = 0
        Me.lbl_titulo2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_titulo2.Location = New System.Drawing.Point(7, 8)
        Me.lbl_titulo2.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_titulo2.Name = "lbl_titulo2"
        Me.lbl_titulo2.Size = New System.Drawing.Size(13, 19)
        Me.lbl_titulo2.TabIndex = 0
        Me.lbl_titulo2.Text = "..."
        '
        'lbl_dado2
        '
        Me.lbl_dado2.AutoSize = True
        Me.lbl_dado2.Depth = 0
        Me.lbl_dado2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_dado2.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.lbl_dado2.Location = New System.Drawing.Point(108, 64)
        Me.lbl_dado2.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_dado2.Name = "lbl_dado2"
        Me.lbl_dado2.Size = New System.Drawing.Size(13, 17)
        Me.lbl_dado2.TabIndex = 1
        Me.lbl_dado2.Text = "..."
        '
        'lbl_titulo3
        '
        Me.lbl_titulo3.AutoSize = True
        Me.lbl_titulo3.Depth = 0
        Me.lbl_titulo3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_titulo3.Location = New System.Drawing.Point(7, 7)
        Me.lbl_titulo3.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_titulo3.Name = "lbl_titulo3"
        Me.lbl_titulo3.Size = New System.Drawing.Size(13, 19)
        Me.lbl_titulo3.TabIndex = 0
        Me.lbl_titulo3.Text = "..."
        '
        'lbl_dado3
        '
        Me.lbl_dado3.AutoSize = True
        Me.lbl_dado3.Depth = 0
        Me.lbl_dado3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_dado3.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2
        Me.lbl_dado3.Location = New System.Drawing.Point(108, 64)
        Me.lbl_dado3.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_dado3.Name = "lbl_dado3"
        Me.lbl_dado3.Size = New System.Drawing.Size(13, 17)
        Me.lbl_dado3.TabIndex = 1
        Me.lbl_dado3.Text = "..."
        '
        'frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1032)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.MaterialCard4)
        Me.Controls.Add(Me.MaterialCard3)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.cmb_tabelas)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_home"
        Me.Text = "           Thanatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_tabelas As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_administracao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_recepcao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_financeiro As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents lbl_nome As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_sair As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_logout As MaterialSkin.Controls.MaterialButton
    Friend WithEvents lbl_dado1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_titulo1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_dado2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_titulo2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_dado3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_titulo3 As MaterialSkin.Controls.MaterialLabel
End Class
