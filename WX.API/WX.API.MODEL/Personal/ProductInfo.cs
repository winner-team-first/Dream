using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Personal
{
    /// <summary>
    /// 商品信息表
    /// </summary>
    public class ProductInfo
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductSummary { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ProductSales { get; set; }
        public int ClassifyID { get; set; }
        public int ShopID { get; set; }
    }
}
