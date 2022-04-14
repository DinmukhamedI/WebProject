using System.Collections.Generic;

namespace WebProject.Data.Models
{
    public class Category
    {
        public int Id { set; get; }
        public string Categotyname { set; get; }

        public string Desc { set; get; }

        public List<Product> products { set; get; }
    }
}
