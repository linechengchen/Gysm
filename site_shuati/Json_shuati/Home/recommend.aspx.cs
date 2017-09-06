using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JsonBook_home_recommend : BasePageShuati
{
    /// <summary>
    /// post到页面的参数对象
    /// </summary>
    [Serializable]
    public class PostData
    {
        public static PostData get(System.Web.UI.Page this1)
        {
            System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            PostData PostData = javaScriptSerializer.Deserialize<PostData>(getString(this1));
            return PostData;
        }
        public static string getString(System.Web.UI.Page this1)
        {
            string json1 = (this1.Request.InputStream != null) ? (new System.IO.StreamReader(this1.Request.InputStream).ReadToEnd()) : ""; this1.Request.InputStream.Close();
            return json1;
        }
        //public string user_id;
    }
    protected void Page_Load(object sender, EventArgs e)
    {                   
        JsonRoot r1 = new JsonRoot();

    }
    /*
     //{
//	"code":200,
//	"message":"success",
//	"data":{
//		"imgs":[{
//			"id":29,
//			"path":"https://image.qess.me/images/2016120817571770048403.jpg",
//			"url":"../recomm/themeinfo.html?id=29"
//		},
//		{
//			"id":26,
//			"path":"https://image.qess.me/images/2016120817573874214129.jpg",
//			"url":"../recomm/themeinfo.html?id=26"
//		}],
//		"txts":[{
//			"id":35,
//			"name":"通识教材专区",
//			"books":[{
//				"id":13855,
//				"path":"https://image.qess.me/images/2016110417400954456187.png",
//				"title":"思想道德修养与法律基础（2015年版）",
//				"marketPrice":"18.00",
//				"publisher":"高等教育出版社",
//				"author":"本书编写组",
//				"supply":0
//			},
//			{
//				"id":4571,
//				"path":"https://image.qess.me/images/2016110417402805359818.png",
//				"title":"思想道德修养与法律基础（2013年版）",
//				"marketPrice":"16.00",
//				"publisher":"高等教育出版社",
//				"author":"本书编写组著",
//				"supply":0
//			},
//			{
//				"id":4633,
//				"path":"https://image.qess.me/images/2016110417382871211312.png",
//				"title":"马克思主义基本原理概论（2013年版）",
//				"marketPrice":"21.00",
//				"publisher":"高等教育出版社",
//				"author":"本书编写组著",
//				"supply":0
//			},
//			{
//				"id":4648,
//				"path":"https://image.qess.me/images/2016110417391584061578.png",
//				"title":"毛泽东思想和中国特色社会主义理论体系概论（2013年版）",
//				"marketPrice":"23.00",
//				"publisher":"高等教育出版社",
//				"author":"本书编写组著",
//				"supply":0
//			}],
//			"type":1
//		},
//		{
//			"id":39,
//			"name":"数学与统计专区",
//			"books":[{
//				"id":4078,
//				"path":"https://image.qess.me/images/2016110817421411377484.png",
//				"title":"工程数学－线性代数",
//				"marketPrice":"12.10",
//				"publisher":"高等教育出版社",
//				"author":"同济大学数学系著",
//				"supply":0
//			},
//			{
//				"id":3464,
//				"path":"https://image.qess.me/images/2016111110201872917345.jpg",
//				"title":"经济应用数学基础",
//				"marketPrice":"26.00",
//				"publisher":"中国人民大学出版社",
//				"author":"赵树嫄著",
//				"supply":0
//			},
//			{
//				"id":1781,
//				"path":"https://image.qess.me/booksIMG/20150912_17095198.jpg",
//				"title":"高等数学",
//				"marketPrice":"38.00",
//				"publisher":"浙江大学出版社",
//				"author":"刘莹著",
//				"supply":0
//			},
//			{
//				"id":6028,
//				"path":"https://image.qess.me/images/2016111110425392238888.jpg",
//				"title":"微积分",
//				"marketPrice":"23.00",
//				"publisher":"中国人民大学出版社",
//				"author":"吴赣昌著",
//				"supply":0
//			}],
//			"type":1
//		},
//		{
//			"id":259,
//			"name":"英语专区",
//			"books":[{
//				"id":5177,
//				"path":"https://image.qess.me/images/2016111114174270614795.jpg",
//				"title":"新视野大学英语(2)(读写教程)(第二版)",
//				"marketPrice":"32.90 ",
//				"publisher":"外语教学与研究出版社",
//				"author":"郑树棠著",
//				"supply":0
//			},
//			{
//				"id":5066,
//				"path":"https://image.qess.me/images/2016111114291006517510.jpg",
//				"title":"新视野大学英语1读写教程",
//				"marketPrice":"35.90",
//				"publisher":"外语教学与研究出版社",
//				"author":"郑树棠著",
//				"supply":0
//			},
//			{
//				"id":7159,
//				"path":"https://image.qess.me/images/2016111114312187213300.jpg",
//				"title":"全新版大学英语(第二版)快速阅读",
//				"marketPrice":"18.00",
//				"publisher":"上海外语教育出版社",
//				"author":"郭杰克著",
//				"supply":0
//			}],
//			"type":1
//		}]
//	}
//}

     */
    private void 例子代码()
    {
        //post获取post过来的所有json字符串参数
        PostData PostData1 = PostData.get(this);
        if (PostData1 == null) return;
        //if(PostData1.user_id == null || PostData1.user_id == "undefine" || PostData1.user_id == "null") return;

        //get获取所有json字符串参数
        string user_id = "";
        if (string.IsNullOrEmpty(Request["user_id"]))
            user_id = Convert.ToString(Request["user_id"]);

        JsonRoot r1 = new JsonRoot();
        TUserInfo user1 = new TUserInfo();
        user1.Top(100);
        TUserInfo cond1 = new TUserInfo();
        List<TUserInfo> list1 = BLLTable<TUserInfo>.Select(user1, cond1);//取得多行记录

        TUserInfo row1 = BLLTable<TUserInfo>.GetRowData(user1, cond1);//取得单行记录

        int ret1 = BLLTable<TUserInfo>.Update(user1, TUserInfo.Attribute.User_id);
        if (ret1 > 0)
        {
            r1.code = 200;
            r1.data.Add(list1);
            r1.data.Add(row1);
            string json1 = r1.ToJsonHeadLower();
            Response.Write(json1);
            Response.End();
        }
    }
}