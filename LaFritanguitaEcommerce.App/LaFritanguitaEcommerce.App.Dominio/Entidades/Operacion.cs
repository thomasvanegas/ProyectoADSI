namespace LaFritanguitaEcommerce.App.Dominio.Entidades
{
    public class Operacion
    {

        // Atributos de la clase Operación
        private string id { get; set; }
        private string fechaOperacion { get; set; } // Cambiar a tipo -> DateTime
        private string metodoPago { get; set; }
        private double valorTotalPagar { get; set; }
        private object listaProductos { get; set; }
        private bool hayDescuento { get; set; }
        private float porcentajeDescuento { get; set; }
        private double valorTotalDescuento { get; set; }

    }
}