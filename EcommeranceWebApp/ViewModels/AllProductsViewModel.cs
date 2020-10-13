using EcommeranceWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommeranceWebApp.ViewModels
{
    public class AllProductsViewModel
    {
        public IEnumerable<ProductToList> Products { get; set; }
    }
}
