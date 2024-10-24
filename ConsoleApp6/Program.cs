try
{
    Console.Write("Введите значение x: ");
    double x = Convert.ToDouble(Console.ReadLine());

    
    double a1 = 4.5;
    double b1 = 8.4;
    double z1 = Math.Pow(Math.Tan(b1 * x), 2);

   
    double a2 = 8.2;
    double b2 = 15.2;
    double z2 = Math.Pow(Math.Tan(b2 * x), 2);

    
    double a3 = 1.7;
    double b3 = 0.5;
    double z3 = Math.Tan(b3 * Math.Pow(x, 2));


    double y1 = (x <= a1) ? (Math.Pow(Math.Acos(x), 2) + b1 * Math.Sin(z1 * x));


    double y2 = (a2 < 4.5 * b2) ? (Math.Atan(a2 * x + z2) + Math.Pow(Math.Sin(b2 * x), 2));

    
    double y3 = (x > 4.5 * b3) ? (Math.Log(a3 * x - b3) + Math.Pow(z3, 2));

    
    Console.WriteLine($"Результат y1(x) = {y1}"); 
    Console.WriteLine($"Результат y2(x) = {y2}");
    Console.WriteLine($"Результат y3(x) = {y3}");
}
catch
{
    Console.WriteLine("Не правильно ты вел значение....");
}
