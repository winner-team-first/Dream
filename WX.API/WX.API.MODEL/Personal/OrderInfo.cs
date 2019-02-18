using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Personal
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class OrderInfo
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int OrderProductMoney { get; set; }
        public int OrderPaymoney { get; set; }
        public int OrderDiscountsMoney { get; set; }
        public int OrderAddrPerson { get; set; }
        public int OrderAddrPhone { get; set; }
        public int OrderAddres { get; set; }
        public int OrderState { get; set; }
        public int OrderCreateTime { get; set; }
        public int OrderPayTime { get; set; }
        public int OrderEndTime { get; set; }
    }
}
