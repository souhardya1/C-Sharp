using System; // a pre defined namespace

namespace Hello_World   // a namespace created by me
{
    internal class helloWorld  // a class inside my created namespace 
    {
        static void Main(string[] args)    // Main method inside the class
        {
            Console.WriteLine("Hello World!");

            // sbyte datatype
            sbyte sb = 126;
            Console.WriteLine("This is a short byte datatype: "+sb);

            // short datatype
            short s = 32000;
            Console.WriteLine("This is a short datatype: "+s);

            // int datatype
            int number1 = 1;
            int number2 = 2;
            Console.WriteLine("number1 + number2 = "+number1+number2);

            // long datatype
            long lnum1 = -79349367648374345;
            long lnum2 = 3798745612314642799;
            long lnum3 = lnum1 * lnum2;
            Console.WriteLine("lnum1 * lnum2 = " + lnum3);

            // float datatype
            float fnum1 = 1.5f;
            float fnum2 = 2.5f;
            Console.WriteLine("fnum1 + fnum2 = "+fnum1+fnum2);

            // double datatype
            double dnum1 = 1.456789;
            double dnum2 = 2.456789;
            Console.WriteLine("dnum1 / dnum2 = "+dnum1/dnum2);

            // decimal datatype
            decimal denum1 = 1.123456789m;
            decimal denum2 = 2.123456789m;
            decimal denum3 = denum1 / denum2;
            Console.WriteLine("denum1 / denum2 = " + denum3);

            // boolean datatype 
            bool what = true;
            Console.WriteLine("Boolean is = " + what);

            // char datatype
            char c = '@';
            Console.WriteLine("This is a character: " + c);

            Console.ReadLine();

        }
    }
}
