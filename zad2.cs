// using System;
// class Pr
// {
//     static void Main()
//     {
//         Console.WriteLine("задания:");
//         Console.WriteLine("1 пл. и пер.");
//         Console.WriteLine("2 конверт. валюты");
//         Console.Write("выберите: ");

//         int choice = int.Parse(Console.ReadLine());
//         Console.WriteLine();

//         switch (choice)
//         {
//             case 1: Zad1(); break;
//             case 2: Zad2(); break;
//         }
//     }
//     static void Zad1()
//     {
//         Console.Write("длина прямоугольника: ");
//         double dl=Convert.ToDouble(Console.ReadLine());
//         Console.Write("ширина прямоугольника: ");
//         double sh=Convert.ToDouble(Console.ReadLine());
//         double pl=dl * sh;
//         double per=2 * (dl + sh);
//         Console.WriteLine($"пл прямоугольника: {pl}");
//         Console.WriteLine($"пер прямоугольника: {per}");
//     }
//     static void Zad2()
//     {
//         const double KURS=84.15;
//         Console.Write("кол-во рублей: ");
//         double rub=Convert.ToDouble(Console.ReadLine());
//         double dollars=rub/KURS;
//         Console.WriteLine($"{rub} рублей равно {dollars:F2} долларов");
//     }
// }