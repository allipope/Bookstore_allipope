using Microsoft.AspNetCore.Mvc;
using Bookstore_allipope.Models;

namespace Bookstore_allipope.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket basketservice)
        {
            basket = basketservice;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
