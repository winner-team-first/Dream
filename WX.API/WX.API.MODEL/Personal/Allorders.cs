using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Personal
{
    /// <summary>
    /// 所有订单
    /// </summary>
    public class Allorders
    {
        public int ID { get; set; }
        public string OrderProductName { get; set; }
        public decimal OrderProductTotalPrice { get; set; }
        public int OrderProductNum { get; set; }
        public decimal OrderProductPrice { get; set; }
        public int OrderState { get; set; }
        public string ProductImage { get; set; }
    }
}
