using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare
{
    internal class Beräkna
    {
        public static void Addition(string userInput)
        {
            
            int plusindex = userInput.IndexOf("+");
            string tal1Text = userInput[..plusindex];
            string tal2Text = userInput[(plusindex + 1)..];
            int tal1 = int.Parse(tal1Text);
            int tal2 = int.Parse(tal2Text);
            int summa = tal1 + tal2;
            Console.WriteLine(userInput + " = " + summa);
        }
        public static void Subtraktion(string userInput)
        {
            int minusIndex = userInput.IndexOf("-");
            string tal1Text = userInput[..minusIndex];
            string tal2Text = userInput[(minusIndex + 1)..];
            int tal1 = int.Parse(tal1Text);
            int tal2 = int.Parse(tal2Text);
            int summa = tal1 - tal2;
            Console.WriteLine(userInput + " = " + summa);
        }
        public static void Division(string userInput)
        {
            int divisionIndex = userInput.IndexOf("/");
            string tal1Text = userInput[..divisionIndex];
            string tal2Text = userInput[(divisionIndex + 1)..];
            int tal1 = int.Parse(tal1Text);
            int tal2 = int.Parse(tal2Text);
            int summa = tal1 + tal2;
            Console.WriteLine(userInput + " = " + summa);
        }
    }
}
