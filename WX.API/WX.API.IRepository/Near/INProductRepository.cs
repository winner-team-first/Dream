using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.MODEL.Near;

namespace WX.API.IRepository.Near
{
    public interface INProductRepository
    {
        /// <summary>
        /// 显示Top5商品
        /// </summary>
        /// <returns></returns>
        List<ProductInfo> ShowProduct();
    }
}
