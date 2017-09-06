using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core.RedisService;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;

namespace RedisService
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRedis redis1 = new MyRedis(0, 0);            
            redis1.Get("1234");

            for (int i = 0; i < 1000; i++)
            {
                ClientInfo c1 = new ClientInfo();
                c1.Id = new IdWorker(0, 0).nextIdUnique().ToString();
                c1.Source1 = "1234";
                c1.sc = "333";
                MyRedis redis = new MyRedis(0, 0);
                redis.Add(c1);
                List<ClientInfo> clist1 = redis.Get(c1.Source1);
                List<ClientInfo> clist2 = redis.Get("323");

                redis.Add(c1);
                redis.Add(c1);
                redis.Add(c1);

                int i1 = redis.Init();
                
                string url1 = "34345";
                string json1 = "34345";
                redis.Hash_Set<string>("ListOptionTypePage", url1, json1);

                St_TTimuDaXueErrorInfo t1 = new St_TTimuDaXueErrorInfo();
                t1._ErrJson = "123";
                t1._ErrorSum = 44411;
                t1._CreateTime = DateTime.Now;
                t1._AnswerSum = 1;
                t1._Id = 9999;
                bool bool1 = redis.Hash_SetTable<St_TTimuDaXueErrorInfo>("St_TTimuDaXueErrorInfo", t1.Id.ToString(), t1);

                St_TTimuDaXueErrorInfo t2 = redis.Hash_GetTable<St_TTimuDaXueErrorInfo>("St_TTimuDaXueErrorInfo", t1.Id.ToString());

                t2.ToString();
            }
            Console.ReadLine();
        }
    }

    public class Car
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
    }

    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Model
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public string Name { get; set; }
    }

}
