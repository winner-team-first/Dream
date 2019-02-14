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

        //商店
        public IShopInfoRepository ShopInfoRepository { set; get; }

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
        /// 显示附近2公里的商店
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        [ActionName("GetShopList")]
        [HttpGet]
        public List<ShopInfo> GetShopList(double latitude ,double longitude)
        {
            List<ShopInfo> shopInfos = ShopInfoRepository.GetShopInfos();

            List<ShopInfo> shopList = new List<ShopInfo>();
            foreach (var item in shopInfos)
            {
                double distance =  GetDistance(latitude, longitude, item.Shoplatitude, item.Shoplongitude);
                
                if (int.Parse(Math.Floor(distance).ToString())<=2)
                {
                    item.Distance = distance;
                    shopList.Add(item);
                }
            }
            return shopList;
        }

        /// <summary>
        /// 获得经纬度距离
        /// </summary>
        /// <param name="lat1"></param>
        /// <param name="lng1"></param>
        /// <param name="lat2"></param>
        /// <param name="lng2"></param>
        /// <returns></returns>
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
