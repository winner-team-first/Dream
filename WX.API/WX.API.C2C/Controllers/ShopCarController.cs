using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WX.API.Model.Car;
using WX.API.IRepository.Car;

namespace WX.API.C2C.Controllers
{
    public class ShopCarController : ApiController
    {
        public IShopCarRepoitory ShopCarRepoitory { get; set; }

        /// <summary>
        /// 显示购物车列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetShopCarList")]
        public List<ShopCar> GetShopCarList()
        {
            List<ShopCar> list = ShopCarRepoitory.GetShopCarList();
            return list; 
        }
        /// <summary>
        /// 点击按钮改变数量
        /// </summary>
        /// <param name="count"></param>
        /// <param name="id"></param>
        [HttpPost]
        [ActionName("Button")]
        public int UpdateCount(int count, int id)
        {
           return ShopCarRepoitory.UpdateCount( count, id);

        }
        /// <summary>
        /// 删除购物车中商品
        /// </summary>
        /// <param name="id"></param>
        [HttpPost]
        [ActionName("DeleteProduct")]
        public int DeleteProduct(string id)
        {
            return ShopCarRepoitory.DeleteProduct(id);
        }
        /// <summary>
        /// 点击修改选中状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        [HttpPost]
        [ActionName("UpdateState")]
        public int UpdateState(int id, int state)
        {
           return  ShopCarRepoitory.UpdateState(id,state);
        }
    }
}
