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
        [HttpGet]
        public List<Allorders> GetAllorders()
        {
            var getallorders = CollectionInfoRepository.GetAllorders();
            return getallorders;
        }
        /// <summary>
        /// 订单状态
        /// </summary>
        [ActionName("GetNewOrders")]
        [HttpGet]
        public List<Allorders> GetNewOrdersStatus(string id)
        {
            var getnewOrders =  CollectionInfoRepository.GetNewOrdersStatus(id);
            return getnewOrders;
        }

        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        /// 
        [ActionName("GetDeleteById")]
        [HttpGet]
        public int DeleteById(string id)
        {
            var count= CollectionInfoRepository.DeleteById(id);
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
    }
}
