using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Product
{
    public class ProductInfo
    {
        /// <summary>
        /// 商品主键
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 商品简介
        /// </summary>
        public string ProductSummary { get; set; }

        /// <summary>
        /// 商品封面
        /// </summary>
        public string ProductImage { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// 商品库存
        /// </summary>
        public int ProductStock { get; set; }

        /// <summary>
        /// 商品销量
        /// </summary>
        public int ProductSales { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        public int ClassifyID { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopID { get; set; }

        /// <summary>
        /// 存放所有详情图片
        /// </summary>
        public List<Img> ImgList { get; set; } = new List<Img>();

    }
}
