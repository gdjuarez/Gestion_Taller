Imports System.Windows.Forms

Public Class MDIMenu

    Private Sub MDIMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestión Taller - GiF Sys - " & Date.Today
        Me.ToolStripLabelUsuario.Text = usuarioGlobal
        If usuarioGlobal = "Admin" Then
        End If
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Normal
        Next
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Minimized
        Next
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        FrmMisDatos.MdiParent = Me
        FrmMisDatos.Show()
    End Sub

    Private Sub HerramientasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HerramientasToolStripMenuItem2.Click
        FrmHerramientas.MdiParent = Me
        FrmHerramientas.Show()
        FrmHerramientas.BtnSeleccionar.Visible = True
    End Sub

    Private Sub ArticulosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem1.Click
        FrmArticulos.MdiParent = Me
        FrmArticulos.Show()
        FrmArticulos.BtnSeleccionar.Visible = True
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
        frmProveedores.BtnCopiar.Visible = True
    End Sub

    Private Sub VehiculosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculosToolStripMenuItem.Click
        FrmVehiculo.MdiParent = Me
        FrmVehiculo.Show()
        FrmVehiculo.BtnSeleccionar.Visible = True
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        FrmMarcaModelo.MdiParent = Me
        FrmMarcaModelo.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub

    Private Sub BackUpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpToolStripMenuItem1.Click
        FrmBackUp.MdiParent = Me
        FrmBackUp.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
        LoginFormUsuarios.MdiParent = Me
        LoginFormUsuarios.Show()
    End Sub

    Private Sub PresupuestoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresupuestoToolStripMenuItem1.Click
        FrmBusquedaPresupuesto.MdiParent = Me
        FrmBusquedaPresupuesto.Show()
    End Sub

    Private Sub CompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        frmCompras.MdiParent = Me
        frmCompras.Show()
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem1.Click
        FrmBusquedaVenta.MdiParent = Me
        FrmBusquedaVenta.Show()
    End Sub

    Private Sub VentasSinPagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasSinPagoToolStripMenuItem.Click
        FrmBusquedaVentaSinPago.MdiParent = Me
        FrmBusquedaVentaSinPago.Show()
    End Sub

    Private Sub VehiculoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoToolStripMenuItem.Click
        FrmBusquedaVehiculo.MdiParent = Me
        FrmBusquedaVehiculo.Show()
    End Sub

    Private Sub VehiculoConEstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoConEstadoToolStripMenuItem.Click
        FrmBusquedaVehiculoEstado.MdiParent = Me
        FrmBusquedaVehiculoEstado.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resultado As DialogResult = MessageBox.Show("Está seguro de salir?",
                                            "Atención", MessageBoxButtons.YesNo)
        If resultado = Windows.Forms.DialogResult.Yes Then
            'Deja el formulario activo 
            FrmLogin.Show()
            FrmLogin.UsernameTextBox.Focus()
            Me.Close()
        End If
    End Sub

    'Informes
    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        FrmInformeStock.MdiParent = Me
        FrmInformeStock.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        FrmInformeClientes.MdiParent = Me
        FrmInformeClientes.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        FrmInformeProveedores.MdiParent = Me
        FrmInformeProveedores.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        FrmDesdeHasta.MdiParent = Me
        FrmDesdeHasta.Show()
        FrmDesdeHasta.BtnInfVenta.Visible = True
    End Sub

    Private Sub MovimientosDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeCajaToolStripMenuItem.Click
        FrmDesdeHasta.MdiParent = Me
        FrmDesdeHasta.Show()
        FrmDesdeHasta.BtnInfCaja.Visible = True
    End Sub

    Private Sub OrdenDeReparaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeReparaciónToolStripMenuItem.Click
        FrmOrdenReparacion.MdiParent = Me
        FrmOrdenReparacion.Show()
    End Sub

    Private Sub OrenDeReparaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrenDeReparaciónToolStripMenuItem.Click
        Global_NombreVista = "VistaOrdenReparacion"
        FrmBusquedaOrdenReparacion.MdiParent = Me
        FrmBusquedaOrdenReparacion.Show()
    End Sub

    Private Sub HerramientasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HerramientasToolStripMenuItem.Click
        FrmInformeHerramientas.MdiParent = Me
        FrmInformeHerramientas.Show()
    End Sub

    Private Sub HerramientasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HerramientasToolStripMenuItem1.Click
        FrmHerramientas.MdiParent = Me
        FrmHerramientas.Show()
        FrmHerramientas.BtnSeleccionar.Visible = True
    End Sub

    Private Sub PresupuestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PresupuestoToolStripMenuItem.Click
        FrmPresupuestos.MdiParent = Me
        FrmPresupuestos.Show()
    End Sub

    Private Sub EntradaTallerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaTallerToolStripMenuItem.Click
        FrmEntradaTaller.MdiParent = Me
        FrmEntradaTaller.Show()
    End Sub

    Private Sub SalidaTallerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidaTallerToolStripMenuItem.Click
        FrmSalidaTaller.MdiParent = Me
        FrmSalidaTaller.Show()
    End Sub

    Private Sub RetiroVehiculoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RetiroVehiculoToolStripMenuItem.Click
        FrmRetiroVehiculo.MdiParent = Me
        FrmRetiroVehiculo.Show()
    End Sub

    Private Sub CajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem1.Click
        frmCaja.MdiParent = Me
        frmCaja.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Shell("calc.exe")
    End Sub

    Private Sub FacturaOnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaOnlineToolStripMenuItem.Click
        FrmNavegador.MdiParent = Me
        FrmNavegador.Show()
    End Sub
End Class
