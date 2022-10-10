


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










//////классные работы


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
