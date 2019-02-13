using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WX.API.Model.Car
{
    public class ShopCar
    {
        /// <summary>
        /// 购物车ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// 商品数量
        /// </summary>
        public int ProductCount { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UID { get; set; }
        /// <summary>
        /// 商品状态
        /// </summary>
        public int ProductState { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 商品简介
        /// </summary>
        public string ProductSummary { get; set; }
        /// <summary>
        /// 商品图片
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
        /// 店铺
        /// </summary>
        public int ShopID { get; set; }


    }
}
