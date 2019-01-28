using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.MODEL.Personal
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class OrderForm
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string OrderNum { get; set; }
        public string OrderAddrPerson { get; set; }
        public string OrderAddrPhone { get; set; }
        public string OrderAddres { get; set; }
        public DateTime OrderTime { get; set; }
        public decimal SumMoney { get; set; }
        public decimal ActualPay { get; set; }
        public decimal Carriage { get; set; }
        public int OrderStatus { get; set; }
        public int WayBllNum { get; set; }
        public int OrderGoodsID { get; set; }
        public DateTime OrderPayTime { get; set; }
        public DateTime OrderEndTime { get; set; }
    }
}
