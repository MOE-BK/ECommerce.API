using ECommerce.API.Dto;
using ECommerce.API.Mapping;
using ECommerce.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _service.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto dto)
        {
            var product = await _service.CreateAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = product.Id },
                product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateProductDto dto)
        {
            var result = await _service.UpdateAsync(id, dto);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
//        [HttpGet("search")]
//        public async Task<ActionResult<List<ProductDto>>> Search(
//            string? name,
//            decimal? minPrice,
//            decimal? maxPrice)
//        {
//            var query = _context.Products
//                .AsNoTracking()
//                .Include(p => p.Category)
//                .AsQueryable();

//            if (!string.IsNullOrEmpty(name))
//                query = query.Where(p => p.Name.Contains(name));

//            if (minPrice.HasValue)
//                query = query.Where(p => p.Price >= minPrice);

//            if (maxPrice.HasValue)
//                query = query.Where(p => p.Price <= maxPrice);

//            var products = await query.ToListAsync();

//            return Ok(products.ToDtoList());
//        }

//        [HttpGet("sorted")]
//        public async Task<ActionResult<List<ProductDto>>> GetSorted()
//        {
//            var products = await _context.Products
//                .AsNoTracking()
//                .Include(p => p.Category)
//                .OrderByDescending(p => p.Price)
//                .ToListAsync();

//            return Ok(products.ToDtoList());
//        }
    }
}