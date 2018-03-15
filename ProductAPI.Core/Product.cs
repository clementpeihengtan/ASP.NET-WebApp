using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c}")]
        public double Price { get; set; }
        public Boolean Archieved { get; set; }
    }
}
