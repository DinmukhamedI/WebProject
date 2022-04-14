using WebProject.Data.Models;
using System.Collections.Generic;

namespace WebProject.ViewModels
{
    public class ProductsListViewModel
    {

        public IEnumerable<Product> getAllProducts { get; set; }

        public string currCategory { get; set; }


    }
}
