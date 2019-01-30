using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web;
using WX.API.MODEL.Address;
using WX.API.IRepository.Address;
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
        public List<MODEL.Address.Address> GetAddressList()
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
    }
}
