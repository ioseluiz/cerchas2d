﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.dgvJoints, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvJoints
        '
        Me.dgvJoints.AllowUserToAddRows = False
        Me.dgvJoints.AllowUserToDeleteRows = False
        Me.dgvJoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJoints.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nodo, Me.CoorX, Me.CoorY, Me.Rx, Me.Ry})
        Me.dgvJoints.Location = New System.Drawing.Point(99, 85)
        Me.dgvJoints.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvJoints.Name = "dgvJoints"
        Me.dgvJoints.RowHeadersVisible = False
        Me.dgvJoints.RowHeadersWidth = 51
        Me.dgvJoints.Size = New System.Drawing.Size(749, 329)
        Me.dgvJoints.TabIndex = 0
        '
        'Nodo
        '
        Me.Nodo.HeaderText = "Nodo"
        Me.Nodo.MinimumWidth = 6
        Me.Nodo.Name = "Nodo"
        Me.Nodo.Width = 125
        '
        'CoorX
        '
        Me.CoorX.HeaderText = "X"
        Me.CoorX.MinimumWidth = 6
        Me.CoorX.Name = "CoorX"
        Me.CoorX.Width = 125
        '
        'CoorY
        '
        Me.CoorY.HeaderText = "Y"
        Me.CoorY.MinimumWidth = 6
        Me.CoorY.Name = "CoorY"
        Me.CoorY.Width = 125
        '
        'Rx
        '
        Me.Rx.HeaderText = "Rx"
        Me.Rx.MinimumWidth = 6
        Me.Rx.Name = "Rx"
        Me.Rx.Width = 125
        '
        'Ry
        '
        Me.Ry.HeaderText = "Ry"
        Me.Ry.MinimumWidth = 6
        Me.Ry.Name = "Ry"
        Me.Ry.Width = 125
        '
        'FormNodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.dgvJoints)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormNodos"
        Me.Text = "FormNodos"
        CType(Me.dgvJoints, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvJoints As DataGridView
    Friend WithEvents Nodo As DataGridViewTextBoxColumn
    Friend WithEvents CoorX As DataGridViewTextBoxColumn
    Friend WithEvents CoorY As DataGridViewTextBoxColumn
    Friend WithEvents Rx As DataGridViewCheckBoxColumn
    Friend WithEvents Ry As DataGridViewCheckBoxColumn
End Class
