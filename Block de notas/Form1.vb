Imports System.IO
Imports System.Drawing

Public Class frmBlocNotas

    Private rutaActual As String = String.Empty
    Private documentoModificado As Boolean = False

    Private Sub frmBlocNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial del RichTextBox
        rtbDocumento.Font = New Font("Consolas", 11)
        rtbDocumento.WordWrap = True
        mnuAjusteLinea.Checked = True

        ' Llenar combos del ToolStrip
        tscbFuente.Items.AddRange(New String() {"Segoe UI", "Consolas", "Arial", "Times New Roman"})
        tscbFuente.SelectedIndex = 1
        tscbTamano.Items.AddRange(New String() {"8", "10", "11", "12", "14", "18", "24"})
        tscbTamano.SelectedIndex = 2

        ActualizarBarraEstado()
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
    End Sub

    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        documentoModificado = True
        ActualizarBarraEstado()
    End Sub

    Private Sub rtbDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub mnuGuardar_Click(sender As Object, e As EventArgs) Handles mnuGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub mnuGuardarComo_Click(sender As Object, e As EventArgs) Handles mnuGuardarComo.Click
        GuardarDocumento(True)
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub mnuDeshacer_Click(sender As Object, e As EventArgs) Handles mnuDeshacer.Click
        If rtbDocumento.CanUndo Then rtbDocumento.Undo()
    End Sub

    Private Sub mnuRehacer_Click(sender As Object, e As EventArgs) Handles mnuRehacer.Click
        If rtbDocumento.CanRedo Then rtbDocumento.Redo()
    End Sub

    Private Sub mnuCortar_Click(sender As Object, e As EventArgs) Handles mnuCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub mnuCopiar_Click(sender As Object, e As EventArgs) Handles mnuCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub mnuPegar_Click(sender As Object, e As EventArgs) Handles mnuPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub mnuSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles mnuSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub mnuFuente_Click(sender As Object, e As EventArgs) Handles mnuFuente.Click
        dlgFuente.Font = rtbDocumento.SelectionFont
        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If
    End Sub

    Private Sub mnuColorTexto_Click(sender As Object, e As EventArgs) Handles mnuColorTexto.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionColor = dlgColor.Color
        End If
    End Sub

    Private Sub mnuAjusteLinea_Click(sender As Object, e As EventArgs) Handles mnuAjusteLinea.Click
        rtbDocumento.WordWrap = mnuAjusteLinea.Checked
    End Sub

    Private Sub mnuZoomMas_Click(sender As Object, e As EventArgs) Handles mnuZoomMas.Click
        If rtbDocumento.ZoomFactor < 4.0F Then rtbDocumento.ZoomFactor += 0.1F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuZoomMenos_Click(sender As Object, e As EventArgs) Handles mnuZoomMenos.Click
        If rtbDocumento.ZoomFactor > 0.3F Then rtbDocumento.ZoomFactor -= 0.1F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuZoomRestablecer_Click(sender As Object, e As EventArgs) Handles mnuRestablecerZoom.Click
        rtbDocumento.ZoomFactor = 1.0F
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles mnuAcercaDe.Click
        MessageBox.Show("Bloc de Notas VB.NET" & vbCrLf & "Desarrolado por Josué Morales y Lesther Velasquez",
                     "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub tsbCortar_Click(sender As Object, e As EventArgs) Handles tsbCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub tsbCopiar_Click(sender As Object, e As EventArgs) Handles tsbCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub tsbPegar_Click(sender As Object, e As EventArgs) Handles tsbPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub tsbNegrita_Click(sender As Object, e As EventArgs) Handles tsbNegrita.Click
        AplicarEstiloFuente(FontStyle.Bold)
    End Sub

    Private Sub tsbCursiva_Click(sender As Object, e As EventArgs) Handles tsbCursiva.Click
        AplicarEstiloFuente(FontStyle.Italic)
    End Sub

    Private Sub tsbSubrayado_Click(sender As Object, e As EventArgs) Handles tsbSubrayado.Click
        AplicarEstiloFuente(FontStyle.Underline)
    End Sub

    Private Sub tscbFuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbFuente.SelectedIndexChanged
        Dim tamano As Single = rtbDocumento.SelectionFont.Size
        rtbDocumento.SelectionFont = New Font(tscbFuente.Text, tamano, rtbDocumento.SelectionFont.Style)
    End Sub

    Private Sub tscbTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTamano.SelectedIndexChanged
        Dim tam As Single = Convert.ToSingle(tscbTamano.Text)
        rtbDocumento.SelectionFont = New Font(rtbDocumento.SelectionFont.FontFamily, tam, rtbDocumento.SelectionFont.Style)
    End Sub

    ' Combina o quita un estilo de fuente sobre el texto seleccionado
    Private Sub AplicarEstiloFuente(estilo As FontStyle)
        Dim fuenteActual As Font = rtbDocumento.SelectionFont
        If fuenteActual Is Nothing Then Exit Sub
        Dim nuevoEstilo As FontStyle
        If fuenteActual.Style.HasFlag(estilo) Then
            nuevoEstilo = fuenteActual.Style And Not estilo
        Else
            nuevoEstilo = fuenteActual.Style Or estilo
        End If
        rtbDocumento.SelectionFont = New Font(fuenteActual, nuevoEstilo)
    End Sub

    Private Sub cmsTexto_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsTexto.Opening
        ' Habilita/deshabilita opciones según haya texto seleccionado
        Dim haySeleccion As Boolean = rtbDocumento.SelectionLength > 0
        cmsCortar.Enabled = haySeleccion
        cmsCopiar.Enabled = haySeleccion
        cmsPegar.Enabled = Clipboard.ContainsText()
    End Sub

    Private Sub cmsCortar_Click(sender As Object, e As EventArgs) Handles cmsCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub cmsCopiar_Click(sender As Object, e As EventArgs) Handles cmsCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub cmsPegar_Click(sender As Object, e As EventArgs) Handles cmsPegar.Click
        rtbDocumento.Paste()
    End Sub

    Private Sub cmsSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles cmsSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub cmsFuente_Click(sender As Object, e As EventArgs) Handles cmsFuente.Click
        dlgFuente.Font = rtbDocumento.SelectionFont
        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If
    End Sub

    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        stsFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")
    End Sub

    Private Sub ActualizarBarraEstado()
        Dim linea As Integer = rtbDocumento.GetLineFromCharIndex(rtbDocumento.SelectionStart) + 1
        Dim inicioLinea As Integer = rtbDocumento.GetFirstCharIndexOfCurrentLine()
        Dim columna As Integer = rtbDocumento.SelectionStart - inicioLinea + 1

        stsPosicion.Text = $"Línea: {linea}   Columna: {columna}"
        stsCaracteres.Text = $"Caracteres: {rtbDocumento.TextLength}"
        stsZoom.Text = $"Zoom: {CInt(rtbDocumento.ZoomFactor * 100)}%"
        stsEstado.Text = If(documentoModificado, "Modificado", "Listo")
    End Sub

    Private Sub NuevoDocumento()
        ' Comprueba si hay cambios no guardados antes de crear un nuevo documento'
        If Not ConfirmarGuardarCambios() Then Exit Sub
        rtbDocumento.Clear()
        rutaActual = String.Empty
        documentoModificado = False
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
        ActualizarBarraEstado()
    End Sub

    Private Sub AbrirDocumento()
        ' Comprueba cambios que no se han guardado antes de abrir un nuevo documento'
        If Not ConfirmarGuardarCambios() Then Exit Sub
        If dlgAbrir.ShowDialog() = DialogResult.OK Then
            rtbDocumento.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.PlainText)
            rutaActual = dlgAbrir.FileName
            documentoModificado = False
            Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
            ActualizarBarraEstado()
        End If
    End Sub

    ' GuardarDocumento cambiado a función que devuelve Boolean para indicar exito o cancelación
    Private Function GuardarDocumento(forzarDialogo As Boolean) As Boolean
        If String.IsNullOrEmpty(rutaActual) OrElse forzarDialogo Then
            If dlgGuardar.ShowDialog() = DialogResult.OK Then
                rutaActual = dlgGuardar.FileName
            Else
                Return False
            End If
        End If
        Try
            rtbDocumento.SaveFile(rutaActual, RichTextBoxStreamType.PlainText)
            documentoModificado = False
            Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
            stsEstado.Text = "Guardado correctamente"
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Nueva función: muestra un mensaje de confirmacion
    Private Function ConfirmarGuardarCambios() As Boolean
        If Not documentoModificado Then Return True
        Dim msg As String = "El documento ha sido modificado. ¿Desea guardar los cambios?"
        Dim r As DialogResult = MessageBox.Show(msg, "Guardar cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If r = DialogResult.Yes Then
            Return GuardarDocumento(False)
        ElseIf r = DialogResult.No Then
            Return True
        Else
            Return False
        End If
    End Function

    ' evita cierre si usuario cancela al confirmar guardar cambios
    Private Sub frmBlocNotas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmarGuardarCambios() Then
            e.Cancel = True
        End If
    End Sub

    ' Funcion para buscar en el editor de texto.
    Private Sub tstbBuscar_TextChanged(sender As Object, e As EventArgs) Handles tstbBuscar.TextChanged
        Dim posicionOriginal As Integer = rtbDocumento.SelectionStart
        Dim longitudOriginal As Integer = rtbDocumento.SelectionLength

        rtbDocumento.SelectAll()
        rtbDocumento.SelectionBackColor = Color.White
        rtbDocumento.SelectionColor = Color.Black

        Dim textoABuscar As String = tstbBuscar.Text.Trim()
        If String.IsNullOrEmpty(textoABuscar) Then
            rtbDocumento.Select(posicionOriginal, 0)
            Exit Sub
        End If

        Dim indice As Integer = 0

        indice = rtbDocumento.Find(textoABuscar, indice, RichTextBoxFinds.None)

        Dim seEncontroAlgo As Boolean = False
        Dim primeraPosicionEncontrada As Integer = -1

        Do Until indice < 0
            seEncontroAlgo = True
            If primeraPosicionEncontrada = -1 Then
                primeraPosicionEncontrada = indice
            End If

            rtbDocumento.SelectionBackColor = Color.Yellow
            rtbDocumento.SelectionColor = Color.Black

            Dim siguienteInicio As Integer = indice + textoABuscar.Length

            If siguienteInicio >= rtbDocumento.TextLength Then Exit Do

            indice = rtbDocumento.Find(textoABuscar, siguienteInicio, RichTextBoxFinds.None)
        Loop

        If seEncontroAlgo Then
            rtbDocumento.Select(primeraPosicionEncontrada, textoABuscar.Length)
            rtbDocumento.ScrollToCaret()
        Else
            rtbDocumento.Select(posicionOriginal, longitudOriginal)
        End If

        tstbBuscar.Focus()
    End Sub
    Private Sub dlgAbrir_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dlgAbrir.FileOk

    End Sub
End Class
