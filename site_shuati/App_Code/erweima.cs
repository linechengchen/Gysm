using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using ThoughtWorks;
using ThoughtWorks.QRCode;
using ThoughtWorks.QRCode.Codec;

namespace AgileFrame.Orm.PersistenceLayer.Model
{
    public class ErWeiMa
    {
        /// <summary>
        /// 生成二维码图片，并返回文件的保存路径  Server.MapPath("~/Images/QRcodeImg/")
        /// </summary>
        /// <param name="nr">要生成二维码的字符串</param>
        /// <returns></returns>
        public string CreateQR(string path, string nr)
        {
            Bitmap bt;
            if (!string.IsNullOrEmpty(nr))
            {
                string filename = Guid.NewGuid().ToString().ToUpper();
                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                bt = qrCodeEncoder.Encode(nr, Encoding.UTF8);
                string imgPath = Path.Combine(path, filename + ".jpg");
                try
                {
                    bt.Save(imgPath);
                    return imgPath;
                }
                catch (Exception)
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
    }
}
