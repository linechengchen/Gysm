using AgileFrame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Source1Helper
{
    public static string getSource1()
    {
        IdWorker id1 = new IdWorker(1, 1);
        string source1 = (id1.nextIdUnique() + DateTime.Now.Ticks).ToString();
        int sum = 0;
        foreach (char c1 in source1)
        {
            if (StringHelper.IsNumeric(c1))
                sum += int.Parse(c1.ToString());
        }
        source1 += sum.ToString("00");
        return source1;
    }
    public static bool isTrueSource1(string source1)
    {
        string sum1 = source1.Substring(source1.Length - 2, 2);
        int sum2 = Convert.ToInt32(sum1);
        int sum3 = 0;
        foreach (char c1 in source1.Substring(0, source1.Length - 2))
        {
            if (StringHelper.IsNumeric(c1))
                sum3 += int.Parse(c1.ToString());
        }
        if (sum2 == sum3) return true;
        return false;
    }
}