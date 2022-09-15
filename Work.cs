string[] MassOfString = {"hello","2","my name","Hi","123","Alluminium minimum","-22"};

void PrintArray (string[] Mass)
{
    for(int i=0; i<Mass.GetLength(0); i++)
    {
        Console.Write($"{Mass[i]} ");
    }
}

string[] StrLength (string[] Massiv, int n)
{
    string[] Str = new string[Massiv.GetLength(0)];
    int j=0;
    for(int i=0; i<MassOfString.GetLength(0); i++)
    {
        if (MassOfString[i].Length<=n)
        {
            Str[j]=MassOfString[i];
            j++;
        }
    }
    return Str;
}

string[] Answer = StrLength(MassOfString,3);
PrintArray(Answer);
