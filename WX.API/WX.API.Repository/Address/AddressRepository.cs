using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WX.API.IRepository.Address;
using WX.API.MODEL.Address;
using Dapper;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WX.API.Repository.Address
{
    public class AddressRepository : IAddressRepository
    {
        /// <summary>
        /// mysql用户刘嘉博的连接字符串
        /// </summary>
        string str = ConfigurationManager.ConnectionStrings["ConnectionLjb"].ConnectionString;

        /// <summary>
        /// 地址信息显示 
        /// </summary>
        /// <returns></returns>
        public List<MODEL.Address.Address> GetList()
        {
            using (MySqlConnection conn = new MySqlConnection(str))
            {
                conn.Open();
                List<MODEL.Address.Address> list = conn.Query<MODEL.Address.Address>("select * from Address").ToList();
                return list;
            }
        }
    }
}
