using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        int roll;
        string name;
        static String branch = "cse";
        int sem;

        public Student(int roll, string name, int sem)
        {
            this.roll = roll;
            this.name = name;
            this.sem = sem;
        }
        public void displayresult(int[] arr)
        {
            int avg = 0;
            int res;
            for (int i = 0; i < arr.Length; i++)
            {
                avg = avg + arr[i];
            }
            res = avg / arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 35)
                {
                    Console.WriteLine("he is failed");
                    break;
                }
                else if (arr[i] > 35 && arr[i] < 50)
                {
                    Console.WriteLine("he is average student");
                    break;

                }
                else
                {
                    Console.WriteLine("he is good student");
                    break;
                }


            }
            Console.WriteLine("average marks is " + res);
            Console.WriteLine("student roll no is " + roll);
            Console.WriteLine("student name is " + name);
            Console.WriteLine("student sem is " + sem);



        }


    }

    internal class A3
    {
        static void Main()
        {
            Student s = new Student(1, "sai", 1);
            Console.WriteLine("enter the marks");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            s.displayresult(arr);

        }
    }

}
