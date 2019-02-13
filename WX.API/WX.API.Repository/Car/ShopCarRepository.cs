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
                var ShopCarList = con.Query<ShopCar>("select a.ID,a.ProductCount,a.ProductState, b.ProductName,b.ProductSummary,b.ProductImage,b.ProductPrice,b.ProductStock,b.ShopID FROM shopcar a INNER JOIN productinfo b on a.ProductId = b.ID where UID = 2").ToList();
                return ShopCarList;
            }
        }
        //点击按钮加减商品
        public void Button(int count, int id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                con.Execute("update ShopCar set ProductCount = " + count + " where ID = " + id + " ");
            }
        }
        //购物车删除商品
        public void DeleteProduct(string id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                con.Execute("delete from shopcar where ID in ("+id+")");
            }
        }
        //修改状态
        public void UpdateState(int id,int state)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                con.Execute("update shopcar set productstate = "+state+" where ID ="+id+"");
            }
        }
    }
}
