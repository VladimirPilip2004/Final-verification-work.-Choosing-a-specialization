string[] GetArrayLength(string[] array)
{
    int count = 0;
    int leng = array.Length;

    for (int i = 0; i < leng; i++)
        if (array[i].Length <= 3) count++;

    string[] newArray = new string[count];
    count = 0;

    for (int i = 0; i < leng; i++)
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }

    return newArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] myArray = new string[] {"hello", "2", "world", ":-)"};
//string[] myArray = new string[] {"1234", "1567", "-2", "computer science"};
//string[] myArray = new string[] {"Russia", "Denmark", "Kazan"};

ShowArray(myArray);
string[] arrayResult = GetArrayLength(myArray);
ShowArray(arrayResult);