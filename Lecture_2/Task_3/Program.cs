int Find = 35;
int count = 0;
int[] array = { 6, 2, 6, 3, 35 };

int n= array.Length;

for (int i = 0; i < n; i++)
{
    if (array[i] == Find) count++;
}

if (count > 0)
{
    Console.WriteLine($"Sucsesful. {count} Times");
}

else
{
    Console.WriteLine("Not Sucsesful");
}

