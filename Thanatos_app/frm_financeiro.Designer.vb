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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_pesquisar2 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_voltar = New MaterialSkin.Controls.MaterialButton()
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
        Me.btn_voltar1 = New MaterialSkin.Controls.MaterialButton()
        Me.BunifuCustomDataGrid2 = New ns1.BunifuCustomDataGrid()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.MaterialTextBox21 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.btn_pesquisar1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialTextBox23 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BunifuCustomDataGrid3 = New ns1.BunifuCustomDataGrid()
        Me.GunaShadowPanel3 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTextBox22 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialTextBox25 = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btn_voltar2 = New MaterialSkin.Controls.MaterialButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_data = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btn_pesquisar2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.BunifuCustomDataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel3.SuspendLayout()
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
        'btn_pesquisar2
        '
        Me.btn_pesquisar2.Controls.Add(Me.TabPage1)
        Me.btn_pesquisar2.Controls.Add(Me.TabPage2)
        Me.btn_pesquisar2.Controls.Add(Me.TabPage3)
        Me.btn_pesquisar2.Depth = 0
        Me.btn_pesquisar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_pesquisar2.ImageList = Me.ImageList1
        Me.btn_pesquisar2.Location = New System.Drawing.Point(3, 64)
        Me.btn_pesquisar2.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_pesquisar2.Multiline = True
        Me.btn_pesquisar2.Name = "btn_pesquisar2"
        Me.btn_pesquisar2.SelectedIndex = 0
        Me.btn_pesquisar2.Size = New System.Drawing.Size(1914, 965)
        Me.btn_pesquisar2.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_voltar)
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
        'btn_voltar
        '
        Me.btn_voltar.AutoSize = False
        Me.btn_voltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_voltar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_voltar.Depth = 0
        Me.btn_voltar.HighEmphasis = True
        Me.btn_voltar.Icon = CType(resources.GetObject("btn_voltar.Icon"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(2, 2)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_voltar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_voltar.Size = New System.Drawing.Size(131, 36)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_voltar.UseAccentColor = False
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
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
        Me.GunaShadowPanel1.Controls.Add(Me.MaterialLabel8)
        Me.GunaShadowPanel1.Controls.Add(Me.txt_data)
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
        Me.MaterialLabel4.Location = New System.Drawing.Point(1247, 99)
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
        Me.txt_idfalecido.Location = New System.Drawing.Point(1247, 131)
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
        Me.MaterialLabel2.Location = New System.Drawing.Point(1247, 187)
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
        Me.cmb_status.Location = New System.Drawing.Point(1246, 219)
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
        Me.txt_id.Size = New System.Drawing.Size(184, 48)
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
        Me.TabPage2.Controls.Add(Me.btn_voltar1)
        Me.TabPage2.Controls.Add(Me.BunifuCustomDataGrid2)
        Me.TabPage2.Controls.Add(Me.GunaShadowPanel2)
        Me.TabPage2.ImageKey = "lupe.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar Serviços"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_voltar1
        '
        Me.btn_voltar1.AutoSize = False
        Me.btn_voltar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_voltar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_voltar1.Depth = 0
        Me.btn_voltar1.HighEmphasis = True
        Me.btn_voltar1.Icon = CType(resources.GetObject("btn_voltar1.Icon"), System.Drawing.Image)
        Me.btn_voltar1.Location = New System.Drawing.Point(2, 2)
        Me.btn_voltar1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_voltar1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_voltar1.Name = "btn_voltar1"
        Me.btn_voltar1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_voltar1.Size = New System.Drawing.Size(131, 36)
        Me.btn_voltar1.TabIndex = 16
        Me.btn_voltar1.Text = "Voltar"
        Me.btn_voltar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_voltar1.UseAccentColor = False
        Me.btn_voltar1.UseVisualStyleBackColor = True
        '
        'BunifuCustomDataGrid2
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.BunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.BunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid2.DoubleBuffered = True
        Me.BunifuCustomDataGrid2.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid2.Location = New System.Drawing.Point(57, 353)
        Me.BunifuCustomDataGrid2.Name = "BunifuCustomDataGrid2"
        Me.BunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid2.Size = New System.Drawing.Size(1755, 555)
        Me.BunifuCustomDataGrid2.TabIndex = 9
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel2.Controls.Add(Me.MaterialTextBox21)
        Me.GunaShadowPanel2.Controls.Add(Me.MaterialLabel6)
        Me.GunaShadowPanel2.Controls.Add(Me.MaterialLabel9)
        Me.GunaShadowPanel2.Controls.Add(Me.btn_pesquisar1)
        Me.GunaShadowPanel2.Controls.Add(Me.MaterialTextBox23)
        Me.GunaShadowPanel2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(57, 38)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 6
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowDepth = 255
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(1755, 284)
        Me.GunaShadowPanel2.TabIndex = 8
        '
        'MaterialTextBox21
        '
        Me.MaterialTextBox21.AnimateReadOnly = False
        Me.MaterialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox21.Depth = 0
        Me.MaterialTextBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox21.HideSelection = True
        Me.MaterialTextBox21.LeadingIcon = Nothing
        Me.MaterialTextBox21.Location = New System.Drawing.Point(211, 46)
        Me.MaterialTextBox21.MaxLength = 32767
        Me.MaterialTextBox21.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox21.Name = "MaterialTextBox21"
        Me.MaterialTextBox21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox21.PrefixSuffixText = Nothing
        Me.MaterialTextBox21.ReadOnly = False
        Me.MaterialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox21.SelectedText = ""
        Me.MaterialTextBox21.SelectionLength = 0
        Me.MaterialTextBox21.SelectionStart = 0
        Me.MaterialTextBox21.ShortcutsEnabled = True
        Me.MaterialTextBox21.Size = New System.Drawing.Size(272, 48)
        Me.MaterialTextBox21.TabIndex = 13
        Me.MaterialTextBox21.TabStop = False
        Me.MaterialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox21.TrailingIcon = Nothing
        Me.MaterialTextBox21.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel6.Location = New System.Drawing.Point(34, 14)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(149, 29)
        Me.MaterialLabel6.TabIndex = 12
        Me.MaterialLabel6.Text = "ID do Serviço"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel9.Location = New System.Drawing.Point(211, 14)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(234, 29)
        Me.MaterialLabel9.TabIndex = 9
        Me.MaterialLabel9.Text = "Descrição do Serviço"
        '
        'btn_pesquisar1
        '
        Me.btn_pesquisar1.AutoSize = False
        Me.btn_pesquisar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_pesquisar1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_pesquisar1.Depth = 0
        Me.btn_pesquisar1.HighEmphasis = True
        Me.btn_pesquisar1.Icon = CType(resources.GetObject("btn_pesquisar1.Icon"), System.Drawing.Image)
        Me.btn_pesquisar1.Location = New System.Drawing.Point(1607, 17)
        Me.btn_pesquisar1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_pesquisar1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_pesquisar1.Name = "btn_pesquisar1"
        Me.btn_pesquisar1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_pesquisar1.Size = New System.Drawing.Size(131, 36)
        Me.btn_pesquisar1.TabIndex = 3
        Me.btn_pesquisar1.Text = "Pesquisar"
        Me.btn_pesquisar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_pesquisar1.UseAccentColor = False
        Me.btn_pesquisar1.UseVisualStyleBackColor = True
        '
        'MaterialTextBox23
        '
        Me.MaterialTextBox23.AnimateReadOnly = False
        Me.MaterialTextBox23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox23.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox23.Depth = 0
        Me.MaterialTextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox23.HideSelection = True
        Me.MaterialTextBox23.LeadingIcon = Nothing
        Me.MaterialTextBox23.Location = New System.Drawing.Point(34, 46)
        Me.MaterialTextBox23.MaxLength = 32767
        Me.MaterialTextBox23.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox23.Name = "MaterialTextBox23"
        Me.MaterialTextBox23.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox23.PrefixSuffixText = Nothing
        Me.MaterialTextBox23.ReadOnly = False
        Me.MaterialTextBox23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox23.SelectedText = ""
        Me.MaterialTextBox23.SelectionLength = 0
        Me.MaterialTextBox23.SelectionStart = 0
        Me.MaterialTextBox23.ShortcutsEnabled = True
        Me.MaterialTextBox23.Size = New System.Drawing.Size(149, 48)
        Me.MaterialTextBox23.TabIndex = 2
        Me.MaterialTextBox23.TabStop = False
        Me.MaterialTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox23.TrailingIcon = Nothing
        Me.MaterialTextBox23.UseSystemPasswordChar = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BunifuCustomDataGrid3)
        Me.TabPage3.Controls.Add(Me.GunaShadowPanel3)
        Me.TabPage3.Controls.Add(Me.btn_voltar2)
        Me.TabPage3.ImageKey = "crud pesquisar.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Consultar Falecidos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BunifuCustomDataGrid3
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.BunifuCustomDataGrid3.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.BunifuCustomDataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid3.DoubleBuffered = True
        Me.BunifuCustomDataGrid3.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid3.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid3.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid3.Location = New System.Drawing.Point(57, 353)
        Me.BunifuCustomDataGrid3.Name = "BunifuCustomDataGrid3"
        Me.BunifuCustomDataGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid3.Size = New System.Drawing.Size(1755, 555)
        Me.BunifuCustomDataGrid3.TabIndex = 18
        '
        'GunaShadowPanel3
        '
        Me.GunaShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.BaseColor = System.Drawing.Color.DimGray
        Me.GunaShadowPanel3.Controls.Add(Me.MaterialLabel5)
        Me.GunaShadowPanel3.Controls.Add(Me.MaterialTextBox22)
        Me.GunaShadowPanel3.Controls.Add(Me.MaterialLabel7)
        Me.GunaShadowPanel3.Controls.Add(Me.MaterialButton3)
        Me.GunaShadowPanel3.Controls.Add(Me.MaterialTextBox25)
        Me.GunaShadowPanel3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GunaShadowPanel3.Location = New System.Drawing.Point(57, 38)
        Me.GunaShadowPanel3.Name = "GunaShadowPanel3"
        Me.GunaShadowPanel3.Radius = 6
        Me.GunaShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel3.ShadowDepth = 255
        Me.GunaShadowPanel3.Size = New System.Drawing.Size(1755, 284)
        Me.GunaShadowPanel3.TabIndex = 17
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel5.Location = New System.Drawing.Point(218, 14)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(198, 29)
        Me.MaterialLabel5.TabIndex = 14
        Me.MaterialLabel5.Text = "Nome do Falecido"
        '
        'MaterialTextBox22
        '
        Me.MaterialTextBox22.AnimateReadOnly = False
        Me.MaterialTextBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox22.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox22.Depth = 0
        Me.MaterialTextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox22.HideSelection = True
        Me.MaterialTextBox22.LeadingIcon = Nothing
        Me.MaterialTextBox22.Location = New System.Drawing.Point(218, 46)
        Me.MaterialTextBox22.MaxLength = 32767
        Me.MaterialTextBox22.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox22.Name = "MaterialTextBox22"
        Me.MaterialTextBox22.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox22.PrefixSuffixText = Nothing
        Me.MaterialTextBox22.ReadOnly = False
        Me.MaterialTextBox22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox22.SelectedText = ""
        Me.MaterialTextBox22.SelectionLength = 0
        Me.MaterialTextBox22.SelectionStart = 0
        Me.MaterialTextBox22.ShortcutsEnabled = True
        Me.MaterialTextBox22.Size = New System.Drawing.Size(283, 48)
        Me.MaterialTextBox22.TabIndex = 13
        Me.MaterialTextBox22.TabStop = False
        Me.MaterialTextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox22.TrailingIcon = Nothing
        Me.MaterialTextBox22.UseSystemPasswordChar = False
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel7.Location = New System.Drawing.Point(34, 14)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(156, 29)
        Me.MaterialLabel7.TabIndex = 12
        Me.MaterialLabel7.Text = "ID do Falecido"
        '
        'MaterialButton3
        '
        Me.MaterialButton3.AutoSize = False
        Me.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton3.Depth = 0
        Me.MaterialButton3.HighEmphasis = True
        Me.MaterialButton3.Icon = CType(resources.GetObject("MaterialButton3.Icon"), System.Drawing.Image)
        Me.MaterialButton3.Location = New System.Drawing.Point(1607, 17)
        Me.MaterialButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton3.Name = "MaterialButton3"
        Me.MaterialButton3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton3.Size = New System.Drawing.Size(131, 36)
        Me.MaterialButton3.TabIndex = 3
        Me.MaterialButton3.Text = "Pesquisar"
        Me.MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton3.UseAccentColor = False
        Me.MaterialButton3.UseVisualStyleBackColor = True
        '
        'MaterialTextBox25
        '
        Me.MaterialTextBox25.AnimateReadOnly = False
        Me.MaterialTextBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MaterialTextBox25.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.MaterialTextBox25.Depth = 0
        Me.MaterialTextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialTextBox25.HideSelection = True
        Me.MaterialTextBox25.LeadingIcon = Nothing
        Me.MaterialTextBox25.Location = New System.Drawing.Point(34, 46)
        Me.MaterialTextBox25.MaxLength = 32767
        Me.MaterialTextBox25.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialTextBox25.Name = "MaterialTextBox25"
        Me.MaterialTextBox25.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialTextBox25.PrefixSuffixText = Nothing
        Me.MaterialTextBox25.ReadOnly = False
        Me.MaterialTextBox25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MaterialTextBox25.SelectedText = ""
        Me.MaterialTextBox25.SelectionLength = 0
        Me.MaterialTextBox25.SelectionStart = 0
        Me.MaterialTextBox25.ShortcutsEnabled = True
        Me.MaterialTextBox25.Size = New System.Drawing.Size(156, 48)
        Me.MaterialTextBox25.TabIndex = 2
        Me.MaterialTextBox25.TabStop = False
        Me.MaterialTextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.MaterialTextBox25.TrailingIcon = Nothing
        Me.MaterialTextBox25.UseSystemPasswordChar = False
        '
        'btn_voltar2
        '
        Me.btn_voltar2.AutoSize = False
        Me.btn_voltar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_voltar2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_voltar2.Depth = 0
        Me.btn_voltar2.HighEmphasis = True
        Me.btn_voltar2.Icon = CType(resources.GetObject("btn_voltar2.Icon"), System.Drawing.Image)
        Me.btn_voltar2.Location = New System.Drawing.Point(2, 2)
        Me.btn_voltar2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_voltar2.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_voltar2.Name = "btn_voltar2"
        Me.btn_voltar2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_voltar2.Size = New System.Drawing.Size(131, 36)
        Me.btn_voltar2.TabIndex = 16
        Me.btn_voltar2.Text = "Voltar"
        Me.btn_voltar2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_voltar2.UseAccentColor = False
        Me.btn_voltar2.UseVisualStyleBackColor = True
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
        'txt_data
        '
        Me.txt_data.AllowPromptAsInput = True
        Me.txt_data.AnimateReadOnly = False
        Me.txt_data.AsciiOnly = False
        Me.txt_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txt_data.BeepOnError = False
        Me.txt_data.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.txt_data.Depth = 0
        Me.txt_data.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_data.HidePromptOnLeave = False
        Me.txt_data.HideSelection = True
        Me.txt_data.InsertKeyMode = System.Windows.Forms.InsertKeyMode.[Default]
        Me.txt_data.LeadingIcon = Nothing
        Me.txt_data.Location = New System.Drawing.Point(960, 131)
        Me.txt_data.Mask = "00/00/0000"
        Me.txt_data.MaxLength = 32767
        Me.txt_data.MouseState = MaterialSkin.MouseState.OUT
        Me.txt_data.Name = "txt_data"
        Me.txt_data.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_data.PrefixSuffixText = Nothing
        Me.txt_data.PromptChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txt_data.ReadOnly = False
        Me.txt_data.RejectInputOnFirstFailure = False
        Me.txt_data.ResetOnPrompt = True
        Me.txt_data.ResetOnSpace = True
        Me.txt_data.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_data.SelectedText = ""
        Me.txt_data.SelectionLength = 0
        Me.txt_data.SelectionStart = 0
        Me.txt_data.ShortcutsEnabled = True
        Me.txt_data.Size = New System.Drawing.Size(250, 48)
        Me.txt_data.SkipLiterals = True
        Me.txt_data.TabIndex = 15
        Me.txt_data.TabStop = False
        Me.txt_data.Text = "  /  /"
        Me.txt_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_data.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.txt_data.TrailingIcon = Nothing
        Me.txt_data.UseSystemPasswordChar = False
        Me.txt_data.ValidatingType = Nothing
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.MaterialLabel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaterialLabel8.Location = New System.Drawing.Point(960, 99)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(173, 29)
        Me.MaterialLabel8.TabIndex = 16
        Me.MaterialLabel8.Text = "Data de Criação"
        '
        'frm_financeiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1032)
        Me.Controls.Add(Me.btn_pesquisar2)
        Me.Controls.Add(Me.PictureBox3)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.btn_pesquisar2
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_financeiro"
        Me.Text = "           Thanatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btn_pesquisar2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.BunifuCustomDataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.BunifuCustomDataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel3.ResumeLayout(False)
        Me.GunaShadowPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_pesquisar2 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
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
    Friend WithEvents BunifuCustomDataGrid2 As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_pesquisar1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialTextBox23 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents MaterialTextBox21 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btn_voltar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_voltar1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents BunifuCustomDataGrid3 As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaShadowPanel3 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialButton3 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialTextBox25 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btn_voltar2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTextBox22 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txt_data As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
End Class
