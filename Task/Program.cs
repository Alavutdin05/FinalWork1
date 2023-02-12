/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполните алгоритм. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

using static System.Console;
Clear();

string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
StrLength(array1, array2);                           // Вызываем void метод   
PrintArray(array2);                                  // Вызываем void метод для вывода консоли

void StrLength(string[] array1, string[] array2)     
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write($" {array[i]}");
    }
    Write("]");
}