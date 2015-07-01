using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //объявление и инициализация массива
            Purchase[] purchases = new Purchase[] 
            {
	            new Purchase("cup",38000,3,Days.Mon),
                new Purchase("plate",50000,1,Days.Sun),
                new Purchase("spoon",21000,4,Days.Wed),
                new Purchase("fork",12000,4,Days.Fri),
                new Purchase("knife",35000,2,Days.Sat),
            };
            double sum = 0; // переменная для нахождения суммы покупок
            for (int i = 0; i < purchases.Length; i++)
            {
                if (purchases[i] != null)
                {
                    Console.WriteLine(purchases[i]);
                    sum = sum + purchases[i].GetCost();
                }
            }
            Array.Sort(purchases);
            Console.WriteLine("\nСредняя стоимость всех покупок "+(sum/purchases.Length));
            Console.WriteLine("День самой дорогой покупки " + purchases[0].Days+"\n");
            for (int i = 0; i < purchases.Length; i++)
            {
                if (purchases[i] != null)
                    Console.WriteLine(purchases[i]);
            }
            Console.ReadKey();
        }
    }
}
