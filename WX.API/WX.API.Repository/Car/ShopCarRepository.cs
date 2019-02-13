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
        public List<ShopCar> GetShopCarList()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                var ShopCarList = con.Query<ShopCar>("select a.ID,a.ProductCount,a.ProductState, b.ProductName,b.ProductSummary,b.ProductImage,b.ProductPrice,b.ProductStock,b.ShopID FROM shopcar a INNER JOIN productinfo b on a.ProductId = b.ID where UID = 2").ToList();
                return ShopCarList;
            }
        }
        public void Button(int count, int id)
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                con.Execute("update ShopCar set ProductCount = " + count + " where ID = " + id + " ");
            }
        }
        public List<ShopCar> Lost()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.LhjConnection))
            {
                return con.Query<ShopCar>("select a.ShopCarId,a.ProductCount,a.ProductState, b.ProductName,b.ProductSummary,b.ProductImage,b.ProductPrice,b.ProductStock,b.ShopID FROM shopcar a INNER JOIN productinfo b on a.ProductId = b.ProductID where UID = 2").ToList();
            }
        }

        
    }
}
