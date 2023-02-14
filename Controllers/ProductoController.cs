using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Modelos;
using WebApplication2.Repositorio;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet("{idUsuario}")]
        public void GetSaleProduct(long idUsuario)
        {
            ManejadorProducto.ObtenerProductoVendido(idUsuario);
        }



        [HttpPost]
        public void InsertProduct(Producto producto)
        {
            ManejadorProducto.InsertarProducto(producto);
        }

        [HttpPut]
        public void UpDateProduct(Producto producto)
        {

            ManejadorProducto.ModificarProducto(producto);
        }

        [HttpDelete("{idProducto}")]
        public void DeleteProduct(int idProducto)
        {
            ManejadorProducto.EliminarProducto(idProducto);
        }


    }
}
