<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class etihouse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(etihouse))
        Me.btnlimpia = New System.Windows.Forms.Button()
        Me.btnprinteti = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfamilia = New System.Windows.Forms.TextBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.chk30x20 = New System.Windows.Forms.RadioButton()
        Me.chk100x70 = New System.Windows.Forms.RadioButton()
        Me.chk55x32 = New System.Windows.Forms.RadioButton()
        Me.txtcantidadetiq = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnomarticulo = New System.Windows.Forms.TextBox()
        Me.txtcodarticulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnlimpia
        '
        Me.btnlimpia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpia.ForeColor = System.Drawing.Color.Black
        Me.btnlimpia.Image = CType(resources.GetObject("btnlimpia.Image"), System.Drawing.Image)
        Me.btnlimpia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlimpia.Location = New System.Drawing.Point(273, 592)
        Me.btnlimpia.Name = "btnlimpia"
        Me.btnlimpia.Size = New System.Drawing.Size(132, 52)
        Me.btnlimpia.TabIndex = 23
        Me.btnlimpia.Text = "Limpiar Selección"
        Me.btnlimpia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlimpia.UseVisualStyleBackColor = True
        '
        'btnprinteti
        '
        Me.btnprinteti.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnprinteti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprinteti.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprinteti.ForeColor = System.Drawing.Color.White
        Me.btnprinteti.Image = CType(resources.GetObject("btnprinteti.Image"), System.Drawing.Image)
        Me.btnprinteti.Location = New System.Drawing.Point(411, 453)
        Me.btnprinteti.Name = "btnprinteti"
        Me.btnprinteti.Size = New System.Drawing.Size(125, 135)
        Me.btnprinteti.TabIndex = 20
        Me.btnprinteti.Text = "Imprimir"
        Me.btnprinteti.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnprinteti.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(136, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(258, 42)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Cantidad Etiquetas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(346, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Destino Marca"
        '
        'txtdestino
        '
        Me.txtdestino.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestino.Location = New System.Drawing.Point(325, 367)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(202, 39)
        Me.txtdestino.TabIndex = 16
        Me.txtdestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(69, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 32)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Familia de Artículos"
        '
        'txtfamilia
        '
        Me.txtfamilia.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfamilia.Location = New System.Drawing.Point(26, 367)
        Me.txtfamilia.Name = "txtfamilia"
        Me.txtfamilia.Size = New System.Drawing.Size(296, 39)
        Me.txtfamilia.TabIndex = 14
        Me.txtfamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsalir
        '
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.ForeColor = System.Drawing.Color.Black
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.Location = New System.Drawing.Point(411, 592)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(125, 52)
        Me.btnsalir.TabIndex = 13
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(158, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 42)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nombre Artículo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 23.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(164, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 42)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Código Artículo"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI", 35.22!)
        Me.txtnombre.Location = New System.Drawing.Point(21, 173)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtnombre.Size = New System.Drawing.Size(504, 159)
        Me.txtnombre.TabIndex = 10
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(21, 55)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(504, 70)
        Me.txtcodigo.TabIndex = 9
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chk30x20
        '
        Me.chk30x20.AutoSize = True
        Me.chk30x20.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk30x20.ForeColor = System.Drawing.Color.Black
        Me.chk30x20.Location = New System.Drawing.Point(8, 21)
        Me.chk30x20.Name = "chk30x20"
        Me.chk30x20.Size = New System.Drawing.Size(101, 25)
        Me.chk30x20.TabIndex = 23
        Me.chk30x20.TabStop = True
        Me.chk30x20.Text = "30x20 (x3)"
        Me.chk30x20.UseVisualStyleBackColor = True
        '
        'chk100x70
        '
        Me.chk100x70.AutoSize = True
        Me.chk100x70.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk100x70.ForeColor = System.Drawing.Color.Black
        Me.chk100x70.Location = New System.Drawing.Point(8, 83)
        Me.chk100x70.Name = "chk100x70"
        Me.chk100x70.Size = New System.Drawing.Size(80, 25)
        Me.chk100x70.TabIndex = 22
        Me.chk100x70.TabStop = True
        Me.chk100x70.Text = "100x70"
        Me.chk100x70.UseVisualStyleBackColor = True
        '
        'chk55x32
        '
        Me.chk55x32.AutoSize = True
        Me.chk55x32.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk55x32.ForeColor = System.Drawing.Color.Black
        Me.chk55x32.Location = New System.Drawing.Point(8, 52)
        Me.chk55x32.Name = "chk55x32"
        Me.chk55x32.Size = New System.Drawing.Size(71, 25)
        Me.chk55x32.TabIndex = 21
        Me.chk55x32.TabStop = True
        Me.chk55x32.Text = "55x32"
        Me.chk55x32.UseVisualStyleBackColor = True
        '
        'txtcantidadetiq
        '
        Me.txtcantidadetiq.Font = New System.Drawing.Font("Segoe UI Emoji", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidadetiq.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtcantidadetiq.Location = New System.Drawing.Point(126, 453)
        Me.txtcantidadetiq.Margin = New System.Windows.Forms.Padding(0)
        Me.txtcantidadetiq.Name = "txtcantidadetiq"
        Me.txtcantidadetiq.Size = New System.Drawing.Size(279, 135)
        Me.txtcantidadetiq.TabIndex = 18
        Me.txtcantidadetiq.Text = "0"
        Me.txtcantidadetiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.txtcantidadetiq)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btnlimpia)
        Me.GroupBox2.Controls.Add(Me.btnprinteti)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtdestino)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtfamilia)
        Me.GroupBox2.Controls.Add(Me.btnsalir)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(746, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 650)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Impresión Etiquetas"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk30x20)
        Me.GroupBox3.Controls.Add(Me.chk100x70)
        Me.GroupBox3.Controls.Add(Me.chk55x32)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 453)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(100, 135)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tamaño Etiqueta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(482, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Familia"
        Me.Label8.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(421, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(177, 25)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.Visible = False
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
        Me.Label2.Size = New System.Drawing.Size(126, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre Artículo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código Artículo"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnomarticulo)
        Me.GroupBox1.Controls.Add(Me.txtcodarticulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 78)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de Búsqueda"
        '
        'datalistado
        '
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(8, 96)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.RowHeadersVisible = False
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(727, 566)
        Me.datalistado.TabIndex = 3
        '
        'etihouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1374, 709)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datalistado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "etihouse"
        Me.Text = "Etiquetado House"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnlimpia As Button
    Friend WithEvents btnprinteti As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdestino As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfamilia As TextBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents chk30x20 As RadioButton
    Friend WithEvents chk100x70 As RadioButton
    Friend WithEvents chk55x32 As RadioButton
    Friend WithEvents txtcantidadetiq As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomarticulo As TextBox
    Friend WithEvents txtcodarticulo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents datalistado As DataGridView
End Class
