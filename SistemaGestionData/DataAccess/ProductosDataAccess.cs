using Microsoft.EntityFrameworkCore;
using SistemaGestionData.Context;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.DataAccess
{
    public class ProductosDataAccess
    {
        private readonly SistemaGestionContext _context;

        public ProductosDataAccess(SistemaGestionContext context)
        {
            _context = context;
        }


        public  List<Producto> GetAllProductos()
        {
            try
            {
                return _context.Productos.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos de la base de datos", ex);
            }
        }

        public  void createProducto(Producto producto)
        {
            try
            {
                    if (producto != null)
                    {
                        // Agregar el producto al contexto
                        _context.Productos.Add(producto);
                        // Guardar los cambios en la base de datos
                        _context.SaveChanges();
                    }
                    else
                    {
                        // Manejar el caso en que el producto sea null (opcional)
                        throw new ArgumentNullException(nameof(producto), "El producto no puede ser null.");
                    }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el producto de la base de datos", ex);
            }
        }
        public  Producto ObtenerProducto(int idproducto)
        {
            try
            {

                    Producto producto =  _context.Productos.FirstOrDefault(p => p.Id == idproducto);
                    return producto;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el producto de la base de datos", ex);
            }

        }

        public  void modificarProducto(Producto producto)
        {
            try
            {

                    int Id = producto.Id;
                    Producto productoActual = _context.Productos.Find(Id);
                    if (productoActual != null)
                    {
                        productoActual.Descripcion = producto.Descripcion;
                        productoActual.Costo = producto.Costo;
                        productoActual.PrecioVenta = producto.PrecioVenta;
                        productoActual.Stock = producto.Stock;
                        _context.Productos.Update(productoActual);
                        _context.SaveChanges();
                    }

                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el producto de la base de datos", ex);

            }

        }
        // Método para eliminar un producto, también recibiendo el contexto
        public  void DeleteProducto(int id)
        {
            try
            {

                var producto = _context.Productos.Find(id);
                if (producto != null)
                {
                    _context.Productos.Remove(producto);
                    _context.SaveChanges(); // Guardar cambios en la base de datos
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto de la base de datos", ex);

            }
        }
    }
}
