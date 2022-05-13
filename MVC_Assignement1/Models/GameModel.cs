using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace MVC_Assignement1.Models
{
	public class GameModel
	{
		public static List<int> store_num = new List<int>();

		public static int GetGuessNumber()
		{
			var random = new Random();
			int num = random.Next(1, 100);
			store_num.Clear();
			return num;
		}
		public static string CheckGuess(int Submit, int guess)
        {
			if (Submit <= 100 && Submit >= 1)
			{
				store_num.Add(Submit);
				if (Submit > guess)
				{
					return "your guess is too high";
				}
				else if (Submit < guess)
				{
					return "your guess is too low";
				}
				else
				{
					return "Congratulations";
				}
			}
            else
            {
				return "please enter a valid number";
            }
			
        }
	}
}

