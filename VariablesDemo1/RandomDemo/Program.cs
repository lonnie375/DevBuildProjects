Random random = new Random(); 

for (int i = 1; i <= 10; i++)
{
    int num = random.Next(1, 7);
    Console.WriteLine(num);
}