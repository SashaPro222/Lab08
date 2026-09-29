// int lessonNumber = 1;
// int totalLessons = 5;

// while (lessonNumber <= totalLessons)
// {
//     Console.WriteLine($"Пара {totalLessons}");
//     totalLessons -= 1;

// }
// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int score = 0;

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     score++;
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Количество оценок: {score}");

// int sum = 0;
// int count = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int max = 0;
// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     if (grade > max)
//     {
//         max = grade;
//     }
//     grade = int.Parse(Console.ReadLine());
// }
// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено ");
// }
// Console.WriteLine($"Максимальная оценка: {max}");

using System.ComponentModel;
using System.Net;

string correctPassword = "qwerty123";
int count = 0;
while (true)
{
    Console.WriteLine("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        System.Console.WriteLine("Доступ разрешен");
        System.Console.WriteLine($"Количество неудачных попыток: {count}");
        break; 
    }
    System.Console.WriteLine("Неверный пароль, попробуйте снова");
    count++;
}
