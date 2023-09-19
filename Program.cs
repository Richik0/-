/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*Console.Write("Введите число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1 == Num2) {
    Console.WriteLine("Введите два разных числа");
}
else if (Num1 > Num2) {
    Console.WriteLine($"Max = {Num1}, Min = {Num2}");
}
else {
    Console.WriteLine($"Max = {Num2}, Min = {Num1}");
}
*/

/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*Console.Write("Введите число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1 >= Num2 && Num1 >= Num3) {
    Console.WriteLine($"Max = {Num1} ");
}
else if (Num2 >= Num3) {
    Console.WriteLine($"Max = {Num2}");
}
else {
    Console.WriteLine($"Max = {Num3}");
}
*/

/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

/*Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
bool Num1 = N%2 == 0;
Console.WriteLine($"Является ли число четным? {Num1}");*/

/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 2;

if (N > 0){
    while(num <= N){
        Console.Write($"{num}, ");
        num += 2;
    }
}
else{
    
    Console.Write("Кхм. Введите число больше 0");
}
