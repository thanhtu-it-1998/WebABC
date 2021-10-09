using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebABC.Web.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int IdType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal PromotionPrice { get; set; }
        public string Image { get; set; }
        public string Unit { get; set; }
    }

}
