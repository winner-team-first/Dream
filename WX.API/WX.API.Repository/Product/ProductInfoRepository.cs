using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.IRepository.Product;
using WX.API.MODEL.Product;
using Dapper;
using MySql.Data.MySqlClient;

namespace WX.API.Repository.Product
{
    public class ProductInfoRepository : IProductInfoRepository
    {
        string str = ConfigurationManager.ConnectionStrings["ConnectionGzx"].ConnectionString;
        public List<ProductInfo> GetProductInfo()
        {
            using (MySqlConnection conn=new MySqlConnection(str))
            {
                return conn.Query<ProductInfo>("select * from ProductInfo").ToList();
            }
        }
    }
}
