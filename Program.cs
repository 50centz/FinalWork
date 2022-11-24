string[] CreateNewArray()
{   
    Console.WriteLine("Enter the size of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Enter the word: ");
        string a = Console.ReadLine();
        array[i] = a;
    }


    return array;
}