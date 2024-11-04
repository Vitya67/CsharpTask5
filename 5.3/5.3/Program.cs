using System;

class GeometricCalculator
{
    public static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double RectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double CubeVolume(double side)
    {
        return Math.Pow(side, 3);
    }

    static void Main()
    {
        Console.WriteLine("Геометричний калькулятор");
        Console.WriteLine("Виберіть фігуру для розрахунку:");
        Console.WriteLine("1 - Площа кола");
        Console.WriteLine("2 - Площа прямокутника");
        Console.WriteLine("3 - Об'єм куба");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Введіть радіус кола: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double circleArea = CircleArea(radius);
                Console.WriteLine("Площа кола: " + circleArea);
                break;

            case 2:
                Console.Write("Введіть довжину прямокутника: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введіть ширину прямокутника: ");
                double width = Convert.ToDouble(Console.ReadLine());
                double rectangleArea = RectangleArea(length, width);
                Console.WriteLine("Площа прямокутника: " + rectangleArea);
                break;

            case 3:
                Console.Write("Введіть сторону куба: ");
                double side = Convert.ToDouble(Console.ReadLine());
                double cubeVolume = CubeVolume(side);
                Console.WriteLine("Об'єм куба: " + cubeVolume);
                break;

            default:
                Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                break;
        }