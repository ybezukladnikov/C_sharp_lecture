// string test = "ooonkhr";

// void findChar(string arg)
// {
//     string result =String.Empty;
//     string o ="o";
//     string O ="O";

//     for (int i =0; i< arg.Length; i++)
//     {
//         if (arg[i]==o[0])
//         {
//             result = result+ O;
//         }

//         else
//         {
//             result = result+ arg[i];
//         }
//     }


//     Console.WriteLine(result);
    
// }


// findChar(test);

// int year = DateTime.Now.Year;
// Console.WriteLine(year);


void sortArray(int [] arg)
{
    

    for (int i=0; i<arg.Length; i++)
    {
        int min = arg[i];
        int count = i;
        for (int j=i+1; j<arg.Length; j++)
        {
            
            if (min>arg[j])
            {
                min = arg[j];
                count = j;
            }
        }
        int time = arg[i];
        arg[i] = min;
        arg[count] = time;


        
    }

    for (int i=0; i<arg.Length; i++)
    {
        Console.WriteLine(arg[i]);
    }
   
}

int [] array = new int [] {5,4,8,3,9,4,34,33,67,1};

sortArray(array);
