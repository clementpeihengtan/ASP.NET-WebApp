using ProductAPI.Core;
using ProductAPI.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Structure
{
    public class ProductRepo : IProductRepo
    {
        ProductContext context = new ProductContext();
        public void Add(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }

        public void Edit(Product p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            Product p = context.Products.Find(id);
            if (p != null)
            {
                context.Products.Remove(p);
                context.SaveChanges();
            }
        }

        public Product FindById(int id)
        {
            Product p = (from i in context.Products where i.Id == id select i).FirstOrDefault();
            return p;
        }

        public IEnumerable GetProducts()
        {
            IEnumerable p = (from i in context.Products where i.Archieved == false select i);
            return p;
        }

        public IEnumerable GetAllProducts()
        {
            return context.Products;
        }
    }
}
