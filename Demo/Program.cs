namespace Demo
{
    class Program
    {
        static void Main()
        {


            #region Part 01 Functions (Prototype, Calling)
            //static void printshapes(int count = 5, string shape = "#_#")
            //{
            //    for (int i = 1; i <= count; i++)
            //    {
            //        Console.WriteLine($"{shape}");
            //    }
            //}
            #endregion

            #region Part 02 Functions - ValueType Parameters 
            //1.Passing by Value
            ///static void SWAP(int x, int y)  Swap(3,5)
            ///{
            ///    Console.WriteLine("==========SWAPING==========");
            ///    int Temp = x;
            ///    x = y;
            ///    y = Temp;
            ///}

            //2.Passing by Ref
            ///static void SWAP(ref int x, ref int y)  swap(A,B)
            ///{
            ///    Console.WriteLine("==========SWAPING==========");
            ///    int Temp = x;
            ///    x = y;
            ///    y = Temp;
            ///}
            #endregion

            #region Part 03 Functions - ReferenceType Parameters

            //1.Passing by Value 
            ///static int SumOfArray(int[] Arr)
            ///{
            ///    int Result = 0;
            ///    if (Arr?.Length > 0)
            ///    {
            ///        Arr[0] = 100;
            ///        for (int i = 0; i < Arr.Length; i++)
            ///            Result += Arr[i];
            ///    }
            ///    return Result;
            ///}

            //2. Passing by Ref
            ///static int SumOfArray(ref int[] Arr)
            ///{
            ///    int Result = 0;
            ///    if (Arr?.Length > 0)
            ///    {
            ///        Arr[0] = 100;
            ///        for (int i = 0; i < Arr.Length; i++)
            ///            Result += Arr[i];
            ///    }
            ///    return Result;
            ///}

            #endregion

            #region Part 05 Functions - Passing By Out
            //static void sumMul(int x, int y, out int sum, out int Mul)
            //{
            //    sum = x + y;
            //    Mul = x * y;
            //}
            #endregion

            #region Part 07 Functions - Params
            //static int SumArray(int x, int y = 0, params int[] Numbers)
            //{
            //    int Result = 0;
            //    if (Numbers?.Length > 0)
            //        for (int i = 0; i < Numbers.Length; i++)
            //            Result += Numbers[i];
            //    return Result;
            //}

            #endregion

            #region Part 08 Functions - Params in C# 13.0
            //static int SumofNumbers(params IEnumerable<int> Numbers)
            //{
            //    int Result = 0;
            //    if (Numbers is not null)
            //        foreach (int Number in Numbers)
            //            Result += Number;
            //    return Result;
            //}
            #endregion


        }
    }
}

