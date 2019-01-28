using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.MODEL.Near
{
    public class AdvertisingInfo
    {
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ProductImg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
