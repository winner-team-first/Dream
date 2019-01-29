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
        List<CollectionInfo> GetCollectionInfoList();
        /// <summary>
        /// 所有订单
        /// </summary>
        /// <returns></returns>
        List<Allorders> GetAllorders();
        /// <summary>
        /// 新订单
        /// </summary>
        List<Allorders> GetNewOrders(string id);
        /// <summary>
        /// Distribution配送中
        /// </summary>
        List<Allorders> GetDistribution(string id);
        /// <summary>
        /// Finish已完成
        /// </summary>
        List<Allorders> GetFinishList(string id);

        /// <summary>
        /// Cancel已取消
        /// </summary>
        List<Allorders> GetCancel(string id);
        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        int GetDeleteById(string id);
    }
}
