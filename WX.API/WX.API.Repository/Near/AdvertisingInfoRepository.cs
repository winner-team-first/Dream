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
    public class AdvertisingInfoRepository : IAdvertisingInfoRepository
    {


        /// <summary>
        /// 显示广告
        /// </summary>
        /// <returns></returns>
        public List<AdvertisingInfo> GetAdvertisingList()
        {
            using (IDbConnection con = new MySqlConnection(ConfigHelper.ZswConnection))
            {
                List<AdvertisingInfo> advertisingInfoList = con.Query<AdvertisingInfo>("select * from advertisinginfo").ToList();
                return advertisingInfoList;
            }
        }

     
    }
}
