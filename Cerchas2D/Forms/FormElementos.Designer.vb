﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.deltaT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvElementos
        '
        Me.dgvElementos.AllowUserToAddRows = False
        Me.dgvElementos.AllowUserToDeleteRows = False
        Me.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElementos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elemento, Me.Inicio, Me.Fin, Me.modE, Me.Area, Me.deltaT})
        Me.dgvElementos.Location = New System.Drawing.Point(87, 98)
        Me.dgvElementos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvElementos.Name = "dgvElementos"
        Me.dgvElementos.RowHeadersVisible = False
        Me.dgvElementos.RowHeadersWidth = 51
        Me.dgvElementos.Size = New System.Drawing.Size(755, 356)
        Me.dgvElementos.TabIndex = 0
        '
        'Elemento
        '
        Me.Elemento.HeaderText = "Elemento"
        Me.Elemento.MinimumWidth = 6
        Me.Elemento.Name = "Elemento"
        Me.Elemento.Width = 125
        '
        'Inicio
        '
        Me.Inicio.HeaderText = "Inicio"
        Me.Inicio.MinimumWidth = 6
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Width = 125
        '
        'Fin
        '
        Me.Fin.HeaderText = "Fin"
        Me.Fin.MinimumWidth = 6
        Me.Fin.Name = "Fin"
        Me.Fin.Width = 125
        '
        'modE
        '
        Me.modE.HeaderText = "E"
        Me.modE.MinimumWidth = 6
        Me.modE.Name = "modE"
        Me.modE.Width = 125
        '
        'Area
        '
        Me.Area.HeaderText = "A"
        Me.Area.MinimumWidth = 6
        Me.Area.Name = "Area"
        Me.Area.Width = 125
        '
        'deltaT
        '
        Me.deltaT.HeaderText = "ΔT"
        Me.deltaT.MinimumWidth = 6
        Me.deltaT.Name = "deltaT"
        Me.deltaT.Width = 125
        '
        'FormElementos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 550)
        Me.Controls.Add(Me.dgvElementos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents deltaT As DataGridViewTextBoxColumn
End Class
