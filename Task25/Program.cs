/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Write("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());

int result = num1;
for(int i = 1; i < num2; i++){
    result = result * num1;
}
Console.WriteLine($"Число {num1} возведенное в степень {num2} равно {result}");

/*Но для оптимизации лучше написать такой код
int result = Convert.ToInt32(Math.Pow(num1, num2));
Console.WriteLine($"Число {num1} возведенное в степень {num2} равно {result}");*/