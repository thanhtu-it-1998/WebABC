using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebABC.Web.Dto
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Total => Price * Qty;
    }
}
