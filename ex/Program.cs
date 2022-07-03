string[] arrayStart = new string[] 
{"Welcome", "to", "Wikipedia", "the", "free", "encyclopedia", "that", "anyone", "can", "edit"};

string[] ThreeSimbols(string[] array)
{
    string[] arrayEnd = new string[array.Length]; //больше этого точно не может быть
    int b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayEnd[b] = array[i];
            b++;
        }
    }
    return arrayEnd;
}

void PrintArray (string[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] arrayFin = ThreeSimbols(arrayStart);
PrintArray (arrayFin);

//Ну... Оно работает