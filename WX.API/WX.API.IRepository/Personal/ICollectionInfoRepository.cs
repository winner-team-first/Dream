using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.IRepository.Personal
{
    using Model.Product;
    using WX.API.Model.Personal;
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


        List<OrderProductInfo> GetProductByOrderID(int orderId);

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
        /// <summary>
        /// 一键支付
        /// </summary>
        /// <returns></returns>
        int PayInformation(string id);
        /// <summary>
        /// 确认支付
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Payment(string id);
        /// <summary>
        /// 确认收货
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Confirm(string id);
        /// <summary>
        /// 取消订单
        /// </summary>
        /// <returns></returns>
        int DeleteOrderID(string id);
        /// <summary>
        /// 提醒商家
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Remind(string id);
    }
}
