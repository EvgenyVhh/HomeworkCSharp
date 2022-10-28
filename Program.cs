﻿//homework

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// double[,] CreateRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colons: ");
//     int colons = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     double[,] array = new double[rows, colons];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colons; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue +1) + new Random().NextDouble();
//             array[i,j] = Math.Round(array[i,j] ,1);
            
//         }
//     }
//     return array;
// }

// void Show2dArray(double [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write("|" + array[i, j] + "| ");
//         Console.WriteLine();
//     }
// }

// double [,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);








//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> числа с такими индексами в массиве нет







// int[,] CreateRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colons: ");
//     int colons = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colons];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colons; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int [,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);


// void Search(int[,] myArray)
// {
//     Console.Write("Input a  rows: ");
//     int r = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a  colons: ");
//     int c = Convert.ToInt32(Console.ReadLine());

//          if((r < 0) || (r > myArray.GetLength(0)) || (c < 0) || (c > myArray.GetLength(1)))
//         {
//          Console.WriteLine("Извините, такого числа нет");
                     
//         }
//             else Console.Write(myArray[r, c]);
                    
//  }


// Search(myArray);











// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colons: ");
    int colons = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colons];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colons; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
void ShowArray(double[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
  Console.WriteLine();
}
int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);



double[] Mean(int [,]myArray)
{
    
    double[] newArray = new double[myArray.GetLongLength(1)];
    
    for (int i = 0; i < myArray.GetLength(1); i++)
    {
        int count = 0;
        
        for (int j = 0; j < myArray.GetLength(0); j++, count++)
            newArray[i] += myArray[j, i];
        newArray[i] =  newArray[i] / count;
    }
      
        
    return newArray;
}
double[] array = Mean(myArray);
ShowArray(array);
































//////классные работы


//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colons: ");
//     int colons = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colons];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colons; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int [,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);



//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colons: ");
//     int colons = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colons];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colons; j++)
//         {
//             array[i,j] = i+j;
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int [,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);


















//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.



// int[,] CreateRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colons: ");
//     int colons = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colons];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colons; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int [,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// void Sqr(int[,] myArray)
// {
//     for(int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < myArray.GetLength(1); j++)
//              if(i % 2 ==0 &&  j % 2 ==0)
//              {
//                  myArray[i,j] = myArray[i,j] * myArray[i,j];
                
//              }

//     }
 
// }
// Sqr(myArray);
// Console.WriteLine();
// Show2dArray(myArray);














//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of colons: ");
//     int colons = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colons];

//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colons; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }

// int [,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);


// int Diag(int[,]myArray)
// {
 
//     int sum = 0;
//     for(int i = 0, j = 0; i < myArray.GetLength(0) && j < myArray.GetLength(1); i++ , j++)
//         {
            
//         sum = myArray[i, j] + sum;
                
//         }        

// return sum;
// }

// Console.WriteLine(Diag(myArray));




















// int[] CreateRandomArray(int size, int minVal, int maxVal) 
// {
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(minVal, maxVal + 1);
//   return array;
// }




// int[] CreateArray(int size) 
// {
//   int[] array = new int[size];
//   Console.WriteLine("Creating array: ");
//   for (int i = 0; i < size; i++)
//   {
//     Console.Write($"Input a {i + 1} element of array: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//   }
//   Console.WriteLine("Complete!");
//   return array;
// }

// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }

// int[] ChengerArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
//     newArray[0] = array[0]+ 10;
//     for(int i = 1; i < array.Length; i++)
//     newArray[i] = array[i];
//     return newArray;
// }
// int[] myArray = CreateRandomArray();

// int[] newArray = ChengerArray(myArray);
// ShowArray(myArray);





//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// int[] CreateRandomArray() 
// {
// Console.Write("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(min, max + 1);
//   return array;
// }

// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }



// void ChengerArray(int[] array)
// {
//     for(int i = 0, j = array.Length - 1 ; i < j; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

// int[] myArray = CreateRandomArray();
// ShowArray(myArray);
// ChengerArray(myArray);
// ShowArray(myArray);



// //Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Console.Write("Input a number1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// bool TreeCycle(int num1,int num2,int num3)
// {
//     if (num1 < (num2 + num3) && num2< (num1 + num3) && num3 < (num1 + num2))
//         return true;
//     else 
//         return false;
// }

// Console.WriteLine(TreeCycle(num1,num2,num3));






//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// int[] CreateRandomArray() 
// {
// Console.Write("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(min, max + 1);
//   return array;
// }

// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }

// int[] ChengerArray(int[] array)
// {
//     int[] newArray = new int[array.Length];
    
//     for(int i = 0; i < array.Length; i++)
//     newArray[i] = array[i];
//     return newArray;
// }
// int[] myArray = CreateRandomArray();
// ShowArray(myArray);
// int[] newArray = ChengerArray(myArray);
// ShowArray(newArray);




