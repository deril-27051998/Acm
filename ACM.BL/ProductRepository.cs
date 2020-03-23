using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            if (productId == 2)
            {
                product.ProductName="Sunflowers";
                product.ProductDescription = "bdhbwvd edvegv hbehwb egvdg";
                product.CurrentPrice = 15.69M;
            }
            
            return product;

        }

        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        //call insert stored procedure
                    }
                    else
                    {
                        //call update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
