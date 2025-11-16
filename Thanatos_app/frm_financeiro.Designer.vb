<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_financeiro
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

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_financeiro))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_idfalecido = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_login = New MaterialSkin.Controls.MaterialLabel()
        Me.cmb_status = New MaterialSkin.Controls.MaterialComboBox()
        Me.txt_valor = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txt_descricao = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        Me.btn_incluir = New MaterialSkin.Controls.MaterialButton()
        Me.txt_id = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btn_pesquisar = New MaterialSkin.Controls.MaterialButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tab_voltar = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(64, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Controls.Add(Me.tab_voltar)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.ImageList = Me.ImageList1
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 64)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1914, 965)
        Me.MaterialTabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.TabPage1.Controls.Add(Me.GunaShadowPanel1)
        Me.TabPage1.ImageKey = "clipboard.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Orçamentos"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(57, 353)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1755, 555)
        Me.BunifuCustomDataGrid1.TabIndex = 8
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel1.Controls.Add(Me.MaterialLabel4)
        Me.GunaShadowPanel1.Controls.Add(Me.txt_idfalecido)
        Me.GunaShadowPanel1.Controls.Add(Me.MaterialLabel3)
        Me.GunaShadowPanel1.Controls.Add(Me.MaterialLabel2)
        Me.GunaShadowPanel1.Controls.Add(Me.MaterialLabel1)
        Me.GunaShadowPanel1.Controls.Add(Me.lbl_login)
        Me.GunaShadowPanel1.Controls.Add(Me.cmb_status)
        Me.GunaShadowPanel1.Controls.Add(Me.txt_valor)
        Me.GunaShadowPanel1.Controls.Add(Me.txt_descricao)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_incluir)
        Me.GunaShadowPanel1.Controls.Add(Me.txt_id)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_pesquisar)
        Me.GunaShadowPanel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(57, 38)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 6
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 255
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(1755, 284)
        Me.GunaShadowPanel1.TabIndex = 7
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel4.Location = New System.Drawing.Point(1226, 187)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(154, 29)
        Me.MaterialLabel4.TabIndex = 14
        Me.MaterialLabel4.Text = "Id do Falecido"
        '
        'txt_idfalecido
        '
        Me.txt_idfalecido.AnimateReadOnly = False
        Me.txt_idfalecido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt_idfalecido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_idfalecido.Depth = 0
        Me.txt_idfalecido.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_idfalecido.HideSelection = True
        Me.txt_idfalecido.LeadingIcon = Nothing
        Me.txt_idfalecido.Location = New System.Drawing.Point(1226, 219)
        Me.txt_idfalecido.MaxLength = 32767
        Me.txt_idfalecido.MouseState = MaterialSkin.MouseState.OUT
        Me.txt_idfalecido.Name = "txt_idfalecido"
        Me.txt_idfalecido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_idfalecido.PrefixSuffixText = Nothing
        Me.txt_idfalecido.ReadOnly = False
        Me.txt_idfalecido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_idfalecido.SelectedText = ""
        Me.txt_idfalecido.SelectionLength = 0
        Me.txt_idfalecido.SelectionStart = 0
        Me.txt_idfalecido.ShortcutsEnabled = True
        Me.txt_idfalecido.Size = New System.Drawing.Size(250, 48)
        Me.txt_idfalecido.TabIndex = 13
        Me.txt_idfalecido.TabStop = False
        Me.txt_idfalecido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_idfalecido.TrailingIcon = Nothing
        Me.txt_idfalecido.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel3.Location = New System.Drawing.Point(34, 14)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(184, 29)
        Me.MaterialLabel3.TabIndex = 12
        Me.MaterialLabel3.Text = "ID do Orçamento"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel2.Location = New System.Drawing.Point(1490, 186)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(69, 29)
        Me.MaterialLabel2.TabIndex = 11
        Me.MaterialLabel2.Text = "Status"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel1.Location = New System.Drawing.Point(960, 187)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(118, 29)
        Me.MaterialLabel1.TabIndex = 10
        Me.MaterialLabel1.Text = "Valor Total"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Depth = 0
        Me.lbl_login.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_login.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_login.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.lbl_login.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_login.Location = New System.Drawing.Point(34, 99)
        Me.lbl_login.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(109, 29)
        Me.lbl_login.TabIndex = 9
        Me.lbl_login.Text = "Descrição"
        '
        'cmb_status
        '
        Me.cmb_status.AutoResize = False
        Me.cmb_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_status.Depth = 0
        Me.cmb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmb_status.DropDownHeight = 174
        Me.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_status.DropDownWidth = 121
        Me.cmb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmb_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.IntegralHeight = False
        Me.cmb_status.ItemHeight = 43
        Me.cmb_status.Items.AddRange(New Object() {"Aberto", "Finalizado", "Cancelado"})
        Me.cmb_status.Location = New System.Drawing.Point(1489, 218)
        Me.cmb_status.MaxDropDownItems = 4
        Me.cmb_status.MouseState = MaterialSkin.MouseState.OUT
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(250, 49)
        Me.cmb_status.StartIndex = 0
        Me.cmb_status.TabIndex = 6
        '
        'txt_valor
        '
        Me.txt_valor.AnimateReadOnly = False
        Me.txt_valor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt_valor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_valor.Depth = 0
        Me.txt_valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_valor.HideSelection = True
        Me.txt_valor.LeadingIcon = Nothing
        Me.txt_valor.Location = New System.Drawing.Point(960, 219)
        Me.txt_valor.MaxLength = 32767
        Me.txt_valor.MouseState = MaterialSkin.MouseState.OUT
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_valor.PrefixSuffixText = Nothing
        Me.txt_valor.ReadOnly = False
        Me.txt_valor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_valor.SelectedText = ""
        Me.txt_valor.SelectionLength = 0
        Me.txt_valor.SelectionStart = 0
        Me.txt_valor.ShortcutsEnabled = True
        Me.txt_valor.Size = New System.Drawing.Size(250, 48)
        Me.txt_valor.TabIndex = 5
        Me.txt_valor.TabStop = False
        Me.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_valor.TrailingIcon = Nothing
        Me.txt_valor.UseSystemPasswordChar = False
        '
        'txt_descricao
        '
        Me.txt_descricao.AnimateReadOnly = False
        Me.txt_descricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_descricao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_descricao.Depth = 0
        Me.txt_descricao.HideSelection = True
        Me.txt_descricao.Location = New System.Drawing.Point(34, 131)
        Me.txt_descricao.MaxLength = 32767
        Me.txt_descricao.MouseState = MaterialSkin.MouseState.OUT
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_descricao.ReadOnly = False
        Me.txt_descricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_descricao.SelectedText = ""
        Me.txt_descricao.SelectionLength = 0
        Me.txt_descricao.SelectionStart = 0
        Me.txt_descricao.ShortcutsEnabled = True
        Me.txt_descricao.Size = New System.Drawing.Size(899, 136)
        Me.txt_descricao.TabIndex = 4
        Me.txt_descricao.TabStop = False
        Me.txt_descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_descricao.UseSystemPasswordChar = False
        '
        'btn_incluir
        '
        Me.btn_incluir.AutoSize = False
        Me.btn_incluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_incluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_incluir.Depth = 0
        Me.btn_incluir.HighEmphasis = True
        Me.btn_incluir.Icon = CType(resources.GetObject("btn_incluir.Icon"), System.Drawing.Image)
        Me.btn_incluir.Location = New System.Drawing.Point(1607, 17)
        Me.btn_incluir.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_incluir.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_incluir.Name = "btn_incluir"
        Me.btn_incluir.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_incluir.Size = New System.Drawing.Size(131, 36)
        Me.btn_incluir.TabIndex = 3
        Me.btn_incluir.Text = "Incluir"
        Me.btn_incluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_incluir.UseAccentColor = False
        Me.btn_incluir.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.AnimateReadOnly = False
        Me.txt_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txt_id.Depth = 0
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_id.HideSelection = True
        Me.txt_id.LeadingIcon = Nothing
        Me.txt_id.Location = New System.Drawing.Point(34, 46)
        Me.txt_id.MaxLength = 32767
        Me.txt_id.MouseState = MaterialSkin.MouseState.OUT
        Me.txt_id.Name = "txt_id"
        Me.txt_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_id.PrefixSuffixText = Nothing
        Me.txt_id.ReadOnly = False
        Me.txt_id.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_id.SelectedText = ""
        Me.txt_id.SelectionLength = 0
        Me.txt_id.SelectionStart = 0
        Me.txt_id.ShortcutsEnabled = True
        Me.txt_id.Size = New System.Drawing.Size(250, 48)
        Me.txt_id.TabIndex = 2
        Me.txt_id.TabStop = False
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_id.TrailingIcon = Nothing
        Me.txt_id.UseSystemPasswordChar = False
        '
        'btn_pesquisar
        '
        Me.btn_pesquisar.AutoSize = False
        Me.btn_pesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_pesquisar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_pesquisar.Depth = 0
        Me.btn_pesquisar.HighEmphasis = True
        Me.btn_pesquisar.Icon = CType(resources.GetObject("btn_pesquisar.Icon"), System.Drawing.Image)
        Me.btn_pesquisar.Location = New System.Drawing.Point(1457, 17)
        Me.btn_pesquisar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_pesquisar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_pesquisar.Name = "btn_pesquisar"
        Me.btn_pesquisar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_pesquisar.Size = New System.Drawing.Size(131, 36)
        Me.btn_pesquisar.TabIndex = 0
        Me.btn_pesquisar.Text = "Pesquisar"
        Me.btn_pesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_pesquisar.UseAccentColor = False
        Me.btn_pesquisar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.ImageKey = "lupe.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar Serviços"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.ImageKey = "crud pesquisar.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Consultar Falecidos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tab_voltar
        '
        Me.tab_voltar.ImageKey = "exit.png"
        Me.tab_voltar.Location = New System.Drawing.Point(4, 39)
        Me.tab_voltar.Name = "tab_voltar"
        Me.tab_voltar.Size = New System.Drawing.Size(1906, 922)
        Me.tab_voltar.TabIndex = 2
        Me.tab_voltar.Text = "Voltar"
        Me.tab_voltar.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "lupe.png")
        Me.ImageList1.Images.SetKeyName(1, "clipboard.png")
        Me.ImageList1.Images.SetKeyName(2, "exit.png")
        Me.ImageList1.Images.SetKeyName(3, "crud pesquisar.png")
        '
        'frm_financeiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1032)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.PictureBox3)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_financeiro"
        Me.Text = "           Thanatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents tab_voltar As TabPage
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents txt_id As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btn_pesquisar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_incluir As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txt_valor As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txt_descricao As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cmb_status As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_login As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_idfalecido As MaterialSkin.Controls.MaterialTextBox2
End Class
