<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_recepcionista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recepcionista))
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_voltar = New MaterialSkin.Controls.MaterialButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_voltar1 = New MaterialSkin.Controls.MaterialButton()
        Me.btn_voltar2 = New MaterialSkin.Controls.MaterialButton()
        Me.btn_voltar3 = New MaterialSkin.Controls.MaterialButton()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(64, 20)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(46, 43)
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.ImageList = Me.ImageList1
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 64)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1914, 965)
        Me.MaterialTabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_voltar)
        Me.TabPage1.ImageKey = "jar.png"
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consultar Cremações"
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
        Me.btn_voltar.TabIndex = 16
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_voltar.UseAccentColor = False
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_voltar1)
        Me.TabPage2.ImageKey = "coffin.png"
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar Falecidos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_voltar2)
        Me.TabPage3.ImageKey = "cross.png"
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Consultar Jazigos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btn_voltar3)
        Me.TabPage4.ImageKey = "bouquet.png"
        Me.TabPage4.Location = New System.Drawing.Point(4, 39)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1906, 922)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Consultar Velórios"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "door.png")
        Me.ImageList1.Images.SetKeyName(1, "jar.png")
        Me.ImageList1.Images.SetKeyName(2, "coffin.png")
        Me.ImageList1.Images.SetKeyName(3, "worker.png")
        Me.ImageList1.Images.SetKeyName(4, "headphone.png")
        Me.ImageList1.Images.SetKeyName(5, "bouquet.png")
        Me.ImageList1.Images.SetKeyName(6, "cross.png")
        Me.ImageList1.Images.SetKeyName(7, "exit.png")
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
        Me.btn_voltar1.TabIndex = 17
        Me.btn_voltar1.Text = "Voltar"
        Me.btn_voltar1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_voltar1.UseAccentColor = False
        Me.btn_voltar1.UseVisualStyleBackColor = True
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
        Me.btn_voltar2.TabIndex = 18
        Me.btn_voltar2.Text = "Voltar"
        Me.btn_voltar2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_voltar2.UseAccentColor = False
        Me.btn_voltar2.UseVisualStyleBackColor = True
        '
        'btn_voltar3
        '
        Me.btn_voltar3.AutoSize = False
        Me.btn_voltar3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_voltar3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btn_voltar3.Depth = 0
        Me.btn_voltar3.HighEmphasis = True
        Me.btn_voltar3.Icon = CType(resources.GetObject("btn_voltar3.Icon"), System.Drawing.Image)
        Me.btn_voltar3.Location = New System.Drawing.Point(2, 2)
        Me.btn_voltar3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btn_voltar3.MouseState = MaterialSkin.MouseState.HOVER
        Me.btn_voltar3.Name = "btn_voltar3"
        Me.btn_voltar3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btn_voltar3.Size = New System.Drawing.Size(131, 36)
        Me.btn_voltar3.TabIndex = 18
        Me.btn_voltar3.Text = "Voltar"
        Me.btn_voltar3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btn_voltar3.UseAccentColor = False
        Me.btn_voltar3.UseVisualStyleBackColor = True
        '
        'frm_recepcionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1032)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.PictureBox5)
        Me.DrawerIsOpen = True
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_recepcionista"
        Me.Text = "           Thanatos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btn_voltar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_voltar1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_voltar2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_voltar3 As MaterialSkin.Controls.MaterialButton
End Class
