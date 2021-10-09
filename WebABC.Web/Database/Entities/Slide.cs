using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebABC.Web.Database.Entities
{
    public class Slide
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string Context { get; set; }
        public int Sale { get; set; }
    }
}
