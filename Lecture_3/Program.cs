string test = "ooonkhr";

void findChar(string arg)
{
    string result =String.Empty;
    string o ="o";
    string O ="O";

    for (int i =0; i< arg.Length; i++)
    {
        if (arg[i]==o[0])
        {
            result = result+ O;
        }

        else
        {
            result = result+ arg[i];
        }
    }


    Console.WriteLine(result);
    
}


findChar(test);

int year = DateTime.Now.Year;
Console.WriteLine(year);

