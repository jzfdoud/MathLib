using System;


namespace TestMathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // 'math' is declared with var, other side of '=' is initializing it. All other lines are using it
            var math = new MathLib.Math();
            Console.WriteLine(math);
            var ans = math.Add(1, 2);
            ans = math.Subtract(5, 2);


        }



    }
}
