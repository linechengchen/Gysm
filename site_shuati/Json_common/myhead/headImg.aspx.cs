using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
public partial class Json_common_myhead_headImg : System.Web.UI.Page
{
    protected string ImgFileUploadPath = @"E:\工程项目\刷题神器\ShuaTiSite\FileUploader";
    protected string ImgSiteUploadUrl = @"../../../../FileUploader";
    protected void Page_Load(object sender, EventArgs e)
    {


        string imgSubDir = "/jz_albumImages/";
        Jz_resume valjzresume = new Jz_resume();
        Jz_resume condJz_resume = new Jz_resume();
        string user_id = Request["user_id"];
        condJz_resume.User_id = Guid.Parse(user_id);
        if (Request["t"] == "1") return; JsonRoot r1 = new JsonRoot();
        #region 插入图片
        System.Web.HttpFileCollection _file = System.Web.HttpContext.Current.Request.Files;
        if (_file.Count > 0)
        {
            //文件大小  
            long size = _file[0].ContentLength;
            //文件类型  
            string type = _file[0].ContentType;
            //文件名  
            string name = _file[0].FileName;
            //文件格式  
            string _tp = System.IO.Path.GetExtension(name);

            if (_tp.ToLower() == ".jpg" || _tp.ToLower() == ".jpeg" || _tp.ToLower() == ".gif" || _tp.ToLower() == ".png" || _tp.ToLower() == ".swf")
            {
                //获取文件流  
                System.IO.Stream stream = _file[0].InputStream;
                //保存文件  
                string saveName = imgSubDir + DateTime.Now.ToString("yyyyMMddHHmmss") + _tp;
                string saveNameMin = imgSubDir + DateTime.Now.ToString("yyyyMMddHHmmss") + "_100" + _tp;
                string path = ImgFileUploadPath + saveName;//"/upload/area/" + saveName;//DataFactory.WFile.FileUploadPath
                string pathMin = ImgFileUploadPath + saveNameMin;//"/upload/area/" + saveName;//DataFactory.WFile.FileUploadPath
                _file[0].SaveAs(path);
                //Jz_userImages.ImageMax = "../../../../FileUploader/jz_albumImages/" + saveName;
                valjzresume.HeadImg = "../../../../FileUploader/" + saveName;

            }
        }
        #endregion
        int ret = BLLTable<Jz_resume>.Update(valjzresume, condJz_resume);
        if (ret > 0)
        {
            r1.code = 200;
            r1.AddTop("data", valjzresume.HeadImg);
            r1.errMsg = "修改头像成功";
            r1.success = true;
            string json = r1.ToJson();
            //json = json.Replace(",}", "}");
            Response.Write(json);
            Response.End();
        }
        else
        {
            r1.errMsg = "修改头像失败";
            string json = r1.ToJson();
            Response.Write(r1.ToJson());
            Response.End();
        }
    }
}

