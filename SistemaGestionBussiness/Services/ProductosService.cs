using SistemaGestionData.DataAccess;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness.Services
{
    public class ProductosService
    {
        private ProductosDataAccess _productosDataAccess;

        public ProductosService(ProductosDataAccess productosDataAccess)
        {
            _productosDataAccess = productosDataAccess;
        }

        public List<Producto> GetProducts()
        {
            return _productosDataAccess.GetAllProductos();
        }
        public Producto? GetOneProducto(int id)
        {
            return _productosDataAccess.ObtenerProducto(id);
        }
        public void CreateProducto(Producto producto)
        {
            _productosDataAccess.createProducto(producto);
        }

        public void UpdateProducto(Producto producto)
        {
            _productosDataAccess.modificarProducto(producto);
        }
        public void DeleteProducto(int id)
        {
            _productosDataAccess.DeleteProducto(id);
        }
    }
}
