
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
