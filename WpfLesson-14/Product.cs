using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLesson_14
{
    public enum ProductTypes
    {
        Food,
        HouseAppliance,
    }
    public class Product
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
