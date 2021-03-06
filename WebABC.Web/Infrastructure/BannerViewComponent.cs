using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebABC.Web.Database;
using WebABC.Web.Dto;

namespace WebABC.Web.Infrastructure
{
    public class BannerViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext context;

        public BannerViewComponent(ApplicationDbContext theContext)
        {
            this.context = theContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var typeProducts = await GetTypeProductAsync();
            return View(typeProducts);
        }

        private async Task<IEnumerable<TypeProductDto>> GetTypeProductAsync()
        {
            return await this.context.TypeProducts.Select(item => new TypeProductDto { Image = item.Image, Description = item.Description, Name = item.Name }).ToListAsync();
        }
    }
}
