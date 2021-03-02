using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Main_form
{
    class SateData
    {

       static string OurInfo = File.ReadAllText("E:\\name.txt");
       public string name = Convert.ToString(OurInfo[0]);
       public int day = Convert.ToInt32(OurInfo[1]);
       public int month = Convert.ToInt32(OurInfo[2]);
       public int year = Convert.ToInt32(OurInfo[3]);
    }
}
