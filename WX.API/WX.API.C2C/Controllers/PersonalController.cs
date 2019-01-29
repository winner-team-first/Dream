using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WX.API.C2C.Controllers
{
    using MODEL.Personal;
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
        /// 新订单
        /// </summary>
        public List<Allorders> GetNewOrders(string id)
        {
            var getnewOrders =  CollectionInfoRepository.GetNewOrders(id);
            return getnewOrders;
        }
        /// <summary>
        /// Distribution配送中
        /// </summary>
        public List<Allorders> GetDistribution(string id)
        {
            var getdistribution =  CollectionInfoRepository.GetDistribution(id);
            return getdistribution;
        }

        /// <summary>
        /// Finish已完成
        /// </summary>
        public List<Allorders> GetFinishList(string id)
        {
            var getfinishlist= CollectionInfoRepository.GetFinishList(id);
            return getfinishlist;
        }
        /// <summary>
        /// Cancel已取消
        /// </summary>
        public List<Allorders> GetCancel(string id)
        {
            var cncelhowlist= CollectionInfoRepository.GetCancel(id);
            return cncelhowlist;
        }
        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        /// 
        [ActionName("GetDeleteById")]
        [HttpGet]
        public int GetDeleteById(string id)
        {
            var getid= CollectionInfoRepository.GetDeleteById(id);
            return getid;
        }
    }
}
