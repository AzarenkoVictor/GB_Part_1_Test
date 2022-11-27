Console.WriteLine("Введите количество строк");
int amount = Convert.ToInt32(Console.ReadLine());

String[] array = new String[amount];
String[] threeLettersArray = new String[array.Length];

Console.WriteLine("Введите строки");

for (int i = 0; i < array.Length; i++)
{
    String inputWorld = Console.ReadLine();
    array[i] = inputWorld;
}

void PrintArray(String[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write($"{array[i]} ");
        else
            Console.Write($"{array[i]}, ");
    }
}
void SeparateArray(String[] array, String[] threeLettersArray)
{
    int l = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k].Length <= 3)
        {
            threeLettersArray[l++] = array[k];
        }

    }
}

Console.WriteLine("Начальный массив:");
PrintArray(array);
SeparateArray(array, threeLettersArray);
Console.WriteLine("");
Console.WriteLine("Массив из <=3 символьных строк:");
PrintArray(threeLettersArray);
