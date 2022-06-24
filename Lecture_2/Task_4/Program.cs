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

int indexOf(int [] array1, int Find)
{
    int count = array1.Length;
    int index = 0;
    int posit = -1;
    while(index<count)
    {
        if (array1[index]==Find)
        {
            posit = index;
            break;
            
        }
    index++; 
    }
    return posit;
}

int [] array = new int [10];

fillArray(array);
array[4]=45;
array[5]=45;
PrintArray(array);

int myIndex = indexOf(array,45);

Console.WriteLine();
Console.WriteLine(myIndex);

