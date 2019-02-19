﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.Model.Car
{
    public class OrderProduct
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductInfoID { get; set; }
        public string OrderProductName { get; set; }
        public int OrderProductNum { get; set; }
        public decimal OrderProductPrice { get; set; }
        public decimal OrderProductTotalPrice { get; set; }
        public string OrderProductImg { get; set; }
        public int OrderProductStatus { get; set; }


    }
}
