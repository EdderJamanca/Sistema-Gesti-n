using SistemaGestionData.DataAccess;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness.Services
{
    public  class VentasService
    {
        private VentaDataAccess _ventaDataAccess;

        public VentasService(VentaDataAccess ventaDataAccess)
        {
            _ventaDataAccess = ventaDataAccess;
        }

        public List<Venta> GetVentas()
        {
            return _ventaDataAccess.listaVenta();
        }
        public Venta? GetOneVenta(int id)
        {
            return _ventaDataAccess.ObtenerVenta(id);
        }
        public void CreateVenta(Venta venta)
        {
            _ventaDataAccess.createVenta(venta);
        }

        public void UpdateVenta(Venta venta)
        {
            _ventaDataAccess.modificarVenta(venta);
        }
        public void DeleteVenta(int id)
        {
            _ventaDataAccess.DeleteVenta(id);
        }
    }
}
