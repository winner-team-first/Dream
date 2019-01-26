using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WX.API.IRepository.Product;
using WX.API.MODEL.Product;

namespace WX.API.C2C.Controllers
{
    public class ProductInfoController : ApiController
    {
        public IProductInfoRepository productInfoDal { get; set; }
        [HttpGet]
        public List<ProductInfo> GetProductInfos()
        {
            return productInfoDal.GetProductInfo();
        }
    }
}
