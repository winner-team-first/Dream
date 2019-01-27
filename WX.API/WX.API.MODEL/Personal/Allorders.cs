using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.MODEL.Personal
{
    /// <summary>
    /// 所有订单
    /// </summary>
    public class Allorders
    {
        //select a.OrderNum 编号, b.OrderProductName 名称, b.OrderProductTotalPrice 单价,
        //    b.GoodsNum 数量, b.OrderProductPrice 总价, a.OrderStatus 状态, c.GoodsImage 
        //    图片 from OrderForm a , OrderGoods b, GoodsInfo c
        public string OrderNum { get; set; }
        public string OrderProductName { get; set; }
        public decimal OrderProductTotalPrice { get; set; }
        public int GoodsNum { get; set; }
        public decimal OrderProductPrice { get; set; }
        public int OrderStatus { get; set; }
        public string GoodsImage { get; set; }
    }
}
