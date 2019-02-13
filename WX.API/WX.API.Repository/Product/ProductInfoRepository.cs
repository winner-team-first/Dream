using System;
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
        /// 根据商品ID查询所有商品详情图片
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public List<Img> GetImgByProductID(int ProductID)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var imgList= conn.Query<Img>("select * from img where ProductID=" + ProductID + "").ToList();
                return imgList;
            }
        }

        /// <summary>
        /// 根据分类ID查询商品信息
        /// </summary>
        /// <returns></returns>
        public List<ProductInfo> GetProductByClassfiyID(int ClassfiyId)
        {
            using (MySqlConnection conn=new MySqlConnection(ConfigHelper.GzxConnection))
            {
                var ProductList = conn.Query<ProductInfo>("SELECT * from productinfo WHERE ClassifyID =" + ClassfiyId + "").ToList();
                return ProductList;
            }
        }
    }
}
