class Function
{

    static void Main(String[] args)
    {
        double sum = 0;

        Console.WriteLine("Введите х: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите кол-во иттераций: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0) {
            Console.WriteLine("Ошибка! Вы ввели отрицательное кол-во иттераций");
            System.Environment.Exit(0);
        }

        Console.WriteLine();
        Console.WriteLine(sum);
        
        for (int i = 0; i <= n; i++)
        {
            x = (Math.Pow(-1, i) * Math.Pow(x, i) / (getFactorial(i)));
            sum += x;
            Console.WriteLine("Сумма иттерации № " + i + " = " + sum);            
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
