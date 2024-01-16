using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly AppDbContext _context;

        public CheckoutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Checkout> checkouts = _context.Checkouts.Include(c => c.Country).ToList();

            List<CheckoutVM> modelList = new List<CheckoutVM>();

            foreach (var checkout in checkouts)
            {
                var model = new CheckoutVM()
                {
                    FirstName = checkout.FirstName,
                    LastName = checkout.LastName,
                    CompanyName = checkout.CompanyName,
                    Address = checkout.Address,
                    Email = checkout.Email,
                    Town = checkout.Town,
                    PhoneNumber = checkout.PhoneNumber,
                    ZipCode = checkout.ZipCode,
                    Comment = checkout.Comment,
                    CountryId = checkout.CountryId,
                    Country = checkout.Country
                };

                modelList.Add(model);
            }

            return View(modelList);
        }

    }
}
