class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input first number: ");
        string input1 = Console.ReadLine();
        double num1 = Convert.ToDouble(input1);

        Console.Write("Input second number: ");
        string imput2 = Console.ReadLine();
        double num2 = Convert.ToDouble(imput2);

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;

        Console.Write("Result:\n");
        Console.Write($"{num1} + {num2} = {sum}\n");
        Console.Write($"{num1} - {num2} = {difference}\n");
        Console.Write($"{num1} * {num2} = {product}\n");
        Console.Write($"{num1} / {num2} = {quotient}\n");

        Console.Write("Press any for exit");
        Console.ReadKey();


    }

}