using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.IRepository.Near;
using WX.API.Model.Near;
using Dapper;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using WX.API.Common;


namespace WX.API.Repository.Near
{
    public class ShopInfoRepository:IShopInfoRepository
    {
        /// <summary>
        /// 显示商家
        /// </summary>
        /// <returns></returns>
        public List<ShopInfo> GetShopInfos()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.ZswConnection))
            {
                List<ShopInfo> shopList = con.Query<ShopInfo>("select * from shopinfo").ToList();
                return shopList;
            }
        }
    }
}
