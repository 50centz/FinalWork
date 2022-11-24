string[] CreateArray()
{
    Console.WriteLine("Enter the size of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter the {i + 1} word: ");
        string a = Console.ReadLine();
        if(a.Length <= 3)
        {
            array[j] = a;
            j++;
        }
        
    }
    return array;
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
