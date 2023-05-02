using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
    public partial class Products : ComponentBase
    {
        const int ItemsPerRow = 4;

        [Inject]
        public IProductService ProductService { get; set; }
        public IEnumerable<ProductDto> ProductList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ProductList = await ProductService.GetItems();
        }

        public IEnumerable<IEnumerable<ProductDto>> GetProductRows() => 
            ProductList.Chunk(ItemsPerRow);

        public IEnumerable<IEnumerable<ProductDto>> GetGroupedProductRows()
        {
            var productGroups = from product in ProductList
                   group product by product.CategoryId into productGroup
                   orderby productGroup.Key
                   select productGroup;
            foreach (var group in productGroups)
            {
                foreach (var chunk in group.Chunk(ItemsPerRow))
                    yield return chunk;
            }
        }
    }
}
