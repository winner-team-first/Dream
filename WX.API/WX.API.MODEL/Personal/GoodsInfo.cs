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
    public class GoodsInfo
    {
        public int ID { get; set; }
        public string GoodsName { get; set; }
        public string GoodsSummary { get; set; }
        public string GoodsImage { get; set; }
        public int GoodsPrice { get; set; }
        public int GoodsStock { get; set; }
        public int ClassifyID { get; set; }
        public int BrandID { get; set; }
    }
}
