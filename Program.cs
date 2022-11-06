// Напишите программу замена элементов массива: положительные элементы замените на существующие отрицательные, и наоборот
//[ -4, 8, -8, 2]

/*
Console.Clear();
int[] mas = GetArray(10,-10,11);
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = mas[i] * (-1);
}
Console.WriteLine($"[{String.Join(",", mas)}]");
*/






// Задача 33.Задайте массив, напишите программу, которая определяет,присутствует ли заданное число в массивеint[]
/*
int[] arr = GetArray(10, -10, 11);
Console.WriteLine($"[{String.Join(",",arr)}]");
Console.WriteLine($"Введите искомое число" );
int find = int.Parse(Console.ReadLine()!);

if (Contains(arr,find))
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}
bool Contains(int[] array, int findEl)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            return true;
        }
    }
    return false;
}
*/







