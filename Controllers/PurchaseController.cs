using Bookstore_allipope.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_allipope.Controllers
{
    public class PurchaseController : Controller
    {
        private IPurchaseRepository repo { get; set; }
        private Basket basket { get; set; }
        
        public PurchaseController(IPurchaseRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }
        
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }

        [HttpPost]
        public IActionResult Checkout(Purchase purchase)
        {
            if (basket.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Your shopping cart is empty.");
            }

            if (ModelState.IsValid)
            {
                purchase.Lines = basket.Items.ToArray();
                repo.SavePurchase(purchase);
                basket.ClearBasket();

                return RedirectToPage("/Confirmation");
            }

            else
            {
                return View();
            }
        }
    }
}
