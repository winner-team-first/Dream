using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Repository.Personal
{
    using WX.API.IRepository.Personal;
    using WX.API.Model.Personal;
    using Dapper;
    using System.Data;
    using MySql.Data.MySqlClient;
    using System.Configuration;
    using WX.API.Common;
    public class CollectionInfoRepository : IRepository.Personal.ICollectionInfoRepository
    {

        /// <summary>
        /// 我的收藏(显示)
        /// </summary>
        /// <returns></returns>
        /// 
        public List<CollectionInfo> GetCollectionInfoList()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                return con.Query<CollectionInfo>("select b.ID, a.ProductName,a.ProductPrice, a.ProductStock,a.ProductImage from ProductInfo a,Collection b where a.ID=b.GoodsID").ToList();
            }
        }

        /// <summary>
        /// 所有订单显示
        /// </summary>
        /// <returns></returns>
        public List<Allorders> GetAllorders()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                return con.Query<Allorders>("select a.ID ,b.OrderProductName ,b.OrderProductTotalPrice ,b.OrderProductNum , b.OrderProductPrice , a.OrderState ,c.ProductImage  from OrderInfo a, OrderProductInfo b, ProductInfo c ").ToList();
            }
        }

        /// <summary>
        /// 新订单
        /// </summary>
        public List<Allorders> GetNewOrders(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                return con.Query<Allorders>("select a.OrderAddrPerson, a.ID ,b.OrderProductName,b.OrderProductTotalPrice,b.OrderProductNum , b.OrderProductPrice, a.OrderState,c.ProductImage from OrderInfo a, OrderProductInfo b, ProductInfo c where a.OrderState = " + id).ToList();
            }
        }

        /// <summary>
        /// Distribution配送中
        /// </summary>
        public List<Allorders> GetDistribution(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                return con.Query<Allorders>("select a.OrderAddrPerson '收件人',  a.ID 'ID',b.OrderProductName '名称',b.OrderProductTotalPrice '单价',b.OrderProductNum '数量', b.OrderProductPrice '总价', a.OrderState '状态',c.ProductImage '图片' from OrderInfo a, OrderProductInfo b, ProductInfo cwhere a.OrderState = " + id).ToList();
            }
        }

        /// <summary>
        /// Finish已完成
        /// </summary>
        public List<Allorders> GetFinishList(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                return con.Query<Allorders>("select a.OrderAddrPerson '收件人',  a.ID 'ID',b.OrderProductName '名称',b.OrderProductTotalPrice '单价',b.OrderProductNum '数量', b.OrderProductPrice '总价', a.OrderState '状态',c.ProductImage '图片' from OrderInfo a, OrderProductInfo b, ProductInfo cwhere a.OrderState = " + id).ToList();
            }
        }

        /// <summary>
        /// Cancel已取消
        /// </summary>
        public List<Allorders> GetCancel(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                return con.Query<Allorders>("select a.OrderAddrPerson '收件人',  a.ID 'ID',b.OrderProductName '名称',b.OrderProductTotalPrice '单价',b.OrderProductNum '数量', b.OrderProductPrice '总价', a.OrderState '状态',c.ProductImage '图片' from OrderInfo a, OrderProductInfo b, ProductInfo cwhere a.OrderState = " + id).ToList();
            }
        }

        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <returns></returns>
        public int GetDeleteById(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                string sql = "delete from Collection where ID=" + id;
                return con.Execute(sql);
            }
        }
    }
}
