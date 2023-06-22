Console.Write("Введите число: ");
int[] ResultArray = new int[Convert.ToInt32(Console.ReadLine())];
for (int i = 1; i < (ResultArray.Length + 1); i++) //Цикл по каждому элементу для замены
    ResultArray[i - 1] = (i * i * i); //Само умножение
Console.WriteLine(string.Join(" ", ResultArray));