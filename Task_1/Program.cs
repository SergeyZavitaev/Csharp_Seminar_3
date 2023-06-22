Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 10000 == number % 10 &
    (number / 1000) % 10 == (number % 100) / 10)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");