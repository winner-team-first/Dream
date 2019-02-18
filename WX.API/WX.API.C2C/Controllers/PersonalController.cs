using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WX.API.C2C.Controllers
{
    using WX.API.Model.Personal;
    using WX.API.IRepository.Personal;

    public class PersonalController : ApiController
    {
        public ICollectionInfoRepository CollectionInfoRepository { get; set; }

        /// <summary>
        /// 我的收藏(显示)
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public List<CollectionInfo> GetCollectionInfoList()
        {
            List<CollectionInfo> getcollectionInfoList = CollectionInfoRepository.GetCollectionInfoList();
            return getcollectionInfoList;
        }
        /// <summary>
        /// 所有订单显示
        /// </summary>
        /// <returns></returns>
        [ActionName("GetAllorders")]
        [HttpGet]
        public List<Allorders> GetAllorders()
        {
            var getallorders = CollectionInfoRepository.GetAllorders();
            return getallorders;
        }

        /// <summary>
        /// 根据不同订单状态查询订单
        /// </summary>
        [ActionName("GetNewOrdersByStatu")]
        [HttpGet]
        public List<Allorders> GetNewOrdersByStatu(string id)
        {
            List<Allorders> getOrders = CollectionInfoRepository.GetNewOrdersStatus(id);

            foreach (var item in getOrders)
            {
                List<OrderProductInfo> orderProducts = CollectionInfoRepository.GetProductByOrderID(item.ID);
                foreach (var orderProduct in orderProducts)
                {
                    item.Products.Add(orderProduct);
                }
            }
            return getOrders;
        }

        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        [ActionName("GetDeleteById")]
        [HttpGet]
        public int DeleteById(string id)
        {
            var count = CollectionInfoRepository.DeleteById(id);
            return count;
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            var count = CollectionInfoRepository.Delete(id);
            return count;
        }

        /// <summary>
        /// 一键支付该状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ActionName("PayInformation")]
        [HttpGet]
        public int PayInformation(string id)
        {
            int i = CollectionInfoRepository.PayInformation(id);
            return i;
        }

        /// <summary>
        /// 确认支付
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ActionName("Payment")]
        [HttpGet]
        public int Payment(string id)
        {
            int i = CollectionInfoRepository.Payment(id);
            return i;
        }
    }
}
