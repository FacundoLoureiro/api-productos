using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Productos.Server.Models;

namespace Productos.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ProductosContext _context;

        public ProductosController(ProductosContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("crear")]
        public async Task<IActionResult>CrearProducto(Producto producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet]
        [Route("lista")]
        public async Task<ActionResult<IEnumerable<Producto>>> ListaProductos()
        {
            var productos = await _context.Productos.ToListAsync();
            return Ok(productos);
        }
        [HttpGet]
        [Route("consulta")]
        public async Task<IActionResult>ConsultaProducto(int id)
        {
            Producto producto = await _context.Productos.FindAsync(id);
            if(producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }
        [HttpPut]
        [Route("modificar")]
        public async Task<IActionResult>ModificarProducto(int id, Producto producto)
        {
            var productoExistente = await _context.Productos.FindAsync(id);
            
            productoExistente!.Nombre = producto.Nombre;
            productoExistente.Descripcion = producto.Descripcion;
            productoExistente.Precio = producto.Precio;

            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete]
        [Route("eliminar")]
        public async Task<IActionResult> EliminarProducto(int id)
        {
            var productoEliminado = await _context.Productos.FindAsync(id);

            _context.Productos.Remove(productoEliminado!);

            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
