Console.WriteLine("Enter the first num");
int first_num = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second num");
int second_num = int.Parse(Console.ReadLine());

for (int i = first_num; i <= second_num; i++)
{
    int sum = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
        {
            sum += j;
        }


    }

    if (sum == i && i != 0)
        Console.WriteLine(i);



}