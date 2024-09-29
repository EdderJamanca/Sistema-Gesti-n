using SistemaGestionData.DataAccess;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness.Services
{
    public class ProductosVendidosService
    {
        private ProductoVendidoDataAccess _productosVendidoDataAccess;

        public ProductosVendidosService(ProductoVendidoDataAccess productosVendidoDataAccess)
        {
            _productosVendidoDataAccess = productosVendidoDataAccess;
        }

        public List<ProductoVendido> GetProductsVendido()
        {
            return _productosVendidoDataAccess.listaProductoVendido();
        }
        public ProductoVendido? GetOneProductoVendido(int id)
        {
            return _productosVendidoDataAccess.ObtenerProductoVendido(id);
        }
        public void CreateProductoVendido(ProductoVendido productovendido)
        {
            _productosVendidoDataAccess.createProductoVendido(productovendido);
        }

        public void UpdateProductoVendido(ProductoVendido productovendido)
        {
            _productosVendidoDataAccess.modificarProductoVendido(productovendido);
        }
        public void DeleteProductoVendido(int id)
        {
            _productosVendidoDataAccess.DeleteProductoVendido(id);
        }
    }
}
