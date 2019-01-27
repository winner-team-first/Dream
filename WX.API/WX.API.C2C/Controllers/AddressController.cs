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
        public IAddressRepository IAddr { get; set; }

        /// <summary>
        /// 收货地址显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<MODEL.Address.Address> GetList()
        {
            List<MODEL.Address.Address> list = IAddr.GetList();
            return list;
        }
    }
}
