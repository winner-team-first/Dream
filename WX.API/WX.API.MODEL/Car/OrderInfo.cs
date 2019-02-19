using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Car
{
    public class OrderInfo
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public decimal OrderProductMoney { get; set; }
        public decimal OrderPaymoney { get; set; }
        public decimal OrderDiscountsMoney { get; set; }
        public string OrderAddrPerson { get; set; }
        public string OrderAddrPhone { get; set; }
        public string OrderAddres { get; set; }
        public int OrderState { get; set; }
        public string OrderCreateTime { get; set; }
        public string OrderPayTime { get; set; }
        public string OrderEndTime { get; set; }
    }
}
