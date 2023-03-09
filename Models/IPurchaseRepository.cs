using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_allipope.Models
{
    public interface IPurchaseRepository
    {
        public IQueryable<Purchase> Purchase { get; }
        public void SavePurchase(Purchase purchase);
    }
}
