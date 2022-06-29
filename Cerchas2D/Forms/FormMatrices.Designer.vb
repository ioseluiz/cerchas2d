<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatrices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvMatrizK = New System.Windows.Forms.DataGridView()
        Me.dgvF = New System.Windows.Forms.DataGridView()
        Me.dgvP = New System.Windows.Forms.DataGridView()
        Me.dgvD = New System.Windows.Forms.DataGridView()
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblK = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblSP = New System.Windows.Forms.Label()
        CType(Me.dgvMatrizK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMatrizK
        '
        Me.dgvMatrizK.AllowUserToAddRows = False
        Me.dgvMatrizK.AllowUserToDeleteRows = False
        Me.dgvMatrizK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatrizK.Location = New System.Drawing.Point(248, 61)
        Me.dgvMatrizK.Name = "dgvMatrizK"
        Me.dgvMatrizK.RowHeadersVisible = False
        Me.dgvMatrizK.Size = New System.Drawing.Size(350, 289)
        Me.dgvMatrizK.TabIndex = 0
        '
        'dgvF
        '
        Me.dgvF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvF.Location = New System.Drawing.Point(13, 61)
        Me.dgvF.Name = "dgvF"
        Me.dgvF.RowHeadersVisible = False
        Me.dgvF.Size = New System.Drawing.Size(98, 289)
        Me.dgvF.TabIndex = 1
        '
        'dgvP
        '
        Me.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvP.Location = New System.Drawing.Point(131, 61)
        Me.dgvP.Name = "dgvP"
        Me.dgvP.RowHeadersVisible = False
        Me.dgvP.Size = New System.Drawing.Size(98, 289)
        Me.dgvP.TabIndex = 2
        '
        'dgvD
        '
        Me.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvD.Location = New System.Drawing.Point(604, 61)
        Me.dgvD.Name = "dgvD"
        Me.dgvD.RowHeadersVisible = False
        Me.dgvD.Size = New System.Drawing.Size(98, 289)
        Me.dgvD.TabIndex = 3
        '
        'dgvSP
        '
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(713, 61)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.RowHeadersVisible = False
        Me.dgvSP.Size = New System.Drawing.Size(98, 289)
        Me.dgvSP.TabIndex = 4
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(41, 36)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(30, 19)
        Me.lblF.TabIndex = 5
        Me.lblF.Text = "{F}"
        '
        'lblP
        '
        Me.lblP.AutoSize = True
        Me.lblP.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP.Location = New System.Drawing.Point(161, 39)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(32, 19)
        Me.lblP.TabIndex = 6
        Me.lblP.Text = "{P}"
        '
        'lblK
        '
        Me.lblK.AutoSize = True
        Me.lblK.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblK.Location = New System.Drawing.Point(377, 36)
        Me.lblK.Name = "lblK"
        Me.lblK.Size = New System.Drawing.Size(30, 19)
        Me.lblK.TabIndex = 7
        Me.lblK.Text = "[K]"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblD.Location = New System.Drawing.Point(631, 36)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(33, 19)
        Me.lblD.TabIndex = 8
        Me.lblD.Text = "{D}"
        '
        'lblSP
        '
        Me.lblSP.AutoSize = True
        Me.lblSP.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSP.Location = New System.Drawing.Point(744, 36)
        Me.lblSP.Name = "lblSP"
        Me.lblSP.Size = New System.Drawing.Size(44, 19)
        Me.lblSP.TabIndex = 9
        Me.lblSP.Text = "{SP}"
        '
        'FormMatrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 448)
        Me.Controls.Add(Me.lblSP)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblK)
        Me.Controls.Add(Me.lblP)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.dgvD)
        Me.Controls.Add(Me.dgvP)
        Me.Controls.Add(Me.dgvF)
        Me.Controls.Add(Me.dgvMatrizK)
        Me.Name = "FormMatrices"
        Me.Text = "FormMatrices"
        CType(Me.dgvMatrizK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMatrizK As DataGridView
    Friend WithEvents dgvF As DataGridView
    Friend WithEvents dgvP As DataGridView
    Friend WithEvents dgvD As DataGridView
    Friend WithEvents dgvSP As DataGridView
    Friend WithEvents lblF As Label
    Friend WithEvents lblP As Label
    Friend WithEvents lblK As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblSP As Label
End Class
