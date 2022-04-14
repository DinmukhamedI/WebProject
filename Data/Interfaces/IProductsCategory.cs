using System.Collections.Generic;
using WebProject.Data.Models;

namespace WebProject.Data.Interfaces
{
    public interface IProductsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
