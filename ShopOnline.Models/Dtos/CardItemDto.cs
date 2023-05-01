using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class CardItemDto
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public string ProductNameescription { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageURL { get; set; }
        public int Price { get; set; }
        public int TotalPrice { get; set; }
    }
}
