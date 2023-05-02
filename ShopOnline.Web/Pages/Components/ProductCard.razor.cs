using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Pages.Components
{
    public partial class ProductCard : ComponentBase
    {
        [Parameter]
        public ProductDto Product { get; set; }
    }
}
