<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatos
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
        Me.lblCantNodos = New System.Windows.Forms.Label()
        Me.nudNodos = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudElementos = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.nudNodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantNodos
        '
        Me.lblCantNodos.AutoSize = True
        Me.lblCantNodos.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantNodos.Location = New System.Drawing.Point(81, 110)
        Me.lblCantNodos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantNodos.Name = "lblCantNodos"
        Me.lblCantNodos.Size = New System.Drawing.Size(184, 24)
        Me.lblCantNodos.TabIndex = 0
        Me.lblCantNodos.Text = "Cantidad Nodos ="
        '
        'nudNodos
        '
        Me.nudNodos.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNodos.Location = New System.Drawing.Point(301, 105)
        Me.nudNodos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudNodos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNodos.Name = "nudNodos"
        Me.nudNodos.Size = New System.Drawing.Size(160, 31)
        Me.nudNodos.TabIndex = 1
        Me.nudNodos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudNodos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 165)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cantidad Elementos ="
        '
        'nudElementos
        '
        Me.nudElementos.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudElementos.Location = New System.Drawing.Point(301, 165)
        Me.nudElementos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudElementos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudElementos.Name = "nudElementos"
        Me.nudElementos.Size = New System.Drawing.Size(160, 31)
        Me.nudElementos.TabIndex = 3
        Me.nudElementos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudElementos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(87, 234)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(417, 74)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "INGRESAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 412)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nudElementos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudNodos)
        Me.Controls.Add(Me.lblCantNodos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormDatos"
        Me.Text = "Datos de Entrada"
        CType(Me.nudNodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCantNodos As Label
    Friend WithEvents nudNodos As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents nudElementos As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
