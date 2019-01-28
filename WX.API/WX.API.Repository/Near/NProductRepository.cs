using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.IRepository.Near;
using WX.API.MODEL.Near;
using Dapper;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace WX.API.Repository.Near
{
    public class NProductRepository : INProductRepository
    {
        //获取连接字符串
        string str = ConfigurationManager.ConnectionStrings["ConnectionZsw"].ConnectionString;
        /// <summary>
        /// 显示销量Top-5
        /// </summary>
        /// <returns></returns>
        public List<ProductInfo> ShowProduct()
        {
            using (IDbConnection con = new MySqlConnection(str))
            {
                List<ProductInfo> ProductInfoList = con.Query<ProductInfo>("select * from productinfo order by ProductSales desc limit 0,5").ToList();
                return ProductInfoList;
            }
        }
    }
}
