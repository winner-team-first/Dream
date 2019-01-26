using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.MODEL.Product;

namespace WX.API.IRepository.Product
{
    public interface IProductInfoRepository
    {
        List<ProductInfo> GetProductInfo();
        
    }
}
