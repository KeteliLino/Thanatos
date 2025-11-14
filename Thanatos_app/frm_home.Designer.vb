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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmb_tabelas = New MaterialSkin.Controls.MaterialComboBox()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_home = New MaterialSkin.Controls.MaterialButton()
        Me.btn_administracao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_recepcao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_financeiro = New MaterialSkin.Controls.MaterialButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
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
        Me.cmb_tabelas.Location = New System.Drawing.Point(375, 101)
        Me.cmb_tabelas.MaxDropDownItems = 4
        Me.cmb_tabelas.MouseState = MaterialSkin.MouseState.OUT
        Me.cmb_tabelas.Name = "cmb_tabelas"
        Me.cmb_tabelas.Size = New System.Drawing.Size(477, 49)
        Me.cmb_tabelas.StartIndex = 0
        Me.cmb_tabelas.TabIndex = 3
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(375, 196)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1461, 617)
        Me.BunifuCustomDataGrid1.TabIndex = 5
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.btn_home)
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
        'btn_home
        '
        Me.btn_home.AutoSize = False
        Me.btn_home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_home.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_home.Depth = 0
        Me.btn_home.Enabled = False
        Me.btn_home.ForeColor = System.Drawing.Color.White
        Me.btn_home.HighEmphasis = True
        Me.btn_home.Icon = CType(resources.GetObject("btn_home.Icon"), System.Drawing.Image)
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.Location = New System.Drawing.Point(6, 110)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_home.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_home.Name = "btn_home"
        Me.btn_home.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_home.Size = New System.Drawing.Size(272, 104)
        Me.btn_home.TabIndex = 3
        Me.btn_home.Text = "HOME"
        Me.btn_home.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_home.UseAccentColor = False
        Me.btn_home.UseVisualStyleBackColor = True
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
        Me.btn_administracao.Location = New System.Drawing.Point(6, 752)
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
        Me.btn_recepcao.Location = New System.Drawing.Point(6, 538)
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
        Me.btn_financeiro.Location = New System.Drawing.Point(6, 324)
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
        'frm_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1032)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmb_tabelas As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_home As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_administracao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_recepcao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_financeiro As MaterialSkin.Controls.MaterialButton
End Class
