using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WX.API.MODEL.Address;

namespace WX.API.IRepository.Address
{
    public interface IAddressRepository
    {
        /// <summary>
        /// 地址显示
        /// </summary>
        /// <returns></returns>
        List<WX.API.MODEL.Address.Address> GetAddressList();

        /// <summary>
        /// 根据ID 删除地址
        /// </summary>
        int Delete(int id);

        
    }
}
