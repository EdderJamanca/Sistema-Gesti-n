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
    public class ProductoVendidoDataAccess
    {
        private readonly SistemaGestionContext _context;

        public ProductoVendidoDataAccess(SistemaGestionContext context)
        {
            _context = context;
        }

        public  List<ProductoVendido> listaProductoVendido()
        {
            try
            {

                return _context.ProductoVendidos.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  void createProductoVendido(ProductoVendido productoVendido)
        {
            try
            {

                    if (productoVendido != null)
                    {
                        _context.ProductoVendidos.Add(productoVendido);
                        _context.SaveChanges();
                    }
                    else
                    {
                        // Manejar el caso en que el usuario sea null
                        throw new ArgumentNullException(nameof(productoVendido), "El usuario no puede ser null.");
                    }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public  ProductoVendido ObtenerProductoVendido(int id)
        {
            try
            {

                    ProductoVendido productoVendido = _context.ProductoVendidos.FirstOrDefault(p => p.Id == id);
                    return productoVendido;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public  void modificarProductoVendido(ProductoVendido data)
        {
            try
            {

                    int Id = data.Id;
                    ProductoVendido productoVendidoActual = _context.ProductoVendidos.Find(Id);
                    if (productoVendidoActual != null)
                    {
                        productoVendidoActual.Stock = data.Stock;

                        _context.SaveChanges();
                    }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public  void DeleteProductoVendido(int id)
        {
            try
            {

                var prodcutoVendido = _context.ProductoVendidos.Find(id);
                if (prodcutoVendido != null)
                {
                    _context.ProductoVendidos.Remove(prodcutoVendido);
                    _context.SaveChanges(); // Guardar cambios en la base de datos
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
