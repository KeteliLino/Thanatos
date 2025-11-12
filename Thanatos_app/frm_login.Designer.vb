<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btn_entrar = New MaterialSkin.Controls.MaterialButton()
        Me.lbl_senha = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl_login = New MaterialSkin.Controls.MaterialLabel()
        Me.txt_login = New MaterialSkin.Controls.MaterialTextBox()
        Me.txt_senha = New MaterialSkin.Controls.MaterialTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.Gray
        Me.GunaShadowPanel1.Controls.Add(Me.btn_entrar)
        Me.GunaShadowPanel1.Controls.Add(Me.lbl_senha)
        Me.GunaShadowPanel1.Controls.Add(Me.lbl_login)
        Me.GunaShadowPanel1.Controls.Add(Me.txt_login)
        Me.GunaShadowPanel1.Controls.Add(Me.txt_senha)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(626, 259)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 6
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(668, 515)
        Me.GunaShadowPanel1.TabIndex = 1
        '
        'btn_entrar
        '
        Me.btn_entrar.AutoSize = False
        Me.btn_entrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_entrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_entrar.Depth = 0
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.MediumPurple
        Me.btn_entrar.HighEmphasis = True
        Me.btn_entrar.Icon = Nothing
        Me.btn_entrar.Location = New System.Drawing.Point(133, 371)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_entrar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_entrar.Size = New System.Drawing.Size(417, 50)
        Me.btn_entrar.TabIndex = 10
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_entrar.UseAccentColor = False
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.BackColor = System.Drawing.Color.White
        Me.lbl_senha.Depth = 0
        Me.lbl_senha.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_senha.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_senha.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.lbl_senha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_senha.Location = New System.Drawing.Point(133, 232)
        Me.lbl_senha.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(67, 29)
        Me.lbl_senha.TabIndex = 9
        Me.lbl_senha.Text = "Senha"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Depth = 0
        Me.lbl_login.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_login.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_login.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        Me.lbl_login.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_login.Location = New System.Drawing.Point(132, 99)
        Me.lbl_login.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(60, 29)
        Me.lbl_login.TabIndex = 8
        Me.lbl_login.Text = "Login"
        '
        'txt_login
        '
        Me.txt_login.AnimateReadOnly = False
        Me.txt_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_login.Depth = 0
        Me.txt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_login.LeadingIcon = Nothing
        Me.txt_login.Location = New System.Drawing.Point(133, 131)
        Me.txt_login.MaxLength = 50
        Me.txt_login.MouseState = MaterialSkin.MouseState.OUT
        Me.txt_login.Multiline = False
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(417, 50)
        Me.txt_login.TabIndex = 7
        Me.txt_login.Text = ""
        Me.txt_login.TrailingIcon = Nothing
        '
        'txt_senha
        '
        Me.txt_senha.AnimateReadOnly = False
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Depth = 0
        Me.txt_senha.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txt_senha.LeadingIcon = Nothing
        Me.txt_senha.Location = New System.Drawing.Point(133, 264)
        Me.txt_senha.MaxLength = 50
        Me.txt_senha.MouseState = MaterialSkin.MouseState.OUT
        Me.txt_senha.Multiline = False
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(417, 50)
        Me.txt_senha.TabIndex = 6
        Me.txt_senha.Text = ""
        Me.txt_senha.TrailingIcon = Nothing
        '
        'frm_login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1920, 1032)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(829, 463)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "           Thanatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents lbl_senha As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl_login As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_login As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txt_senha As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btn_entrar As MaterialSkin.Controls.MaterialButton
End Class
