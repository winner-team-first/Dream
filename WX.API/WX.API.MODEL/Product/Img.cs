using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Product
{
    public  class Img
    {
        /// <summary>
        /// 详情图片ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 所属商品
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// 详情图片
        /// </summary>
        public string ProductImage { get; set; }
    }
}
