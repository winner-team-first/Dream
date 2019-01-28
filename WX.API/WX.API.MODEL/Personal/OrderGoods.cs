using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.MODEL.Personal
{
    /// <summary>
    /// 订单商品详情
    /// </summary>
    public class OrderGoods
    {
        public int ID { get; set; }
        public int GoodsID { get; set; }
        public string OrderProductName { get; set; }
        public decimal OrderProductPrice { get; set; }
        public decimal OrderProductTotalPrice { get; set; }
        public int GoodsNum { get; set; }
        public int OrderProducStatus { get; set; }
    }
}
