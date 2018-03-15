using ProductAPI.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Structure
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext() : base(@"name=C:\USERS\CLEMENT\SOURCE\REPOS\MYPRODUCT\PRODUCTMARKET.WEB\PRODUCTMARKET.WEB\APP_DATA\PRODUCT.MDF") { }
    }
}
