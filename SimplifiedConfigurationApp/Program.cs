using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplifiedConfigurationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppSettings.IntValue);
            Console.WriteLine(AppSettings.BoolValue);
            Console.WriteLine(AppSettings.DatetimeValue);
            Console.WriteLine(AppSettings.DoubleValue);
            Console.WriteLine(AppSettings.LongValue);
            Console.WriteLine(AppSettings.ShortValue);
            Console.WriteLine(AppSettings.StringValue);
            
            Console.Read();
        }
    }
}
