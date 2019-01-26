using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WX.API.MODEL.Car;
using WX.API.IRepository.Car;

namespace WX.API.C2C.Controllers
{
    public class ShopCarController : ApiController
    {
        public IShopCarRepoitory ShopCarRepoitory { get; set; }

        [HttpGet]
        [ActionName("Show")]
        public List<ShopCar> Show()
        {
            return ShopCarRepoitory.Show(); 
        }
    }
}
