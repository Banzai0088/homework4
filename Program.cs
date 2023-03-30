// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число A:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B:");
// int numberB= Convert.ToInt32(Console.ReadLine());

// int sqt = 1;
// for(int i = 1; i<=numberB;i++)
// {
//   sqt=sqt* numberA; 
// }
// Console.WriteLine(sqt);

// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine ("Введите число: ");
// string num = Console.ReadLine();

// int sum = 0;

//  for (int i=0; i<num.Length; i++)
//  {
//     string str = Convert.ToString(num[i]);
//     int num1=Convert.ToInt32(str);
 
//  sum=sum+num1;
//  }
//  Console.WriteLine (sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] GetArray()
// {
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(1,9);
// }
// return array;
// }
//  Console.Write(String.Join (" ", GetArray()));