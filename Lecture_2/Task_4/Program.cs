void fillArray(int [] myArray)
{
    int length = myArray.Length;
    int index = 0;
    while (index < length)
    {
        myArray[index] = new Random().Next(0, 10);
        index ++;
    }
}

void PrintArray(int [] col)
{
    int pos = 0;
    int len = col.Length;
    while (pos < len)
    {
        Console.WriteLine(col[pos]);
        pos ++;
    } 
}

int [] array = new int [10];

fillArray(array);
PrintArray(array);


