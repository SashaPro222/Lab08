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

// string correctPassword = "qwerty123";
// int count = 0;
// while (true)
// {
//     Console.WriteLine("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         System.Console.WriteLine("Доступ разрешен");
//         System.Console.WriteLine($"Количество неудачных попыток: {count}");
//         break; 
//     }
//     System.Console.WriteLine("Неверный пароль, попробуйте снова");
//     count++;
// }

// string answer;
// do
// {
//     Console.WriteLine("Ввeдите дату посещения (Например 01.09):   ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     System.Console.WriteLine("Добавить еще одну запись? (да/нет):  ");
//     answer = Console.ReadLine();
// }
// while (answer == "да");

// Console.WriteLine("Дневник сохранен");

// Задание A

// int n = int.Parse(Console.ReadLine());
// int min = 1;
// while (min != 11)
// {
//     int res = n * min;
//     System.Console.WriteLine($"{min} * {n} = {res}");
//     min++;
// }

//Задача Б
// System.Console.WriteLine("Введите имена учеников, чтобы завершить напишите: конец ");
// string name = "Имя";
// int score = -1;
// while (name != "конец")
// {
//     name = Console.ReadLine();
//     score++;
// }
// Console.WriteLine($"Количество имен:{score}");

//Вариант 7
// int score = 0;
// int sum = 0;
// int temp = 0;
// System.Console.WriteLine("Введите температуру за дни недели, начиная с понедельника");
// while (score != 7)
// {
//     temp = int.Parse(Console.ReadLine());
//     sum += temp;
//     score++;
// }

// System.Console.WriteLine($"Средняя температура за неделю: {(double)sum/score}");
//Вариант 8
// string correctPassword = "qwerty123";
// int count = 0;
// while (count != 3)
// {
//     Console.WriteLine("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         System.Console.WriteLine("Доступ разрешен");
//         break;
//     }
//     System.Console.WriteLine("Неверный пароль, попробуйте снова");
//     count++;
// }
// if (count == 3)
// {
//     System.Console.WriteLine("Доступ заблокирован");
// }