using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.MODEL.Near
{
    public class ProductInfo
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductSummary { get; set; }
        public string ProductImage { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ProductSales { get; set; }
        public int ClassifyID { get; set; }
        public int ShopID { get; set; }

    }
}
