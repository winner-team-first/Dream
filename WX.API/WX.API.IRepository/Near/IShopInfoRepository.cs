using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.Model.Near;
namespace WX.API.IRepository.Near
{
    public interface IShopInfoRepository
    {
        /// <summary>
        /// 获取商店信息
        /// </summary>
        /// <returns></returns>
        List<ShopInfo> GetShopInfos();
    }
}
