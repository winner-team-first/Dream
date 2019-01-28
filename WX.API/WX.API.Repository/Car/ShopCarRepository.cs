﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.IRepository.Car;
using WX.API.MODEL.Car;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using Dapper;
namespace WX.API.Repository.Car
{
    public class ShopCarRepository : IShopCarRepoitory
    {
        string str = ConfigurationManager.ConnectionStrings["ConnectionLhj"].ConnectionString;

        public List<ShopCar> Show()
        {
            using (IDbConnection con = new MySqlConnection(str))
            {
                return con.Query<ShopCar>("select a.ShopCarId,a.ProductCount,a.ProductState, b.ProductName,b.ProductSummary,b.ProductImage,b.ProductPrice,b.ProductStock,b.ShopID FROM shopcar a INNER JOIN productinfo b on a.ProductId = b.ProductID where UID = 2").ToList();
            }
        }
    }
}
