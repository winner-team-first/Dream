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
        public ICollectionInfoRepository ICollectionInfoRepository { get; set; }

        /// <summary>
        /// 我的收藏(显示)
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public List<CollectionInfo> CollectionInfoShow()
        {
            List<CollectionInfo>list= ICollectionInfoRepository.CollectionInfoShow();
            return list;
        }
        /// <summary>
        /// 所有订单显示
        /// </summary>
        /// <returns></returns>
        public List<Allorders> AllordersShow()
        {
            return ICollectionInfoRepository.AllordersShow();
        }
        /// <summary>
        /// 新订单
        /// </summary>
        public List<Allorders> NewOrdersShow(string pid)
        {
            return ICollectionInfoRepository.NewOrdersShow(pid);
        }
        /// <summary>
        /// Distribution配送中
        /// </summary>
        public List<Allorders> DistributionShow(string pid)
        {
            return ICollectionInfoRepository.DistributionShow(pid);
        }

        /// <summary>
        /// Finish已完成
        /// </summary>
        public List<Allorders> FinishShow(string pid)
        {
            return ICollectionInfoRepository.FinishShow(pid);
        }
        /// <summary>
        /// Cancel已取消
        /// </summary>
        public List<Allorders> CancelShow(string pid)
        {
            return ICollectionInfoRepository.CancelShow(pid);
        }
        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        /// 
        [ActionName("Delete_CollectionInfoShow")]
        [HttpGet]
        public int Delete_CollectionInfoShow(string pid)
        {
            return ICollectionInfoRepository.Delete_CollectionInfoShow(pid);
        }
    }
}
