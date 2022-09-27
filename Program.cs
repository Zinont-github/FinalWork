string[] Array = {"eqw","heleo", "341","f","press"};
string[] NewArray = new string[Array.Length];

FindingElements(Array, NewArray);
PrintArray(NewArray);



void FindingElements(string[] array, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3 )
        {
            newarray[count] = array[i];
            count++;
        }
    }

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}