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
        public IAdvertisingInfoRepository AdvertisingRepository { set; get; }

        //Top-5商品
        public INProductRepository NProductRepository { set; get; }


        /// <summary>
        /// 显示广告
        /// </summary>
        /// 
        /// <returns></returns>
        [ActionName("GetAdvertisingList")]
        [HttpPost]
        public List<AdvertisingInfo> GetAdvertisingList()
        {
            List<AdvertisingInfo> advertisingInfoList = AdvertisingRepository.GetAdvertisingList();
            return advertisingInfoList;
        }



        /// <summary>
        /// 显示产品
        /// </summary>
        /// <returns></returns>
        [ActionName("GetProductList")]
        [HttpGet]
        public List<ProductInfo> GetProductList()
        {
            List<ProductInfo> productList = NProductRepository.GetProductList();
            return productList;
        }
    }
}
