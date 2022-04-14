using System.Collections.Generic;
using System.Linq;
using WebProject.Data.Interfaces;
using WebProject.Data.Models;

namespace WebProject.Data.mocks
{
    public class MockProducts : IAllProducts
    {

        private readonly IProductsCategory _categoryProducts = new MockCategory();
        public IEnumerable<Product> Products {
            get
            {
                return new List<Product>
                {
                    new Product {
                        Name ="Samsung A70", ShortDesc = "128 GB MEM, 6 GB RAM", LongDesc = "Белый,SoC Qualcomm Snapdragon 675, 8 ядер (2 Kryo 460 Gold @2,0 ГГц + 6 Kryo 460 Silver @1,7 ГГц), GPU Adreno 612.", Img = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F151840_1vbn.jpg&w=3840&q=85", Price = 130000, IsFavourite = true, Available = true, Category = _categoryProducts.AllCategories.ElementAt(2)
                    },
                    new Product {
                        Name ="Acer Swift 3", ShortDesc = "512 SSD, 8 GB RAM", LongDesc = "Процессор Intel Core i5 6200U 2.3 ГГц, Количество ядер 2, Кэш-память 3 МБ, Емкость аккумулятора 3220 мАч Работа от аккумулятора до 12 часов", Img = "https://fora.kz/images/content/products/620526/acer-swift-3-sf314-59-nxa0mer002_5fd7042dd5f5f.jpg", Price = 320000, IsFavourite = true, Available = true, Category = _categoryProducts.AllCategories.ElementAt(1)

                    },
                    new Product {
                        Name ="Airpods 2", ShortDesc = "Вкладыши, беспроводные", LongDesc = "Размер (каждый наушник): 16,5x18,0x40,5 мм; Размер футляра: 44,3x21,3x53,5 мм; Вес: наушники — 8 гр, футляр — 38 гр; ", Img = "https://best-magazin.com/image/cache/catalog/product/APPLE_acsessuare/naushniki-air-pods-v-zaryadnom-futljare-800x800.jpg", Price = 320000, IsFavourite = true, Available = true, Category = _categoryProducts.AllCategories.ElementAt(3)

                    },
                    new Product {
                        Name ="AppleWatch", ShortDesc = "Активность, сердцебиение", LongDesc = "Корпус 42 мм 312×390 пикселей Площадь дисплея 740 мм Корпус 38 мм 272×340 пикселей Площадь дисплея 563 мм Дисплей OLED с технологиями Retina и Force Touch. Яркость 1000 кд/ м", Img = "https://www.technodom.kz/_next/image?url=https%3A%2F%2Fapi.technodom.kz%2Ff3%2Fapi%2Fv1%2Fimages%2F800%2F800%2F125945_1pqn.jpg&w=3840&q=85", Price = 320000, IsFavourite = true, Available = true, Category = _categoryProducts.AllCategories.ElementAt(3)

                    }
                };
            }
        }
        public IEnumerable<Product> getFavProducts { get; set; }

        public Product getObjectCar(int productId)
        {
            throw new System.NotImplementedException();
        }
    }
}
