//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

        Console.WriteLine("Введите числа через пробел:");
        string[] array1= Console.ReadLine().Split();
        int i=0;
        int Length=array1.Length;
        int max=0;
        for (; i<Length;i++)
        {   
            int element = Convert.ToInt32(array1[i]);
            if(element>max)
            {
                max=element;
            }
        }
        Console.Write($"{max} - максимальное число");
