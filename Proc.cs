using System.IO;
using System;
class Proc
{
    static void Main()
    {
        Proc2();
        Proc3();
        Proc4();
        Proc17();
        Proc18();
        Proc19();
        Proc20();
        Proc21();
        Proc22();
    }
    static void PowerA3(int a, ref int b)
    {
        b = (int)Math.Pow(a, 3);
    }
    static void Proc2()
    {
        int a = 0;
        PowerA3(3, ref a);
        Console.WriteLine(a);
    }
    static void PowerA234(int a, ref int b, ref int c, ref int d)
    {
        b = (int)Math.Pow(a, 2);
        c = (int)Math.Pow(a, 3);
        d = (int)Math.Pow(a, 4);
    }
    static void Proc3()
    {
        int a = 0;
        PowerAt234(2, ref a);
        PowerAt234(3, ref a);
        PowerAt234(4, ref a);
        Console.WriteLine(a);
    }
    static double Mean(int X, int Y, double AMean, double GMean)
    {
        AMean = (X + Y) / 2;
        GMean = Math.Sqrt(X * Y);
    }
    static void Proc4()
    {
        int a = 6;
        int b = 11;
        int c = 18;
        int d = 3;
        Console.WriteLine(Mean(a, b, AMean, GMean));
        Console.WriteLine(Mean(a, c, AMean, GMean));
        Console.WriteLine(Mean(a, d, AMean, GMean));
    }
    static int Sign(double x)
    {
        if (x < 0)
            return -1;
        if (x == 0)
            return 0;
        return 1;
    }
    static void Proc17()
    {
        double a = 2.9;
        double b = 13.5;
        Console.WriteLine(Sign(a) + Sign(b));
    }
    static int RootsCount(int a, int b, int c)
    {
        double d = b * b + 4 * a * c;
        if (d < 0)
            return 0;
        if (d == 0)
            return 1;
        return 2;
    }
    static void Proc18()
    {
        int a = 2;
        int b = 6;
        int c = 7;
        Console.WriteLine(RootsCount(a, b, c));
    }
    static double CircleS(int R)
    {
        return Math.PI * R * R;
    }
    static void Proc19()
    {
        int R = 5;
        Console.WriteLine(CircleS(R));
    }
    static double RingS(int R1, int R2)
    {
        return (Math.PI * R1 * R1) - (Math.PI * R2 * R2);
    }
    static void Proc20()
    {
        int R1 = 12;
        int R2 = 9;
        Console.WriteLine(RingS(R1, R2));
    }
    static double TriangleP(double a, double h)
    {
        double b = Math.Sqrt((a / 2) * (a / 2) + h * h);
        return a + b + b;
    }
    static void Proc21()
    {
        double h = 10;
        double a = 14;
        Console.WriteLine(TriangleP(a, h));
    }
    static int SumRange(int a, int )
    {
        int sum = 0;
        if (a> b)
        {
            return sum;
        }
        else
        {
            for (int i = a; i <= b;i++)
                sum += i;
            return sum;
        }
    }
    static void Proc22()
    {
        int a = 6;
        int b = 10;
        int c = 14;
        Console.WriteLine(SumRange(a, b));
        Console.WriteLine(SumRange(b, c));
    }
}
