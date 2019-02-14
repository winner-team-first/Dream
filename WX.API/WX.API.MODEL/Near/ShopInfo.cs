using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Near
{
    public class ShopInfo
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺纬度
        /// </summary>
        public double Shoplongitude { get; set; }

        /// <summary>
        /// 店铺经度
        /// </summary>
        public double Shoplatitude { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        public double Distance { get; set; }
    }
}
