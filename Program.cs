using System;

class lesson5{

    static void Main(){
        Console.Clear();
        firstTask();
        //secondTask();
       // thirdTask();
    }

//Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
    static void firstTask(){
        Console.WriteLine("Введите значение М:");
        int M = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Числа от {M} до {N}: {ShowDigit(M,N)}");

        

    }

    public static string ShowDigit(int firstDigit,int secondDigit)
        {
            if (firstDigit > secondDigit)
            return "";
            
            return $"{firstDigit} " + ShowDigit(firstDigit+1,secondDigit);
        }



}