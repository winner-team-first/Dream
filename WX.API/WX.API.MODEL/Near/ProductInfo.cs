using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Near
{
    public class ProductInfo
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        public int ID { get; set; }


        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }


        /// <summary>
        /// 产品简介
        /// </summary>
        public string ProductSummary { get; set; }


        /// <summary>
        /// 产品图片
        /// </summary>
        public string ProductImage { get; set; }


        /// <summary>
        /// 产品价格
        /// </summary>
        public decimal ProductPrice { get; set; }


        /// <summary>
        /// 产品库存
        /// </summary>
        public int ProductStock { get; set; }


        /// <summary>
        /// 产品销售量
        /// </summary>
        public int ProductSales { get; set; }


        /// <summary>
        /// 类别ID
        /// </summary>
        public int ClassifyID { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopID { get; set; }

    }
}
