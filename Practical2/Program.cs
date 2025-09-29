using System;
class Programm
{
    static void Main()
    {//1 Задание
     //string input = Console.ReadLine();
     //Console.WriteLine((input[0] - '0') * 128 + (input[1] - '0') * 64 + (input[2] - '0') * 32 + (input[3] - '0') * 16 + (input[4] - '0') * 8 + (input[5] - '0') * 4 + (input[6] - '0') * 2 + (input[7] - '0') * 1);
     //2 Задание
     //int n = int.Parse(Console.ReadLine());
     //Console.WriteLine((n / 128 % 2).ToString() + (n / 64 % 2).ToString() + (n / 32 % 2).ToString() + (n / 16 % 2).ToString() + (n / 8 % 2).ToString() + (n / 4 % 2).ToString() + (n / 2 % 2).ToString() + (n / 1 % 2).ToString());
     //3 Задание
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int t = int.Parse(Console.ReadLine());
        int o = n * 60 + m + t;
        int hours = (o / 60) % 24;
        int minutes = o % 60;
        Console.WriteLine($"{hours:D2}:{minutes:D2}");
    }
}