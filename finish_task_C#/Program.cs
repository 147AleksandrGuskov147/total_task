// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекмондуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] plovArray = new string [9] {"плов", "=", "лук", "морковь", "рис", "мясо", "специи", "и", "повар"};
string[] resultArray = new string [plovArray.Length];
                                       
void MassivMassiv(string[] plovArray, string[] resultArray)
{
    int temp = 0;
    for (int i = 0; i < plovArray.Length; i++)
    {
    if(plovArray[i].Length <= 3)
        {
        resultArray[temp] = plovArray[i];
        temp++;
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

MassivMassiv(plovArray, resultArray);
Console.WriteLine();
Console.WriteLine("Заданный массив: ");
PrintArray(plovArray);
Console.WriteLine();
Console.WriteLine("Искомый массив: ");
PrintArray(resultArray);
Console.WriteLine();

