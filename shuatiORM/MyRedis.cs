using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RedisService;
using AgileFrame.Core.RedisService;
using AgileFrame.Orm.PersistenceLayer.Model;
using ServiceStack.Redis;
using AgileFrame.Core;

namespace AgileFrame.Orm.PersistenceLayer.BLL.Base
{
    public class MyRedis : RedisBase
    {
        public static MyRedis redis = new MyRedis();
        public static MyRedis Factory()
        {
            return redis;
        }
        public MyRedis()
            : base()
        {
        }

        public MyRedis(long workerId, long datacenterId)
            : base(workerId, datacenterId)
        {
        }
        public static bool isInit = false;
        public int Init()
        {
            if (!isInit)
            {
                try
                {
                    List<ClientInfo> clist = this.GetAll();
                    foreach (ClientInfo c2 in clist)
                    {
                        if (!this.Hash_Exist<ClientInfo>("ClientInfo", c2.Source1))
                        {
                            this.Hash_Set<ClientInfo>("ClientInfo", c2.Source1, c2);
                        }
                    }
                }
                catch (Exception ex)
                {
                    RedisManager.isOK = false;
                }
                isInit = true;
            }
            return this.Hash_Count("ClientInfo");
        }
        /// <summary>
        /// 存储数据到hash表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <returns></returns>
        public new bool Hash_Set<T>(string key, string dataKey, T t)
        {
            if (string.IsNullOrEmpty(dataKey) || !RedisManager.isOK)
                return false;

            try
            {
                using (IRedisClient redis = RedisManager.GetClient())
                {
                    string value = null;
                    string n2 = typeof(T).Name.ToLower();
                    if ("string.long.int32.int16.bool".Contains(n2))
                        value = Convert.ToString(t);
                    else
                    {
                        string n1 = typeof(T).FullName.ToLower();
                        if (n1.StartsWith("agileFrame.orm.persistenceLayer.model"))
                        {
                            throw new Exception("请调用另一种接口");
                        }
                        else
                        {
                            value = ServiceStack.Text.JsonSerializer.SerializeToString<T>(t);
                        }
                    }
                    return redis.SetEntryInHash(key, dataKey, value);
                }
            }
            catch (Exception ex)
            {
                RedisManager.isOK = false;
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        /// <summary>
        /// 存储数据到hash表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <returns></returns>
        public bool Hash_SetTable<MyTable>(string key, string dataKey, MyTable t) where MyTable : ITableImplement, new()
        {
            if (string.IsNullOrEmpty(dataKey) || !RedisManager.isOK)
                return false;
            try
            {
                using (IRedisClient redis = RedisManager.GetClient())
                {
                    string value = new JsonServiceBase().ToJson<MyTable>(t);
                    return redis.SetEntryInHash(key, dataKey, value);
                }
            }
            catch (Exception ex)
            {
                RedisManager.isOK = false;
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        /// <summary>
        /// 从hash表获取数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="dataKey"></param>
        /// <returns></returns>
        public MyTable Hash_GetTable<MyTable>(string key, string dataKey) where MyTable : ITableImplement, new()
        {
            if (string.IsNullOrEmpty(dataKey) || !RedisManager.isOK)
                return default(MyTable);
            try
            {
                using (IRedisClient redis = RedisManager.GetReadOnlyClient())
                {
                    string value = redis.GetValueFromHash(key, dataKey);
                    MyTable mytable = new MyTable();
                    new JsonServiceBase().FromJson<MyTable>(mytable, value);
                    return mytable;
                }
            }
            catch (Exception ex)
            {
                RedisManager.isOK = false;
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
        /// <summary>
        /// 获取整个hash的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<MyTable> Hash_GetAllTable<MyTable>(string key) where MyTable : ITableImplement, new()
        {
            if (string.IsNullOrEmpty(key) || !RedisManager.isOK)
                return null;
            try
            {
                using (IRedisClient redis = RedisManager.GetReadOnlyClient())
                {
                    var list = redis.GetHashValues(key);
                    if (list != null && list.Count > 0)
                    {
                        List<MyTable> result = new List<MyTable>();
                        foreach (string item in list)
                        {
                            MyTable value = new MyTable();
                            if (new JsonServiceBase().FromJson<MyTable>(value, item))
                                result.Add(value);
                        }
                        return result;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                RedisManager.isOK = false;
                Console.WriteLine(ex.ToString());
            }
            return null;
        }
    }
}
