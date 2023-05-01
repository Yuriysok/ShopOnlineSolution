using ShopOnline.Api.Entities;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products,
                                                        IEnumerable<ProductCategory> productCategories) =>
            from product in products
            join productCategory in productCategories
            on product.CategoryId equals productCategory.Id
            select new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Qty = product.Qty,
                Price = product.Price,
                Description = product.Description,
                ImageURL = product.ImageURL,
                CategoryId = product.CategoryId,
                CategoryName = productCategory.Name
            };
    }
}
