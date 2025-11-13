<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_financeiro
    Inherits MaterialSkin.Controls.MaterialForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_financeiro))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_financeiro = New MaterialSkin.Controls.MaterialButton()
        Me.btn_home = New MaterialSkin.Controls.MaterialButton()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_administracao = New MaterialSkin.Controls.MaterialButton()
        Me.btn_recepcao = New MaterialSkin.Controls.MaterialButton()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.Gray
        Me.GunaShadowPanel1.Controls.Add(Me.btn_financeiro)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_home)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaShadowPanel2)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_administracao)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_recepcao)
        Me.GunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(3, 64)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 6
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(244, 974)
        Me.GunaShadowPanel1.TabIndex = 3
        '
        'btn_financeiro
        '
        Me.btn_financeiro.AutoSize = False
        Me.btn_financeiro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_financeiro.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_financeiro.Depth = 0
        Me.btn_financeiro.ForeColor = System.Drawing.Color.MediumPurple
        Me.btn_financeiro.HighEmphasis = True
        Me.btn_financeiro.Icon = CType(resources.GetObject("btn_financeiro.Icon"), System.Drawing.Image)
        Me.btn_financeiro.Location = New System.Drawing.Point(5, 324)
        Me.btn_financeiro.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_financeiro.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_financeiro.Name = "btn_financeiro"
        Me.btn_financeiro.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_financeiro.Size = New System.Drawing.Size(234, 104)
        Me.btn_financeiro.TabIndex = 4
        Me.btn_financeiro.Text = "Financeiro"
        Me.btn_financeiro.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_financeiro.UseAccentColor = False
        Me.btn_financeiro.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.AutoSize = False
        Me.btn_home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_home.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_home.Depth = 0
        Me.btn_home.ForeColor = System.Drawing.Color.MediumPurple
        Me.btn_home.HighEmphasis = True
        Me.btn_home.Icon = CType(resources.GetObject("btn_home.Icon"), System.Drawing.Image)
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.Location = New System.Drawing.Point(5, 110)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_home.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_home.Name = "btn_home"
        Me.btn_home.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_home.Size = New System.Drawing.Size(234, 104)
        Me.btn_home.TabIndex = 3
        Me.btn_home.Text = "HOME"
        Me.btn_home.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_home.UseAccentColor = False
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(-3, 313)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 6
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(250, 125)
        Me.GunaShadowPanel2.TabIndex = 3
        '
        'btn_administracao
        '
        Me.btn_administracao.AutoSize = False
        Me.btn_administracao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_administracao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_administracao.Depth = 0
        Me.btn_administracao.ForeColor = System.Drawing.Color.MediumPurple
        Me.btn_administracao.HighEmphasis = True
        Me.btn_administracao.Icon = CType(resources.GetObject("btn_administracao.Icon"), System.Drawing.Image)
        Me.btn_administracao.Location = New System.Drawing.Point(5, 752)
        Me.btn_administracao.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_administracao.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_administracao.Name = "btn_administracao"
        Me.btn_administracao.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_administracao.Size = New System.Drawing.Size(234, 104)
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
        Me.btn_recepcao.ForeColor = System.Drawing.Color.MediumPurple
        Me.btn_recepcao.HighEmphasis = True
        Me.btn_recepcao.Icon = CType(resources.GetObject("btn_recepcao.Icon"), System.Drawing.Image)
        Me.btn_recepcao.Location = New System.Drawing.Point(5, 538)
        Me.btn_recepcao.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_recepcao.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_recepcao.Name = "btn_recepcao"
        Me.btn_recepcao.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_recepcao.Size = New System.Drawing.Size(234, 104)
        Me.btn_recepcao.TabIndex = 6
        Me.btn_recepcao.Text = "Recepção"
        Me.btn_recepcao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_recepcao.UseAccentColor = False
        Me.btn_recepcao.UseVisualStyleBackColor = True
        '
        'frm_financeiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_financeiro"
        Me.Text = "           Thanatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_financeiro As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_home As MaterialSkin.Controls.MaterialButton
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btn_administracao As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_recepcao As MaterialSkin.Controls.MaterialButton
End Class
