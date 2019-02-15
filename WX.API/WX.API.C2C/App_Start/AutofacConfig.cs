using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.WebApi;
using System.Web.Http;
using Autofac.Integration.Mvc;
using WX.API.IRepository.Near;
using WX.API.Repository.Near;
using WX.API.IRepository.Car;
using WX.API.Repository.Car;
using WX.API.IRepository.Product;
using WX.API.Repository.Product;
using WX.API.Repository.Personal;
using WX.API.IRepository.Personal;
using WX.API.IRepository.Addresss;
using WX.API.Repository.Address;

namespace WX.API.C2C
{
    public static class AutofacConfig
    {
        /// <summary>
        /// 项目初始化，实例化IOC容器
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);

            //注册所有的ApiControllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();

            //注册api容器需要使用HttpConfiguration对象
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        /// <summary>
        /// 将实现类与接口注入到IOC容器中
        /// </summary>
        /// <param name="builder"></param>
        public static void SetupResolveRules(ContainerBuilder container)
        {
            container.RegisterType<AdvertisingInfoRepository>().As<IAdvertisingInfoRepository>();//前面是Repository里面的方法 后面写他所继承的借口
            container.RegisterType<ShopCarRepository>().As<IShopCarRepoitory>();
            container.RegisterType<ProductInfoRepository>().As<IProductInfoRepository>();
            container.RegisterType<CollectionInfoRepository>().As<IRepository.Personal.ICollectionInfoRepository>();
            container.RegisterType<AddressRepository>().As<IAddressRepository>();
            container.RegisterType<NProductRepository>().As<INProductRepository>();
            container.RegisterType<ShopInfoRepository>().As<IShopInfoRepository>();
        }
    }
}