namespace Delegates
{
    internal class Program
    {

        public delegate bool Filters(string item);
        public delegate void Shouter(string msg);

        

        static void Main(string[] args)
        {
            string[] dogs = { "Tommy", "Jimmy", "Dudu", "Tuffy", "Pom", "Dollar", "Shiro", "Pluto" };
            Console.WriteLine("Less than five character dog names are: " + string.Join(",",LessThanFiveChar(dogs)));
            Console.WriteLine("More than five character dog names are: " + string.Join(",", MoreThanFiveChar(dogs)));
            /* So, for every condition we have to create different methods. Thats wher Delegates comes in.
               Delegate are methods but variable methods. We can take a piece of code and make it varying.
               In our code, if(i.Length>5) if the varying line as we will change it based on the conditions. Like if(i.Length<5) or if(I.Length==5)
             */

            Console.WriteLine();

            // After creating variable methods and we have to pass the variable methods to the delegate method
            Console.WriteLine("Five character dog names are: " + string.Join(",", NameFilter(dogs,ExactTheNumber)));
            Console.WriteLine("More than Five character dog names are: " + string.Join(",", NameFilter(dogs, MoreThanNumber)));
            Console.WriteLine("Less than Five character dog names are: " + string.Join(",", NameFilter(dogs, LessThanNumber)));
            // now we can do all the operations using a single method and by passing the variable methods to the delegate method

            Console.WriteLine();

            // if theres just one line or one condition in variable methods then we can also use lambdas instead of variable methods
            Console.WriteLine(" Exact character dog names USING LAMBDA are: " + string.Join(",", NameFilter(dogs, d => d.Length == 5)));
            Console.WriteLine(" More than Five character dog names USING LAMBDA are: " + string.Join(",", NameFilter(dogs, d => d.Length > 5)));
            Console.WriteLine(" Less than Five character dog names USING LAMBDA are: " + string.Join(",", NameFilter(dogs, d => d.Length < 5)));
            Console.WriteLine();


            // Store a method in a delegate variable
            Shouter s = Shout;
            s("Holaaaaaa!!!");
            s = s + Shout;
            s = s + ShoutTwice;
            s = s + Shout;
            s = s + ShoutTwice;
            s = s + Shout;
            s("yes yes");
            Console.WriteLine();


            // Anonymous Methods or Arrow Functoins
            Func<int,bool> CheckInt = i => i%2==0; // its a function without method definition
            Console.WriteLine("Anonymous Function CheckInt: "+CheckInt(5));

            Func<int,int,bool> SumEquals = (i,j)=>i+j==8; // anonymous function with two inputs 
            Console.WriteLine("Anonymous Function SumEqual: " + SumEquals(5,2));

            Action Print = () => Console.WriteLine("Printing from Action"); // anonymous method without parameters and void return
            Print();

            Action<int, int> SumOfTwo = (i, j) => // action returns void but function returns something
            {
                Console.WriteLine("The i is: " + i);
                Console.WriteLine("The j is: " + j);
                Console.WriteLine("The sum is: " + i + j);
            }; SumOfTwo(5, 7);

            // complex anonymous function
            Func<string[], Func<string, bool>, List<string>> ExtractStrings = (arr, filter) =>
            {
                List<string> result = new List<string>();
                foreach (var item in arr)
                {
                    if (filter(item))
                    {
                        result.Add(item);
                    }
                }
                return result;
            };Func<string, bool> less = x => x.Length < 5;
            List<string> output = ExtractStrings(dogs, less);
            Console.WriteLine("Complex Anonymous function: "+string.Join(",",output));
        }



        public static List<string> LessThanFiveChar(string[] arr)
        {
            List<string> lessThanFive = new List<string>();
            foreach (var i in arr)
            {
                if (i.Length < 5)
                {
                    lessThanFive.Add(i);
                }
            }
            return lessThanFive;
        }

        public static List<string> MoreThanFiveChar(string[] arr)
        {
            List<string> moreThanFive = new List<string>();
            foreach (var i in arr)
            {
                if (i.Length > 5)
                {
                    moreThanFive.Add(i);
                }
            }
            return moreThanFive;
        }

        // Variable methods based on conditions
        public static bool ExactTheNumber(string name) { return name.Length == 5; }
        public static bool MoreThanNumber(string name) { return name.Length > 5; }
        public static bool LessThanNumber(string name) { return name.Length < 5; }

        // Delegate method
        public static List<string> NameFilter(string[] dogs,Filters filter)
        {
            List<string> lst = new List<string>();
            foreach (var i in dogs)
            {
                if (filter(i))
                {
                    lst.Add(i);
                }
            }
            return lst;
        }

        // method as a variable
        public static void Shout(string msg) { Console.WriteLine(msg); }
        public static void ShoutTwice(string msg) { Console.WriteLine(msg+"1"); Console.WriteLine(msg+"2"); }

    }
}