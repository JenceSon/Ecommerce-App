using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_App.Models
{
    public class Product
    {
        private string product_id;
        public string Product_id { get=>product_id; set=> product_id = value; }
        private string name, des, img,catid;
        private int totalRemaining, noSales;
        private double minPrice, maxPrice;

        public string Name { get => name; set => name = value; }
        public string Des { get => des; set => des = value; }
        public string Img { get => img; set => img = value; }
        public string CatId { get=> catid; set => catid = value; }
        public int TotalRemaining { get=>totalRemaining; set => totalRemaining = value; }
        public int NoSales { get=> noSales; set => noSales = value; }
        public double MinPrice { get=>minPrice; set => minPrice = value; }
        public double MaxPrice { get=>maxPrice; set => maxPrice = value; }
        
        public Product(string product_id,string name,string des, int totalRemaining, int noSales, double minPrice, double maxPrice,string img = "",string catid = "")
        {
            this.product_id = product_id;
            this.name = name;
            this.des = des;
            this.totalRemaining = totalRemaining;
            this.noSales = noSales;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
            this.img = img;
            this.catid = catid;

        }
    }
}
