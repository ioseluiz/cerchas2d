<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormElementos
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
        Me.dgvElementos = New System.Windows.Forms.DataGridView()
        Me.Elemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvElementos
        '
        Me.dgvElementos.AllowUserToAddRows = False
        Me.dgvElementos.AllowUserToDeleteRows = False
        Me.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElementos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elemento, Me.Inicio, Me.Fin, Me.modE, Me.Area})
        Me.dgvElementos.Location = New System.Drawing.Point(65, 80)
        Me.dgvElementos.Name = "dgvElementos"
        Me.dgvElementos.RowHeadersVisible = False
        Me.dgvElementos.Size = New System.Drawing.Size(552, 289)
        Me.dgvElementos.TabIndex = 0
        '
        'Elemento
        '
        Me.Elemento.HeaderText = "Elemento"
        Me.Elemento.Name = "Elemento"
        '
        'Inicio
        '
        Me.Inicio.HeaderText = "Inicio"
        Me.Inicio.Name = "Inicio"
        '
        'Fin
        '
        Me.Fin.HeaderText = "Fin"
        Me.Fin.Name = "Fin"
        '
        'modE
        '
        Me.modE.HeaderText = "E"
        Me.modE.Name = "modE"
        '
        'Area
        '
        Me.Area.HeaderText = "A"
        Me.Area.Name = "Area"
        '
        'FormElementos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 447)
        Me.Controls.Add(Me.dgvElementos)
        Me.Name = "FormElementos"
        Me.Text = "FormElementos"
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvElementos As DataGridView
    Friend WithEvents Elemento As DataGridViewTextBoxColumn
    Friend WithEvents Inicio As DataGridViewTextBoxColumn
    Friend WithEvents Fin As DataGridViewTextBoxColumn
    Friend WithEvents modE As DataGridViewTextBoxColumn
    Friend WithEvents Area As DataGridViewTextBoxColumn
End Class
