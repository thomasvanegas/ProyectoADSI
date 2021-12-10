using System;
using System.Collections.Generic;
using LaFritanguitaEcommerce.App.Dominio.Entidades;

// namespace LaFritanguitaEcommerce.App.Persistencia.AppRepositorios
namespace LaFritanguitaEcommerce.App.Persistencia
{
    public interface IRepositorioProducto
    {

        // CREACIÓN DE UN CRUD DE PRODUCTOS
        // IEnumerable -> Retorna una Lista

        IEnumerable<Producto> GetAllProducts(); // Retorna un lista de productos
        Producto GetProduct(int idProducto); // Retorna un solo producto a partir del id
        Producto CreateNewProduct(Producto producto); // Añadir un producto y lo retorna cuando sea añadido
        Producto UpdateProduct(Producto producto); // Actualizar producto
        string Delete(int idProducto); // Eliminar producto

    }

}