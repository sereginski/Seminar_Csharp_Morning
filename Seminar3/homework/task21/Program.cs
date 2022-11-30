// task21
Console.Clear();
Console.Write("Введите координату Х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double result= Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.Write(result);