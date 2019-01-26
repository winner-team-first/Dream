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
    public class AdvertisingInfoRepository : IAdvertisingInfoRepository
    {
        string str = ConfigurationManager.ConnectionStrings["ConnectionZsw"].ConnectionString;
        public List<AdvertisingInfo> Show()
        {
            using (IDbConnection con = new MySqlConnection(str) )
            {
                List<AdvertisingInfo> list= con.Query<AdvertisingInfo>("select * from advertisinginfo").ToList();
                return list;
            }
        }
    }
}
