using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WX.API.MODEL.Address
{
    public class Address
    {
        /// <summary>
        /// 地址表ID
        /// </summary>
        public int AddressID { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 省级ID
        /// </summary>
        public int ProvinceID { get; set; }

        /// <summary>
        /// 市级ID
        /// </summary>
        public int CityID { get; set; }

        /// <summary>
        /// 县级ID
        /// </summary>
        public int CountyID { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string DetailedAddress { get; set; }
    }
}