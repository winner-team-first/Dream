using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web;
using WX.API.Model.Addresss;
using WX.API.IRepository.Addresss;
using WX.API.Repository.Address;

namespace WX.API.C2C.Controllers
{
    public class AddressController : ApiController
    {
        public IAddressRepository Addr { get; set; }

        /// <summary>
        /// 收货地址显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetAddressList")]
        public List<Address> GetAddressList()
        {
            var addressList = Addr.GetAddressList();
            return addressList;
        }

        /// <summary>
        /// 根据ID 删除地址信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("Delete")]
        public int Delete(int id)
        {
            int i = Addr.Delete(id);
            return i;
        }

        /// <summary>
        /// 地址添加
        /// </summary>
        /// <param name="Consignee"></param>
        /// <param name="Phone"></param>
        /// <param name="Province"></param>
        /// <param name="City"></param>
        /// <param name="County"></param>
        /// <param name="DetailedAddress"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("Add")]
        public int Add(string Consignee, string Phone, string Province, string City, string County, string DetailedAddress)
        {
            int i = Addr.Add(Consignee, Phone, Province, City, County, DetailedAddress);
            
            return i;
        }

        /// <summary>
        /// 根据ID查询地址信息用来反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetAddressById")]
        public Model.Addresss.Address GetAddressById(int id)
        {
            var result = Addr.GetAddressById(id);
            return result;
        }

        /// <summary>
        /// 地址修改
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("Update")]
        public int Update(string Consignee, string Phone, string Province, string City, string County, string DetailedAddress,int ID)
        {
            var i = Addr.Update(Consignee, Phone, Province, City, County, DetailedAddress,ID);
            return i;
        }

        /// <summary>
        /// 根据用户状态修改默认地址状态
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetStateByUserID")]
        public int GetStateByUserID(int UserID)
        {
            int i = Addr.GetStateByUserID(UserID);
            return i;
        }

        /// <summary>
        /// 根据ID设置默认地址
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetDefaultAddressById")]
        public int GetDefaultAddressById(int ID)
        {
            int i = Addr.GetDefaultAddressById(ID);
            return i;            
        }
    }
}
