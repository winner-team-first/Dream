﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.Model.Car;

namespace WX.API.IRepository.Car
{
    public interface IShopCarRepoitory
    {
        List<ShopCar> GetShopCarList();

        int UpdateCount(int count, int id);

        int DeleteProduct(string id);

        int UpdateState(int id, int state);
    }
}
