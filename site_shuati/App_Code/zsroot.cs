using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class zsroot
{
    public struct ZsType
    {
        /// <summary>
        /// 
        /// </summary>
        public string zsid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string zsname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int zstypeid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string isshowindex { get; set; }

        public List<zs> zslist { get; set; }
    }
    public struct zs
    {
        public string typename;
        public string typeid;
    }
}