//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числовая последовательность по принципу каждый новый элемент = суммы двух предыдущих

// Console.Write("Input a N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number a : ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int[] Fibonache(int size , int num1, int num2)
// {
//     int[] newArray = new int[size];
//     newArray[0] = num1;
//     newArray[1] = num2;
    
//  for(int i = 2; i < size; i++)
//     newArray[i] = newArray[i - 1]+newArray[i - 2];
//  return  newArray;   
// } 
// int[] array = Fibonache(n, a, b);
// ShowArray(array);
// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }




//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

/*

int SumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    
        if(array[i] < 0)
            sum += array[i];
    
    return sum;
}

Console.Write("input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = SumOfNegatives(myArray);
Console.WriteLine("sum of negative elements is " + result);
*/













// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }


// int[] CreateRandomArray(int size, int minVal, int maxVal) 
// {
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(minVal, maxVal + 1);
//   return array;
// }

// int[] CreateArray(int size) 
// {
//   int[] array = new int[size];
//   Console.WriteLine("Creating array: ");
//   for (int i = 0; i < size; i++)
//   {
//     Console.Write($"Input a {i + 1} element of array: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//   }
//   Console.WriteLine("Complete!");
//   return array;
// }















// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.


// int SumOfNegatives(int[] array) 
// {
//   int sum = 0;
//   for (int i = 0; i < array.Length; i++)
//     if(array[i] < 0) 
//       sum += array[i];
//   return sum;
// }

// CreateRandomArray(int size, int minVal, int maxVal); 


// Console.Write("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);

// ShowArray(myArray);

// int result = SumOfNegatives(myArray);
// Console.WriteLine("Sum of negative elements is " + result);


















// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] NegativeArray(int[] arr) 
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     arr[i] = -arr[i];
//   }
//   return arr;
// }
// int[] arr = CreateRandomArray(12, -10, 10);

// ShowArray(NegativeArray(arr));

















// Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int NumOfTwoArray(int[] arr) 
// {
//   int count = 0;
//   for (int i = 0; i < arr.Length; i++)
//   {
//     if(arr[i] >= 10 && arr[i] <= 99) 
//     {
//       count++;
//     }
//   }
//   return count;
// }

// int[] arr = CreateRandomArray(12, 0, 200);
// ShowArray(arr);

// Console.WriteLine(NumOfTwoArray(arr));




















// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// bool FindNumarr(int[] arr, int num) 
// {
//   for (int i = 0; i < arr.Length; i++)
//   {
//     if(arr[i] == num) 
//       return true;
//   }
//   return false;
// }

// int[] arr = CreateArray(5);

// Console.Write("Введите требуемое значение для поиска в массиве: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(FindNumarr(arr, num)) 
// {
//   Console.WriteLine("Данное число есть в массиве");
// } else 
// {
//   Console.WriteLine("Данного числа нет в массиве");
// }





//Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.















//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum(int num)
{
    int sum = 0;

    for(int current =1 ; current <= num  ; current++)
    
        sum += current;//sum = sum + current
    

    return sum;
}



Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int s = GetSum(num);
Console.WriteLine("sum of number from 1 to" + num + "  :" + s);

*/




//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//цикл отсекаем младщий разряд пока не кончатся цифры

/*
int Cur(int num)
{
    int current = 0;
    while(num != 0)
    {
     num = num / 10;
     current ++;
    }
    return current;
}


Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int co = Cur(num);
Console.WriteLine("Количество цифр:"+ co);

*/






//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int GetWork(int num)
{
    int work = 1;

    for(int current = 1; current <= num; current++)

        work *= current;
    

    return work;
}



Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int s = GetWork(num);
Console.WriteLine("work of number from 1 to  " + num + "  :" + s);


*/





//упорядочевание по возрастанию в массиве
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count ; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i=0; i< array.Length -1 ; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/




























//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*

int FindQuart(double x , double y)//метод нахождения четверти координат
{
    int num = 0;

    if(x > 0 && y > 0) num =1;
    if(x < 0 && y > 0) num =2;
    if(x < 0 && y < 0) num =3;
    if(x > 0 && y < 0) num =4;
    return num;
}

Console.Write("Input X-coordinate:");
double x = Convert.ToDouble(Console.ReadLine());//конвертируем
Console.Write("Input Y-coordinate:");
double y = Convert.ToDouble(Console.ReadLine());

int quartNum = FindQuart(x ,y);//создали переменную и выташили из метода
Console.WriteLine($"The point A({x},{y}) is in {quartNum} quart");
*/




