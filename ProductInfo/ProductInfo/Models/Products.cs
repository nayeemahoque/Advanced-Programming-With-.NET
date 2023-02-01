using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInfo.Models
{
    public class Products
    {
        private string id;
        private string name;
        private double price;
        
        internal string Id
        {
            get { return id; }
            set { id = value; }
        }
        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal double Price 
        {
            get { return price; }
            set { price = value; }
        }
        public Products(string id, string name, double price)
        {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        }

}
}