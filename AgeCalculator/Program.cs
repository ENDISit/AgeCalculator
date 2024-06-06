using System;

class AgeCalculator
{
    static void Main()
    {
        Console.WriteLine("Введите дату рождения (например, 1990-01-01):");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;

        int ageYears = today.Year - birthDate.Year;
        int ageMonths = today.Month - birthDate.Month;
        int ageDays = today.Day - birthDate.Day;

        if (ageDays < 0)
        {
            ageDays += DateTime.DaysInMonth(today.Year, today.Month - 1);
            ageMonths--;
        }
        if (ageMonths < 0)
        {
            ageMonths += 12;
            ageYears--;
        }

        Console.WriteLine($"Возраст: {ageYears} лет, {ageMonths} месяцев, {ageDays} дней");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadLine();
    }
}
