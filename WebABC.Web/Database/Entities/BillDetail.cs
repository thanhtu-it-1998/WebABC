using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebABC.Web.Database.Entities
{
    public class BillDetail
    {
        public int Id { get; set; }
        public int IdBill{ get; set; }
        public int IdProduct{ get; set; }
        public int Quantity{ get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        public Product Product { get; set; }
        public Bill Bill { get; set; }
    }
}
