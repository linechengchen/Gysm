using AgileFrame.Core;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wap_main_query : BasePageShuati
{
    public void Page_Load(object sender, EventArgs e)
    {
        int question_sum = 0;
        int question_sum0 = 0;
        int question_sum1 = 0;
        int question_sum2 = 0;
        int question_sum3 = 0;
        int question_sum4 = 0;
        int question_sum5 = 0;
        int question_sum6 = 0;
        int question_sum7 = 0;
        int question_sum8 = 0;
        int question_sum_cuoti = -1;
        string kaoshiTime = "2017-1-1";

        string questionid_max = "0";
        string questionid_max0 = "0";
        string questionid_max1 = "0";
        string questionid_max2 = "0";
        string questionid_max3 = "0";
        string questionid_max4 = "0";
        string questionid_max5 = "0";
        string questionid_max6 = "0";
        string questionid_max7 = "0";
        string questionid_max8 = "0";
                
        List<St_kemuInfo> list2 = BLLTable<St_kemuInfo>.Select();
        foreach (St_kemuInfo zs1 in list2)
        {
            St_kemuInfo_q_sum sum1 = new St_kemuInfo_q_sum();
            St_kemuInfo_q_sum sum_cond1 = new St_kemuInfo_q_sum();
            sum_cond1.KemuId = zs1.KemuId;
            sum_cond1.Sc = zs1.Sc;

            sum1.KemuId = zs1.KemuId;
            sum1.Sc = zs1.Sc;
            St_TTimuDaXue cond1 = new St_TTimuDaXue();
            cond1.KemuId = zs1.KemuId;
            sum1.Question_sum = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "0";
            sum1.Question_sum0 = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "1";
            sum1.Question_sum1 = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "2";
            sum1.Question_sum2 = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "3";
            sum1.Question_sum3 = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "4";
            sum1.Question_sum4 = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "5";
            sum1.Question_sum5 = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "6";
            sum1.Question_sum6 = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "7";
            sum1.Question_sum7 = BLLTable<St_TTimuDaXue>.Count(cond1);
            cond1.OptionType = "8";
            sum1.Question_sum8 = BLLTable<St_TTimuDaXue>.Count(cond1);

            sum1.Question_sum_time = DateTime.Now;
            if (!BLLTable<St_kemuInfo_q_sum>.Exists(sum_cond1))
                BLLTable<St_kemuInfo_q_sum>.Insert(sum1);
            else
                BLLTable<St_kemuInfo_q_sum>.Update(sum1, sum_cond1);
        }

        List<St_kemuInfo_zs> list1 = BLLTable<St_kemuInfo_zs>.Select();
        foreach (St_kemuInfo_zs zs1 in list1)
        {
            BLL233 bll233 = new BLL233();
            St_TiMu233 cond233 = new St_TiMu233();
            cond233.ClassId = zs1.KemuId.ToString();
            zs1.Question_sum = BLLTable<St_TiMu233>.Count(cond233);
            cond233.ExamType = bll233.get233OptionType("0");
            zs1.Question_sum0 = BLLTable<St_TiMu233>.Count(cond233);
            cond233.ExamType = bll233.get233OptionType("1");
            zs1.Question_sum1 = BLLTable<St_TiMu233>.Count(cond233);
            cond233.ExamType = bll233.get233OptionType("2");
            zs1.Question_sum2 = BLLTable<St_TiMu233>.Count(cond233);
            cond233.ExamType = bll233.get233OptionType("3");
            zs1.Question_sum3 = BLLTable<St_TiMu233>.Count(cond233);
            cond233.ExamType = bll233.get233OptionType("4");
            zs1.Question_sum4 = BLLTable<St_TiMu233>.Count(cond233);

            zs1.Question_sum_time = DateTime.Now;
            BLLTable<St_kemuInfo_zs>.Update(zs1, St_kemuInfo_zs.Attribute.KemuId);
        }

        List<St_TzsInfo> list3 = BLLTable<St_TzsInfo>.Select();
        foreach (St_TzsInfo zs1 in list3)
        {
            St_TzsInfo zs2 = zs1.Clone();
            zs2.Question_sum = 0;
            St_kemuInfo_zs cond1 = new St_kemuInfo_zs();
            cond1.ZsId = zs1.ZsId;
            List<St_kemuInfo_zs> list11 = BLLTable<St_kemuInfo_zs>.Select(new St_kemuInfo_zs(), cond1);
            int sum1 = 0;
            foreach (St_kemuInfo_zs kemu1 in list11)
            {
                sum1 += kemu1.Question_sum;
            }
            zs2.Question_sum = sum1;
            int ret1 = BLLTable<St_TzsInfo>.Update(zs2, St_TzsInfo.Attribute.Id);
        }

    }
}