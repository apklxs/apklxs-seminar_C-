// Программа №3 для определения честности числа a. Вариант решения 

Console.WriteLine("Программа №3 для для определения честности числа");
bool i2 = false;
// int a4=0;

while (i2 == false)
 {
  Console.Write("введите целое число и нажмите клавишу <<Enter>> ");
  i2 = (int.TryParse(Console.ReadLine(), out int a4));
 }

 if (a4 % 2 == 0) Console.WriteLine($"число {a4} четноe");
 else Console.WriteLine($"число {a4} нечетноe");
 Console.WriteLine();