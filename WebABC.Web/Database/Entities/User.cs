using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebABC.Web.Database.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
        public string RememberToken { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
