using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Personal
{
    /// <summary>
    /// 商品图片表
    /// </summary>
    public class Img
    {
        public int ID { get; set; }
        public int GoodsID { get; set; }
        public string GoodsImage { get; set; }
    }
}
