ChoiceTasks(OutIntDigit(@"Введите 1 для выполнения Задачи №1"+"\n"+ "Веедите 2 для выполнения Задачи №2"+"\n"+ 
"Веедите 3 для выполнения Задачи №3"+"\n"+"№="));


void ChoiceTasks(int task)
{
 switch(task)
 {
    
    case 1:
        RunTask1();
        break;
 
    case 2:
        Runtask2(); 
        break;
    
    case 3:
        RunTask3(); 
        break;

    default:
        Console.WriteLine("Выход из программы");
        break;
 }
}
// Программа №1, Выводит все натуральные числа в промежутке от N до 1. Воод N осуществляетпользователь.
void RunTask1()
{
 Console.WriteLine("Программа №1, Выводит все натуральные числа в промежутке от N до 1. Ввод N осуществляет пользователь.");
 int n = OutIntDigit("Введите целое число N=");
 OutNaturalNumbersFromNtoOne(n);
}

//Программа №2. Находит сумму натуральных элементов в промежутке от M до N. M и N осуществляет пользователь
void Runtask2()
{
Console.WriteLine("Программа №2. Находит сумму натуральных элементов в промежутке от M до N. M и N осуществляет пользователь");
 int m = OutIntDigit("Введите целое число M=");
 int n = OutIntDigit("Введите целое число N=");
 int summbegin = 0;
 OutNaturalNumbersFromMtoN(m,n,summbegin);

}

//Программа №3. Вычисления функции Аккермана с помощью рекурсии при заданных аргументах функции n и m.
// ВНИМАНИЕ!!! при значениях n и m больше 2 вычисление функции может занять продолжительное время.
void RunTask3()
{
Console.WriteLine("Программа №3. Вычисления функции Аккермана с помощью рекурсии при заданных аргументах функции n и m.");
Console.WriteLine("ВНИМАНИЕ!!! при значениях n и m больше 2 вычисление функции может занять продолжительное время.");

int n = OutIntDigit("Введите первый аргумент фун-ии Аккермана n=");
int m = OutIntDigit("Введите второй аргумент фун-ии Аккермана m=");
ulong akkermanResult= FunctionAkkerman(Convert.ToUInt64(n), Convert.ToUInt64(m));
 Console.WriteLine($"Результат функции Аккермана= {akkermanResult}");
} 

 

ulong FunctionAkkerman(ulong n, ulong m)
{
Console.WriteLine($"m={m}, n= {n}"); 
if (n == 0) return m+1; 
 else if (n != 0 && m == 0) return FunctionAkkerman(n-1,1);
      else return FunctionAkkerman(n-1, FunctionAkkerman(n,m-1));

}




void OutNaturalNumbersFromMtoN(int naturalNumberM, int naturalNumberN, int summ )
{
 summ = summ+naturalNumberM;
 if (naturalNumberN-naturalNumberM > 0)
  {
    OutNaturalNumbersFromMtoN(naturalNumberM+1,naturalNumberN,summ);
  } 
 else 
  {
   Console.Write($"Сумма цифр в заданном промежутке {summ} ");
  }
}


void OutNaturalNumbersFromNtoOne(int naturalNumber)
{
 int nout;
 nout = naturalNumber - 1;
 Console.Write($" {nout} ");
 if (nout != 1)
  {
    OutNaturalNumbersFromNtoOne(nout);
  } 
 else 
  {
   Console.WriteLine($" ");
  }
}



int OutIntDigit(string info)
{
 int i;   
 Console.Write(info);
 
 while (!int.TryParse(Console.ReadLine(), out i))
 {
  Console.WriteLine("Вы ввели не целое число повторите еще раз");
 }
 
 return i;
}



 