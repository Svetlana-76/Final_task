// Задача: Написать программу, которая из имеющегося
//  массива строк формирует новый массив из строк, 
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[n];

for (int i = 0; i < Array.Length; i++)
	{
        Console.WriteLine("Введите данные ");
	    Array[i] = Console.ReadLine();
	}
Console.Write("Исходный массив: ");
void PrintArray(string[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}

void Diffarray(string[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
string element = arr[i];
if (element.Length <= 3)
{
arr[i] = element;
}
else arr[i] = string.Empty;

}
}

PrintArray(Array);

Diffarray(Array);

Console.Write("Новый массив: ");

PrintArray(Array);
