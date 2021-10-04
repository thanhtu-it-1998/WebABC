using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebABC.Web.Database.Entities
{
    public class Bill
    {
        public int Id { get; set; }
        public int IdCustomer{ get; set; }
        public DateTime DateOrder{ get; set; }
        public decimal Total { get; set; }
        public string Payment { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<BillDetail> BillDetails { get; set; }
        public Customer Customer { get; set; }
    }
}
