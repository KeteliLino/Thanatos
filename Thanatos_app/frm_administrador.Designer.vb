<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_administrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_administrador))
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_home = New MaterialSkin.Controls.MaterialButton()
        Me.btn_administracao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_recepcao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_financeiro = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialFloatingActionButton1 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFloatingActionButton2 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Me.MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFloatingActionButton3 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Me.MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFloatingActionButton4 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Me.MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFloatingActionButton5 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Me.MaterialCard5 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFloatingActionButton6 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Me.MaterialCard6 = New MaterialSkin.Controls.MaterialCard()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.MaterialCard1.SuspendLayout()
        Me.MaterialCard2.SuspendLayout()
        Me.MaterialCard3.SuspendLayout()
        Me.MaterialCard4.SuspendLayout()
        Me.MaterialCard5.SuspendLayout()
        Me.MaterialCard6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
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
        Me.GunaShadowPanel1.TabIndex = 3
        '
        'btn_home
        '
        Me.btn_home.AutoSize = False
        Me.btn_home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_home.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_home.Depth = 0
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
        Me.btn_administracao.Enabled = False
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
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.MaterialLabel1)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(337, 174)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(411, 318)
        Me.MaterialCard1.TabIndex = 4
        '
        'MaterialFloatingActionButton1
        '
        Me.MaterialFloatingActionButton1.Depth = 0
        Me.MaterialFloatingActionButton1.Icon = Global.Thanatos_app.My.Resources.Resources.crud
        Me.MaterialFloatingActionButton1.ImageKey = "crud.png"
        Me.MaterialFloatingActionButton1.ImageList = Me.ImageList1
        Me.MaterialFloatingActionButton1.Location = New System.Drawing.Point(724, 295)
        Me.MaterialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFloatingActionButton1.Name = "MaterialFloatingActionButton1"
        Me.MaterialFloatingActionButton1.Size = New System.Drawing.Size(60, 60)
        Me.MaterialFloatingActionButton1.TabIndex = 5
        Me.MaterialFloatingActionButton1.Text = "MaterialFloatingActionButton1"
        Me.MaterialFloatingActionButton1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "crud.png")
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel1.Location = New System.Drawing.Point(82, 124)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(255, 41)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = " MANTER SALAS"
        '
        'MaterialFloatingActionButton2
        '
        Me.MaterialFloatingActionButton2.Depth = 0
        Me.MaterialFloatingActionButton2.Icon = Global.Thanatos_app.My.Resources.Resources.crud
        Me.MaterialFloatingActionButton2.ImageKey = "crud.png"
        Me.MaterialFloatingActionButton2.ImageList = Me.ImageList1
        Me.MaterialFloatingActionButton2.Location = New System.Drawing.Point(1264, 295)
        Me.MaterialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFloatingActionButton2.Name = "MaterialFloatingActionButton2"
        Me.MaterialFloatingActionButton2.Size = New System.Drawing.Size(60, 60)
        Me.MaterialFloatingActionButton2.TabIndex = 7
        Me.MaterialFloatingActionButton2.Text = "MaterialFloatingActionButton2"
        Me.MaterialFloatingActionButton2.UseVisualStyleBackColor = True
        '
        'MaterialCard2
        '
        Me.MaterialCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard2.Controls.Add(Me.MaterialLabel2)
        Me.MaterialCard2.Depth = 0
        Me.MaterialCard2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard2.Location = New System.Drawing.Point(872, 174)
        Me.MaterialCard2.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard2.Name = "MaterialCard2"
        Me.MaterialCard2.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard2.Size = New System.Drawing.Size(411, 318)
        Me.MaterialCard2.TabIndex = 6
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel2.Location = New System.Drawing.Point(51, 124)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(309, 41)
        Me.MaterialLabel2.TabIndex = 0
        Me.MaterialLabel2.Text = " MANTER SERVIÇOS"
        '
        'MaterialFloatingActionButton3
        '
        Me.MaterialFloatingActionButton3.Depth = 0
        Me.MaterialFloatingActionButton3.Icon = Global.Thanatos_app.My.Resources.Resources.crud
        Me.MaterialFloatingActionButton3.ImageKey = "crud.png"
        Me.MaterialFloatingActionButton3.ImageList = Me.ImageList1
        Me.MaterialFloatingActionButton3.Location = New System.Drawing.Point(1817, 295)
        Me.MaterialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFloatingActionButton3.Name = "MaterialFloatingActionButton3"
        Me.MaterialFloatingActionButton3.Size = New System.Drawing.Size(60, 60)
        Me.MaterialFloatingActionButton3.TabIndex = 9
        Me.MaterialFloatingActionButton3.Text = "MaterialFloatingActionButton3"
        Me.MaterialFloatingActionButton3.UseVisualStyleBackColor = True
        '
        'MaterialCard3
        '
        Me.MaterialCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard3.Controls.Add(Me.MaterialLabel3)
        Me.MaterialCard3.Depth = 0
        Me.MaterialCard3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard3.Location = New System.Drawing.Point(1430, 174)
        Me.MaterialCard3.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard3.Name = "MaterialCard3"
        Me.MaterialCard3.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard3.Size = New System.Drawing.Size(411, 318)
        Me.MaterialCard3.TabIndex = 8
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel3.Location = New System.Drawing.Point(66, 124)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(289, 41)
        Me.MaterialLabel3.TabIndex = 0
        Me.MaterialLabel3.Text = " MANTER JAZIGOS"
        '
        'MaterialFloatingActionButton4
        '
        Me.MaterialFloatingActionButton4.Depth = 0
        Me.MaterialFloatingActionButton4.Icon = Global.Thanatos_app.My.Resources.Resources.crud
        Me.MaterialFloatingActionButton4.ImageKey = "crud.png"
        Me.MaterialFloatingActionButton4.ImageList = Me.ImageList1
        Me.MaterialFloatingActionButton4.Location = New System.Drawing.Point(724, 723)
        Me.MaterialFloatingActionButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFloatingActionButton4.Name = "MaterialFloatingActionButton4"
        Me.MaterialFloatingActionButton4.Size = New System.Drawing.Size(60, 60)
        Me.MaterialFloatingActionButton4.TabIndex = 11
        Me.MaterialFloatingActionButton4.Text = "MaterialFloatingActionButton4"
        Me.MaterialFloatingActionButton4.UseVisualStyleBackColor = True
        '
        'MaterialCard4
        '
        Me.MaterialCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard4.Controls.Add(Me.MaterialLabel4)
        Me.MaterialCard4.Depth = 0
        Me.MaterialCard4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard4.Location = New System.Drawing.Point(337, 602)
        Me.MaterialCard4.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard4.Name = "MaterialCard4"
        Me.MaterialCard4.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard4.Size = New System.Drawing.Size(411, 318)
        Me.MaterialCard4.TabIndex = 10
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel4.Location = New System.Drawing.Point(82, 124)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(255, 41)
        Me.MaterialLabel4.TabIndex = 0
        Me.MaterialLabel4.Text = " MANTER SALAS"
        '
        'MaterialFloatingActionButton5
        '
        Me.MaterialFloatingActionButton5.Depth = 0
        Me.MaterialFloatingActionButton5.Icon = Global.Thanatos_app.My.Resources.Resources.crud
        Me.MaterialFloatingActionButton5.ImageKey = "crud.png"
        Me.MaterialFloatingActionButton5.ImageList = Me.ImageList1
        Me.MaterialFloatingActionButton5.Location = New System.Drawing.Point(1259, 723)
        Me.MaterialFloatingActionButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFloatingActionButton5.Name = "MaterialFloatingActionButton5"
        Me.MaterialFloatingActionButton5.Size = New System.Drawing.Size(60, 60)
        Me.MaterialFloatingActionButton5.TabIndex = 13
        Me.MaterialFloatingActionButton5.Text = "MaterialFloatingActionButton5"
        Me.MaterialFloatingActionButton5.UseVisualStyleBackColor = True
        '
        'MaterialCard5
        '
        Me.MaterialCard5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard5.Controls.Add(Me.MaterialLabel5)
        Me.MaterialCard5.Depth = 0
        Me.MaterialCard5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard5.Location = New System.Drawing.Point(872, 602)
        Me.MaterialCard5.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard5.Name = "MaterialCard5"
        Me.MaterialCard5.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard5.Size = New System.Drawing.Size(411, 318)
        Me.MaterialCard5.TabIndex = 12
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel5.Location = New System.Drawing.Point(82, 124)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(255, 41)
        Me.MaterialLabel5.TabIndex = 0
        Me.MaterialLabel5.Text = " MANTER SALAS"
        '
        'MaterialFloatingActionButton6
        '
        Me.MaterialFloatingActionButton6.Depth = 0
        Me.MaterialFloatingActionButton6.Icon = Global.Thanatos_app.My.Resources.Resources.crud
        Me.MaterialFloatingActionButton6.ImageKey = "crud.png"
        Me.MaterialFloatingActionButton6.ImageList = Me.ImageList1
        Me.MaterialFloatingActionButton6.Location = New System.Drawing.Point(1817, 723)
        Me.MaterialFloatingActionButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFloatingActionButton6.Name = "MaterialFloatingActionButton6"
        Me.MaterialFloatingActionButton6.Size = New System.Drawing.Size(60, 60)
        Me.MaterialFloatingActionButton6.TabIndex = 9
        Me.MaterialFloatingActionButton6.Text = "MaterialFloatingActionButton6"
        Me.MaterialFloatingActionButton6.UseVisualStyleBackColor = True
        '
        'MaterialCard6
        '
        Me.MaterialCard6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard6.Controls.Add(Me.MaterialLabel6)
        Me.MaterialCard6.Depth = 0
        Me.MaterialCard6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard6.Location = New System.Drawing.Point(1430, 602)
        Me.MaterialCard6.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard6.Name = "MaterialCard6"
        Me.MaterialCard6.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard6.Size = New System.Drawing.Size(411, 318)
        Me.MaterialCard6.TabIndex = 8
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        Me.MaterialLabel6.Location = New System.Drawing.Point(82, 124)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(255, 41)
        Me.MaterialLabel6.TabIndex = 0
        Me.MaterialLabel6.Text = " MANTER SALAS"
        '
        'frm_administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1032)
        Me.Controls.Add(Me.MaterialFloatingActionButton6)
        Me.Controls.Add(Me.MaterialFloatingActionButton5)
        Me.Controls.Add(Me.MaterialCard6)
        Me.Controls.Add(Me.MaterialCard5)
        Me.Controls.Add(Me.MaterialFloatingActionButton4)
        Me.Controls.Add(Me.MaterialCard4)
        Me.Controls.Add(Me.MaterialFloatingActionButton3)
        Me.Controls.Add(Me.MaterialCard3)
        Me.Controls.Add(Me.MaterialFloatingActionButton2)
        Me.Controls.Add(Me.MaterialCard2)
        Me.Controls.Add(Me.MaterialFloatingActionButton1)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_administrador"
        Me.Text = "           Thanatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
        Me.MaterialCard2.ResumeLayout(False)
        Me.MaterialCard2.PerformLayout()
        Me.MaterialCard3.ResumeLayout(False)
        Me.MaterialCard3.PerformLayout()
        Me.MaterialCard4.ResumeLayout(False)
        Me.MaterialCard4.PerformLayout()
        Me.MaterialCard5.ResumeLayout(False)
        Me.MaterialCard5.PerformLayout()
        Me.MaterialCard6.ResumeLayout(False)
        Me.MaterialCard6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_home As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_administracao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_recepcao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_financeiro As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialFloatingActionButton1 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFloatingActionButton2 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFloatingActionButton3 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFloatingActionButton4 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFloatingActionButton5 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents MaterialCard5 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFloatingActionButton6 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents MaterialCard6 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
End Class
