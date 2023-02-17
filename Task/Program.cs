// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
//либо *задать на старте выполнения алгоритма*. 

string[] arrayStart = new string[] {"Russia", ":-)", "hello", "cat", "12345", "-2", "123"};
string[] arrayFinal = new string[arrayStart.Length];

void SecondArray(string[] arrayStart, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
    if(arrayStart[i].Length <= 3)
        {
        arrayFinal[count] = arrayStart[i];
        count++;
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
SecondArray(arrayStart, arrayFinal);
PrintArray(arrayFinal);