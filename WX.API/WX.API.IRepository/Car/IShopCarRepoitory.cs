﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.MODEL.Car;

namespace WX.API.IRepository.Car
{
    public interface IShopCarRepoitory
    {
        List<ShopCar> Show();
    }
}
