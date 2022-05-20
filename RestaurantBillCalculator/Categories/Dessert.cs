using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillCalculator
{
    public class Dessert
    {
        private string category;
        private string name;
        private decimal price;

        public Dessert(string category, string name, decimal price)
        {
            this.category = category;
            this.name = name;
            this.price = price;
        }

        public Dessert()
        {

        }

        public string GetNameAndPrice
        {
            get
            {
                return $"{name}        ${price}";
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
        }
    }
}
