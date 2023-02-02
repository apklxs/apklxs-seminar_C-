//Программа №1 для сравнения целых чисел a и b. Вариант решения 1
Console.WriteLine("Программа №1 для сравнения целых чисел a и b");
Console.Write("введите целое число a и нажмите клавишу <<Enter>> а=");
if (int.TryParse(Console.ReadLine(), out int a))
 {
  Console.Write("введите целое число b и нажмите клавишу <<Enter>> b=");
  if (int.TryParse(Console.ReadLine(), out int b))
   {
    if (a > b) {Console.WriteLine($"а({a}) > b({b})");}
    else {Console.WriteLine($"b({b}) > или = a({a})");}
   }
  else
   {
    Console.WriteLine("Вы ввели не целое число, необходимо перезапустить программу");
   }
 } 
else
 {
  Console.WriteLine("Вы ввели не целое число, необходимо перезапустить программу");
 } 

//Программа №1 для сравнения целых чисел a и b. Вариант решения 2
Console.WriteLine("Вариант решения 2");
Console.Write("введите целое число a и нажмите клавишу <<Enter>> а=");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите целое число a и нажмите клавишу <<Enter>> b=");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Получены значения а={a2}, b={b2}");
if (a2 > b2) 
 {
  Console.WriteLine($"а({a2}) > b({b2})");
 }
else
 { 
  Console.WriteLine($"b({b2}) > или = a({a2})"); 
 }
Console.WriteLine();
// Программа №2 для сравнения целых чисел a, b, c. Вариант решения 

Console.WriteLine("Программа №2 для сравнения целых чисел a, b, c");
bool i = false;
int a3=0, b3=0, c3=0; 

while (i == false)
 {
  Console.Write("введите целое число a и нажмите клавишу <<Enter>> а=");
  i = (int.TryParse(Console.ReadLine(), out a3));
 }

i = false;
while (i == false)
 {
  Console.Write("введите целое число b и нажмите клавишу <<Enter>> b=");
  i = (int.TryParse(Console.ReadLine(), out b3));
 }

 i = false;
while (i == false)
 {
  Console.Write("введите целое число c и нажмите клавишу <<Enter>> c=");
  i = (int.TryParse(Console.ReadLine(), out c3));
 }

Console.WriteLine($"Получены значения а={a3}, b={b3}, c={c3}");

int max=a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;
Console.WriteLine($"Максимальное число {max}");
Console.WriteLine();

// Программа №3 для определения честности числа a. Вариант решения 

Console.WriteLine("Программа №3 для для определения честности числа");
bool i2 = false;
int a4=0;

while (i2 == false)
 {
  Console.Write("введите целое число и нажмите клавишу <<Enter>> ");
  i2 = (int.TryParse(Console.ReadLine(), out a4));
 }

 if (a4 % 2 == 0) Console.WriteLine($"число {a4} четноe");
 else Console.WriteLine($"число {a4} нечетноe");
 Console.WriteLine();


 // Программа №4 для определения честности чисел интервала . Вариант решения 

Console.WriteLine("Программа №4 для для определения честности чисел интервала");
bool i3 = false;
int a5=0,k;

while (i3 == false)
 {
  Console.Write("введите размер интервала целых чисел, больше 1 и нажмите клавишу <<Enter>> ");
  i3 = (int.TryParse(Console.ReadLine(), out a5));
  if (a5 <=  1) i3 = false; 
 }
for (k = 2; k <= a5; k++)if (k % 2 == 0) Console.Write($"{k}  ");
