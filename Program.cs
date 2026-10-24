using System;

class Program
{
    static void Main()
    {
        string flower = "";
        int price = 0;

        Console.WriteLine("FLOWER STUDIO");
        Console.WriteLine("1. Роза - 180 сом");
        Console.WriteLine("2. Тюльпан - 100 сом");
        Console.WriteLine("3. Пион - 250 сом");
        Console.Write("Выберите цветок: ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            flower = "Роза";
            price = 180;
        }
        else if (choice == "2")
        {
            flower = "Тюльпан";
            price = 100;
        }
        else if (choice == "3")
        {
            flower = "Пион";
            price = 250;
        }
        else
        {
            Console.WriteLine("Такого цветка нет.");
            return;
        }

        Console.Write("Введите количество: ");
        int quantity;

        if (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1)
        {
            Console.WriteLine("Неправильное количество.");
            return;
        }

        int total = price * quantity;

        Console.WriteLine();
        Console.WriteLine("Ваш заказ:");
        Console.WriteLine("Цветок: " + flower);
        Console.WriteLine("Количество: " + quantity);
        Console.WriteLine("Цена: " + price + " сом");
        Console.WriteLine("Итого: " + total + " сом");

        Console.Write("Ваше имя: ");
        string name = Console.ReadLine();

        Console.WriteLine("Спасибо за заказ, " + name + "!");
        Console.WriteLine("Нажмите Enter для выхода.");
        Console.ReadLine();
    }
}