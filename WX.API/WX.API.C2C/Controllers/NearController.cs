using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WX.API.IRepository.Near;
using WX.API.Model.Near;

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


        /// <summary>
        /// 获得经纬度距离
        /// </summary>
        /// <param name="lat1"></param>
        /// <param name="lng1"></param>
        /// <param name="lat2"></param>
        /// <param name="lng2"></param>
        /// <returns></returns>
        [ActionName("GetDistance")]
        [HttpGet]
        public double GetDistance(double lat1, double lng1, double lat2, double lng2)
        {
            var radLat1 = (lat1 * Math.PI / 180.0);
            var radLat2 = (lat2 * Math.PI / 180.0);
            var a = radLat1 - radLat2;
            var b = (lng1 * Math.PI / 180.0) - (lng2 * Math.PI / 180.0);
            var distance = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2) +
            Math.Cos(radLat1) * Math.Cos(radLat2) * Math.Pow(Math.Sin(b / 2), 2)));
            distance = distance * 6378.137;// EARTH_RADIUS;
            distance = Math.Round(distance * 10000) / 10000;
            return distance;
        }


    }
}
