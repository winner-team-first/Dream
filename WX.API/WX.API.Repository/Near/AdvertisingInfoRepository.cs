﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WX.API.IRepository.Near;
using WX.API.MODEL.Near;
using Dapper;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WX.API.Repository.Near
{
    public class AdvertisingInfoRepository : IAdvertisingInfoRepository
    {
        //获取连接字符串
        string str = ConfigurationManager.ConnectionStrings["ConnectionZsw"].ConnectionString;


        /// <summary>
        /// 显示广告
        /// </summary>
        /// <returns></returns>
        public List<AdvertisingInfo> ShowAdvertisingInfo()
        {
            using (IDbConnection con = new MySqlConnection(str) )
            {
                List<AdvertisingInfo> AdvertisingInfoList = con.Query<AdvertisingInfo>("select * from advertisinginfo").ToList();
                return AdvertisingInfoList;
            }
        }

     
    }
}
