using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Json_aes : BasePageShuati
{
    //https://deck.net/ js转换 很有用
    public string encryptedData = "";
    public string data = "{\"code\":200,\"message\":\"success成功信息\",\"data\":{}}";
    public string json2 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        json2 = data;

        //encryptedData = AESHelper.Encrypt(data, "1234567812345678", "1234567812345678");
        //HttpUtility.UrlEncode(data, System.Text.Encoding.GetEncoding(936));
        //byte[] resultArray = UTF8Encoding.UTF8.GetBytes(data);
        //json1 = Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //json1 = AESHelper.Encrypt(data, "1234567812345678", "1234567812345678");
        
        //json2 = AESHelper.AESEncrypt(json2);

        //json2 = RootObject.escape(json2);
        //json2 = RootObject.Jiami(json2);
        json2 = KaiSa.Encrypt(json2);

        //json2 = json2.Replace("c", "`");
        //json2 = json2.Replace("c", "`");

        //Response.Write(json2);
        //Response.End();
    }
    public static string Escape(string str)
    {
        StringBuilder sb = new StringBuilder(256);
        foreach (char c in str)
        {
            sb.Append((Char.IsLetterOrDigit(c)
            || c == '-' || c == '_' || c == '\\'
            || c == '/' || c == '.') ? c.ToString() : Uri.HexEscape(c));
        }
        return sb.ToString();
    }
}