Console.Write("輸入數字");
String input = Console.ReadLine();
int inputNumber = Int32.Parse(input);
int columns = 3;

if (inputNumber % 5 == 0)
{
    columns = 5;
}else if (inputNumber % 4 == 0)
{
    columns = 4;
}else if (inputNumber % 7 == 0)
{
    columns = 7;
}

for (int k = 1; k <= inputNumber; k += columns)
{
    for (int j = 1; j <= inputNumber; j++)
    {
        for (int i = k; i <= k+(columns-1)&& i<=inputNumber; i++)
        {
            Console.Write($"{i} x {j} = {i * j}\t");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}
