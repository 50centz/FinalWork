string[] CreateArray()
{
    Console.WriteLine("Enter the size of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter the {i + 1} word: ");
        string a = Console.ReadLine();
        array[i] = a;
    }
    return array;
}

string[] CreateNewArray(string[] array)
{
    string[] myArray = new string[array.Length];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            myArray[j] = array[i];
            j++;
        }
    }

    return myArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] array = CreateArray();
Console.WriteLine();
ShowArray(array);
string[] newArray = CreateNewArray(array);
Console.WriteLine();
ShowArray(newArray);