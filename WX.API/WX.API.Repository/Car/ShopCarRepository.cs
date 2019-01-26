using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.IRepository.Car;
using WX.API.MODEL.Car;
using System.Configuration;

namespace WX.API.Repository.Car
{
    public class ShopCarRepository : IShopCarRepoitory
    {
        string str = ConfigurationManager.ConnectionStrings["ConnectionLhj"].ConnectionString;

        public List<ShopCar> Show()
        {
            throw new NotImplementedException();
        }
    }
}
