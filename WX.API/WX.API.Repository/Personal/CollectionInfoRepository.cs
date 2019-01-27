using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Repository.Personal
{
    using WX.API.IRepository.Personal;
    using MODEL.Personal;
    using Dapper;
    using System.Data;
    using MySql.Data.MySqlClient;
    using System.Configuration;
    public class CollectionInfoRepository : ICollectionInfoRepository
    {
        string conn = ConfigurationManager.ConnectionStrings["ConnectionFxw"].ConnectionString;
        /// <summary>
        /// 我的收藏(显示)
        /// </summary>
        /// <returns></returns>
        public List<CollectionInfo> CollectionInfoShow(string pid)
        {
            using (IDbConnection con = new MySqlConnection(conn))
            {
                return con.Query<CollectionInfo>("select b.OrderProductName,b.OrderProductName from CollectionInfo a ,OrderGoods b where a.GoodsID=b.OrderGoodsID and OrderGoodsID="+pid).ToList();
            }
        }
        /// <summary>
        /// 所有订单显示
        /// </summary>
        /// <returns></returns>
        public List<Allorders> AllordersShow()
        {
            using (IDbConnection con = new MySqlConnection(conn))
            {
                return con.Query<Allorders>("select a.OrderNum 编号, b.OrderProductName 名称,b.OrderProductTotalPrice 单价,b.GoodsNum 数量,b.OrderProductPrice 总价 ,a.OrderStatus 状态 ,c.GoodsImage 图片 from OrderForm a , OrderGoods b , GoodsInfo c").ToList();
            }
        }
        /// <summary>
        /// 新订单
        /// </summary>
        public List<Allorders> NewOrdersShow(string pid)
        {
            using (IDbConnection con = new MySqlConnection(conn))
            {
                return con.Query<Allorders>("select a.OrderNum 编号, b.OrderProductName 名称,b.OrderProductTotalPrice 单价,b.GoodsNum 数量,b.OrderProductPrice 总价 ,a.OrderStatus 状态 ,c.GoodsImage 图片 from OrderForm a , OrderGoods b , GoodsInfo c where a.OrderStatus="+pid).ToList();
            }
        }
        /// <summary>
        /// Distribution配送中
        /// </summary>
        public List<Allorders> DistributionShow(string pid)
        {
            using (IDbConnection con = new MySqlConnection(conn))
            {
                return con.Query<Allorders>("select a.OrderNum 编号, b.OrderProductName 名称,b.OrderProductTotalPrice 单价,b.GoodsNum 数量,b.OrderProductPrice 总价 ,a.OrderStatus 状态 ,c.GoodsImage 图片 from OrderForm a , OrderGoods b , GoodsInfo c where a.OrderStatus=" + pid).ToList();
            }
        }
        /// <summary>
        /// Finish已完成
        /// </summary>
        public List<Allorders> FinishShow(string pid)
        {
            using (IDbConnection con = new MySqlConnection(conn))
            {
                return con.Query<Allorders>("select a.OrderNum 编号, b.OrderProductName 名称,b.OrderProductTotalPrice 单价,b.GoodsNum 数量,b.OrderProductPrice 总价 ,a.OrderStatus 状态 ,c.GoodsImage 图片 from OrderForm a , OrderGoods b , GoodsInfo c where a.OrderStatus=" + pid).ToList();
            }
        }
        /// <summary>
        /// Cancel已取消
        /// </summary>
        public List<Allorders> CancelShow(string pid)
        {
            using (IDbConnection con = new MySqlConnection(conn))
            {
                return con.Query<Allorders>("select a.OrderNum 编号, b.OrderProductName 名称,b.OrderProductTotalPrice 单价,b.GoodsNum 数量,b.OrderProductPrice 总价 ,a.OrderStatus 状态 ,c.GoodsImage 图片 from OrderForm a , OrderGoods b , GoodsInfo c where a.OrderStatus=" + pid).ToList();
            }
        }
    }
}
