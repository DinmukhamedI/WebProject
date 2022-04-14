using System.Collections.Generic;
using WebProject.Data.Interfaces;
using WebProject.Data.Models;

namespace WebProject.Data.mocks
{
    public class MockCategory : IProductsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        Categotyname = "Ноутбуки", Desc = "Легкий и доступный ПК который ты можешь брать с собой"
                    },
                    new Category
                    {
                        Categotyname = "Телефоны", Desc = "Компактный быстрый смартфоны"
                    },
                    new Category
                    {
                        Categotyname = "Наушники", Desc = "Легкий и доступный ПК который ты можешь брать с собой"
                    },
                    new Category
                    {
                        Categotyname ="Часы", Desc = "Умный часы, фитнес браслеты и т.д"
                    }

                };
            }
        }
    }
}
