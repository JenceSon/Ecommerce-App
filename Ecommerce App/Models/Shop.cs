using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_App.Models
{
    public class Shop
    {
        private string shop_id, bio, urlLink, name, date_joined;
        private int no_following, no_follower, no_product;
        private double rating;
        public string Shop_id { get => shop_id; set=>shop_id = value; }
        public string Bio { get => bio; set => bio = value; }  
        public string UrlLink { get => urlLink; set => urlLink = value; }
        public string Name { get => name; set => name = value; }
        public string DateJoined { get => date_joined; set => date_joined = value; }
        public int No_following { get => no_following; set => no_following = value; }
        public int No_folower { get => no_follower; set => no_follower = value;}
        public int No_product { get => no_product; set => no_product = value; }

        public double Rating { get => rating; set => rating = value; }

        public Shop(string shop_id, string bio, string urlLink, string name, string date_joined, int no_following, int no_follower, int no_product, double rating)
        {
            this.shop_id = shop_id;
            this.bio = bio;
            this.urlLink = urlLink;
            this.name = name;
            this.date_joined = date_joined;
            this.no_following = no_following;
            this.no_follower = no_follower;
            this.rating = rating;
            this.no_product = no_product;
        }
    }
}
