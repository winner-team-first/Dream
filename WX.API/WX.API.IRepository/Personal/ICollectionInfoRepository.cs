using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.IRepository.Personal
{
    using WX.API.MODEL.Personal;
    public interface ICollectionInfoRepository
    {
        /// <summary>
        /// 我的收藏(显示)
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        List<CollectionInfo> CollectionInfoShow(string pid);
        /// <summary>
        /// 所有订单
        /// </summary>
        /// <returns></returns>
        List<Allorders> AllordersShow();
        /// <summary>
        /// 新订单
        /// </summary>
        List<Allorders> NewOrdersShow(string pid);
        /// <summary>
        /// Distribution配送中
        /// </summary>
        List<Allorders> DistributionShow(string pid);
        /// <summary>
        /// Finish已完成
        /// </summary>
        List<Allorders> FinishShow(string pid);

        /// <summary>
        /// Cancel已取消
        /// </summary>
        List<Allorders> CancelShow(string pid);
    }
}
