using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_4
{
    public class Temperature
    {
        private double celsius;

      
        public double Celsius
        {
            get { return celsius; }
            set { celsius = value; }
        }

        
        public double Fahrenheit
        {
            get
            {
              
                return (celsius * 9 / 5) + 32;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            temp.Celsius = 25.0; 

         
            Console.WriteLine($"Temperature in Celsius: {temp.Celsius}°C");
            Console.WriteLine($"Temperature in Fahrenheit: {temp.Fahrenheit}°F");
        }
    }
}
