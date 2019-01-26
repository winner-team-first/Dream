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
        List<AdvertisingInfo> Show();

    }
}
