//Миронова Анастасия 22-ИСП-2/1
//Задание 1.2, уровень высокий, вариант 4
try
{
    Console.Write("Введите катет:");
    double cathet = double.Parse(Console.ReadLine());
    Console.Write("Введите гипотинузу:");
    double gipot = double.Parse(Console.ReadLine());
    double S = cathet/2 * Math.Sqrt(gipot * gipot - cathet * cathet);
    double cathetTwo = Math.Sqrt(gipot * gipot) - (cathet * cathet);
    Console.WriteLine($"Площадь:{S:F2}");
    Console.WriteLine($"Катет:{cathetTwo:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}