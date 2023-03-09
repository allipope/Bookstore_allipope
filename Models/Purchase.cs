using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore_allipope.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }
        
        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please enter the city.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter the state.")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter the country.")]
        public string Country { get; set; }
    }
}
