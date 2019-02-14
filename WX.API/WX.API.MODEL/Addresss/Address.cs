using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WX.API.Model.Addresss
{
    public class Address
    {
        /// <summary>
        /// 地址表ID
        /// </summary>
        public int ID { get; set; }

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
        public string Province { get; set; }

        /// <summary>
        /// 市级ID
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 县级ID
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        public string DetailedAddress { get; set; }
    }
}