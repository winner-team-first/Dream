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
    using Model.Product;

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
                var sql = "select a.ID ,a.OrderAddrPerson, b.OrderProductName ,b.OrderProductTotalPrice ,b.OrderProductNum , b.OrderProductPrice , a.OrderState ,b.OrderProductImg from OrderInfo a ,OrderProductInfo b where a.ID=b.OrderID";
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
                var sql = "";
                if (id=="0")
                {
                    sql = $"select * from orderinfo where userId=2 ";
                }
                else
                {
                    sql = $"select * from orderinfo where userId=2 and OrderState =" + id;
                }
                //var sql = "select a.ID ,b.OrderID,a.OrderAddrPerson, b.OrderProductName ,b.OrderProductTotalPrice ,b.OrderProductNum , b.OrderProductPrice , a.OrderState ,b.OrderProductImg from OrderInfo a ,OrderProductInfo b where a.ID=b.OrderID and a.OrderState =" + id;
                
                var allordersList = con.Query<Allorders>(sql).ToList();
                return allordersList;
            }
        }

        /// <summary>
        /// 根据OrderID 查询订单下的商品
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public List<OrderProductInfo> GetProduct(int OrderID)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {

                var sql = $"SELECT * FROM OrderProductInfo WHERE  OrderID={OrderID}";
                var ProList = con.Query<OrderProductInfo>(sql).ToList();
                return ProList;
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
                int i = con.Execute(sql);
                return i;
            }
        }
        /// <summary>
        /// 一键支付改状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int PayInformation(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                var sql = $"update OrderInfo set OrderState=3 where ID={id}";
                var i = con.Execute(sql);
                return i;
            }
        }
        /// <summary>
        /// 确认支付
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Payment(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                var sql = $"update OrderInfo set OrderState=3 where ID={id}";
                var i = con.Execute(sql);
                return i;
            }
        }

        public List<OrderProductInfo> GetProductByOrderID(int orderId)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {

                var sql = $"SELECT * from orderproductinfo WHERE OrderID={orderId}";
                var orderProList = con.Query<OrderProductInfo>(sql).ToList();
                return orderProList;
            }
        }

        /// <summary>
        /// 确认收货
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Confirm(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                var sql = $"update OrderInfo set OrderState=1 where ID={id}";
                var i = con.Execute(sql);
                return i;
            }
        }
        /// <summary>
        /// 取消订单
        /// </summary>
        /// <returns></returns>
        public int DeleteOrderID(string id)
        { 
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {
                string sql = $"delete from OrderInfo where ID={id}";
                int i = con.Execute(sql);
                string sqll = $"delete from OrderProductInfo where OrderID={id}";
                int j = con.Execute(sqll);
                if(i>0&&j>0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        /// <summary>
        /// 提醒商家
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Remind(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.FxwConnection))
            {

                var sql = $"update OrderInfo set OrderState=4 where ID={id}";
                var i = con.Execute(sql);
                return i;
            }
        }
    }
}
