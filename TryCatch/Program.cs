using System;

class Program
{
    public static int F(int n)
    {
        if (n <= 5)
        {
            return n;
        }
        if (n > 5 && n % 8 == 0)
        {
            return n + F(n / 2 - 3);
        }
        if (n > 1000000)
        {
            throw new StackOverflowException();
        }
        return n + F(n + 4);
    }

    public static void Main(string[] args)
    {
        int n = 0;
        while (true)
        {
            n++;
            try
            {
                Console.WriteLine("{0}, {1}", F(n), n);
            }
            catch (Exception)
            {
                Console.WriteLine("Переполнение стека", n);
            }
        }

    }
}