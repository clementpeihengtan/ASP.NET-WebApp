using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Core.Interfaces
{
    public interface IProductRepo
    {
        void Add(Product p);
        void Edit(Product p);
        void Remove(int id);
        IEnumerable GetAllProducts();
        IEnumerable GetProducts();
        Product FindById(int id);
    }
}
