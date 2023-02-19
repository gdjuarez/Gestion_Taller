Module Module_Variables_Globales

    'Usado para pasar de frmLogin-Usuario al MDIParent
    Public usuarioGlobal As String
    'Usado para pasar por parametro el numero del presupuesto e imprimir
    Public Global_numeroPresupuesto As Integer
    'Usado para asignar el idCompras 
    Public Global_numeroCompra As Integer
    Public Global_numeroVenta As Integer
    '-------------caja-----
    Public Global_ultimoGrabado As Integer
    Public flag As String
    '---------------------
    Public GlobalDesdeVentas As Date
    Public GlobalHastaVentas As Date
    Public GlobalDesdeCaja As Date
    Public GlobalHastaCaja As Date

    '--------orden reparacion---------------------
    Public Global_numeroReparacion As Integer



    Public Global_NombreVista As String

    '---------------Anula reparacion-----------

    Public Global_RazonSocialCliente As String
    Public Global_AnularVenta As Integer
    Public Global_Dominio As String

End Module
