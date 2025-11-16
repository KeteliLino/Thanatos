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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmb_tabelas = New MaterialSkin.Controls.MaterialComboBox()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_administracao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_recepcao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_financeiro = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
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
        Me.cmb_tabelas.Location = New System.Drawing.Point(677, 97)
        Me.cmb_tabelas.MaxDropDownItems = 4
        Me.cmb_tabelas.MouseState = MaterialSkin.MouseState.OUT
        Me.cmb_tabelas.Name = "cmb_tabelas"
        Me.cmb_tabelas.Size = New System.Drawing.Size(926, 49)
        Me.cmb_tabelas.StartIndex = 0
        Me.cmb_tabelas.TabIndex = 3
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(677, 703)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(926, 299)
        Me.BunifuCustomDataGrid1.TabIndex = 5
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
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
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(677, 195)
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
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(1024, 195)
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
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(1373, 195)
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
        Me.MaterialCard4.Location = New System.Drawing.Point(677, 351)
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
        'frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1032)
        Me.Controls.Add(Me.MaterialCard4)
        Me.Controls.Add(Me.MaterialCard3)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.cmb_tabelas)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_home"
        Me.Text = "           Thanatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.MaterialCard4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmb_tabelas As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_administracao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_recepcao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_financeiro As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
End Class
