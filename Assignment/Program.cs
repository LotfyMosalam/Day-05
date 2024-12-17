using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Dynamic;
using System.IO.Pipelines;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    class Person
    {
        public string Name;
    }

    class Program
    {

        #region 1-   Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

        //static void PassByValue(int x)
        //{
        //    x = x + 10;
        //    Console.WriteLine("Inside PassByValue : " + x);
        //}


        //static void PassByRef(ref int x)
        //{
        //    x = x + 10;
        //    Console.WriteLine("Inside PassByRef : " + x);
        //}


        //static void PassByOut(out int x)
        //{
        //    x = 10;
        //    x = x + 5;
        //    Console.WriteLine("Inside PassByOut : " + x);
        //}

        #endregion


        #region 2-   Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        //// 1. Passing Reference Type by Value :
        //static void ChangeNameByValue(Person p)
        //{
        //    p.Name = "John"; // تغيير اسم الشخص داخل الدالة
        //    p = new Person(); // تغيير المرجع داخل الدالة => قمت بإنشاء كائن جديد لا يؤثر علي الكائن الأصلي في الدالة الرئيسية
        //    p.Name = "Alex"; // تغيير اسم الشخص الجديد
        //}

        //// 2. Passing Reference Type by Reference(ref) :
        //static void ChangeNameByReference(ref Person p)
        //{
        //    p.Name = "John"; // تغيير اسم الشخص داخل الدالة
        //    p = new Person(); // إعادة تعيين المرجع إلى كائن جديد
        //    p.Name = "Alex"; // تغيير اسم الشخص الجديد 
        //}

        #endregion


        #region 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        //public static (int, int) SumAndSubtract(int num1, int num2, int num3, int num4)
        //{
        //    int sum = num1 + num2 + num3 + num4;
        //    int subtract = (num1 - num2) - (num3 - num4);
        //    return (sum, subtract);
        //}

        #endregion


        #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //public static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}


        #endregion





        static void Main()
        {

            #region 1-   Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            // 1.Pass by Value
            // Behavior :
            // A copy of the variable's value is passed to the method. Any changes made to the parameter inside the method do not affect the original variable.
            // Default Behavior :
            // All value types(e.g., int, float, bool) are passed by value unless specified otherwise.

            // 2.Pass by Reference(ref)
            // Behavior :
            // A reference to the original variable is passed to the method. Any changes made to the parameter inside the method do affect the original variable.
            // Requirement :
            // The variable must be initialized(given a value) before being passed to the method.

            // 3.Pass by Out(out)
            // Behavior :
            // Similar to ref, a reference to the variable is passed.However, the method must initialize the variable before it is used.
            // Requirement :
            // The variable does not need to be initialized before being passed.
            // Use Case:
            // It is typically used when the method needs to return multiple values or ensure the variable gets initialized.


            //int num1 = 5;
            //int num2 = 5;
            //int num3;

            //Console.WriteLine("Before PassByValue : " + num1);
            //PassByValue(num1);
            //Console.WriteLine("After PassByValue : " + num1);

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Before PassByRef : " + num2);
            //PassByRef(ref num2);
            //Console.WriteLine("After PassByRef : " + num2);

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Before PassByOut : Uninitialized");
            //PassByOut(out num3);
            //Console.WriteLine("After PassByOut : " + num3);

            //Console.WriteLine();

            #endregion


            #region 2-   Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            // 1.Passing Reference Type by Value:
            // Definition: When you pass a reference type by value, you pass a copy of the reference to the method.
            // Effect on Object:
            // Changes made to the object's data (e.g., properties) inside the method will affect the original object because the reference still points to the same object in memory.
            // However, if you change the reference itself(e.g., assigning it to a new object), it will not affect the original reference in the calling method because the method only has a copy of the reference.
            // Key Point: Changes to the object’s data will reflect, but changing the reference itself inside the method does not affect the original reference.

            //// 1. Passing Reference Type by Value:
            //Person person = new Person();
            //person.Name = "Alice";

            //Console.WriteLine();
            //Console.WriteLine("Before method : " + person.Name); // قبل التعديل
            //ChangeNameByValue(person);
            //Console.WriteLine("------------------------");
            //Console.WriteLine("After method : " + person.Name); // بعد التعديل




            //// 2.Passing Reference Type by Reference(ref):
            //// Definition: When you pass a reference type by reference using the ref keyword, you pass the actual reference to the method.
            //// Effect on Object:
            //// Changes made to the object's data inside the method will affect the original object because both the method and the calling code share the same reference.
            //// Additionally, if you change the reference itself(e.g., assigning it to a new object), it will affect the original reference in the calling method because the method is operating on the same reference.
            //// Key Point: Both changes to the object's data and changes to the reference will affect the original object and reference in the calling method.


            //// 2. Passing Reference Type by Reference (ref):
            //Person person = new Person();
            //person.Name = "Alice";

            //Console.WriteLine("Before method: " + person.Name); // قبل التعديل
            //ChangeNameByReference(ref person);
            //Console.WriteLine("After method: " + person.Name); // بعد التعديل




            //// Key Differences:
            //// 1.Passing by Value:
            //// Only a copy of the reference is passed.
            //// Modifications to the object’s data are reflected, but modifications to the reference itself do not affect the calling code.
            //// 2.Passing by Reference(ref):
            //// The actual reference is passed.
            //// Modifications to the object’s data are reflected, and modifications to the reference itself also affect the calling code.

            #endregion


            #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //Console.Write("Enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The sum of the digits of the number {num} is: {SumOfDigits(num)}");

            #endregion


            #region 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //public static bool IsPrime(int num)
            //{
            //    if (num <= 1) return false;
            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0) return false;
            //    }
            //    return true;
            //}


            #endregion


            #region 6- Create a function named MinMaxArray, to return the minimum and  maximum values stored in an array, using reference parameters

            //public static void MinMaxArray(int[] arr, ref int min, ref int max)
            //{
            //    min = arr[0];
            //    max = arr[0];
            //    foreach (int num in arr)
            //    {
            //        if (num < min) min = num;
            //        if (num > max) max = num;
            //    }
            //}


            #endregion



            #region 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //public static int Factorial(int number)
            //{
            //int result = 1;
            //for (int i = 1; i <= number; i++)
            //    {
            //        result *= i;
            //    }
            //return result;
            //}
            #endregion



            #region 8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different lette

            //public static string ChangeChar(string input, int position, char newChar)
            //{
            //    char[] charArray = input.ToCharArray();
            //    charArray[position] = newChar;
            //    return new string(charArray);
            //}

            #endregion








        }
    }
}
