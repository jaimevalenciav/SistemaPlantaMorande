<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalisis
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalisis))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomarticulo = New System.Windows.Forms.TextBox()
        Me.txtcodarticulo = New System.Windows.Forms.TextBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.swactivo = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnlimpia = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtvalormax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtvalormin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnomarticulo)
        Me.GroupBox1.Controls.Add(Me.txtcodarticulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 78)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de Búsqueda"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(421, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 25)
        Me.TextBox1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(476, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Abreviatura"
        Me.Label8.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(601, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 56)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Borrar Filtros"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre Análisis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código Análisis"
        '
        'txtnomarticulo
        '
        Me.txtnomarticulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomarticulo.Location = New System.Drawing.Point(165, 38)
        Me.txtnomarticulo.Name = "txtnomarticulo"
        Me.txtnomarticulo.Size = New System.Drawing.Size(254, 25)
        Me.txtnomarticulo.TabIndex = 1
        '
        'txtcodarticulo
        '
        Me.txtcodarticulo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodarticulo.Location = New System.Drawing.Point(6, 38)
        Me.txtcodarticulo.Name = "txtcodarticulo"
        Me.txtcodarticulo.Size = New System.Drawing.Size(157, 25)
        Me.txtcodarticulo.TabIndex = 0
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(12, 94)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(727, 566)
        Me.datalistado.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.btneditar)
        Me.GroupBox2.Controls.Add(Me.swactivo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnlimpia)
        Me.GroupBox2.Controls.Add(Me.btnguardar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtvalormax)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtvalormin)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(745, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 489)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle del Análisis"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(71, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 42)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Id"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.SystemColors.Window
        Me.txtid.Location = New System.Drawing.Point(21, 55)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(171, 70)
        Me.txtid.TabIndex = 27
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btneditar
        '
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.ForeColor = System.Drawing.Color.Black
        Me.btneditar.Image = CType(resources.GetObject("btneditar.Image"), System.Drawing.Image)
        Me.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btneditar.Location = New System.Drawing.Point(416, 410)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(109, 66)
        Me.btneditar.TabIndex = 26
        Me.btneditar.Text = "Editar Análisis"
        Me.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'swactivo
        '
        Me.swactivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.swactivo.BorderRadius = 0
        Me.swactivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.swactivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swactivo.Location = New System.Drawing.Point(114, 318)
        Me.swactivo.Name = "swactivo"
        Me.swactivo.Oncolor = System.Drawing.Color.RoyalBlue
        Me.swactivo.Onoffcolor = System.Drawing.Color.DarkGray
        Me.swactivo.Size = New System.Drawing.Size(51, 19)
        Me.swactivo.TabIndex = 25
        Me.swactivo.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.swactivo.Value = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 32)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Estado"
        '
        'btnlimpia
        '
        Me.btnlimpia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpia.ForeColor = System.Drawing.Color.Black
        Me.btnlimpia.Image = CType(resources.GetObject("btnlimpia.Image"), System.Drawing.Image)
        Me.btnlimpia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlimpia.Location = New System.Drawing.Point(198, 411)
        Me.btnlimpia.Name = "btnlimpia"
        Me.btnlimpia.Size = New System.Drawing.Size(114, 65)
        Me.btnlimpia.TabIndex = 23
        Me.btnlimpia.Text = "Nuevo Análisis"
        Me.btnlimpia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpia.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(318, 410)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(92, 65)
        Me.btnguardar.TabIndex = 20
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(325, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Valor Máximo"
        '
        'txtvalormax
        '
        Me.txtvalormax.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtvalormax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalormax.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalormax.ForeColor = System.Drawing.SystemColors.Window
        Me.txtvalormax.Location = New System.Drawing.Point(285, 261)
        Me.txtvalormax.Name = "txtvalormax"
        Me.txtvalormax.Size = New System.Drawing.Size(243, 39)
        Me.txtvalormax.TabIndex = 16
        Me.txtvalormax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(72, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 32)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Valor Mínimo"
        '
        'txtvalormin
        '
        Me.txtvalormin.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtvalormin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvalormin.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalormin.ForeColor = System.Drawing.SystemColors.Window
        Me.txtvalormin.Location = New System.Drawing.Point(24, 261)
        Me.txtvalormin.Name = "txtvalormin"
        Me.txtvalormin.Size = New System.Drawing.Size(249, 39)
        Me.txtvalormin.TabIndex = 14
        Me.txtvalormin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(158, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 42)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nombre Análisis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(264, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 42)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Código Análisis"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.SystemColors.Window
        Me.txtnombre.Location = New System.Drawing.Point(21, 173)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(504, 46)
        Me.txtnombre.TabIndex = 10
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.ForeColor = System.Drawing.SystemColors.Window
        Me.txtcodigo.Location = New System.Drawing.Point(198, 55)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(327, 70)
        Me.txtcodigo.TabIndex = 9
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsalir
        '
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.ForeColor = System.Drawing.Color.Black
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.Location = New System.Drawing.Point(1174, 594)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(125, 66)
        Me.btnsalir.TabIndex = 13
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'frmAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 697)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.btnsalir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAnalisis"
        Me.Text = "Analisis"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomarticulo As TextBox
    Friend WithEvents txtcodarticulo As TextBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents swactivo As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label7 As Label
    Friend WithEvents btnlimpia As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtvalormax As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtvalormin As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents btneditar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtid As TextBox
End Class
