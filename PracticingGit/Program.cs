class TestClass
{
    static void Main(string[] args)
    {

        Console.WriteLine(Subtract(6, 1));

        Console.WriteLine(Divide(2, 1));

    
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;

    static int Divide(int x, int y)
    {
        if (y == 0)
        {
            Console.WriteLine("ERROR: División entre cero");
            Console.WriteLine("Devuelve cero");
            return 0;
        }
        else
        {
            return x / y;
        }
    }


    }