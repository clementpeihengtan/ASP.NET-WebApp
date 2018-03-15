using ProductAPI.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Structure
{
    public class ProductInitDB : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new Product { Id = 1, Description = "Item 1", Price = 40.93, Number = 500, Archieved = false });
            base.Seed(context);
        }
    }
}
