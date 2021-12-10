namespace LaFritanguitaEcommerce.App.Dominio.Entidades
{
    public class Empleado : Persona
    {

        // Atributos de la clase Empleado - Recordar: Empleado hereda de la clase Persona
        private string cargo { get; set; }
        private long salario { get; set; }
        private short numeroMaximoHorasTrabajo { get; set; }
        private short numeroMinimoHorasTrabajo { get; set; }
        private string eps { get; set; }
        private string fondoPension { get; set; }
        private string estadoCivil { get; set; }
        private string tipoSangre { get; set; }
        private string numeroCelularEmergencia { get; set; }

        // Métodos de la clase Empleado

        /*
        public string solicitarProductosProveedores(object productos, Proveedor proveedor);
        public object recibirProductosProveedores(string productosSolicitadosProveedor);
        public string venderProductos(Venta venta);
        public string realizarEntregaDomicilio(Venta venta);
        public abstract string agregarProductosSistemaInformacion(Producto producto);
        public abstract string eliminarProductosSistemaInformacion(Producto producto);
        public abstract string actualizarProductosSistemaInformacion(Producto producto);
        */

    }
}