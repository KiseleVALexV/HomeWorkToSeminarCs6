// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int SearchPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] InputArray(int num)   
{
    Console.WriteLine("Введите числа : ");
    int[] numbers = new int[num];
    for (int i = 0; i < num; i++) 
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}

Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] numbers = (InputArray(m));
Console.WriteLine($"Количество положительных чисел : {SearchPositiveNumbers(numbers)}");
Console.ReadKey();
