using System;
using System.Linq;
using System.Collections.Generic; // List
using LaFritanguitaEcommerce.App.Dominio;
using LaFritanguitaEcommerce.App.Dominio.Entidades; // Producto

namespace LaFritanguitaEcommerce.App.Persistencia
{

    public class RepositorioProducto : IRepositorioProducto
    {

        List<Producto> Productos; // Lista de Productos - Manipulación -> SIMULACIÓN BASE DE DATOS

        // MÉTODO CONSTRUCTOR
        public RepositorioProducto()
        {

            Productos = new List<Producto>(){

                new Producto{

                    idProducto = 1,
                    nombre = "Leche Colanta Entera",
                    categoria = CategoriaEnum.lacteos,
                    precio = 3000,
                    pesoVolumen = "1000 mL",
                    fechaLlegada = new DateTime(2021, 12, 9),
                    fechaVencimiento = new DateTime(2021, 12, 16),
                    imagen = "LecheColantaEntera1L.png",
                    descripcion = "Vacia",
                    estaDisponible = true,
                    cantDisponible = 20,
                    idProveedor = 1

                },
                new Producto{

                    idProducto = 2,
                    nombre = "Leche Colanta Deslactosada",
                    categoria = CategoriaEnum.lacteos,
                    precio = 3000,
                    pesoVolumen = "1000 mL",
                    fechaLlegada = new DateTime(2021, 12, 8),
                    fechaVencimiento = new DateTime(2021, 12, 15),
                    imagen = "LecheColantaDeslactosada1000mL.png",
                    descripcion = "Vacia",
                    estaDisponible = true,
                    cantDisponible = 10,
                    idProveedor = 1

                },
                new Producto{

                    idProducto = 3,
                    nombre = "Coca Cola Original",
                    categoria = CategoriaEnum.bebidasNoAlcoholicas,
                    precio = 7000,
                    pesoVolumen = "3 L",
                    fechaLlegada = new DateTime(2021, 12, 9),
                    fechaVencimiento = new DateTime(2022, 3, 9),
                    imagen = "CocaColaOriginal3L.png",
                    descripcion = "Vacia",
                    estaDisponible = true,
                    cantDisponible = 12,
                    idProveedor = 2

                }

            };

        }

        // MÉTODOS DE LA INTERFACE IRepositorioProducto.cs
        // Visibilidad TipoDatoRetorna NombreMetodo (Parametros){Estructura del metodo return Sentencia};

        public IEnumerable<Producto> GetAllProducts()
        {

            // throw new NotImplementedException(); -> propiedad para que no genere error el método / Indica que el método no está implementado
            return Productos; // Retorna un lista o conjunto de productos

        }
        public Producto GetProduct(int idProducto)
        {

            // throw new NotImplementedException();

            return Productos.SingleOrDefault(product => product.idProducto == idProducto);

            // Retorna un solo producto a partir del id

        }
        public Producto CreateNewProduct(Producto producto)
        {

            //throw new NotImplementedException();

            int nuevoId = Productos.Max(r => r.idProducto) + 1;

            producto.idProducto = nuevoId; // IdProducto Autoincremental a partir del id más alto

            Productos.Add(producto);

            return producto; // Crear un producto y lo retorna cuando sea añadido

        }
        public Producto UpdateProduct(Producto producto)
        {

            //throw new NotImplementedException();

            var productoExistente = Productos.SingleOrDefault(product => product.idProducto == producto.idProducto);

            if (productoExistente != null)
            {

                productoExistente.nombre = producto.nombre;
                productoExistente.categoria = producto.categoria;
                productoExistente.precio = producto.precio;
                productoExistente.pesoVolumen = producto.pesoVolumen;
                productoExistente.fechaLlegada = producto.fechaLlegada;
                productoExistente.fechaVencimiento = producto.fechaVencimiento;
                productoExistente.imagen = producto.imagen;
                productoExistente.descripcion = producto.descripcion;
                productoExistente.estaDisponible = producto.estaDisponible;
                productoExistente.cantDisponible = producto.cantDisponible;
                productoExistente.idProveedor = producto.idProveedor;

            }

            return productoExistente; // Actualizar producto

        }
        public string Delete(int idProducto)
        {

            // throw new NotImplementedException();

            var productoExistente = Productos.SingleOrDefault(product => product.idProducto == idProducto);

            if (productoExistente == null)
            {

                return "Producto No Encontrado en la Base de Datos";

            }

            Productos.Remove(productoExistente);

            return "Producto Eliminado Correctamente de la Base de Datos";

        } // Eliminar producto

    }

}