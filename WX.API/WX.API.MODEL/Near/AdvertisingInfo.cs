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
        /// 广告ID
        /// </summary>
        public int ProductID { get; set; }


        /// <summary>
        /// 广告图片
        /// </summary>
        public string ProductImg { get; set; }


        /// <summary>
        /// 广告开始时间
        /// </summary>
        public DateTime CreateTime { get; set; }


        /// <summary>
        /// 广告结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
