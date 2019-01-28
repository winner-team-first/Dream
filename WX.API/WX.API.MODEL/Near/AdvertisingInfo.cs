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
        public int ProductID { get; set; }
        public string ProductImg { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
