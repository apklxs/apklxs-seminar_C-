//Программа №1 Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");
Console.Write("Введите целое число трехзначное число и нажмите клавишу <<Enter>> а=");
if (int.TryParse(Console.ReadLine(), out int a) && a > 100 && a<1000)
 {
  Console.WriteLine($"получено  a={a}");
  Console.WriteLine($"вторая цифра числа {(a%100)/10}");
 }  
else Console.WriteLine("Вы ввели не трехзначное число, необходимо перезапустить программу");
Console.WriteLine();
 
//Программа №2 Выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
Console.Write("Введите целое число двух или трехзначное и нажмите клавишу <<Enter>> b=");
if (int.TryParse(Console.ReadLine(), out int b) && b > 9 && b<1000)
 {
  Console.WriteLine($"получено  b={b}");
  if (b<100) Console.WriteLine($"третьей цифры у числа {b} нет");
  else Console.WriteLine($"третья цифра числа {b%10}");
 }  
else Console.WriteLine("Вы ввели не двух или трехзначное число, необходимо перезапустить программу");
Console.WriteLine();
 
//Программа №3 Впринимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Введите целое число от 1 до 7 '(семидневная неделя)' и нажмите клавишу <<Enter>> n=");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && n < 8)
 {
  Console.Write($"получен день недели № {n} ");
  if (n == 6 || n == 7) Console.Write("соответствует выходному дню недели");
  else Console.Write("не соответствует выходному дню недели");
 }
else Console.WriteLine("Вы ввели число не соответствующее дню недели");
