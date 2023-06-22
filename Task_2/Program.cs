Console.WriteLine("Введите массив x1 y1 z1 x2 y2 z2: ");
int[] coords = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
double result = Math.Sqrt(
    (coords[0] - coords[3]) * (coords[0] - coords[3])
    + (coords[1] - coords[4]) * (coords[1] - coords[4])
    + (coords[2] - coords[5]) * (coords[2] - coords[5]));

Console.WriteLine(result);