// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 1;
int num3 = 1; // переменная обозначающая как будто-бы следующее число за num2
Console.WriteLine(num1);
Console.WriteLine(num2);

for (int i = 2; i < num; i++) // т.к. первые 2 числа известны следовательно i=2
{
  num3 = num1 + num2; // сложить первое и второе число
  Console.WriteLine(num3); // вывести переменную
  num1 = num2; // действие для смены чисел, как будто бы переходим на одно число вправо
  num2 = num3;
}

