using System;

namespace LaFritanguitaEcommerce.App.Dominio.Entidades
{
    public class Producto
    {

        // Propiedades (atributos) de la clase Producto

        public int idProducto { get; set; }
        public string nombre { get; set; }
        public CategoriaEnum categoria { get; set; }
        public int precio { get; set; }
        public string pesoVolumen { get; set; }
        public DateTime fechaLlegada { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public string imagen { get; set; }
        public string descripcion { get; set; }
        public bool estaDisponible { get; set; }
        public int cantDisponible { get; set; }
        public int idProveedor { get; set; }

        // Métodos de la clase Producto
        // public string anadirAlCarritoCompras(Producto producto);

    }
}