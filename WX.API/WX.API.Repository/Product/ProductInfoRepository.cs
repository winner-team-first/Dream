﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.IRepository.Product;
using WX.API.Model.Product;
using Dapper;
using MySql.Data.MySqlClient;
using WX.API.Common;
using WX.API.Model.Car;

namespace WX.API.Repository.Product
{
    public class ProductInfoRepository : IProductInfoRepository
    {
   
        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
        public List<ProductInfo> GetProductInfo()
        {
            using (MySqlConnection conn=new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var productList= conn.Query<ProductInfo>("select * from ProductInfo").ToList();
                return productList;
            }
        }

        /// <summary>
        /// 添加到收藏
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public int AddCollection(int productId)
        {
            using (MySqlConnection conn=new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var sql = $"INSERT INTO collection(UserID,GoodsID) VALUES(2,{productId})";
                var i = conn.Execute(sql);
                return i;
            }
        }

        /// <summary>
        /// 删除收藏
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelCollection(int id)
        {
            using (MySqlConnection conn=new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var sql = $"DELETE FROM collection WHERE GoodsID={id}";
                var i= conn.Execute(sql);
                return i;
            }
        }

        /// <summary>
        /// 根据商品ID查询所有商品详情图片
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public List<Img> GetImgByProductID(int productID)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var imgList= conn.Query<Img>("select * from img where ProductID=" + productID ).ToList();
                return imgList;
            }
        }

        /// <summary>
        /// 根据分类ID查询商品信息
        /// </summary>
        /// <returns></returns
        public List<ProductInfo> GetProductByClassfiyID(int classfiyId)
        {
            using (MySqlConnection conn=new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var productList = conn.Query<ProductInfo>("SELECT * from productinfo WHERE ClassifyID =" + classfiyId ).ToList();
                return productList;
            }
        }

        /// <summary>
        /// 根据名称查询商品信息
        /// </summary>
        /// <param name="proName"></param>
        /// <returns></returns>
        public List<ProductInfo> GetProByName(string proName)
        {
            using (MySqlConnection conn=new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var sql = $"SELECT * FROM productinfo WHERE ProductName LIKE '%{proName}%'";
                var productList = conn.Query<ProductInfo>(sql).ToList();
                return productList;
            }
        }

        /// <summary>
        /// 添加到购物车
        /// </summary>
        /// <param name="shopCar"></param>
        /// <returns>受影响行数</returns>
        public int AddShopCar(int productId)
        {
            using (MySqlConnection conn=new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var sqlOne = "select * from shopcar where UId=2 and ProductId="+productId;
                var resOne = conn.Query<ShopCar>(sqlOne).FirstOrDefault();
                if (resOne!=null)
                {
                    var sqlTwo = "update shopcar set ProductCount=ProductCount+1 where UId=2 and ProductId=" + productId;
                    var resTwo = conn.Execute(sqlTwo);
                    return resTwo;
                }
                else
                {
                    var sqlTwo = $"insert into shopcar(productId,UId,ProductCount,ProductState) VALUES({productId},2,1,0)";
                    var resTwo = conn.Execute(sqlTwo);
                    return resTwo;
                }
                
            }
        }

       
    }
}
