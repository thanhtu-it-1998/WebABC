using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebABC.Web.Database;
using WebABC.Web.Database.Entities;
using WebABC.Web.Dto;
using WebABC.Web.Helper;

namespace WebABC.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext context;

        public ShopController(ApplicationDbContext theContext)
        {
            context = theContext;
        }

        public async Task<IActionResult> Index(string? cat, string? type)
        {

            var data = await this.context.Products
                .Select(item => new ProductDto
                {
                    Id = item.Id,
                    IdType = item.IdType,
                    Image = item.Image,
                    Name = item.Name,
                    Unit = item.Unit,
                    PromotionPrice = item.PromotionPrice,
                    UnitPrice = item.UnitPrice
                }).ToListAsync();
            if (cat != null)
            {
                var category = await this.context.TypeProducts.Where(item => item.Name.ToLower() == cat.ToLower()).SingleOrDefaultAsync();
                data = data.Where(item => item.IdType == category.Id).ToList();
            }
            if (type != null)
            {
                data = data.Where(item => item.Unit.ToLower() == type.ToLower()).ToList();
            }
            return View(data);
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult ShoppingCart()
        {
            var data = Carts;
            return View(data);
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        public async Task<IActionResult> ProductDetail(int Id)
        {

            var data = await this.context.Products
                .Select(item => new ProductDto
                {
                    Id = item.Id,
                    IdType = item.IdType,
                    Name = item.Name,
                    Description = item.Description,
                    Image = item.Image,
                    Unit = item.Unit,
                    PromotionPrice = item.PromotionPrice,
                    UnitPrice = item.UnitPrice
                })
                .Where(item => item.Id == Id)
                .SingleOrDefaultAsync();
            
            ViewData["Category"] = await this.context.TypeProducts
                .Where(item => item.Id == data.IdType)
                .Select(item => item.Name)
                .SingleOrDefaultAsync();
            
            ViewBag.RelatedProducts = await this.context.Products
                .Where(item => item.Unit == data.Unit)
                .Select(item => new ProductDto
                {
                    Id = item.Id,
                    IdType = item.IdType,
                    Image = item.Image,
                    Name = item.Name,
                    Unit = item.Unit,
                    PromotionPrice = item.PromotionPrice,
                    UnitPrice = item.UnitPrice
                })
                .Take(4)
                .ToListAsync();
            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckOut([FromForm] CustomerDto model)
        {
            var data = Carts;
            if (data.Count == 0)
            {
                TempData["Error"] = "No Product In Cart";
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var myCart = Carts;
                    var idBill = SaveBill(model);
                    foreach (var item in myCart)
                    {
                        SaveBillDetail(idBill, item);
                    }
                    HttpContext.Session.Clear();
                    return RedirectToAction("Successfully");
                }
            }
            return View(model);

        }
        public IActionResult Successfully()
        {
            return View();
        }

        public List<CartItemDto> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<CartItemDto>>("Carts");
                if (data == null)
                {
                    data = new List<CartItemDto>();
                }
                return data;
            }
        }


        public IActionResult AddToCart(int Id, int Qty, string type = "Normal")
        {

            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.Id == Id);
            if (item == null)
            {
                var product = context.Products.SingleOrDefault(p => p.Id == Id);
                item = new CartItemDto { Id = Id, Name = product.Name, Price = product.PromotionPrice, Qty = Qty, Image = product.Image };
                myCart.Add(item);
            }
            else
            {
                item.Qty += Qty;
            }
            HttpContext.Session.Set("Carts", myCart);
            if (type == "ajax")
            {
                return Json(new
                {
                    item = Carts.Sum(p => p.Qty)
                });
            }
            return Ok(myCart);
        }
        public IActionResult GetItemCart()
        {
            var myCart = Carts;
            return Ok(myCart);
        }

        public IActionResult DeleteItemCart(int Id)
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.Id == Id);
            myCart.Remove(item);
            HttpContext.Session.Set("Carts", myCart);
            return Ok();
        }

        public int SaveCustomer(CustomerDto model)
        {
            Customer cus = new Customer();
            cus.Name = model.Name;
            cus.Email = model.Email;
            cus.PhoneNumber = model.PhoneNumber;
            cus.Gender = model.Gender;
            cus.Address = model.Address;
            this.context.Customers.Add(cus);
            this.context.SaveChanges();
            return cus.Id;
        }

        public int SaveBill(CustomerDto model)
        {
            var bill = new Bill();
            bill.IdCustomer = SaveCustomer(model);
            bill.Note = model.Note;
            bill.Payment = "Cash Payment";
            bill.Total = GetTotalPrice();
            this.context.Bills.Add(bill);
            this.context.SaveChanges();
            return bill.Id;
        }
        public void SaveBillDetail(int Id, CartItemDto item)
        {

            var billDetail = new BillDetail();
            billDetail.IdBill = Id;
            billDetail.IdProduct = item.Id;
            billDetail.Quantity = item.Qty;
            billDetail.UnitPrice = item.Total;
            this.context.BillDetails.Add(billDetail);
            this.context.SaveChanges();

        }

        public decimal GetTotalPrice()
        {
            var myCart = Carts;
            decimal total = 0;
            foreach (var item in myCart)
            {
                total = total + item.Total;
            }
            return total;
        }
    }
}
