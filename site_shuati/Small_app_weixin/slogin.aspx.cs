using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Configuration;
using System.Security.Cryptography;
using System.Text;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using Newtonsoft.Json;
using System.Xml;
using LitJson;
using System.Net;
using System.Web.Security;
using AgileFrame.Core;

/// <summary>
/// 小程序登录流畅：code换session，然后获取openID，再获取用户信息
/// </summary>
public partial class small_app_slogin : Page
{
    /**
    * 	配置账号信息
    */
    public class WxPayConfig
    {
        private static Dictionary<string, WxPayConfig> dic1 = new Dictionary<string, WxPayConfig>();
        public static Dictionary<string, WxPayConfig> getDic()
        {
            if (dic1.Count == 0)
            {
                //刷题神器 小程序
                WxPayConfig w1 = new WxPayConfig();
                w1.APPID = "wx7048e7f4ede7428b";
                w1.APPSECRET = "093923b886584dcfd221ed0cdbe6fc3b";
                dic1.Add(w1.APPID, w1);
                //刷题宝典 公众号
                w1 = new WxPayConfig();
                w1.APPID = "wx1f49864edcede162";
                w1.APPSECRET = "397321322f90543dd09719a1aedcb5a5";
                dic1.Add(w1.APPID, w1);
                //学霸优选（教师端）小程序
                w1 = new WxPayConfig();
                w1.APPID = "wxbe395de96370a6ea";
                w1.APPSECRET = "d0dd299852646d15e6d0345c3a4219a7";
                dic1.Add(w1.APPID, w1);

                //学霸优选小程序
                w1 = new WxPayConfig();
                w1.APPID = "wxef4d119123db4765";
                w1.APPSECRET = "d562e94abca0a74be485b21e679c5af1";
                dic1.Add(w1.APPID, w1);
                //学霸优选 公众号
                w1 = new WxPayConfig();
                w1.APPID = "wx1d5993af684bee55";
                w1.APPSECRET = "8c2ce78f641208713d4052256c95e127";
                dic1.Add(w1.APPID, w1);
            }
            return dic1;
        }
        //=======【基本信息设置】=====================================
        /* 微信公众号信息配置
        * APPID：绑定支付的APPID（必须配置）
        * MCHID：商户号（必须配置）
        * KEY：商户支付密钥，参考开户邮件设置（必须配置）
        * APPSECRET：公众帐号secert（仅JSAPI支付的时候需要配置）
        */
        public string APPID = "wxef4d119123db4765";
        public string APPSECRET = "d562e94abca0a74be485b21e679c5af1";
        public string MCHID = "1427310402";
        public string KEY = "aibang1001aibang1001aibang1001ai";

