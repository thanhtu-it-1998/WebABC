using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebABC.Web.Database;
using WebABC.Web.Dto;
using WebABC.Web.Models;

namespace WebABC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext theContext)
        {
            this.context = theContext;
        }

        public async Task<IActionResult> Index()
        {
            var data = await this.context.Products
                .Select(item => new ProductDto
                {
                    Id = item.Id,
                    IdType = item.IdType,
                    Name = item.Name,
                    Image = item.Image,
                    Unit = item.Unit,
                    PromotionPrice = item.PromotionPrice,
                    UnitPrice = item.UnitPrice
                })
                .ToListAsync();

            return View(data);
        }


    }
}
