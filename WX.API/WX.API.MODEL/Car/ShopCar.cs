using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WX.API.MODEL.Car
{
    public class ShopCar
    {
        public int ShopCarID { get; set; }
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
        public string UID { get; set; }
        public int ProductState { get; set; }
        public string ProductName { get; set; }
        public string ProductSummary { get; set; }
        public string ProductImage { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int ShopID { get; set; }


    }
}
