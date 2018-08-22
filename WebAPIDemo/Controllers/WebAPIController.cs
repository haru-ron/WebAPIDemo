using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class WebAPIController : ApiController
    {
        #region 対象データ初期化
        List<MyModel> _models = new List<MyModel>()
        {
            new MyModel(){ID=1,Name="渋谷"},
            new MyModel(){ID=2,Name="表参道"},
            new MyModel(){ID=3,Name="青山一丁目"},
            new MyModel(){ID=4,Name="永田町"},
            new MyModel(){ID=5,Name="半蔵門"},
            new MyModel(){ID=6,Name="九段下"},
            new MyModel(){ID=7,Name="神保町"},
            new MyModel(){ID=8,Name="大手町"},
            new MyModel(){ID=9,Name="三越前"},
            new MyModel(){ID=10,Name="水天宮前"},
            new MyModel(){ID=11,Name="清澄白河"},
            new MyModel(){ID=12,Name="住吉"},
            new MyModel(){ID=13,Name="錦糸町"},
            new MyModel(){ID=14,Name="押上"}
        };
        #endregion 

        /// <summary>
        /// 一覧を取得します
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MyModel> Get()
        {
            return _models;
        }

        /// <summary>
        /// 該当するIDのデータを取得します
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MyModel Get(int id)
        {
            return _models
                   .SingleOrDefault(x => x.ID == id)
                   ?? new MyModel() { ID = -1, Name = "見つかりません" };
        }

        /*
         * Memo: Put, Post などで model を受け取る場合には、
         * パラメーターに FromBody などで修飾する必要があります
         */ 
    }
}
