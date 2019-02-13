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
                var sql = "select b.ID, a.ProductName,a.ProductPrice, a.ProductStock,a.ProductImage from ProductInfo a,Collection b where a.ID=b.GoodsID";
                var collectionlist = con.Query<CollectionInfo>(sql).ToList();
                return collectionlist;
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
                var sql = "select a.ID ,a.OrderAddrPerson, b.OrderProductName ,b.OrderProductTotalPrice ,b.OrderProductNum , b.OrderProductPrice , a.OrderState ,c.ProductImage  from OrderInfo a, OrderProductInfo b, ProductInfo c ";
                var orderlist = con.Query<Allorders>(sql).ToList();
                return orderlist;
            }
        }

        /// <summary>
        /// 订单状态
        /// </summary>
        public List<Allorders> GetNewOrdersStatus(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                var sql = "select a.OrderAddrPerson, a.ID ,b.OrderProductName,b.OrderProductTotalPrice,b.OrderProductNum , b.OrderProductPrice, a.OrderState,c.ProductImage from OrderInfo a, OrderProductInfo b, ProductInfo c where a.OrderState = " + id;
                var allordersList = con.Query<Allorders>(sql).ToList();
                return allordersList;
            }
        }

        /// <summary>
        /// 取消收藏
        /// </summary>
        /// <returns></returns>
        public int DeleteById(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                string sql = "delete from Collection where ID=" + id;
                return con.Execute(sql);
            }
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                var sql = $"delete from OrderInfo where UserID={id}";
                int i= con.Execute(sql);
                return i;
            }
        }
    }
}
