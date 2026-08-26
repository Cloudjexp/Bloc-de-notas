<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlocNotas))
        mnuPrincipal = New MenuStrip()
        mnuArchivo = New ToolStripMenuItem()
        mnuNuevo = New ToolStripMenuItem()
        mnuAbrir = New ToolStripMenuItem()
        mnuGuardar = New ToolStripMenuItem()
        mnuGuardarComo = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        mnuEdicion = New ToolStripMenuItem()
        mnuDeshacer = New ToolStripMenuItem()
        mnuRehacer = New ToolStripMenuItem()
        mnuCortar = New ToolStripMenuItem()
        mnuCopiar = New ToolStripMenuItem()
        mnuPegar = New ToolStripMenuItem()
        mnuSeleccionarTodo = New ToolStripMenuItem()
        mnuFormato = New ToolStripMenuItem()
        mnuFuente = New ToolStripMenuItem()
        mnuColorTexto = New ToolStripMenuItem()
        mnuAjusteLinea = New ToolStripMenuItem()
        mnuVer = New ToolStripMenuItem()
        mnuZoomMas = New ToolStripMenuItem()
        mnuZoomMenos = New ToolStripMenuItem()
        mnuRestablecerZoom = New ToolStripMenuItem()
        mnuAyuda = New ToolStripMenuItem()
        mnuAcercaDe = New ToolStripMenuItem()
        tsPrincipal = New ToolStrip()
        tsbNuevo = New ToolStripButton()
        tsbAbrir = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        tsbCortar = New ToolStripButton()
        tsbCopiar = New ToolStripButton()
        tsbPegar = New ToolStripButton()
        tsbNegrita = New ToolStripButton()
        tsbCursiva = New ToolStripButton()
        tsbSubrayado = New ToolStripButton()
        tscbFuente = New ToolStripComboBox()
        tscbTamano = New ToolStripComboBox()
        rtbDocumento = New RichTextBox()
        cmsTexto = New ContextMenuStrip(components)
        cmsCortar = New ToolStripMenuItem()
        cmsCopiar = New ToolStripMenuItem()
        cmsPegar = New ToolStripMenuItem()
        cmsSeleccionarTodo = New ToolStripMenuItem()
        cmsFuente = New ToolStripMenuItem()
        stsInferior = New StatusStrip()
        stsEstado = New ToolStripStatusLabel()
        stsPosicion = New ToolStripStatusLabel()
        stsCaracteres = New ToolStripStatusLabel()
        stsFechaHora = New ToolStripStatusLabel()
        stsZoom = New ToolStripStatusLabel()
        dlgAbrir = New OpenFileDialog()
        dlgGuardar = New SaveFileDialog()
        dlgFuente = New FontDialog()
        dlgColor = New ColorDialog()
        tmrReloj = New Timer(components)
        mnuPrincipal.SuspendLayout()
        tsPrincipal.SuspendLayout()
        cmsTexto.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.Items.AddRange(New ToolStripItem() {mnuArchivo, mnuEdicion, mnuFormato, mnuVer, mnuAyuda})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(800, 24)
        mnuPrincipal.TabIndex = 0
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' mnuArchivo
        ' 
        mnuArchivo.DropDownItems.AddRange(New ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardar, mnuGuardarComo, mnuSalir})
        mnuArchivo.Name = "mnuArchivo"
        mnuArchivo.Size = New Size(60, 20)
        mnuArchivo.Text = "&Archivo"
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(159, 22)
        mnuNuevo.Text = "&Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
        mnuAbrir.Size = New Size(159, 22)
        mnuAbrir.Text = "&Abrir"
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.ShortcutKeys = Keys.Control Or Keys.S
        mnuGuardar.Size = New Size(159, 22)
        mnuGuardar.Text = "&Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New Size(159, 22)
        mnuGuardarComo.Text = "Guardar &como..."
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = Keys.Control Or Keys.F4
        mnuSalir.Size = New Size(159, 22)
        mnuSalir.Text = "Salir"
        ' 
        ' mnuEdicion
        ' 
        mnuEdicion.DropDownItems.AddRange(New ToolStripItem() {mnuDeshacer, mnuRehacer, mnuCortar, mnuCopiar, mnuPegar, mnuSeleccionarTodo})
        mnuEdicion.Name = "mnuEdicion"
        mnuEdicion.Size = New Size(58, 20)
        mnuEdicion.Text = "&Edición"
        ' 
        ' mnuDeshacer
        ' 
        mnuDeshacer.Name = "mnuDeshacer"
        mnuDeshacer.ShortcutKeys = Keys.Control Or Keys.Z
        mnuDeshacer.Size = New Size(204, 22)
        mnuDeshacer.Text = "Deshacer"
        ' 
        ' mnuRehacer
        ' 
        mnuRehacer.Name = "mnuRehacer"
        mnuRehacer.ShortcutKeys = Keys.Control Or Keys.Y
        mnuRehacer.Size = New Size(204, 22)
        mnuRehacer.Text = "Rehacer"
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Name = "mnuCortar"
        mnuCortar.ShortcutKeys = Keys.Control Or Keys.X
        mnuCortar.Size = New Size(204, 22)
        mnuCortar.Text = "Cortar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.ShortcutKeys = Keys.Control Or Keys.C
        mnuCopiar.Size = New Size(204, 22)
        mnuCopiar.Text = "Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Name = "mnuPegar"
        mnuPegar.ShortcutKeys = Keys.Control Or Keys.V
        mnuPegar.Size = New Size(204, 22)
        mnuPegar.Text = "Pegar"
        ' 
        ' mnuSeleccionarTodo
        ' 
        mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        mnuSeleccionarTodo.ShortcutKeys = Keys.Control Or Keys.A
        mnuSeleccionarTodo.Size = New Size(204, 22)
        mnuSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' mnuFormato
        ' 
        mnuFormato.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuColorTexto, mnuAjusteLinea})
        mnuFormato.Name = "mnuFormato"
        mnuFormato.Size = New Size(64, 20)
        mnuFormato.Text = "&Formato"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(151, 22)
        mnuFuente.Text = "&Fuente..."
        ' 
        ' mnuColorTexto
        ' 
        mnuColorTexto.Name = "mnuColorTexto"
        mnuColorTexto.Size = New Size(151, 22)
        mnuColorTexto.Text = "Color de texto"
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.CheckOnClick = True
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New Size(151, 22)
        mnuAjusteLinea.Text = "Ajuste de línea"
        ' 
        ' mnuVer
        ' 
        mnuVer.DropDownItems.AddRange(New ToolStripItem() {mnuZoomMas, mnuZoomMenos, mnuRestablecerZoom})
        mnuVer.Name = "mnuVer"
        mnuVer.Size = New Size(35, 20)
        mnuVer.Text = "&Ver"
        ' 
        ' mnuZoomMas
        ' 
        mnuZoomMas.Name = "mnuZoomMas"
        mnuZoomMas.Size = New Size(167, 22)
        mnuZoomMas.Text = "Zoom +"
        ' 
        ' mnuZoomMenos
        ' 
        mnuZoomMenos.Name = "mnuZoomMenos"
        mnuZoomMenos.Size = New Size(167, 22)
        mnuZoomMenos.Text = "Zoom -"
        ' 
        ' mnuRestablecerZoom
        ' 
        mnuRestablecerZoom.Name = "mnuRestablecerZoom"
        mnuRestablecerZoom.Size = New Size(167, 22)
        mnuRestablecerZoom.Text = "Restablecer zoom"
        ' 
        ' mnuAyuda
        ' 
        mnuAyuda.DropDownItems.AddRange(New ToolStripItem() {mnuAcercaDe})
        mnuAyuda.Name = "mnuAyuda"
        mnuAyuda.Size = New Size(53, 20)
        mnuAyuda.Text = "&Ayuda"
        ' 
        ' mnuAcercaDe
        ' 
        mnuAcercaDe.Name = "mnuAcercaDe"
        mnuAcercaDe.Size = New Size(126, 22)
        mnuAcercaDe.Text = "Acerca de"
        ' 
        ' tsPrincipal
        ' 
        tsPrincipal.GripStyle = ToolStripGripStyle.Hidden
        tsPrincipal.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, tsbCortar, tsbCopiar, tsbPegar, tsbNegrita, tsbCursiva, tsbSubrayado, tscbFuente, tscbTamano})
        tsPrincipal.Location = New Point(0, 24)
        tsPrincipal.Name = "tsPrincipal"
        tsPrincipal.Size = New Size(800, 25)
        tsPrincipal.TabIndex = 1
        tsPrincipal.Text = "ToolStrip1"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNuevo.Image = CType(resources.GetObject("tsbNuevo.Image"), Image)
        tsbNuevo.ImageTransparentColor = Color.Magenta
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(23, 22)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbAbrir.Image = CType(resources.GetObject("tsbAbrir.Image"), Image)
        tsbAbrir.ImageTransparentColor = Color.Magenta
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(23, 22)
        tsbAbrir.Text = "Abrir"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), Image)
        tsbGuardar.ImageTransparentColor = Color.Magenta
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(23, 22)
        tsbGuardar.Text = "Guardar"
        ' 
        ' tsbCortar
        ' 
        tsbCortar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCortar.Image = My.Resources.Resources.icons8_cut_30
        tsbCortar.ImageTransparentColor = Color.Magenta
        tsbCortar.Name = "tsbCortar"
        tsbCortar.Size = New Size(23, 22)
        tsbCortar.Text = "Cortar"
        ' 
        ' tsbCopiar
        ' 
        tsbCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCopiar.Image = My.Resources.Resources.icons8_copy_30
        tsbCopiar.Name = "tsbCopiar"
        tsbCopiar.Size = New Size(23, 22)
        tsbCopiar.Text = "Copiar"
        ' 
        ' tsbPegar
        ' 
        tsbPegar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbPegar.Image = CType(resources.GetObject("tsbPegar.Image"), Image)
        tsbPegar.Name = "tsbPegar"
        tsbPegar.Size = New Size(23, 22)
        tsbPegar.Text = "P"
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbNegrita.Image = CType(resources.GetObject("tsbNegrita.Image"), Image)
        tsbNegrita.ImageTransparentColor = Color.Magenta
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(23, 22)
        tsbNegrita.Text = "N"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbCursiva.Image = CType(resources.GetObject("tsbCursiva.Image"), Image)
        tsbCursiva.ImageTransparentColor = Color.Magenta
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(23, 22)
        tsbCursiva.Text = "K"
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsbSubrayado.Image = CType(resources.GetObject("tsbSubrayado.Image"), Image)
        tsbSubrayado.ImageTransparentColor = Color.Magenta
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New Size(23, 22)
        tsbSubrayado.Text = "S"
        ' 
        ' tscbFuente
        ' 
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New Size(121, 25)
        ' 
        ' tscbTamano
        ' 
        tscbTamano.Name = "tscbTamano"
        tscbTamano.Size = New Size(121, 25)
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbDocumento.Location = New Point(0, 49)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(800, 401)
        rtbDocumento.TabIndex = 2
        rtbDocumento.Text = ""
        ' 
        ' cmsTexto
        ' 
        cmsTexto.Items.AddRange(New ToolStripItem() {cmsCortar, cmsCopiar, cmsPegar, cmsSeleccionarTodo, cmsFuente})
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(163, 114)
        ' 
        ' cmsCortar
        ' 
        cmsCortar.Name = "cmsCortar"
        cmsCortar.Size = New Size(162, 22)
        cmsCortar.Text = "Cortar"
        ' 
        ' cmsCopiar
        ' 
        cmsCopiar.Name = "cmsCopiar"
        cmsCopiar.Size = New Size(162, 22)
        cmsCopiar.Text = "Copiar"
        ' 
        ' cmsPegar
        ' 
        cmsPegar.Name = "cmsPegar"
        cmsPegar.Size = New Size(162, 22)
        cmsPegar.Text = "Pegar"
        ' 
        ' cmsSeleccionarTodo
        ' 
        cmsSeleccionarTodo.Name = "cmsSeleccionarTodo"
        cmsSeleccionarTodo.Size = New Size(162, 22)
        cmsSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' cmsFuente
        ' 
        cmsFuente.Name = "cmsFuente"
        cmsFuente.Size = New Size(162, 22)
        cmsFuente.Text = "Fuente..."
        ' 
        ' stsInferior
        ' 
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsFechaHora})
        stsInferior.Location = New Point(0, 428)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(800, 22)
        stsInferior.TabIndex = 4
        stsInferior.Text = "StatusStrip1"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(537, 17)
        stsEstado.Spring = True
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(105, 17)
        stsPosicion.Text = "Linea:1 Columna:1"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(74, 17)
        stsCaracteres.Text = "Caracteres: 0"
        ' 
        ' stsFechaHora
        ' 
        stsFechaHora.Name = "stsFechaHora"
        stsFechaHora.Size = New Size(69, 17)
        stsFechaHora.Text = "Fecha/Hora"
        ' 
        ' stsZoom
        ' 
        stsZoom.Name = "stsZoom"
        stsZoom.Size = New Size(23, 23)
        ' 
        ' dlgAbrir
        ' 
        dlgAbrir.FileName = "OpenFileDialog1"
        dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        ' 
        ' dlgGuardar
        ' 
        dlgGuardar.DefaultExt = "txt"
        dlgGuardar.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        ' 
        ' dlgFuente
        ' 
        dlgFuente.ShowColor = True
        ' 
        ' dlgColor
        ' 
        dlgColor.FullOpen = True
        ' 
        ' tmrReloj
        ' 
        tmrReloj.Enabled = True
        tmrReloj.Interval = 1000
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(stsInferior)
        Controls.Add(rtbDocumento)
        Controls.Add(tsPrincipal)
        Controls.Add(mnuPrincipal)
        FormScreenCaptureMode = ScreenCaptureMode.HideWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = mnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET"
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        tsPrincipal.ResumeLayout(False)
        tsPrincipal.PerformLayout()
        cmsTexto.ResumeLayout(False)
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents tsPrincipal As ToolStrip
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents dlgAbrir As OpenFileDialog
    Friend WithEvents dlgGuardar As SaveFileDialog
    Friend WithEvents dlgFuente As FontDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents tmrReloj As Timer
    Friend WithEvents mnuArchivo As ToolStripMenuItem
    Friend WithEvents mnuEdicion As ToolStripMenuItem
    Friend WithEvents mnuFormato As ToolStripMenuItem
    Friend WithEvents mnuVer As ToolStripMenuItem
    Friend WithEvents mnuAyuda As ToolStripMenuItem
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents mnuAbrir As ToolStripMenuItem
    Friend WithEvents mnuGuardar As ToolStripMenuItem
    Friend WithEvents mnuGuardarComo As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuDeshacer As ToolStripMenuItem
    Friend WithEvents mnuRehacer As ToolStripMenuItem
    Friend WithEvents mnuCortar As ToolStripMenuItem
    Friend WithEvents mnuCopiar As ToolStripMenuItem
    Friend WithEvents mnuPegar As ToolStripMenuItem
    Friend WithEvents mnuSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents mnuFuente As ToolStripMenuItem
    Friend WithEvents mnuColorTexto As ToolStripMenuItem
    Friend WithEvents mnuAjusteLinea As ToolStripMenuItem
    Friend WithEvents mnuZoomMas As ToolStripMenuItem
    Friend WithEvents mnuZoomMenos As ToolStripMenuItem
    Friend WithEvents mnuRestablecerZoom As ToolStripMenuItem
    Friend WithEvents mnuAcercaDe As ToolStripMenuItem
    Friend WithEvents cmsCortar As ToolStripMenuItem
    Friend WithEvents cmsCopiar As ToolStripMenuItem
    Friend WithEvents cmsPegar As ToolStripMenuItem
    Friend WithEvents cmsSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents cmsFuente As ToolStripMenuItem
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbAbrir As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbCortar As ToolStripButton
    Friend WithEvents tsbCopiar As ToolStripButton
    Friend WithEvents tsbPegar As ToolStripButton
    Friend WithEvents tsbNegrita As ToolStripButton
    Friend WithEvents tsbCursiva As ToolStripButton
    Friend WithEvents tsbSubrayado As ToolStripButton
    Friend WithEvents tscbFuente As ToolStripComboBox
    Friend WithEvents tscbTamano As ToolStripComboBox
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsFechaHora As ToolStripStatusLabel
    Friend WithEvents stsZoom As ToolStripStatusLabel

End Class
