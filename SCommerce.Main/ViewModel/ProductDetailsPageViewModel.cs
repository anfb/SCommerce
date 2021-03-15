using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCommerce.Main.ViewModel
{
    public class ProductDetailsPageViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
        public List<string> Images { get; set; }
        public string SelectedImage { get; set; }

        public ProductDetailsPageViewModel()
        {
            this.Title = "Product 1";
            this.Description = "Don't have a lot of informations about this product. But it's nice.";
            this.Price = 80.20564;
            this.Rating = 4;
            Images = new List<string>
            {
                "/Assets/product1.jpg",
                "/Assets/product2.jpg",
                "/Assets/product3.jpg"
            };
            this.SelectedImage = Images[0];

        }
    }
}
