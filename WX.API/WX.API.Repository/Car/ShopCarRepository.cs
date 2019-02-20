using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.IRepository.Car;
using WX.API.Model.Car;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;
using WX.API.Common;
namespace WX.API.Repository.Car
{
    public class ShopCarRepository : IShopCarRepoitory
    {
        //获取购物车商品信息
        public List<ShopCar> GetShopCarList()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                var shopCarList = con.Query<ShopCar>("select a.ID,a.ProductCount,a.ProductState88 b.ProductName,b.ProductSummary,b.ProductImage,b.ProductPrice,b.ProductStock,b.ShopID FROM shopcar a INNER JOIN productinfo b on a.ProductId = b.ID where UID = 2").ToList();
                return shopCarList;
            }
        }
        //点击按钮加减商品
        public int UpdateCount(int count, int id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                var i =con.Execute("update ShopCar set ProductCount = " + count + " where ID = " + id + " ");
                return i;
            }
        }
        //购物车删除商品
        public int DeleteProduct(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
               var i =  con.Execute("delete from shopcar where ID in ("+id+")");
                return i;
            }
        }
        //修改状态
        public int UpdateState(int id,int state)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
               var i = con.Execute("update shopcar set productstate = "+state+" where ID ="+id+"");
                return i;
            }
        }
        /// <summary>
        /// 获取选中商品信息
        /// </summary>
        /// <returns></returns>
        public List<ShopCar> GetProductState()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                var productState = con.Query<ShopCar>("select a.ID,a.ProductCount,a.ProductId,a.ProductState, b.ProductName,b.ProductSummary,b.ProductImage,b.ProductPrice,b.ProductStock,b.ShopID FROM shopcar a INNER JOIN productinfo b on a.ProductId = b.ID where UID = 2 and a.productstate > 0 ").ToList();
                return productState;
            }
        }
        /// <summary>
        /// 获取地址
        /// </summary>
        /// <returns></returns>
        public List<UserAddress> GetAddress()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                var address = con.Query<UserAddress>("select * from address where userid =2 and defaultaddress = 1 ").ToList();
                return address;
            }
        }
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int AddOrderInfo(OrderInfo data)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                string sql = string.Format("insert into orderinfo (UserID,OrderProductMoney,OrderPaymoney,OrderDiscountsMoney,OrderAddrPerson,OrderAddrPhone,OrderAddres,OrderState,OrderCreateTime,OrderPayTime,OrderEndTime) values(2,'{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','2019-2-15 19:35:02','2019-2-15 19:35:02')", data.OrderProductMoney, data.OrderPaymoney, data.OrderDiscountsMoney, data.OrderAddrPerson, data.OrderAddrPhone, data.OrderAddres, 2,DateTime.Now);
                var i = con.Execute(sql);
                return i;
            }
        }
        public int AddOrderProduct(OrderProduct data)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                string orderidsql = "select * from orderinfo ORDER BY ID DESC  LIMIT 1";
                var orderid = con.Query<OrderInfo>(orderidsql).FirstOrDefault();
                string sql = string.Format("INSERT INTO orderproductinfo (OrderID,productinfoID,OrderProductName,orderproductNum,orderproductprice,orderproducttotalprice,orderproductimg,orderproducstatus) values({0},{1},'{2}',{3},{4},{5},'{6}',{7})",orderid.ID,data.ProductInfoID,data.OrderProductName,data.OrderProductNum,data.OrderProductPrice,data.OrderProductTotalPrice,data.OrderProductImg,data.OrderProductStatus);

                var i = con.Execute(sql);
                return i;
            }
        }

        
    }
}
