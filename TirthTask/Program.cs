void coordinates()
{
    System.Console.Write("Введите x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    intersectiPoint(x1, y1, x2, y2);
}

void intersectiPoint(double x1, double y1, double x2, double y2)
{
    double x = (x2-x1)/(y1-y2);
    double y = (y2*x) + x2;
    System.Console.WriteLine($"{"Точка пересечения: "} {x} {":"} {y}");
}


coordinates();