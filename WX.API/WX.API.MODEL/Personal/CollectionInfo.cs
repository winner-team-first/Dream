using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.API.MODEL.Personal
{
    /// <summary>
    /// 我的收藏
    /// </summary>
    public class CollectionInfo
    {
        public int CollectionInfoID { get; set; }
        public int UserID { get; set; }
        public int GoodsID { get; set; }
    }
}
