using System.Threading.Tasks;
namespace AsynchronousProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Factory.StartNew(ConcatenateChars);  // We are sending the method as action in the Task thread. from here,ConcatenateChars() is called.
            Console.WriteLine("In Progress");
            /* If we dont have wait then it will execute all the codes in main method while the ConcaenateChars will run in background
               So, anything between the t.Start() [or StartNew()] and t.Wait() will be executed while the ConcatenateChars() is running in the background.
               The Lines after the t.wait() will start after the ConcatenateChars() method is finished.
            */
            t.Wait();      
            Console.WriteLine("Completed");
            Console.WriteLine();

            // Asynchronous method with parameters
            Task t1 = Task.Factory.StartNew(() =>
            {
                ConcatenateCharsWithParameters('2', 20000);  // it can also be written as StartNew(() => ConcatenateCharsWithParameters('2',20000)); 
            });
            Console.WriteLine("Parameter in Progress");
            t1.Wait();
            Console.WriteLine("Parameter is completed");

            // Asynchronous method with parameters and return
            Task<string> t2 = Task.Factory.StartNew(() => ConcatenateCharsWithParametersAndReturn('3', 20000));
            Console.WriteLine("Parameter with return in Progress");
            t2.Wait();
            Console.WriteLine("Completed");
            Console.WriteLine("The length of the result is: "+t2.Result.Length);

            // Async and Await
            Task<string> t3 = ConcatenateCharsWithParametersAndReturnWithAsync('4', 20000);
            Console.WriteLine("ASYNC Parameter with return in Progress ");
            // No wait in this case as we have already used it in the async method
            Console.WriteLine("ASYNC Completed"); // it will execute this line as await will only work at the time of returning
            Console.WriteLine("The length of the ASYNC result is: " + t3.Result.Length);
        }



        public static void ConcatenateChars()
        {
            string concat = string.Empty;
            for(int i = 0; i < 200000; i++)
            {
                concat += '1';
            }
            Console.WriteLine(concat);
        }

        public static void ConcatenateCharsWithParameters(char c,int count)
        {
            string concat = string.Empty;
            for (int i = 0; i < count; i++)
            {
                concat += c;
            }
            Console.WriteLine(concat);
        }

        public static string ConcatenateCharsWithParametersAndReturn(char c, int count)
        {
            string concat = string.Empty;
            for (int i = 0; i < count; i++)
            {
                concat += c;
            }
            return concat;
        }


        // Async Await method
        public async static Task<string> ConcatenateCharsWithParametersAndReturnWithAsync(char c, int count)
        {
            Task<string> T = Task<string>.Factory.StartNew(() =>
            {
                string concat = string.Empty;
                for (int i = 0; i < count; i++)
                {
                    concat += c;
                }
                return concat;
            });
            return await T;
        }


    }
}