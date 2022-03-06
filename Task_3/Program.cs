// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите N => ");
string inputN = Console.ReadLine();
int N = int.Parse(inputN);
int i = 1;
while (i <= N)
{
    int ans = i * i;
    Console.Write(ans + " ");
    i++;
}
Console.WriteLine("Второй вариант: ");

for (int j = 1; j <= N; j++)
{
    Console.Write(j*j+" ");
}