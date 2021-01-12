using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekseatTest
{
    class Program
    {

        public class Village
        {
            int age;
            int year;

            public Village()
            {

            }

            public Village(int _age, int _year)
            {
                this.age = _age;
                this.year = _year;
            }

            public double calculateAverage(List<Village> villages)
            {
                double result = 0;
                List<int> _yearKilled = new List<int>();

                foreach(Village _village in villages)
                {
                    if(_village.age < 0)
                    {
                        return -1;
                    }

                    int _year = _village.year - _village.age,
                        _defaultVillage = 1;

                    for(int x = 1; x< _year; x++)
                    {
                        _defaultVillage += x;
                    }

                    result += _defaultVillage;
                }


                return result / villages.Count();
            }
        }

        static void Main(string[] args)
        {
            List<Village> villages = new List<Village>();
            villages.Add(new Village(10, 12));
            villages.Add(new Village(13, 17));

            Village village = new Village();
            Console.WriteLine("Average: " + village.calculateAverage(villages));
            Console.ReadLine();
        }
    }
}
