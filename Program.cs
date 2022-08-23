using System;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "322";
            Console.WriteLine(s.ToCurrency());
            
        }
    }

    public static class Extension
    {
        public static string ToCurrency(this string str)
        {

            var IsNumeric = int.TryParse(str, out int n);
            if (IsNumeric)
            { str = "$" + str; }
            else { throw new Exception(); }
            return str;
        }
    
    }
}
