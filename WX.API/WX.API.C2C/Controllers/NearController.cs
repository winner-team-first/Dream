using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WX.API.IRepository.Near;
using WX.API.MODEL.Near;

namespace WX.API.C2C.Controllers
{
    public class NearController : ApiController
    {
        //广告属性
        public IAdvertisingInfoRepository _advertisingRepository { set; get; }

        /// <summary>
        /// 显示广告
        /// </summary>
        /// 
        /// <returns></returns>
        [ActionName("ShowAdvertisingInfo")]
        [HttpPost]
        public List<AdvertisingInfo> ShowAdvertisingInfo()
        {
            List<AdvertisingInfo> advertisingInfoList = _advertisingRepository.ShowAdvertisingInfo();
            return advertisingInfoList;
        }
    }
}
