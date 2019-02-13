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
        /// 订单状态
        /// </summary>
        List<Allorders> GetNewOrdersStatus(string id);
        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        int DeleteById(string id);
        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(string id);
    }
}
