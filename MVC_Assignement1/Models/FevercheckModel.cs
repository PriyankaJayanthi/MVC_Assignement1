using System;
namespace MVC_Assignement1.Models
{
	public class FevercheckModel
	{
       public static string Fever_check(double temp, string scale)
       {
           string ret = "";
            if (scale == "Celsius")
             {
                if (temp > 37) ret = "You have fever";
                else if (temp < 35) ret = "you have hypothermis";
                else ret = "your temparature is normal";
             }
             if (scale == "Fahrenheit")
             {
                 if (temp > 100.4) ret = "You have fever";
                 else if (temp < 95) ret = "you have hypothermis";
                 else ret = "Your temparature is normal";
             }
                return ret;
       }

        
	}
}

