// Определение входного числа
Console.WriteLine("Ведите число: ");
int number = int.Parse(Console.ReadLine());

// Получение квадрата входного числа
int result = number * number;
Console.WriteLine($"Квадрат числа {number} = {result}");

// Получение квадрата числа математической функцией
int result_2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {result}");