public class Pattern
{
    public static void FirstPattern()
    {
        int numRows = 7;
        int numCols = 31;
        int gap = 5;

        void upperHalf(int num)
        {
            for (int row = num; row < (int)Math.Ceiling(((double)numRows / 2)); row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    if (col == (numCols / 2) - (gap * row) || col == (numCols / 2) + (gap * row))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        void lowerHalf()
        {
            for (int row = numRows / 2 - 1; row >= 0; row--)
            {
                for (int col = 0; col <= numCols; col++)
                {
                    if (col == (numCols / 2) - (gap * row) || col == (numCols / 2) + (gap * row))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        upperHalf(0);
        lowerHalf();
        upperHalf(1);
        lowerHalf();
    }

    public static void SecondPattern()
    {
        int numRows = 6;
        int numCols = 31;
        int gap = 3;

        for (int row = 0; row < numRows; row++) 
        { 
            for (int col = 0; col <= numCols; col++)
            {
                if(col == row * gap || col == numCols - 1 - (row * gap))
                {
                    if (col % 7 == 1)
                        Console.Write("1");
                    else if (col % 4 == 1)
                        Console.Write("3");
                    else if (col % 2 == 1)
                        Console.Write("5");
                    else
                        Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        for (int row = numRows - 2; row >= 0; row--)
        {
            for (int col = 0; col <= numCols; col++)
            {
                if (col == row * gap || col == numCols - 1 - (row * gap))
                {
                    if (col % 7 == 1)
                        Console.Write("1");
                    else if (col % 4 == 1)
                        Console.Write("3");
                    else if (col % 2 == 1)
                        Console.Write("5");
                    else
                        Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void ThirdPattern()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int  j = 1; j <= i; j++)
            {
                Console.Write($"{i * j, -3}");
            }
            Console.WriteLine();
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{i * j,-3}");
            }
            Console.WriteLine();
        }
    }

    public static void FourthPattern()
    {
        int n = 6;
        int num = 2;
        int temp;

        for (int i = 1; i<= n; i++)
        {
            temp = i;
            Console.Write($"{temp, -5}");
            for(int j = 2; j <= n - 1; j++)
            {
                Console.Write($"{temp * num, -5}");
                temp *= num;
            }
            num++;
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("First Pattern");
        FirstPattern();
        Console.WriteLine();
        Console.WriteLine("Second Pattern");
        SecondPattern();
        Console.WriteLine();
        Console.WriteLine("Third Pattern");
        ThirdPattern();
        Console.WriteLine();
        Console.WriteLine("Fourth Pattern");
        FourthPattern();
        Console.WriteLine();
    }
}