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
        List<WX.API.MODEL.Address.Address> GetList();
    }
}