//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double FindDistance(double xa,double ya ,double xb ,double yb)
 {
    double ac = xb - xa;
    double bc = yb - ya;
    double ab = ac * ac + bc * bc;
 
    return Math.Sqrt(ab);
}


Console.Write("Input Xa-coordinate:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Ya-coordinate:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Xb-coordinate:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Yb-coordinate:");
double yb = Convert.ToDouble(Console.ReadLine());


double ab = FindDistance(xa, ya, xb, yb);
Console.WriteLine("Distance"+ ab);
*/


//Напишите программу, которая принимает на вход число (N) и выдаёт ряд квадратов чисел от 1 до N.

/*
void Sqr(int num)
{
    int count = 1;
    while (count <= num)
    {
       double n= Math.Pow(count, 2);
        Console.Write(n + " ");
        count++;
    }


}


Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Sqr(num);

/*










//Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.
//снизу  метод
/*
int FindBiggerDigit(int num)
{
    int result;

    if(num < 10 || num >= 100)
        return 0;
    else
    {
        int ed = num % 10;
        int dec = num /10;

        if(ed > dec)
        
            result = ed;
            else
            
                result = dec;
            
        
    }
    return result;
}

Console.Write("Input a two-digit number:");
int number = Convert.ToInt32(Console.ReadLine());

FindBiggerDigit(number);
int biggerDigit = FindBiggerDigit(number);
Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");
*/


//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int numberEx = new Random().Next(99, 1000);
Console.WriteLine(numberEx);
int RandomThirdNumber(int num) {
  int oneNumber = num / 100;
  int thirdNumber = num % 10;
  return oneNumber *10 + thirdNumber;
}
Console.WriteLine(RandomThirdNumber(numberEx));



*/





//2 Напишите программу, которая принимает на вход число n и проверяет, кратно ли оно одновременно a и b(целочисленные делители, также задаются пользователем).

/*

int krat(int x, int y, int z)
{
    if(x % y == 0 && x % z == 0)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
Console.WriteLine("Введите N");
int n =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 1 делитель");
int number1 =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 делитель");
int number2 = Convert.ToInt32(Console.ReadLine());
int del = krat(n, number1, number2);
Console.WriteLine(del);

*/








/*

//Задача 3 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Input a number:");
int n = Convert.ToInt32(Console.ReadLine());
if(n >= 100 && n < 1000)
{
    Console.WriteLine(n % 10);
}
else{
    Console.Write("uncorrect input!");
}



/*

3162 % 10 -> 2
3162 % 200 -> 62
3162 / 10 -> 316
3162 / 100 -> 31










/*

//Задача2 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input a number:");
int n = Convert.ToInt32(Console.ReadLine());
int current = -n;

if(n < 0)
{
    current = n;
    n = -n;
}
while(current <= n)
{
    Console.Write(current + " ");
    current++;
}









/*
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write("Input a first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int n2 = Convert.ToInt32(Console.ReadLine());

int q2 = n2 * n2;

if (n1 == q2)
{
    Console.WriteLine("yes");
}
else{
    Console.WriteLine("no");
}

*/
/*
Console.Write("Input  number:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("your number is "+ num);
*/


//Домашки архив
//дз задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.a = 5; b = 7 -> max = 7a = 2 b = 10 -> max = 10a = -9 b = -3 -> max = -3
/*
Console.Write("Input a first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2)
{
    Console.WriteLine("Max number is " + n1);
    Console.WriteLine("Min number is " + n2);
}
else{
    Console.WriteLine("Max number is " + n2);
    Console.WriteLine("Min number is " + n1);
}
*/

// дз задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number:");
int n3 = Convert.ToInt32(Console.ReadLine());


int maximal = Math.Max(Math.Max(n1, n2), n3);
Console.WriteLine("Max number is " + maximal);
*/



//задача Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number:");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 % 2==0 )
{
    Console.WriteLine("Введенное число чётное");
    
}
else{
    Console.WriteLine("Введенное число не чётное");
}

*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("ВВедите число:");
int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (n > 0){


while(n > max)
        {
        max = max + 2;
        Console.Write(max + ",");
        
        };
   
}
else {
       while(n < max)
        {
        max = max - 2;
        Console.Write(max + ",");
        
        };
};

*/
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Введите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());
int SecondNumber(int num) {
  int oneNumber = num / 100;
  int thirdNumber = num % 10;
  int tviceNumber = n - oneNumber * 100;
  int averageNumber = tviceNumber /10;
  return averageNumber;
}
Console.WriteLine(SecondNumber(n));
*/




//Задача 13.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num<=100)

    Console.Write("Третьего числа нет");
    else{

    
int ThirdNumber(int num) {
    int current = num;
    while (current > 1000)
    {
       current = current / 10 ;       
    };

    return current % 10;
}



Console.Write("Третье число:" + ThirdNumber(num));

    };

