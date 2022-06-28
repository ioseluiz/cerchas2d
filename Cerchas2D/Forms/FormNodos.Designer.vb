<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNodos
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
        Me.dgvJoints = New System.Windows.Forms.DataGridView()
        Me.Nodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoorX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoorY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rx = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Ry = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.deltax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deltay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvJoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvJoints
        '
        Me.dgvJoints.AllowUserToAddRows = False
        Me.dgvJoints.AllowUserToDeleteRows = False
        Me.dgvJoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJoints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nodo, Me.CoorX, Me.CoorY, Me.Rx, Me.Ry, Me.deltax, Me.deltay})
        Me.dgvJoints.Location = New System.Drawing.Point(74, 69)
        Me.dgvJoints.Name = "dgvJoints"
        Me.dgvJoints.RowHeadersVisible = False
        Me.dgvJoints.RowHeadersWidth = 51
        Me.dgvJoints.Size = New System.Drawing.Size(562, 267)
        Me.dgvJoints.TabIndex = 0
        '
        'Nodo
        '
        Me.Nodo.HeaderText = "Nodo"
        Me.Nodo.MinimumWidth = 6
        Me.Nodo.Name = "Nodo"
        Me.Nodo.Width = 80
        '
        'CoorX
        '
        Me.CoorX.HeaderText = "X"
        Me.CoorX.MinimumWidth = 6
        Me.CoorX.Name = "CoorX"
        Me.CoorX.Width = 80
        '
        'CoorY
        '
        Me.CoorY.HeaderText = "Y"
        Me.CoorY.MinimumWidth = 6
        Me.CoorY.Name = "CoorY"
        Me.CoorY.Width = 80
        '
        'Rx
        '
        Me.Rx.HeaderText = "Rx"
        Me.Rx.MinimumWidth = 6
        Me.Rx.Name = "Rx"
        Me.Rx.Width = 80
        '
        'Ry
        '
        Me.Ry.HeaderText = "Ry"
        Me.Ry.MinimumWidth = 6
        Me.Ry.Name = "Ry"
        Me.Ry.Width = 80
        '
        'deltax
        '
        Me.deltax.HeaderText = "Δx"
        Me.deltax.MinimumWidth = 6
        Me.deltax.Name = "deltax"
        Me.deltax.Width = 80
        '
        'deltay
        '
        Me.deltay.HeaderText = "Δy"
        Me.deltay.MinimumWidth = 6
        Me.deltay.Name = "deltay"
        Me.deltay.Width = 80
        '
        'FormNodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvJoints)
        Me.Name = "FormNodos"
        Me.Text = "Nodos"
        CType(Me.dgvJoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvJoints As DataGridView
    Friend WithEvents Nodo As DataGridViewTextBoxColumn
    Friend WithEvents CoorX As DataGridViewTextBoxColumn
    Friend WithEvents CoorY As DataGridViewTextBoxColumn
    Friend WithEvents Rx As DataGridViewCheckBoxColumn
    Friend WithEvents Ry As DataGridViewCheckBoxColumn
    Friend WithEvents deltax As DataGridViewTextBoxColumn
    Friend WithEvents deltay As DataGridViewTextBoxColumn
End Class
