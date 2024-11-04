    public static double ConvertCurrency(double amount, double exchangeRate)
    {
        return amount * exchangeRate;
    }
        {
        Console.Write("Введіть суму для конвертації: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть обмінний курс: ");
        double exchangeRate = Convert.ToDouble(Console.ReadLine());

        double convertedAmount = ConvertCurrency(amount, exchangeRate);
        Console.WriteLine("Сума після конвертації: " + convertedAmount);
    }
}
