using ECommerce.API.Dto;
using ECommerce.API.Models;

namespace ECommerce.API.Mapping
{
    public static class ProductMappings
    {
        public static Product ToEntity(this CreateProductDto dto) => new()
        {
            Name = dto.Name,
            Price = dto.Price,
            Stock = dto.Stock,
            CategoryId = dto.CategoryId
        };

        public static ProductDto ToDto(this Product product) => new()
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Stock = product.Stock,
            CategoryName = product.Category?.Name ?? string.Empty
        };

        public static List<ProductDto> ToDtoList(this IEnumerable<Product> products)
            => products.Select(p => p.ToDto()).ToList();

        public static void ApplyTo(this UpdateProductDto dto, Product product)
        {
            product.Name = dto.Name;
            product.Price = dto.Price;
            product.Stock = dto.Stock;
            product.CategoryId = dto.CategoryId;
        }

    }
}
