﻿// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования

int[] array = new int[]{6,7,321,15,0,7};
int[] result = new int[array.Length]; // вводим новый массив с длинной заданного
// копируем переменные массива спомощью цикла
for (int i = 0; i < array.Length; i++) // цикл отвечает только за копирование переменных массива 
{
  result[i] = array[i];
}
// выводим копию массива с помощью цикла
for (int i = 0; i < result.Length; i++) // цикл отвечает только за вывод нашего массива
{
  System.Console.WriteLine(result[i]); // выводим все наши элементы
}

// System.Console.WriteLine - System это название библиотеки, в которой храниться встроенная функция Console.WriteLine
// указывать System не обязательно, в данном случае просто для ознакомления