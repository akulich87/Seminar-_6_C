// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник со сторонами такой длины

// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int sum1 = num2 + num3;
int sum2 = num1 + num3;
int sum3 = num1 + num2;

if( (num1 < sum1 ) && (num2 < sum2) && (num3 < sum3))
{
  Console.WriteLine($"Треугольник существует ");
}

else 
{
  Console.WriteLine($"Треугольник не существует ");
}

