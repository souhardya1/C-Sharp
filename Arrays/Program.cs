using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayHashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize a array
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 30;
            grades[2] = 40;
            grades[3] = 50;
            grades[4] = 60;

            // another way of initializing
            int[] arr = {1,2,3,4,5};

            // another way of initializing
            int[] arr1 = new int[] {11,12,13,14,15};

            // print array elements
            Console.WriteLine("grade[0] element is: "+grades[0]);

            // length of arr
            Console.WriteLine("Length of arr is: " + arr.Length);

            // traversing a array
                // for loop
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Traversing arr. arr[{i}] = {arr[i]}");
            }
                //foreach loop
            int k=0;
            foreach(int i in arr1)
            {
               
                Console.WriteLine($"Traversing arr1. arr1[{k}] = {i}");
                k++;
            }

            // 2D array
            int[,] twoD = new int[,]

            //1st dimension
            {
                // 2nd dimension
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            Console.WriteLine("element of 2D array is "+twoD[2,1]);

            //3D array
            int[,,] threeD = new int[,,]

            // 1st dimension
            {
                // 2nd dimension
                {
                    // 3rd dimension
                    {1,2,3 },
                    {4,5,6 },
                    {7,8,9 }
                },
                {
                    {10,11,12 },
                    {13,14,15 },
                    {16,17,18 }
                }
            };
            Console.WriteLine("element of 3D array is " + threeD[1,1, 1]);

            // Traverse a multi dimensional array
            foreach(int i in threeD)
            {
                Console.WriteLine("ALl elements in threeD array are: "+i);
            }

            // Jagged array
            int[][] jagged = new int[][]
            {
                new int[] { 2,3,5,7,11},
                new int[] {1,2,3}
                // [[2,3,5,7,11],[1,2,3]]
            };

                // Traverse a jagged array
            Console.WriteLine("The value in the middle of the first entry is "+jagged[0][2]);
            for(int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine("Element at {0} is ",i);
                for (int j= 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine(jagged[i][j]);
                }
            }

            // Array as parameters
            Console.WriteLine("Array as parameter result is: "+getAvg(grades));


            // collections -- : NonGeneric
            //                : Generic

                // Non Generic COllections(system.collections)
            int num1 = 5;
            float num2 = 3.75f;
            string name = "Souhardya";
            ArrayList arrlst = new ArrayList();
            arrlst.Add(num1);
            arrlst.Add(num2);
            arrlst.Add(name);

            foreach (object i in arrlst) // object not int bcz it contains different datatypes
            {
                Console.WriteLine("element of non-generic collection are: "+i);
            }
            // arrlst.Reverse(); // to reverse it
            // arrlst.Contains("Souhardya"); // to check if it contains or not
            // arrlst.Remove("Souahardya"); // to remove a element
            // arrlst.RemoveAt(0); // index wise deletion
            // Console.WriteLine(  arrlst.Count); // return the length

            // Generic Collection(system.collections.generic
            string animal1 = "dog";
            string animal2 = "cat";
            string animal3 = "pig";
            List<string> lst = new List<string>();
            lst.Add(animal1);
            lst.Add(animal2);
            lst.Add((animal3));
            
            foreach(string i in lst)
            {
                Console.WriteLine("elements of generic collection are: "+i);
            }

            // Hashtables
            //key value pair (can be different type)
                // create a hash table
            Hashtable studentTable = new Hashtable();
            student s1 = new student(1, "A", 76);
            student s2 = new student(2, "B", 97);
            student s3 = new student(3, "C", 65);
            student s4 = new student(4, "D", 79);
                
                // store data in a hashtable
            studentTable.Add(s1.id, s1);
            studentTable.Add(s2.id, s2);
            studentTable.Add(s3.id, s3);
            studentTable.Add(s4.id, s4);
                
                // retrive data from a hashtable by id
            student storedStudent = (student)studentTable[s1.id]; // check v100 6:27
            Console.WriteLine($"student id:{storedStudent.id}, Name:{storedStudent.name}, GPA:{storedStudent.gpa}");
                
                // retrive all data from hashtable
            foreach (DictionaryEntry i in studentTable)
            {
                student temp = (student)i.Value;
                Console.WriteLine("Student Id is "+temp.id);
                Console.WriteLine("Student name is " + temp.name);
                Console.WriteLine("Student gpa is "+temp.gpa);
            }


            // Dictionary

            Dictionary<int, string> myDic = new Dictionary<int, string>()
            {
                { 1,"One" },
                { 2,"Two" },
                { 3,"Three" }
            };
            myDic.Add(4, "Four");
            myDic.Add(5, "Five");

            myDic[4] = "Seven";

            Console.WriteLine("myDic is");
            foreach(var i  in myDic)
            {
                Console.WriteLine(i.ToString());
                
            }

            Console.WriteLine("Dictionary Values are: ");
            foreach (var i in myDic)
            {
                Console.WriteLine(i.Value);

            }

            Console.WriteLine("Dictionary Keys are:");
            foreach (var i in myDic)
            {
                Console.WriteLine(i.Key);

            }




            Console.WriteLine("key 1 : value = " + myDic[1]);
            Console.WriteLine("Length of my dic is: "+myDic.Count);
            Console.WriteLine("Does myDic Contains key=1? "+myDic.ContainsKey(1));
        
            myDic.Remove(4);
            foreach (object i in myDic)
            {
                Console.WriteLine(i.ToString());
            }

            // Stack
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("last element in stack is: "+stack.Peek());

            stack.Pop();
            Console.WriteLine("last element in stack is: " + stack.Peek());

            Console.WriteLine("Length of stack: "+stack.Count);
        }

        // array as parameter
        static double getAvg(int[] grades)
        {
            int size = grades.Length;
            double avg = 0;
            int sum=0;
            for (int i = 0; i < size; i++)
            {
                sum=sum+grades[i];
            }
            avg=sum/size;
            return avg;
        }

    }

    // Hashtables
    //key value pair (can be different type)
    class student
    {
        // property called id
        public int id { get; set; }
        
        // property called name
        public string name { get; set; }

        //property called GPA
        public int gpa { get; set; }

        // constructor
        public student(int id,string name, int gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        }
    }
}
