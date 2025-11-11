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
        Me.btn_entrar = New Guna.UI.WinForms.GunaButton()
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
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
        Me.GunaShadowPanel1.Controls.Add(Me.GunaTextBox2)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaTextBox1)
        Me.GunaShadowPanel1.Controls.Add(Me.btn_entrar)
        Me.GunaShadowPanel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GunaShadowPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(936, 173)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 6
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(688, 515)
        Me.GunaShadowPanel1.TabIndex = 1
        '
        'btn_entrar
        '
        Me.btn_entrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_entrar.AnimationHoverSpeed = 0.07!
        Me.btn_entrar.AnimationSpeed = 0.03!
        Me.btn_entrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_entrar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btn_entrar.BorderColor = System.Drawing.Color.Black
        Me.btn_entrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_entrar.FocusedColor = System.Drawing.Color.Empty
        Me.btn_entrar.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.Color.White
        Me.btn_entrar.Image = Nothing
        Me.btn_entrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_entrar.Location = New System.Drawing.Point(192, 370)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_entrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_entrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_entrar.OnHoverImage = Nothing
        Me.btn_entrar.OnPressedColor = System.Drawing.Color.Black
        Me.btn_entrar.Radius = 6
        Me.btn_entrar.Size = New System.Drawing.Size(297, 81)
        Me.btn_entrar.TabIndex = 4
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(106, 215)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(116, 39)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Senha"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(106, 50)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(137, 39)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Usuário"
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.HideSelection = False
        Me.GunaTextBox1.Location = New System.Drawing.Point(113, 92)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.SelectedText = ""
        Me.GunaTextBox1.Size = New System.Drawing.Size(471, 74)
        Me.GunaTextBox1.TabIndex = 5
        Me.GunaTextBox1.Text = "GunaTextBox1"
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox2.HideSelection = False
        Me.GunaTextBox2.Location = New System.Drawing.Point(113, 257)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.SelectedText = ""
        Me.GunaTextBox2.Size = New System.Drawing.Size(471, 74)
        Me.GunaTextBox2.TabIndex = 6
        Me.GunaTextBox2.Text = "GunaTextBox2"
        '
        'frm_login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1940, 1100)
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
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents btn_entrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
End Class
