using System;

public class BiblaClass
{
    public static int add(int a, int b)
    {
        return a + b;
    }

    public static int subtract(int a, int b)
    {
        return a - b;
    }

    public static int multiply(int a, int b)
    {
        return a * b;
    }

    public static int divide(int a, int b)
    {
        return a / b;
    }

    // число в степень
    public static int power(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }
}
