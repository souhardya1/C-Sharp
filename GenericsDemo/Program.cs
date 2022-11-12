using System;


namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreEqual(2,2));
            Console.WriteLine(AreEqual('a','a'));
            Console.WriteLine(AreEqual("hehe","hoho"));

            int[] arr = { 2, 4, 12, 5, 1, 2, 5, 12, 10, 7, 5, 9, 4 };
            string[] strArr = { "Tommy", "Jimmy", "Dudu", "Tuffy", "Pom", "Dollar", "Shiro", "Pluto" };

            IntSelectionSort(arr);
            Console.WriteLine("IntSelection Sort: " + string.Join(",",arr));

            StrSelectionSort(strArr);
            Console.WriteLine("StrSelection Sort: "+ string.Join(",",strArr));
            // for every type of array we have to create another sort method. Thats why we use generics

            AnySelectionSort(arr);
            Console.WriteLine("AnySelection Sort: " + string.Join(",", arr));
            AnySelectionSort(strArr);
            Console.WriteLine("AnySelection Sort: " + string.Join(",", strArr));

            // Implemented my own IComparable interface method
            Person p1 = new Person() { Age = 10 };
            Person p2 = new Person() { Age = 15 };
            Console.WriteLine("Is Person1 and Person2 has same age? "+AreEqual(p1,p2));

            // Creating my own generic lst class with Add and Indexing feature
            MyList<int> lst = new MyList<int>();
            lst.Add(6);
            lst.Add(1);
            lst.Add(5);
            Console.WriteLine("Index 2 of MyList lst is: " + lst[2]);

        }

        /* Here T represents any type. but both must be same type. 
           The method definition says, AreEqual will accept any type of parameter but both must be of same type. 
           And, the any type T must implement the IComparable interface so that we can use .CompareTo method.
        */

        public static bool AreEqual<T>(T num1,T num2) where T :IComparable<T> 
        {
            return num1.CompareTo(num2)==0; // CompareTo will return 0 if same
        }


        // Selection Sort for Int Array
        public static int[] IntSelectionSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }                  
                }
            }
            return arr;
        }


        // Selection Sort for String Array
        public static string[] StrSelectionSort(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }


        // for every type of array we have to create another sort method. Thats why we use generics
        public static T[] AnySelectionSort<T>(T[] arr) where T:IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        T temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}