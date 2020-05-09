using System;

namespace Number.Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = 10000;
                var output = input.ConvertToSpelling();

            }catch(Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
