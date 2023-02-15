class Function
{

    static void Main(String[] args)
    {
        double sum = 0;

        Console.WriteLine("Введите х: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите кол-во шагов: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0) Console.WriteLine("Отрицательное кол-во шагов");

        Console.WriteLine();
        
        for (int i = 0; i <= n; i++)
        {
            if (n < 0)
            {
                break;
            }
            else
            {
                x = (Math.Pow(-1, i) * Math.Pow(x, i) / (getFactorial(i)));
                sum += x;
                Console.WriteLine(sum);
            }
        }
    }
    public static int getFactorial(int f)
    {
        int result = 1;
        for (int i = 1; i <= f; i++)
        {
            result = result * i;
        }
        return result;
    }
}