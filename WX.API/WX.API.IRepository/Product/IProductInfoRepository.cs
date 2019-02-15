using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.Model.Product;
using WX.API.Model.Car;

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
        /// 添加到收藏
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        int AddCollection(int productId);

        /// <summary>
        /// 删除收藏
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DelCollection(int id);

        /// <summary>
        /// 根据商品ID查询所有详情图片
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        List<Img> GetImgByProductID(int productID);

        /// <summary>
        /// 根据分类ID查询商品
        /// </summary>
        /// <returns></returns>
        List<ProductInfo> GetProductByClassfiyID(int classfiyId);

        /// <summary>
        /// 根据商品名称查询商品
        /// </summary>
        /// <param name="proName"></param>
        /// <returns></returns>
        List<ProductInfo> GetProByName(string proName);

        /// <summary>
        /// 添加到购物车
        /// </summary>
        /// <param name="shopCar"></param>
        /// <returns></returns>
        int AddShopCar(int productId);
    }

}
