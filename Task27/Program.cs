/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
string number1 = Convert.ToString(number);

int sum = 0;
int number2 = number;
for(int i = 0; i < number1.Length; i++){
    sum += number2%10;
    number2 = number2 / 10;
}
Console.WriteLine($"Сумма цифр числа {number} равна {sum}");