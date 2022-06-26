<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResultados
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
        Me.picBoxDiagram = New System.Windows.Forms.PictureBox()
        Me.lstDesplazamientos = New System.Windows.Forms.ListBox()
        Me.lstReacciones = New System.Windows.Forms.ListBox()
        CType(Me.picBoxDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBoxDiagram
        '
        Me.picBoxDiagram.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picBoxDiagram.Location = New System.Drawing.Point(16, 37)
        Me.picBoxDiagram.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBoxDiagram.Name = "picBoxDiagram"
        Me.picBoxDiagram.Size = New System.Drawing.Size(480, 443)
        Me.picBoxDiagram.TabIndex = 0
        Me.picBoxDiagram.TabStop = False
        '
        'lstDesplazamientos
        '
        Me.lstDesplazamientos.FormattingEnabled = True
        Me.lstDesplazamientos.ItemHeight = 16
        Me.lstDesplazamientos.Location = New System.Drawing.Point(531, 37)
        Me.lstDesplazamientos.Name = "lstDesplazamientos"
        Me.lstDesplazamientos.Size = New System.Drawing.Size(228, 148)
        Me.lstDesplazamientos.TabIndex = 1
        '
        'lstReacciones
        '
        Me.lstReacciones.FormattingEnabled = True
        Me.lstReacciones.ItemHeight = 16
        Me.lstReacciones.Location = New System.Drawing.Point(531, 204)
        Me.lstReacciones.Name = "lstReacciones"
        Me.lstReacciones.Size = New System.Drawing.Size(228, 148)
        Me.lstReacciones.TabIndex = 2
        '
        'FormResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lstReacciones)
        Me.Controls.Add(Me.lstDesplazamientos)
        Me.Controls.Add(Me.picBoxDiagram)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormResultados"
        Me.Text = "Resultados"
        CType(Me.picBoxDiagram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBoxDiagram As PictureBox
    Friend WithEvents lstDesplazamientos As ListBox
    Friend WithEvents lstReacciones As ListBox
End Class
