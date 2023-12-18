using System;

class lesson5{

    static void Main(){
        Console.Clear();
        //firstTask();
        //secondTask();
       thirdTask();
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

    //Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
    // Использовать рекурсию, не использовать циклы.
    static void thirdTask(){
        Random rnd =  new Random();
        int n = rnd.Next(0, 20);

        int[] array = new int[n];
        for(int i=0; i<n; i++) 
            array[i] = rnd.Next(1000, 9999);

        Console.WriteLine("Исходный массив:");
        Console.WriteLine($"[{PrintArray(array)}]");

        Console.WriteLine($"Перевернутый массив:");
        Console.WriteLine($"[{PrintArray(ArraySwap(array,array.Length-1))}]");
            



    }

    static string ShowDigit(int firstDigit,int secondDigit)
        {
            if (firstDigit > secondDigit)
            return "";
            
            return $"{firstDigit} " + ShowDigit(firstDigit+1,secondDigit);
        }

    static uint funAck(uint m, uint n)
        {
            if (m == 0) 
                return n + 1;
            else
                if (n == 0) 
                    return funAck(m - 1, 1);
                else
                    return funAck(m - 1, funAck(m, n - 1));            

        }

    static int [] ArraySwap(int [] array,int index){

        if (index <= 0)
            return array;
        int temp = array[index];
        array[index] = array[array.Length - index-1];
        array[array.Length - index-1] = temp;
        return ArraySwap(array,index -= 2);
    }

    static string PrintArray(int [] array){
        return string.Join(", ",array);
    }

}