        public string SourceId = "3";
        //=======【证书路径设置】===================================== 
        /* 证书路径,注意应该填写绝对路径（仅退款、撤销订单时需要）
        */
        public string SSLCERT_PATH = "cert/apiclient_cert.p12";
        public string SSLCERT_PASSWORD = "1233410002";
        public const int LOG_LEVENL = 3;        
    }
    WxPayConfig config1 = new WxPayConfig();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["appid"]))
        {
            com.appid = Convert.ToString(Request["appid"]);
            config1 = WxPayConfig.getDic()[com.appid];
            com.secret = config1.APPSECRET;
        }
        else
        {
            com.appid = config1.APPID;
            com.secret = config1.APPSECRET;
        }
        if (Request["act"] == "code")
        {
            WeiXinAPPUserOpenID();

            string _json = json.ToJsonHeadLower();
            Response.Write(_json);
            return;
        }
        if (Request["act"] == "userinfo")
        {
            WeiXinAPPUserInfoParam param1 = new WeiXinAPPUserInfoParam();
            WeiXinAPPUserInfo(param1);

            string _json = json.ToJsonHeadLower();
            Response.Write(_json);
            return;
        }
    }
    Common com = new Common();
    public string token = HttpContext.Current.Request["token"];
    public string code = HttpContext.Current.Request["code"];
    public string message = HttpContext.Current.Request["message"];
    public class WeiXinAPPUserOpenIDJsonEntity : JsonEntity
    {
        public string session_key;
    }
    public string HttpGet(string url)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        //request.ContentType = "text/html;charset=UTF-8";
        request.ContentType = "text/plain";

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream myResponseStream = response.GetResponseStream();
        StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
        string retString = myStreamReader.ReadToEnd();
        myStreamReader.Close();
        myResponseStream.Close();

        return retString;
    }
    /// <summary>
    /// 第一步：微信小程序获取openID
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    internal void WeiXinAPPUserOpenID()
    {
        token = HttpContext.Current.Request["token"];
        code = HttpContext.Current.Request["code"];
        message = HttpContext.Current.Request["message"];
        //验证

        if (ValidateAuthentication(token))
        {
            string appId = config1.APPID;
            string appSecret = config1.APPSECRET;
                //https://api.weixin.qq.com/sns/jscode2session?appid=APPID&secret=SECRET&js_code=JSCODE&grant_type=authorization_code
            string url = "https://api.weixin.qq.com/sns/jscode2session?appid=" + appId + "&secret=" + config1.APPSECRET +
              "&js_code=" + code + "&grant_type=authorization_code";
                LogWrite(url);

                //code 换取 session_key
                string jsonStr = HttpGet(url);// To100.Common.WebHelper.HttpClient.RequestByGet(url);
                //json.AddTop("jsonStr", jsonStr);
                LogWrite("==" + jsonStr);

                //jsonStr = "{\"session_key\":\"RE2Z2aNS7MjhAImr3b4y3Q == \",\"expires_in\":2592000,\"openid\":\"osnP50Lx9Fhm76ZcPHyKk3xW32tU\"}";
                if (string.IsNullOrEmpty(jsonStr) || jsonStr.Contains("errcode"))
                {
                    json.error = jsonStr + url;
                    json.code = (int)AppErrorCode.账户信息错误;
                    json.message = message + "jsonStr=" + jsonStr + "jsonStr.contains=" + jsonStr.Contains("errcode");
                }
                else
                {
                    //expires_in
                    //{"session_key":"frflGk06wsgKhEYVstP80Q==","expires_in":7200,"openid":"ow1IM0e8u37t8cot8Q8YIb3VPrEY"}
                    JObject jsonSuccess = JObject.Parse(jsonStr);
                    string openid1 = jsonSuccess.Value<string>("openid");
                    string session_key1 = jsonSuccess.Value<string>("session_key");
                    int expires_in = jsonSuccess.Value<int>("expires_in");
                    //LogWrite("==jsonSuccess==" + session_key1);
                    if (string.IsNullOrEmpty(openid1))
                    {
                        json.AddTop("errmsg2", "openid1为空");
                    }
                    else
                    {
                        WX_USER_INFO user1 = BLLTable<WX_USER_INFO>.GetRowData(WX_USER_INFO.Attribute.Openid, openid1);
                        if (user1 == null || user1.IsNull())
                        {
                            WX_USER_INFO user = new WX_USER_INFO();
                            user.AuthSession3rd = Guid.NewGuid().ToString();
                            user.AuthSessionKey = session_key1;
                            user.Openid = openid1;
                            user.SourceId = config1.SourceId;
                            user.Appid = config1.APPID;
                            user.CreateTime = DateTime.Now;
                            user.User_id = Guid.NewGuid().ToString();


                            int ret1 = BLLTable<WX_USER_INFO>.Insert(user);//, WX_USER_INFO.Attribute.AuthSessionKey
                            if (ret1 <= 0)
                            {
                                json.AddTop("SaveOrUpdate-AuthSession3rd", "失败1AuthSession3rd=" + user.AuthSession3rd + "AuthSessionKey=" + user.AuthSessionKey + "SourceId=" + user.SourceId + "Appid=" + user.Appid + "User_id=" + user.User_id+"ret1="+ret1);
                            }         
                            json.AddTop("session_key", user.AuthSession3rd);
                            LogWrite(ret1 + "==Insert==" + session_key1);
                        }
                        else
                        {
                            bool modify = false;
                            if (string.IsNullOrEmpty(user1.AuthSession3rd))
                            {
                                user1.AuthSession3rd = Guid.NewGuid().ToString(); modify = true;
                            }
                            if (string.IsNullOrEmpty(user1.User_id))
                            {
                                user1.User_id = Guid.NewGuid().ToString(); modify = true;
                            }
                            if (string.IsNullOrEmpty(user1.Appid))
                            {
                                user1.Appid = config1.APPID; modify = true;
                            }
                            if (string.IsNullOrEmpty(user1.SourceId))
                            {
                                user1.SourceId = config1.APPID; modify = true;
                            }
                            if (user1.AuthSessionKey != session_key1)
                            {
                                user1.AuthSessionKey = session_key1; modify = true;
                            }
                            if (modify)
                            {
                                int ret1 = BLLTable<WX_USER_INFO>.Update(user1, WX_USER_INFO.Attribute.Openid);
                            }
                            json.AddTop("session_key", user1.AuthSession3rd);//jsonSuccess.Value<string>("session_key");//
                            json.AddTop("user_id", user1.User_id.ToString());
                            //LogWrite(ret1 + "==Update==" + session_key1);
                        }
                        json.error = "";
                        json.code = (int)AppErrorCode.操作正确;
                        json.message = message;
                    }
                }
            }
            else
            {
                //数据校验有误
                json.error = "数据校验有误";
                json.code = (int)AppErrorCode.接口验证错误;
                json.message = message;
            }
    }



    int count = 0;
    public void LogWrite(string jsonStr)
    {
        try
        {
            if (!MyDebugger.IsAttached) return;
            //if (count == 0)
            //    File.WriteAllText(@"D:\网站系统\刷题日志\刷题神器\shuatisite\small_app\1.txt", jsonStr + "\r\n\r\n");
            //else
            //    File.AppendAllText(@"D:\网站系统\刷题日志\刷题神器\shuatisite\small_app\1.txt", jsonStr + "\r\n\r\n");
            count++;
        }
        catch (Exception e) { throw; }
    }
    public class WeiXinAPPUserInfoParam
    {
        public string token = HttpContext.Current.Request["token"];
        public string raw_data = HttpContext.Current.Request["raw_data"];
        public string signature = HttpContext.Current.Request["signature"];
        public string encrypted_data = HttpContext.Current.Request["encrypted_data"];
        public string session_key = HttpContext.Current.Request["session_key"];
        public string iv = HttpContext.Current.Request["iv"];
        public string message = HttpContext.Current.Request["message"];
    }
    JsonRoot json = new JsonRoot();
    /// <summary>
    /// 获取微信小程序用户信息
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    internal void WeiXinAPPUserInfo(WeiXinAPPUserInfoParam param)
    {
        if (ValidateAuthentication(param.token))
        {
            string rawData = param.raw_data;
            string signature = param.signature;
            string encryptedData = param.encrypted_data;
            string iv = param.iv;
            string sessionKey = param.session_key;
            LogWrite("sessionKey:" + sessionKey);

            WX_USER_INFO cond1 = new WX_USER_INFO();

            cond1.AuthSession3rd = sessionKey;
            //cond1.SourceId = config1.SourceId;
            //cond1.Appid = config1.APPID;
            //System.ComponentModel.BindingList<TUserInfo> userList = UserWeixinBindLogic.GetList(string.Format("AuthSession3rd='{0}' AND SourceID={1}", sessionKey, 8), "ID", 1, 1);
            WX_USER_INFO user1 = BLLTable<WX_USER_INFO>.GetRowData(new WX_USER_INFO(), cond1);
            if (user1 == null || user1.IsNull()) //if (userList.Count == 0)
            {

                //数据校验有误
                json.error = "sessionKey不正确=" + sessionKey;
                json.code = (int)AppErrorCode.sessionKey不正确;
                json.message = param.message;
            }
            else
            {
                string AuthSessionKey = user1.AuthSessionKey; //SHA1加密
                string signatureNew = FormsAuthentication.HashPasswordForStoringInConfigFile(rawData + AuthSessionKey, "SHA1");
                //string signatureNew = To100.Common.DEncrypt.Security.SHA1(rawData + AuthSessionKey);
                //string signatureNew = GenarateSinature(rawData + AuthSessionKey);
                if (signatureNew.ToLower() == signature.ToLower())
                {
                    json.data.Add("signatureNew_same", "signatureNew相同");
                    string encryptData = Decrption(encryptedData, AuthSessionKey, iv);
                    //string encryptData = Decrption("Nyg1EcD8l4woOR5LDpKzjAW+NwhF9nN/GQJX1ESLpUj60B7dEGNa71m6c7Ncy6WDdr8CMZGqAnY8zshdMwc5Nwm+196wPLkTgefmb/cJ0PPqjywmV5edEnbjZaCt5EV3awIvwu8m+RFj7NIDsJw4dkts4GI82HzhN4VBsCaGn/FofY6Tm6nS/rdd7Ew29VHRLrJP5SaBbpUsEStvhem3c52JbamRMiVzHMa9mx+XWlP5/CZhOyEYyD58yGDnX4N/tLtzW4gihLjX1uH+D/gpeLphFkCDNce82T83PwIWuT/EJAprEOzMT0n0EpbFHcDZQ8rNJeV/MFkbxw9KQ5mjchsi41Dqe0udDaxMsFzgvHcGzrz/a7h2A10w4fZV62rlrHBVr6NUyS1AFCQEJTePtTAaV8XTJTns2qaNqfHAk3qtshW4vadM1lFrG2EB6YaTRukBUgwRNV+XoIuUyUheXuXo6btnY68+ykEqzyJQmgk=", AuthSessionKey, "JBHxir1nZrUBVruFmIxb+w==");
                    LogWrite(encryptData);
                    JObject jsonUserInfo = JObject.Parse(encryptData);
                    json.data.Add("encryptData", encryptData);
                    openid = jsonUserInfo.Value<string>("openId");
                    json.data.Add("jsonUserInfo_openid", jsonUserInfo.Value<string>("openId"));
                    string unionid = jsonUserInfo.Value<string>("unionId");
                    if (user1 != null && user1.IsNotNull())//if (userList.Count > 0)
                    {
                        json.AddTop("user1_user_id", user1.User_id);
                        user1.City = jsonUserInfo.Value<string>("city");
                        user1.Country = jsonUserInfo.Value<string>("country");
                        user1.Head_img_url = jsonUserInfo.Value<string>("avatarUrl");
                        user1.Language = jsonUserInfo.Value<string>("language");
                        user1.Nick_name = jsonUserInfo.Value<string>("nickName");
                        user1.Province = jsonUserInfo.Value<string>("province");
                        user1.Sex = jsonUserInfo.Value<int>("gender");
                        string Openid2 = jsonUserInfo.Value<string>("openId");
                        int retsaveTUserInfoData = saveTUserInfoData(user1);
                        json.AddTop("插入TUserInfo表", retsaveTUserInfoData);
                        if (user1.Openid != Openid2 || user1.Unionid != unionid)
                        {
                            user1.Openid = Openid2;
                            user1.Unionid = unionid;
                            int ret1 = BLLTable<WX_USER_INFO>.Update(user1, WX_USER_INFO.Attribute.Openid);
                            user1.Openid = Openid2;
                            //UserWeixinBindLogic.UpdateUserWeixinBind(bindEntity);                        
                            if (ret1 > 0)
                            {
                              

                            }
                        }
                        json.AddTop("user1_user_id2", user1.User_id);
                    }
                    else
                    {
                        WX_USER_INFO bindEntity = new WX_USER_INFO();
                        bindEntity.CreateTime = DateTime.Now;
                        bindEntity.User_id = Guid.NewGuid().ToString();
                        //bindEntity.IsBind = false;
                        //bindEntity.ValidCode = Guid.NewGuid().ToString().Replace("-", "");
                        bindEntity.Openid = jsonUserInfo.Value<string>("openId");
                        bindEntity.City = jsonUserInfo.Value<string>("city");
                        bindEntity.Country = jsonUserInfo.Value<string>("country");
                        bindEntity.Head_img_url = jsonUserInfo.Value<string>("avatarUrl");
                        bindEntity.Language = jsonUserInfo.Value<string>("language");
                        bindEntity.Nick_name = jsonUserInfo.Value<string>("nickName");
                        bindEntity.Province = jsonUserInfo.Value<string>("province");
                        bindEntity.Sex = jsonUserInfo.Value<int>("gender");
                        bindEntity.Unionid = unionid;
                        int ret1 = BLLTable<WX_USER_INFO>.Insert(bindEntity);
                        if (ret1 > 0)
                        {
                            user1 = bindEntity;
                        }
                    }
                    json.data.Add("user_info", user1);

                    UnionAuth auth1 = null;
                    if (openid != null && openid != "")
                    {
                        auth1 = BLLTable<UnionAuth>.GetRowData(UnionAuth.Attribute.Openid, openid);
                    }
                    else if (unionid != null && unionid != "")
                    {
                        auth1 = BLLTable<UnionAuth>.GetRowData(UnionAuth.Attribute.Unionid, unionid);
                    }
                    if (auth1 != null && auth1.IsNotNull())//if (userList.Count > 0)
                    {

                    }
                    else
                    {
                        auth1 = new UnionAuth();
                        auth1.Appid = config1.APPID;
                        auth1.User_id = user1.User_id;
                        auth1.Unionid = unionid;
                        auth1.Openid = openid;
                        int ret1 = BLLTable<UnionAuth>.Insert(auth1);
          
                    }
                    json.data.Add("UnionAuth", auth1);
                    json.errMsg = "";
                    json.code = (int)AppErrorCode.操作正确;
                    json.message = param.message;
                }
                else
                {
                    //数据校验有误
                    json.error = "数据校验有误";
                    json.code = (int)AppErrorCode.接口验证错误;
                    json.message = param.message;
                }
            }
        }
        else
        {
            //数据校验有误
            json.error = "数据校验有误";
            json.code = (int)AppErrorCode.接口验证错误;
            json.message = param.message;
        }
    }
    public class UserEntity
    {
        public string NickName;
        public string Guid;
        public string UserID;
    }

    /// <summary>
    /// 微信小程序解密代码
    /// </summary>
    /// <param name="encryptedDataStr"></param>
    /// <param name="key"></param>
    /// <param name="iv"></param>
    /// <returns></returns>
    public static string Decrption(string encryptedDataStr, string key, string iv)
    {
        RijndaelManaged rijalg = new RijndaelManaged();
        //-----------------    
        //设置格式 AES-128-CBC   PKCS7  
        rijalg.KeySize = 128;
        rijalg.Padding = PaddingMode.PKCS7;
        rijalg.Mode = CipherMode.CBC;

        rijalg.Key = Convert.FromBase64String(key);
        rijalg.IV = Convert.FromBase64String(iv);

        byte[] encryptedData = Convert.FromBase64String(encryptedDataStr);
        //解密    
        ICryptoTransform decryptor = rijalg.CreateDecryptor(rijalg.Key, rijalg.IV);

        string result;
        using (MemoryStream msDecrypt = new MemoryStream(encryptedData))
        {
            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            {
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    result = srDecrypt.ReadToEnd();
                }
            }
        }
        return result;
    }


    public class UserPayStatus
    {
        public static int 未支付 = 1;
    }
    public class UserRechargeType
    {
        public static int 球币充值 = 1;
    }
    public class AppErrorCode
    {
        public static int 操作正确 = 200;
        public static int 账户信息错误 = 401;
        public static int 接口验证错误 = 403;
        public static int sessionKey不正确 = 404;
        public static int 充值金额有误 = 405;
    }
    public class WeiXinAPPUserOpenIDParam
    {
        public string token = HttpContext.Current.Request["token"];
        public string code = HttpContext.Current.Request["code"];
        public string message = HttpContext.Current.Request["message"];
    }
    public bool ValidateAuthentication(string token)
    {
        return true;
    }
    public static string GenarateSinature(string raw)
    {
        string sMsgSignature = "";
        SHA1 sha;
        ASCIIEncoding enc;
        string hash = "";
        try
        {
            sha = new SHA1CryptoServiceProvider();
            enc = new ASCIIEncoding();
            byte[] dataToHash = enc.GetBytes(raw);
            byte[] dataHashed = sha.ComputeHash(dataToHash);
            hash = BitConverter.ToString(dataHashed).Replace("-", "");
            hash = hash.ToLower();
        }
        catch (Exception)
        {
            throw;
            //return (int)WXBizMsgCryptErrorCode.WXBizMsgCrypt_ComputeSignature_Error;
        }
        sMsgSignature = hash;
        return sMsgSignature;
    }
    public class JsonEntity
    {
        public string error;
        public int code;
        public string message;
    }
    public class WxPayException : Exception
    {
        public WxPayException(string msg)
            : base(msg)
        {

        }
    }
    public class Log
    {
        //在网站根目录下创建日志目录
        public static string path = HttpContext.Current.Request.PhysicalApplicationPath + "logs";

        /**
         * 向日志文件写入调试信息
         * @param className 类名
         * @param content 写入内容
         */
        public static void Debug(string className, string content)
        {
            if (WxPayConfig.LOG_LEVENL >= 3)
            {
                WriteLog("DEBUG", className, content);
            }
        }

        /**
        * 向日志文件写入运行时信息
        * @param className 类名
        * @param content 写入内容
        */
        public static void Info(string className, string content)
        {
            if (WxPayConfig.LOG_LEVENL >= 2)
            {
                WriteLog("INFO", className, content);
            }
        }

        /**
        * 向日志文件写入出错信息
        * @param className 类名
        * @param content 写入内容
        */
        public static void Error(string className, string content)
        {
            if (WxPayConfig.LOG_LEVENL >= 1)
            {
                WriteLog("ERROR", className, content);
            }
        }

        /**
        * 实际的写日志操作
        * @param type 日志记录类型
        * @param className 类名
        * @param content 写入内容
        */
        protected static void WriteLog(string type, string className, string content)
        {
            if (!Directory.Exists(path))//如果日志目录不存在就创建
            {
                Directory.CreateDirectory(path);
            }

            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");//获取当前系统时间
            string filename = path + "/" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";//用日期对日志文件命名

            //创建或打开日志文件，向日志文件末尾追加记录
            StreamWriter mySw = File.AppendText(filename);

            //向日志文件写入内容
            string write_content = time + " " + type + " " + className + ": " + content;
            mySw.WriteLine(write_content);

            //关闭日志文件
            mySw.Close();
        }
    }
    public class WxPayData
    {
        WxPayConfig config1 = new WxPayConfig();
        public WxPayData(WxPayConfig config1)
        {
            this.config1 = config1;
        }

        //采用排序的Dictionary的好处是方便对数据包进行签名，不用再签名之前再做一次排序
        private SortedDictionary<string, object> m_values = new SortedDictionary<string, object>();

        /**
        * 设置某个字段的值
        * @param key 字段名
         * @param value 字段值
        */
        public void SetValue(string key, object value)
        {
            m_values[key] = value;
        }

        /**
        * 根据字段名获取某个字段的值
        * @param key 字段名
         * @return key对应的字段值
        */
        public object GetValue(string key)
        {
            object o = null;
            m_values.TryGetValue(key, out o);
            return o;
        }

        /**
         * 判断某个字段是否已设置
         * @param key 字段名
         * @return 若字段key已被设置，则返回true，否则返回false
         */
        public bool IsSet(string key)
        {
            object o = null;
            m_values.TryGetValue(key, out o);
            if (null != o)
                return true;
            else
                return false;
        }

        /**
        * @将Dictionary转成xml
        * @return 经转换得到的xml串
        * @throws WxPayException
        **/
        public string ToXml()
        {
            //数据为空时不能转化为xml格式
            if (0 == m_values.Count)
            {
                //Log.Error(this.GetType().ToString(), "WxPayData数据为空!");
                throw new Exception("WxPayData数据为空!");
            }

            string xml = "<xml>";
            foreach (KeyValuePair<string, object> pair in m_values)
            {
                //字段值不能为null，会影响后续流程
                if (pair.Value == null)
                {
                    //Log.Error(this.GetType().ToString(), "WxPayData内部含有值为null的字段!");
                    throw new Exception("WxPayData内部含有值为null的字段!");
                }

                if (pair.Value.GetType() == typeof(int))
                {
                    xml += "<" + pair.Key + ">" + pair.Value + "</" + pair.Key + ">";
                }
                else if (pair.Value.GetType() == typeof(string))
                {
                    xml += "<" + pair.Key + ">" + "<![CDATA[" + pair.Value + "]]></" + pair.Key + ">";
                }
                else//除了string和int类型不能含有其他数据类型
                {
                    Log.Error(this.GetType().ToString(), "WxPayData字段数据类型错误!");
                    throw new Exception("WxPayData字段数据类型错误!");
                }
            }
            xml += "</xml>";
            return xml;
        }

        /**
        * @将xml转为WxPayData对象并返回对象内部的数据
        * @param string 待转换的xml串
        * @return 经转换得到的Dictionary
        * @throws WxPayException
        */
        public SortedDictionary<string, object> FromXml(string xml)
        {
            if (string.IsNullOrEmpty(xml))
            {
                //Log.Error(this.GetType().ToString(), "将空的xml串转换为WxPayData不合法!");
                throw new Exception("将空的xml串转换为WxPayData不合法!");
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            XmlNode xmlNode = xmlDoc.FirstChild;//获取到根节点<xml>
            XmlNodeList nodes = xmlNode.ChildNodes;
            foreach (XmlNode xn in nodes)
            {
                XmlElement xe = (XmlElement)xn;
                m_values[xe.Name] = xe.InnerText;//获取xml的键值对到WxPayData内部的数据中
            }

            try
            {
                //2015-06-29 错误是没有签名
                if (m_values["return_code"] != "SUCCESS")
                {
                    return m_values;
                }
                CheckSign();//验证签名,不通过会抛异常
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return m_values;
        }

        /**
        * @Dictionary格式转化成url参数格式
        * @ return url格式串, 该串不包含sign字段值
        */
        public string ToUrl()
        {
            string buff = "";
            foreach (KeyValuePair<string, object> pair in m_values)
            {
                if (pair.Value == null)
                {
                    //Log.Error(this.GetType().ToString(), "WxPayData内部含有值为null的字段!");
                    throw new Exception("WxPayData内部含有值为null的字段!");
                }

                if (pair.Key != "sign" && pair.Value.ToString() != "")
                {
                    buff += pair.Key + "=" + pair.Value + "&";
                }
            }
            buff = buff.Trim('&');
            return buff;
        }


        /**
        * @Dictionary格式化成Json
         * @return json串数据
        */
        public string ToJson()
        {
            string jsonStr = JsonMapper.ToJson(m_values);
            return jsonStr;
        }

        /**
        * @values格式化成能在Web页面上显示的结果（因为web页面上不能直接输出xml格式的字符串）
        */
        public string ToPrintStr()
        {
            string str = "";
            foreach (KeyValuePair<string, object> pair in m_values)
            {
                if (pair.Value == null)
                {
                    Log.Error(this.GetType().ToString(), "WxPayData内部含有值为null的字段!");
                    throw new Exception("WxPayData内部含有值为null的字段!");
                }

                str += string.Format("{0}={1}<br>", pair.Key, pair.Value.ToString());
            }
            Log.Debug(this.GetType().ToString(), "Print in Web Page : " + str);
            return str;
        }

        /**
        * @生成签名，详见签名生成算法
        * @return 签名, sign字段不参加签名
        */
        public string MakeSign()
        {
            //转url格式
            string str = ToUrl();
            //在string后加入API KEY
            str += "&key=" + config1.KEY;
            //MD5加密
            var md5 = MD5.Create();
            var bs = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            var sb = new StringBuilder();
            foreach (byte b in bs)
            {
                sb.Append(b.ToString("x2"));
            }
            //所有字符转为大写
            return sb.ToString().ToUpper();
        }

        /**
        * 
        * 检测签名是否正确
        * 正确返回true，错误抛异常
        */
        public bool CheckSign()
        {
            //如果没有设置签名，则跳过检测
            if (!IsSet("sign"))
            {
                Log.Error(this.GetType().ToString(), "WxPayData签名存在但不合法!");
                throw new WxPayException("WxPayData签名存在但不合法!");
            }
            //如果设置了签名但是签名为空，则抛异常
            else if (GetValue("sign") == null || GetValue("sign").ToString() == "")
            {
                Log.Error(this.GetType().ToString(), "WxPayData签名存在但不合法!");
                throw new WxPayException("WxPayData签名存在但不合法!");
            }

            //获取接收到的签名
            string return_sign = GetValue("sign").ToString();

            //在本地计算新的签名
            string cal_sign = MakeSign();

            if (cal_sign == return_sign)
            {
                return true;
            }

            Log.Error(this.GetType().ToString(), "WxPayData签名验证错误!");
            throw new WxPayException("WxPayData签名验证错误!");
        }

        /**
        * @获取Dictionary
        */
        public SortedDictionary<string, object> GetValues()
        {
            return m_values;
        }
    }
    string access_token = "";
    string openid = "";
    public void GetOpenidAndAccessTokenFromCode(string code)
    {
        try
        {
            //构造获取openid及access_token的url
            WxPayData data = new WxPayData(config1);
            data.SetValue("appid", config1.APPID);
            data.SetValue("secret", config1.APPSECRET);
            data.SetValue("code", code);
            data.SetValue("grant_type", "authorization_code");
            string url = "https://api.weixin.qq.com/sns/oauth2/access_token?" + data.ToUrl();

            //请求url以获取数据
            string result = com.HttpGet(url);

            Log.Debug(this.GetType().ToString(), "GetOpenidAndAccessTokenFromCode response : " + result);

            //保存access_token，用于收货地址获取
            LitJson.JsonData jd = JsonMapper.ToObject(result);
            access_token = (string)jd["access_token"];

            //获取用户openid
            openid = (string)jd["openId"];

            Log.Debug(this.GetType().ToString(), "Get openid : " + openid);
            Log.Debug(this.GetType().ToString(), "Get access_token : " + access_token);
        }
        catch (Exception ex)
        {
            Log.Error(this.GetType().ToString(), ex.ToString());
            throw new WxPayException(ex.ToString());
        }
    }
    public void GetOpenidAndAccessToken()
    {
        if (!string.IsNullOrEmpty(this.Request.QueryString["code"]))
        {
            //获取code码，以获取openid和access_token
            string code = this.Request.QueryString["code"];
            Log.Debug(this.GetType().ToString(), "Get code : " + code);
            GetOpenidAndAccessTokenFromCode(code);
        }
        else
        {
            //构造网页授权获取code的URL
            string host = this.Request.Url.Host;
            string path = this.Request.Path;
            string redirect_uri = HttpUtility.UrlEncode("https://" + host + path);
            WxPayData data = new WxPayData(config1);
            data.SetValue("appid", config1.APPID);
            data.SetValue("redirect_uri", redirect_uri);
            data.SetValue("response_type", "code");
            data.SetValue("scope", "snsapi_base");
            data.SetValue("state", "STATE" + "#wechat_redirect");
            string url = "https://open.weixin.qq.com/connect/oauth2/authorize?" + data.ToUrl();
            //Log.Debug(this.GetType().ToString(), "Will Redirect to URL : " + url);
            try
            {
                //触发微信返回code码         
                this.Response.Redirect(url);//Redirect函数会抛出ThreadAbortException异常，不用处理这个异常
            }
            catch (System.Threading.ThreadAbortException ex)
            {
            }
        }
    }


    public int saveTUserInfoData(WX_USER_INFO source )
    {
        int ret1 = 0;
        TUserInfo valselect = new TUserInfo();
        TUserInfo condselect = new TUserInfo();
        condselect.User_id=new Guid(source.User_id);
        TUserInfo select=BLLTable<TUserInfo>.SelectOne(valselect,condselect);
        json.Add("ces", select);
        if(select==null)
        {
            TUserInfo insert1=new TUserInfo();
            insert1.User_id=Guid.Parse(source.User_id);
            insert1._Unionid=source.Unionid;
  
            insert1.Head_img_url = source._Head_img_url;
            insert1.City = source.City;
            insert1.Nick_name = source.Nick_name;
            //insert1.Phone_number=source.Phone_number;
            //ret1 = BLLTable<TUserInfo>.Insert(insert1);
        }

        //TUserInfo val2 = new TUserInfo();
        //TUserInfo cond2 = new TUserInfo();
        //if()


        return ret1;
    }
}