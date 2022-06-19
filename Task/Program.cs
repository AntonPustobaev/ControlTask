using System;
Console.Clear();

string[] array1 = new string[5] {"конь", "123", "Grib", "-2", "5LA"};
Console.WriteLine(String.Join(" ", array1));
string[] array2 = new string[array1.Length];

FindSecondArray(array1, array2);
PrintArray(array2);

void FindSecondArray(string[] array1, string[] array2)
{
    int k = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[k] = array1[i];
        k++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
