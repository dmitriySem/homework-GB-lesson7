using System;

class lesson5{

    static void Main(){
        Console.Clear();
        //firstTask();
        secondTask();
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
//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
        static void secondTask(){
        Console.WriteLine("Введите значение m:");
        uint m = uint.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите значение n:");
        uint n = uint.Parse(Console.ReadLine()!);

        Console.WriteLine($"Значение по фукнкции Аккермана ({m},{n}) = {funAck(m,n)}");

    }

    public static string ShowDigit(int firstDigit,int secondDigit)
        {
            if (firstDigit > secondDigit)
            return "";
            
            return $"{firstDigit} " + ShowDigit(firstDigit+1,secondDigit);
        }

    public static uint funAck(uint m, uint n)
        {
            if (m == 0) 
                return n + 1;
            else
                if (n == 0) 
                    return funAck(m - 1, 1);
                else
                    return funAck(m - 1, funAck(m, n - 1));            

        }



}