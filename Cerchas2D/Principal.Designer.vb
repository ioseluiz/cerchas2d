<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnResultados = New FontAwesome.Sharp.IconButton()
        Me.btnFuerzas = New FontAwesome.Sharp.IconButton()
        Me.btnElementos = New FontAwesome.Sharp.IconButton()
        Me.btnNodos = New FontAwesome.Sharp.IconButton()
        Me.btnEntrada = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PicBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.btnCalcular = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PicBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnResultados)
        Me.PanelMenu.Controls.Add(Me.btnFuerzas)
        Me.PanelMenu.Controls.Add(Me.btnElementos)
        Me.PanelMenu.Controls.Add(Me.btnNodos)
        Me.PanelMenu.Controls.Add(Me.btnEntrada)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 630)
        Me.PanelMenu.TabIndex = 0
        '
        'btnResultados
        '
        Me.btnResultados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResultados.FlatAppearance.BorderSize = 0
        Me.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResultados.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnResultados.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.btnResultados.IconColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnResultados.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnResultados.IconSize = 32
        Me.btnResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResultados.Location = New System.Drawing.Point(0, 380)
        Me.btnResultados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResultados.Name = "btnResultados"
        Me.btnResultados.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnResultados.Size = New System.Drawing.Size(220, 60)
        Me.btnResultados.TabIndex = 5
        Me.btnResultados.Text = "Resultados"
        Me.btnResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnResultados.UseVisualStyleBackColor = True
        '
        'btnFuerzas
        '
        Me.btnFuerzas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFuerzas.FlatAppearance.BorderSize = 0
        Me.btnFuerzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuerzas.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuerzas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFuerzas.IconChar = FontAwesome.Sharp.IconChar.ArrowDown
        Me.btnFuerzas.IconColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFuerzas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFuerzas.IconSize = 32
        Me.btnFuerzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuerzas.Location = New System.Drawing.Point(0, 320)
        Me.btnFuerzas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFuerzas.Name = "btnFuerzas"
        Me.btnFuerzas.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnFuerzas.Size = New System.Drawing.Size(220, 60)
        Me.btnFuerzas.TabIndex = 4
        Me.btnFuerzas.Text = "Fuerzas"
        Me.btnFuerzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuerzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFuerzas.UseVisualStyleBackColor = True
        '
        'btnElementos
        '
        Me.btnElementos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnElementos.FlatAppearance.BorderSize = 0
        Me.btnElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElementos.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElementos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnElementos.IconChar = FontAwesome.Sharp.IconChar.Link
        Me.btnElementos.IconColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnElementos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnElementos.IconSize = 32
        Me.btnElementos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElementos.Location = New System.Drawing.Point(0, 260)
        Me.btnElementos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnElementos.Name = "btnElementos"
        Me.btnElementos.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnElementos.Size = New System.Drawing.Size(220, 60)
        Me.btnElementos.TabIndex = 3
        Me.btnElementos.Text = "Elementos"
        Me.btnElementos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElementos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnElementos.UseVisualStyleBackColor = True
        '
        'btnNodos
        '
        Me.btnNodos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNodos.FlatAppearance.BorderSize = 0
        Me.btnNodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNodos.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNodos.IconChar = FontAwesome.Sharp.IconChar.ProjectDiagram
        Me.btnNodos.IconColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNodos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNodos.IconSize = 32
        Me.btnNodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNodos.Location = New System.Drawing.Point(0, 200)
        Me.btnNodos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNodos.Name = "btnNodos"
        Me.btnNodos.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnNodos.Size = New System.Drawing.Size(220, 60)
        Me.btnNodos.TabIndex = 2
        Me.btnNodos.Text = "Nodos"
        Me.btnNodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNodos.UseVisualStyleBackColor = True
        '
        'btnEntrada
        '
        Me.btnEntrada.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEntrada.FlatAppearance.BorderSize = 0
        Me.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrada.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEntrada.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.btnEntrada.IconColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEntrada.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEntrada.IconSize = 32
        Me.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrada.Location = New System.Drawing.Point(0, 140)
        Me.btnEntrada.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Padding = New System.Windows.Forms.Padding(11, 0, 20, 0)
        Me.btnEntrada.Size = New System.Drawing.Size(220, 60)
        Me.btnEntrada.TabIndex = 1
        Me.btnEntrada.Text = "Datos de Entrada"
        Me.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PicBoxLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'PicBoxLogo
        '
        Me.PicBoxLogo.Image = CType(resources.GetObject("PicBoxLogo.Image"), System.Drawing.Image)
        Me.PicBoxLogo.Location = New System.Drawing.Point(3, 12)
        Me.PicBoxLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicBoxLogo.Name = "PicBoxLogo"
        Me.PicBoxLogo.Size = New System.Drawing.Size(213, 116)
        Me.PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxLogo.TabIndex = 0
        Me.PicBoxLogo.TabStop = False
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.btnCalcular)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitleBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(888, 75)
        Me.PanelTitleBar.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCalcular.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.btnCalcular.IconColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalcular.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCalcular.IconSize = 32
        Me.btnCalcular.Location = New System.Drawing.Point(623, 12)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(177, 55)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalcular.UseVisualStyleBackColor = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Helvetica", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(68, 34)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(49, 16)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 44
        Me.IconCurrentForm.Location = New System.Drawing.Point(19, 22)
        Me.IconCurrentForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(44, 46)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.White
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 75)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(888, 555)
        Me.PanelDesktop.TabIndex = 2
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1108, 630)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Principal"
        Me.Text = "Cerchas 2D"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PicBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnResultados As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFuerzas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnElementos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNodos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEntrada As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PicBoxLogo As PictureBox
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btnCalcular As FontAwesome.Sharp.IconButton
End Class
