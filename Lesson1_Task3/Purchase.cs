using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task3
{
    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    class Purchase : IComparable<Purchase>
    {
        string name;
        int price;
        int number;
        Days days;

        public Purchase()
        { }
        public Purchase( string name, int price, int number, Days days)
        {
            this.name=name;
            this.price=price;
            this.number=number;
            this.days = days;
        }
        /// <summary>
        /// Стоимость покупки
        /// </summary>
        /// <returns></returns>
        public int GetCost()
        {
            return (price * number);
        }
        /// <summary>
        /// Метод сравнения по стоимости покупки
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CompareTo(Purchase p)
        {
            if (this.GetCost() > p.GetCost())
                return -1;
            else
                if (this.GetCost() < p.GetCost())
                    return 1;
                else
                    return 0;
        }

        public override string ToString()
        {
            return name+";"+price+";"+number+";"+days+";"+GetCost();
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Number
        {
            get { return number; }
            set { this.number = value; }
        }

        public int Price
        {
            get { return price; }
            set { this.price = value; }
        }

        public Days Days
        {
            get { return days; }
            set { this.days = value; }
        }
    }
}
