// int test(int x)
// {
//     int result = x*x;
//     return result;
// }

// int A = test(5);

// Console.WriteLine(A);


int maxN(int a, int b, int c, int d, int e, int f, int g, int h, int i)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    if (d > max) max = d;
    if (e > max) max = e;
    if (f > max) max = f;
    if (g > max) max = g;
    if (h > max) max = h;
    if (i > max) max = i;

    return max;
}

int A = maxN(5,9,8,100,2,35,67,4,89);

Console.WriteLine(A);
