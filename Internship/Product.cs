using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship
{
    public class Product
    {
        string ProductName;
        double ProductPrice;
        int ProductQuantity;
        bool Active;

        public Product(string productName)
        {
            this.ProductName = productName;
        }

        public Product(string productName, double productPrice) : this(productName)
        {
            this.ProductPrice = productPrice;
        }
        public Product(string productName, double productPrice, int productQuantity) : this(productName, productPrice)
        {
            this.ProductQuantity = productQuantity;
        }
        public Product(string productName, double productPrice, int productQuantity, bool active) : this(productName, productPrice, productQuantity)
        {
            this.Active = active;
        }

    }
}
