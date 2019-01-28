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
        /// <summary>
        /// 查询所有商品信息
        /// </summary>
        /// <returns></returns>
        List<ProductInfo> GetProductInfo();
        /// <summary>
        /// 根据商品ID查询所有详情图片
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        List<Img> GetImgByProductID(int ProductID);

    }
   
}
