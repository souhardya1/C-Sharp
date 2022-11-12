namespace ExtensionMethods
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 6, 7, 2, 9, 1, 2, 6, 2 };
            string[] strArr = { "asd", "Aseq", "qwe", "popo" };

            arr.BubbleSort();
            Console.WriteLine("Only Sort: " + string.Join(",", arr));

            arr.BubbleSort(true);
            Console.WriteLine("Sort and Reverse: " + string.Join(",", arr));

            arr.Reverse();
            Console.WriteLine("Only reverse: " + string.Join(",", arr));

         /* 
             Because of the this keyword(in Extensions.cs) we can use arr.BubbleSort() not using BubbleSort(arr). This is a Extension.
             We cant use this on any type of array( e.g str[] ) other than int[] as the parameter is this int[]. So, strArr.BubbleSort(); not possible reason mentioned below
        */
        }
    }
}