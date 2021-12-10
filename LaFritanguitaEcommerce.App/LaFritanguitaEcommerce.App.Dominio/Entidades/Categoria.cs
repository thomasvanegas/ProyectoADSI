using System;
using System.Collections.Generic; // Librería que nos permite tener Arrays de tipo List<>

namespace LaFritanguitaEcommerce.App.Dominio.Entidades
{
    public class Categoria
    {

        // Atributos de la clase Categoria
        private string id { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private string imagenURL { get; set; }
        private List<Producto> productos { get; set; } // Array de productos de tipo Producto

    }
}