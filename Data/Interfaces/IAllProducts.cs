using System.Collections.Generic;
using WebProject.Data.Models;


namespace WebProject.Data.Interfaces
{
    public interface IAllProducts
    {

        IEnumerable<Product> Products { get;}

        IEnumerable<Product> getFavProducts { get; set; }

        Product getObjectCar(int productId); 
    }
}
