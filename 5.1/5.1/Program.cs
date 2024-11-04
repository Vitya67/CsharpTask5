public static double Calculate(double operand1, double operand2, string operation)
    {
        return operation switch
        {
            "+" => operand1 + operand2,
            "-" => operand1 - operand2,
            "*" => operand1 * operand2,
            "/" => operand2 != 0 ? operand1 / operand2 : throw new DivideByZeroException("Ділення на нуль неможливе"),
            _ => throw new ArgumentException("Неправильна операція")
        };
    }
        {
            Console.Write("Введіть перший операнд: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть операцію (+, -, *, /): ");
            string operation = Console.ReadLine();

            Console.Write("Введіть другий операнд: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + Calculate(operand1, operand2, operation));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }