using System;

namespace LaFritanguitaEcommerce.App.Dominio.Entidades
{
    public class Cliente : Persona
    {

        // Atributos de la clase Cliente que hereda de la clase Persona
        private string direccionFavorita1 { set; get; }
        private string direccionFavorita2 { set; get; }
        private string direccionFavorita3 { set; get; }
        private string codigoPostal { set; get; }

        // Métodos de la clase Cliente -> modificadorAcceso modificadorOpcional tipoDatoRetorno nombreMetodo (parametros)

        /*
        private string realizarCompra(Compra compra);
        private string solicitarDomicilio(Compra compra, string direccionDomicilio);
        private object devolverProductos(Compra compra, Producto producto);
        */

    }
}