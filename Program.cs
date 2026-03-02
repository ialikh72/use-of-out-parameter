using System;
class Program
{
    static void Main()
    {
        int answer,sum,diff;
        answer=Average(3,4,2,out sum,out diff);
        Console.WriteLine("Average ="+answer);
        Console.WriteLine("sum ="+sum);
        Console.WriteLine("diff ="+diff);
    }
    static int Average(int a,int b,int c,out int sum,out int diff)
    {
        sum = a + b + c;
        diff = a - b - c;
        return sum / 3;

    }
}
