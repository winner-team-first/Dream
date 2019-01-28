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
        public IAdvertisingInfoRepository AdvertisingDal { set; get; }

        [ActionName("Show")]
        [HttpPost]
        public List<AdvertisingInfo> Show()
        {
            List<AdvertisingInfo> list = AdvertisingDal.Show();
            return list;
        }

        [ActionName("ShowProduct")]
        [HttpGet]
        public List<ProductInfo> ShowProduct()
        {
            List<ProductInfo> list = AdvertisingDal.ShowProduct();
            return list;
        }
    }
}
