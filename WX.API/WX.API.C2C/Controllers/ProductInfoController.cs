using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WX.API.IRepository.Product;
using WX.API.Model.Car;
using WX.API.Model.Product;

namespace WX.API.C2C.Controllers
{
    public class ProductInfoController : ApiController
    {
        public IProductInfoRepository productInfoDal { get; set; }

        /// <summary>
        /// 查询所有商品信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProductInfo> GetProductInfos()
        {
            var productList= productInfoDal.GetProductInfo();
            return productList;
        }

        /// <summary>
        /// 根据名称查询商品信息
        /// </summary>
        /// <param name="proName"></param>
        /// <returns></returns>
        [HttpGet]
        public List<ProductInfo> GetProByName(string proName)
        {
            var productList = productInfoDal.GetProByName(proName);
            return productList;
        }

        /// <summary>
        /// 根据ID查看商品具体信息
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetProduct")]
        public ProductInfo GetProduct(int productID)
        {
            //获取商品信息
            List<ProductInfo> productInfoList = productInfoDal.GetProductInfo();
            //根据ID查询到某条数据
            ProductInfo productInfo = productInfoList.Where(m=>m.ID==productID).FirstOrDefault();
            //根据某条数据的ID查询到所属图片
            List<Img> imgList = productInfoDal.GetImgByProductID(productInfo.ID);
            //将查询到的图片依次添加到ImgList集合
            for (int i = 0; i < imgList.Count; i++)
            {
                productInfo.ImgList.Add(imgList[i]);
            }
            return productInfo;
        }

        /// <summary>
        /// 根据分类ID查询商品信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProductInfo> GetProductByClassfiyID(int ClassfiyId)
        {
            var productList = productInfoDal.GetProductByClassfiyID(ClassfiyId);
            return productList;
        }

        /// <summary>
        /// 添加到购物车
        /// </summary>
        /// <param name="shopCar"></param>
        /// <returns>受影响行数</returns>
        [HttpGet]
        public int AddShopCar(int productId)
        {
            var i = productInfoDal.AddShopCar(productId);
            return i;
        }
    }
}
