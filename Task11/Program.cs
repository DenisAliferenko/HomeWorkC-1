//Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число обозначающее день недели:");
int number = int.Parse(Console.ReadLine());

string[] days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string result = "";

if (number > 5) result= ($". Ура! Это выходной день!");
else result = ($", рабочий день.");

Console.WriteLine($"{number}-й день недели - это {days[number - 1]}{result}");
