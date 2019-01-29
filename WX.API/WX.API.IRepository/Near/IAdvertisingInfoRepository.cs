using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.MODEL.Near;

namespace WX.API.IRepository.Near
{
    public interface IAdvertisingInfoRepository
    {
        /// <summary>
        /// 显示广告
        /// </summary>
        /// <returns></returns>
        List<AdvertisingInfo> GetAdvertisingList();
    }
}