*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Week(int num){
    if (num > 5 && num <=7){
        return true;
    }
    return false;
};

Console.Write("Введите цифру, обозначающую день недели:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Week(num));

*/


//Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Polindrom(int num)
{
int current = num;
    if (((current / 10000) == (current % 10)) && ((current / 1000 % 10) == (current % 100 / 10)))
    {
        return true;
    }
    return false;

    
};

Console.Write("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Polindrom(num));
*/




//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
 {
    double ac = ((xb - xa) * (xb - xa));
    double bc = ((yb - ya) * (yb - ya));
    double z = ((zb - za) * (zb - za)) ;
    double az = Math.Sqrt(ac + bc + z);
    double resoult = Math.Round(az , 2);
    return resoult;
}


Console.Write("Input xa-coordinate:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ya-coordinate:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input za-coordinate:");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xb-coordinate:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yb-coordinate:");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zb-coordinate:");
double zb = Convert.ToDouble(Console.ReadLine());

double dis = FindDistance(xa, ya, za, xb, yb, zb);
Console.WriteLine("Distance:"+ dis);
*/




//Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
       double n= Math.Pow(count, 3);
        Console.Write(n + " ");
        count++;
    }


}


Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);


*/



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.



// int Sqr (int num , int num2)
// {
//     int i = 1;
//     int sqr = num;
//         while (i < num2)
//         {
//         sqr = (sqr * num);
        
//         i++;
//          }
//     return sqr;
// }


// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int sqr = Sqr(num , num2);

// Console.WriteLine(sqr);










// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.



// int SumNum (int num)
// {
//     int res = 0;
//     int sum = 0;
    
//     while (num > 0)
//     {
//         sum = num % 10;
//         res = res + sum;
//         num = num / 10;
//     }
// return res;
// }

// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = SumNum(num);
// Console.WriteLine(sum);









// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.





// int[] CreateRandomArray(int size) 
// {
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 1000 + 1);
//   return array;
// }
// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }


// Console.Write("Введите количество элементов(m)");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateRandomArray(size);
// ShowArray(arr);








// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



// int[] CreateRandomArray(int size) 
// {
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(100, 999 + 1);
//   return array;
// }

// int NumEven(int[] array) 
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if(array[i] % 2==0) 
//     {
//       count++;
//     }
//   }
//   return count;
// }

// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }



// Console.Write("Введите количество элементов массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// ShowArray(array);
// Console.WriteLine(NumEven(array));










// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.





// int[] CreateRandomArray(int size) 
// {
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(100, 999 + 1);
//   return array;
// }

// int Sum(int[] array) 
// {
//   int sum = 0;
//   for (int i = 1; i < array.Length; i = i +2)
//   {
//     sum = array[i] + sum;
    
//   }
//   return sum;
// }

// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }



// Console.Write("Введите количество элементов массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// ShowArray(array);
// Console.WriteLine(Sum(array));





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



// int[] CreateRandomArray(int size) 
// {
//   int[] array = new int[size];
//   for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 999 + 1);
//   return array;
// }
 
// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }

// int Max (int[] array)
// {
// int max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
        
//         if (array[i] > max)
//         max = array[i];
        
//     }
    
// return max;
// }

// int Min (int[] array)
// {
// int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
        
//          if (array[i] < min)
//         min = array[i];
       
//     }
    
// return min;
// }

// Console.Write("Введите количество элементов массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateRandomArray(size);
// ShowArray(array);
// Console.WriteLine("Разница = " + (Max(array) - Min(array)));
// Console.WriteLine("minValue: " + Min(array));
// Console.WriteLine("maxValue: " + Max(array));









//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// int[] CreateRandomArray() 
// {
// Console.Write("Input a num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a num2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a num3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a num4: ");
// int num4 = Convert.ToInt32(Console.ReadLine());
//   int[] array = new int[5];
//   for (int i = 0; i < 5; i++)
//     array[i] = num;
//     array[1] = num1;
//     array[2] = num2;
//     array[3] = num3;
//     array[4] = num4;
//   return array;
// }
// void ShowArray(int[] array) 
// {
//   foreach (var item in array)
//     Console.Write(item + " ");
//   Console.WriteLine();
// }



// int[] arr = CreateRandomArray();
// ShowArray(arr);



// int PolNum(int[] arr)
// {
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++)
//         if(arr[i] > 0)
//         {
        
//         count ++;
//         }
// return count;
// }

// Console.WriteLine("Положительных чисел введено: " + PolNum(arr));








//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("Введите b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// double x = ((b1-b2)/(-(k1-k2)));
// double y = (k1 * x + b1);
// double y2 = (k2 * x + b2);
// Console.Write("Координаты точек пересечения "+ y);
// Console.Write(" "+ y2);


