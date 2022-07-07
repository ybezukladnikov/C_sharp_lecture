
int i = 1;
int j = 1;
Console.WriteLine(i);
Console.WriteLine(j);




int Fib(int i, int j)
{
    int result = i+Fib(int i_1, int j_1);
    int i_1 = j;
    int j_1 = result;

    return result;

}

    
