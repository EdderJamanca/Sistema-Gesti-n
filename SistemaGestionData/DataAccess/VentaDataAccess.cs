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
    public class VentaDataAccess
    {
        private readonly SistemaGestionContext _context;

        public VentaDataAccess(SistemaGestionContext context)
        {
            _context = context;
        }

        public  List<Venta> listaVenta()
        {
            return _context.Ventas.ToList();
        }

        public  void createVenta(Venta venta)
        {
                if (venta != null)
                {
                    _context.Ventas.Add(venta);
                    _context.SaveChanges();
                }
                else
                {
                    // Manejar el caso en que el usuario sea null
                    throw new ArgumentNullException(nameof(venta), "El usuario no puede ser null.");
                }
            
        }
        public  Venta ObtenerVenta(int idventa)
        {
            try
            {

                Venta venta = _context.Ventas.FirstOrDefault(p => p.Id == idventa);
                return venta;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async void modificarVenta(Venta venta)
        {
            try
            {

                    int Id = venta.Id;
                    Venta ventaActual = await _context.Ventas.FindAsync(Id);
                    if (ventaActual != null)
                    {
                        ventaActual.Comentario = venta.Comentario;

                        _context.SaveChanges();
                    }

                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public  void DeleteVenta(int id)
        {
            try
            {

                var venta = _context.Ventas.Find(id);
                if (venta != null)
                {
                    _context.Ventas.Remove(venta);
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
