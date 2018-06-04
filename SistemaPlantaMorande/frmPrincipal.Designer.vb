<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtiquetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosBodegaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosHouseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArtículosAgroMorandéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CubicajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtiquetadoPerchaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaboratorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParámetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnálisisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrupoDeAnálisisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorrelativoMuestraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoAnálisisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CubasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarricasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoAnálisisCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaAnálisisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(849, 67)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(39, 13)
        Me.lbluser.TabIndex = 5
        Me.lbluser.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(797, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EtiquetasToolStripMenuItem, Me.ProducciónToolStripMenuItem, Me.LaboratorioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1137, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.PermisosToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Image = CType(resources.GetObject("ArchivoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Image = CType(resources.GetObject("PermisosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EtiquetasToolStripMenuItem
        '
        Me.EtiquetasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArtículosBodegaToolStripMenuItem, Me.ArtículosHouseToolStripMenuItem, Me.ArtículosAgroMorandéToolStripMenuItem})
        Me.EtiquetasToolStripMenuItem.Image = CType(resources.GetObject("EtiquetasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EtiquetasToolStripMenuItem.Name = "EtiquetasToolStripMenuItem"
        Me.EtiquetasToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.EtiquetasToolStripMenuItem.Text = "Almacenes"
        '
        'ArtículosBodegaToolStripMenuItem
        '
        Me.ArtículosBodegaToolStripMenuItem.Image = CType(resources.GetObject("ArtículosBodegaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArtículosBodegaToolStripMenuItem.Name = "ArtículosBodegaToolStripMenuItem"
        Me.ArtículosBodegaToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.ArtículosBodegaToolStripMenuItem.Text = "Etiquetado Artículos Planta"
        '
        'ArtículosHouseToolStripMenuItem
        '
        Me.ArtículosHouseToolStripMenuItem.Image = CType(resources.GetObject("ArtículosHouseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArtículosHouseToolStripMenuItem.Name = "ArtículosHouseToolStripMenuItem"
        Me.ArtículosHouseToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.ArtículosHouseToolStripMenuItem.Text = "Etiquetado Artículos House"
        '
        'ArtículosAgroMorandéToolStripMenuItem
        '
        Me.ArtículosAgroMorandéToolStripMenuItem.Image = CType(resources.GetObject("ArtículosAgroMorandéToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArtículosAgroMorandéToolStripMenuItem.Name = "ArtículosAgroMorandéToolStripMenuItem"
        Me.ArtículosAgroMorandéToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.ArtículosAgroMorandéToolStripMenuItem.Text = "Etiquetado Artículos AgroMorandé"
        '
        'ProducciónToolStripMenuItem
        '
        Me.ProducciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CubicajeToolStripMenuItem, Me.EtiquetadoPerchaToolStripMenuItem})
        Me.ProducciónToolStripMenuItem.Image = CType(resources.GetObject("ProducciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProducciónToolStripMenuItem.Name = "ProducciónToolStripMenuItem"
        Me.ProducciónToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.ProducciónToolStripMenuItem.Text = "Producción"
        '
        'CubicajeToolStripMenuItem
        '
        Me.CubicajeToolStripMenuItem.Name = "CubicajeToolStripMenuItem"
        Me.CubicajeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CubicajeToolStripMenuItem.Text = "Cubicaje"
        '
        'EtiquetadoPerchaToolStripMenuItem
        '
        Me.EtiquetadoPerchaToolStripMenuItem.Name = "EtiquetadoPerchaToolStripMenuItem"
        Me.EtiquetadoPerchaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EtiquetadoPerchaToolStripMenuItem.Text = "Etiquetado Percha"
        '
        'LaboratorioToolStripMenuItem
        '
        Me.LaboratorioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParámetrosToolStripMenuItem, Me.IngresoAnálisisToolStripMenuItem, Me.IngresoAnálisisCamposToolStripMenuItem, Me.ConsultaAnálisisToolStripMenuItem})
        Me.LaboratorioToolStripMenuItem.Image = CType(resources.GetObject("LaboratorioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaboratorioToolStripMenuItem.Name = "LaboratorioToolStripMenuItem"
        Me.LaboratorioToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.LaboratorioToolStripMenuItem.Text = "Laboratorio"
        '
        'ParámetrosToolStripMenuItem
        '
        Me.ParámetrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnálisisToolStripMenuItem, Me.GrupoDeAnálisisToolStripMenuItem, Me.CorrelativoMuestraToolStripMenuItem})
        Me.ParámetrosToolStripMenuItem.Image = CType(resources.GetObject("ParámetrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ParámetrosToolStripMenuItem.Name = "ParámetrosToolStripMenuItem"
        Me.ParámetrosToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ParámetrosToolStripMenuItem.Text = "Parámetros"
        '
        'AnálisisToolStripMenuItem
        '
        Me.AnálisisToolStripMenuItem.Image = CType(resources.GetObject("AnálisisToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AnálisisToolStripMenuItem.Name = "AnálisisToolStripMenuItem"
        Me.AnálisisToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AnálisisToolStripMenuItem.Text = "Análisis"
        '
        'GrupoDeAnálisisToolStripMenuItem
        '
        Me.GrupoDeAnálisisToolStripMenuItem.Image = CType(resources.GetObject("GrupoDeAnálisisToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GrupoDeAnálisisToolStripMenuItem.Name = "GrupoDeAnálisisToolStripMenuItem"
        Me.GrupoDeAnálisisToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.GrupoDeAnálisisToolStripMenuItem.Text = "Grupo de Análisis"
        '
        'CorrelativoMuestraToolStripMenuItem
        '
        Me.CorrelativoMuestraToolStripMenuItem.Image = CType(resources.GetObject("CorrelativoMuestraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CorrelativoMuestraToolStripMenuItem.Name = "CorrelativoMuestraToolStripMenuItem"
        Me.CorrelativoMuestraToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CorrelativoMuestraToolStripMenuItem.Text = "Maestro de correlativos"
        '
        'IngresoAnálisisToolStripMenuItem
        '
        Me.IngresoAnálisisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CubasToolStripMenuItem, Me.BarricasToolStripMenuItem})
        Me.IngresoAnálisisToolStripMenuItem.Image = CType(resources.GetObject("IngresoAnálisisToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IngresoAnálisisToolStripMenuItem.Name = "IngresoAnálisisToolStripMenuItem"
        Me.IngresoAnálisisToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.IngresoAnálisisToolStripMenuItem.Text = "Ingreso Análisis Enología"
        '
        'CubasToolStripMenuItem
        '
        Me.CubasToolStripMenuItem.Image = CType(resources.GetObject("CubasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CubasToolStripMenuItem.Name = "CubasToolStripMenuItem"
        Me.CubasToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.CubasToolStripMenuItem.Text = "Cubas"
        '
        'BarricasToolStripMenuItem
        '
        Me.BarricasToolStripMenuItem.Image = CType(resources.GetObject("BarricasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BarricasToolStripMenuItem.Name = "BarricasToolStripMenuItem"
        Me.BarricasToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.BarricasToolStripMenuItem.Text = "Barricas"
        '
        'IngresoAnálisisCamposToolStripMenuItem
        '
        Me.IngresoAnálisisCamposToolStripMenuItem.Image = CType(resources.GetObject("IngresoAnálisisCamposToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IngresoAnálisisCamposToolStripMenuItem.Name = "IngresoAnálisisCamposToolStripMenuItem"
        Me.IngresoAnálisisCamposToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.IngresoAnálisisCamposToolStripMenuItem.Text = "Ingreso Análisis Microbiologia"
        '
        'ConsultaAnálisisToolStripMenuItem
        '
        Me.ConsultaAnálisisToolStripMenuItem.Image = CType(resources.GetObject("ConsultaAnálisisToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultaAnálisisToolStripMenuItem.Name = "ConsultaAnálisisToolStripMenuItem"
        Me.ConsultaAnálisisToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ConsultaAnálisisToolStripMenuItem.Text = "Consulta Análisis"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(907, 503)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 556)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Sistema Morandé :: Menú Principal "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbluser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtiquetasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosBodegaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosHouseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArtículosAgroMorandéToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProducciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CubicajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtiquetadoPerchaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LaboratorioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParámetrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoAnálisisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaAnálisisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresoAnálisisCamposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnálisisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrupoDeAnálisisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CubasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarricasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorrelativoMuestraToolStripMenuItem As ToolStripMenuItem
End Class
