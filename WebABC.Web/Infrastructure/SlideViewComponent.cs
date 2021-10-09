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
    public class SlideViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext context;

        public SlideViewComponent(ApplicationDbContext theContext)
        {
            this.context = theContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var slides = await GetSlidesAsync();
            return View(slides);
        }

        private async Task<IEnumerable<SlideDto>> GetSlidesAsync()
        {
            return await this.context.Slides.Select(item => new SlideDto { Image = item.Image, Link = item.Link,Context = item.Context,Sale= item.Sale}).ToListAsync();
        }
    }
}
