using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WX.API.IRepository.Address;
using WX.API.Model.Address;
using Dapper;
using MySql.Data.MySqlClient;
using System.Configuration;
using WX.API.Common;

namespace WX.API.Repository.Address
{
    public class AddressRepository : IAddressRepository
    {
        /// <summary>
        /// 地址添加
        /// </summary>
        /// <param name="Consignee"></param>
        /// <param name="Phone"></param>
        /// <param name="Province"></param>
        /// <param name="City"></param>
        /// <param name="County"></param>
        /// <param name="DetailedAddress"></param>
        /// <param name="Code"></param>
        /// <returns></returns>
        public int Add(string Consignee, string Phone, string Province, string City, string County, string DetailedAddress)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigHelper.LjbConnection))
            {
                int i = conn.Execute("insert into address values(NULL,'" + Consignee + "','" + Phone + "','" + Province + "','" + City + "','" + County + "','" + DetailedAddress + "')");
                return i;
            }
        }

        /// <summary>
        /// 根据ID删除地址
        /// </summary>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigHelper.LjbConnection))
            {
                int i = conn.Execute("delete from Address where ID = " + id);
                return i;
            }
        }

        /// <summary>
        /// 地址信息显示 
        /// </summary>
        /// <returns></returns>
        public List<WX.API.Model.Address.Address> GetAddressList()
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigHelper.LjbConnection))
            {
                List<WX.API.Model.Address.Address> addressList = conn.Query<WX.API.Model.Address.Address>("select * from Address").ToList();
                return addressList;
            }
        }

        List<Model.Address.Address> IAddressRepository.GetAddressList()
        {
            throw new NotImplementedException();
        }
    }
}
