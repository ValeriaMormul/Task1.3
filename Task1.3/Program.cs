using System;

class Program
{
    static void Main()
    {
        // Введення цілого числа - години
        Console.Write("13");
        int h = Convert.ToInt32(Console.ReadLine());

        // Визначення часу доби та виведення відповідного тексту
        string greeting;

        if (h >= 0 && h < 6)
        {
            greeting = "Доброї ночі!";
        }
        else if (h >= 6 && h < 12)
        {
            greeting = "Доброго ранку!";
        }
        else if (h >= 12 && h < 18)
        {
            greeting = "Добрий день!";
        }
        else
        {
            greeting = "Добрий вечір!";
        }

        Console.WriteLine(greeting);
    }
}