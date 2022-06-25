<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFuerzas
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
        Me.dgvCargas = New System.Windows.Forms.DataGridView()
        Me.Nodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Px = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Py = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCargas
        '
        Me.dgvCargas.AllowUserToAddRows = False
        Me.dgvCargas.AllowUserToDeleteRows = False
        Me.dgvCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nodo, Me.Px, Me.Py})
        Me.dgvCargas.Location = New System.Drawing.Point(65, 68)
        Me.dgvCargas.Name = "dgvCargas"
        Me.dgvCargas.RowHeadersVisible = False
        Me.dgvCargas.RowHeadersWidth = 51
        Me.dgvCargas.RowTemplate.Height = 24
        Me.dgvCargas.Size = New System.Drawing.Size(443, 286)
        Me.dgvCargas.TabIndex = 0
        '
        'Nodo
        '
        Me.Nodo.HeaderText = "Nodo"
        Me.Nodo.MinimumWidth = 6
        Me.Nodo.Name = "Nodo"
        Me.Nodo.Width = 125
        '
        'Px
        '
        Me.Px.HeaderText = "Px"
        Me.Px.MinimumWidth = 6
        Me.Px.Name = "Px"
        Me.Px.Width = 125
        '
        'Py
        '
        Me.Py.HeaderText = "Py"
        Me.Py.MinimumWidth = 6
        Me.Py.Name = "Py"
        Me.Py.Width = 125
        '
        'FormFuerzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvCargas)
        Me.Name = "FormFuerzas"
        Me.Text = "FormFuerzas"
        CType(Me.dgvCargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCargas As DataGridView
    Friend WithEvents Nodo As DataGridViewTextBoxColumn
    Friend WithEvents Px As DataGridViewTextBoxColumn
    Friend WithEvents Py As DataGridViewTextBoxColumn
End Class
